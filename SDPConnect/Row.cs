using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDPConnect
{
    internal enum RowStatus
    {
        Added,
        Treated,
        Faulted,
        Finished
    }

    public class Row
    {
        private const char _separator = ';';
        private DateTime _date;

        private int _account;
        private float _paymentSum;
        private float _totalAmount;
        private float _totalTransferSum;
        private float _totalComissionSum;


        public int Index { get; set; }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Id { get; set; }

        public int Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public float PaymentSum
        {
            get { return _paymentSum; }
            set { _paymentSum = value; }
        }

        public float TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }

        public float TotalTransferSum
        {
            get { return _totalTransferSum; }
            set { _totalTransferSum = value; }
        }

        public float TotalCommissionSum
        {
            get { return _totalComissionSum; }
            set { _totalComissionSum = value; }
        }

        public Row(int index, string str)
        {
            if (str.Split(_separator).Length != 15)
                throw new Exception($"Строка с номером {index} имеет не 15 полей: {str}");
            var row =
                new List<string> {str}.Select(p => p.Split(_separator))
                    .Select(p => new
                    {
                        Date = $"{p[0]} {p[1]}",
                        Id = Id = p[4],
                        Account = p[5],
                        PaymentSum = p[9],
                        TotalAmount = p[12],
                        TotalTransferSum = p[13],
                        TotalCommissionSum = p[14]
                    }).FirstOrDefault();
            if (
                !DateTime.TryParseExact(row.Date, "dd-MM-yyyy HH-mm-ss", CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out _date)) throw new Exception($"Ошибка преобразования даты платежа {row.Date}");
            if (!int.TryParse(row.Account, out _account))
                throw new Exception($"Ошибка приведения номера счета к integer {row.Account}");
            if (
                !float.TryParse(row.PaymentSum, NumberStyles.AllowDecimalPoint,
                    new NumberFormatInfo() {NumberDecimalSeparator = ","}, out _paymentSum))
                throw new Exception($"Ошибка приведения суммы по услуге к float {row.PaymentSum}");
            if (
                !float.TryParse(row.TotalAmount, NumberStyles.AllowDecimalPoint,
                    new NumberFormatInfo() {NumberDecimalSeparator = ","}, out _totalAmount))
                throw new Exception($"Ошибка приведения общей суммы платежа к float {row.TotalAmount}");
            if (
                !float.TryParse(row.TotalTransferSum, NumberStyles.AllowDecimalPoint,
                    new NumberFormatInfo() {NumberDecimalSeparator = ","}, out _totalTransferSum))
                throw new Exception($"Ошибка приведения общей суммы перевода к float {row.TotalTransferSum}");
            if (
                !float.TryParse(row.TotalCommissionSum, NumberStyles.AllowDecimalPoint,
                    new NumberFormatInfo() {NumberDecimalSeparator = ","}, out _totalComissionSum))
                throw new Exception(
                    $"Ошибка приведения суммы комиссии банка от общей суммы к float {row.TotalCommissionSum}");
        }

        public void AddTo(DataTable dt)
        {
            var row = dt.Rows.Add();
            foreach (var prop in typeof(Row).GetProperties())
            {
                row[$"col{prop.Name}"] = typeof(Row).GetProperty(prop.Name).GetValue(this, null);
            }
            row["colStatus"] = (int)RowStatus.Faulted;
        }

        internal static DataTable PrepareDataTable()
        {
            DataTable dt = new DataTable();
            foreach (var prop in typeof (Row).GetProperties())
            {
                dt.Columns.Add(new DataColumn($"col{prop.Name}"));
            }
            dt.Columns.Add(new DataColumn("colStatus"));
            return dt;
        }

        internal static void CustomizeReestrGrid(DataGridView dgv)
        {
            GridTools.AdjustColumn(dgv.Columns["colIndex"], "Номер строки", 50, 0);
            GridTools.AdjustColumn(dgv.Columns["colDate"], "Дата платежа", 50, 1);
            GridTools.AdjustColumn(dgv.Columns["colId"], "Уникальный код операции в ЕПС", 100, 2);
            GridTools.AdjustColumn(dgv.Columns["colAccount"], "Лицевой счет", 50, 3, DataGridViewAutoSizeColumnMode.Fill);
            GridTools.AdjustColumn(dgv.Columns["colPaymentSum"], "Сумма по услуге", 100, 4);
            GridTools.AdjustColumn(dgv.Columns["colTotalAmount"], "Общая сумма платежа", 100, 5);
            GridTools.AdjustColumn(dgv.Columns["colTotalTransferSum"], "Общая сумма перевода", 100, 6);
            GridTools.AdjustColumn(dgv.Columns["colTotalCommissionSum"], "Сумма комиссию банку от общей суммы", 100, 7);
            GridTools.HideColumn(dgv.Columns["colStatus"]);

            dgv.CellPainting += dgv_CellPainting;
        }

        private static void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) return; 
            Color fontColor = GridTools.GetRowColor(
                (RowStatus) int.Parse(((DataGridView) sender).Rows[e.RowIndex].Cells["colStatus"].Value.ToString()));
            e.CellStyle.ForeColor = fontColor;
            e.CellStyle.SelectionForeColor = fontColor;
        }
    }
}
