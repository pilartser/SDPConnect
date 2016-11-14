using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
        internal const char Separator = ';';
        private static readonly NumberFormatInfo DigitalComma = new NumberFormatInfo { NumberDecimalSeparator = "," };
        private DateTime _date;

        private int _account;
        private float _paymentSum;
        private float _amount;
        private float _transferSum;
        private float _comissionSum;


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

        public float Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public float TransferSum
        {
            get { return _transferSum; }
            set { _transferSum = value; }
        }

        public float CommissionSum
        {
            get { return _comissionSum; }
            set { _comissionSum = value; }
        }

        public Row(int index, string str)
        {
            if (str.Split(Separator).Length != 15)
                throw new Exception($"Строка с номером {index} имеет не 15 полей: {str}");
            var row =
                new [] {str}.Select(p => p.Split(Separator))
                    .Select(p => new
                    {
                        Date = $"{p[0]} {p[1]}",
                        Id = Id = p[4],
                        Account = p[5],
                        PaymentSum = p[9],
                        TotalAmount = p[12],
                        TotalTransferSum = p[13],
                        TotalCommissionSum = p[14]
                    }).First();
            
            if (
                !DateTime.TryParseExact(row.Date, "dd-MM-yyyy HH-mm-ss", CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out _date)) throw new Exception($"Ошибка преобразования даты платежа {row.Date}");
            if (!int.TryParse(row.Account, out _account))
                throw new Exception($"Ошибка приведения номера счета к integer {row.Account}");
            if (
                !float.TryParse(row.PaymentSum, NumberStyles.AllowDecimalPoint,
                    DigitalComma, out _paymentSum))
                throw new Exception($"Ошибка приведения суммы по услуге к float {row.PaymentSum}");
            if (
                !float.TryParse(row.TotalAmount, NumberStyles.AllowDecimalPoint,
                    DigitalComma, out _amount))
                throw new Exception($"Ошибка приведения общей суммы платежа к float {row.TotalAmount}");
            if (
                !float.TryParse(row.TotalTransferSum, NumberStyles.AllowDecimalPoint,
                    DigitalComma, out _transferSum))
                throw new Exception($"Ошибка приведения общей суммы перевода к float {row.TotalTransferSum}");
            if (
                !float.TryParse(row.TotalCommissionSum, NumberStyles.AllowDecimalPoint,
                    DigitalComma, out _comissionSum))
                throw new Exception(
                    $"Ошибка приведения суммы комиссии банка от общей суммы к float {row.TotalCommissionSum}");
            Index = index;
        }

        private void AddTo(DataTable dt)
        {
            var row = dt.Rows.Add();
            foreach (var prop in typeof(Row).GetProperties())
            {
                row[$"col{prop.Name}"] = typeof(Row).GetProperty(prop.Name).GetValue(this, null);
            }
            row["colStatus"] = (int)RowStatus.Added;
        }

        

        internal static DataTable PrepareDataTable()
        {
            DataTable dt = new DataTable();
            foreach (var prop in typeof(Row).GetProperties())
            {
                dt.Columns.Add(new DataColumn($"col{prop.Name}"));
            }
            dt.Columns.Add(new DataColumn("colStatus"));
            return dt;
        }

        internal static bool CompareRows(Row[] rows, string[] line)
        {
            var controlLine = new[]{line}.Select(p => new {TotalCount = p[0], TotalAmount = p[1], TotalTransferSum = p[2], TotalCommissionSum = p[3]}).First();
            int totalCount;
            float totalAmount;
            float totalTransferSum;
            float totalCommissionSum;

            if (!int.TryParse(controlLine.TotalCount, out totalCount)) throw new Exception($"Ошибка приведения количества строк в реестре к int {controlLine.TotalCount}");
            if (
                !float.TryParse(controlLine.TotalAmount, NumberStyles.AllowDecimalPoint,
                    DigitalComma, out totalAmount))
                throw new Exception($"Ошибка приведения общей суммы принятых средств к float {controlLine.TotalAmount}");
            if (
                !float.TryParse(controlLine.TotalTransferSum, NumberStyles.AllowDecimalPoint,
                    DigitalComma, out totalTransferSum))
                throw new Exception($"Ошибка приведения общей суммы перечисления клиенту к float {controlLine.TotalTransferSum}");
            if (
                !float.TryParse(controlLine.TotalCommissionSum, NumberStyles.AllowDecimalPoint,
                    DigitalComma, out totalCommissionSum))
                throw new Exception($"Ошибка приведения общей комиссии банку к float {controlLine.TotalCommissionSum}");

            var total =  new
            {
                TotalAmount = rows.Sum(p => p.Amount),
                TotalTransferSum = rows.Sum(p => p.TransferSum),
                TotalCommissionSum = rows.Sum(p => p.CommissionSum)
            };

            return ((totalCount == rows.Length) && (totalAmount == total.TotalAmount) && (totalTransferSum == total.TotalTransferSum) && (totalCommissionSum == total.TotalCommissionSum));
        }

        internal static void CustomizeGrid(DataGridView dgv)
        {
            GridTools.AdjustColumn(dgv.Columns["colIndex"], "Номер строки", 50, 0);
            GridTools.AdjustColumn(dgv.Columns["colDate"], "Дата платежа", 50, 1);
            GridTools.AdjustColumn(dgv.Columns["colId"], "Уникальный код операции в ЕПС", 100, 2);
            GridTools.AdjustColumn(dgv.Columns["colAccount"], "Лицевой счет", 50, 3, DataGridViewAutoSizeColumnMode.Fill);
            GridTools.AdjustColumn(dgv.Columns["colPaymentSum"], "Сумма по услуге", 100, 4);
            GridTools.AdjustColumn(dgv.Columns["colAmount"], "Общая сумма платежа", 100, 5);
            GridTools.AdjustColumn(dgv.Columns["colTransferSum"], "Общая сумма перевода", 100, 6);
            GridTools.AdjustColumn(dgv.Columns["colCommissionSum"], "Сумма комиссию банку от общей суммы", 100, 7);
            GridTools.HideColumn(dgv.Columns["colStatus"]);

            dgv.CellPainting += dgv_CellPainting;
        }

        private static void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Color fontColor = GridTools.GetRowColor(
                (RowStatus)int.Parse(((DataGridView)sender).Rows[e.RowIndex].Cells["colStatus"].Value.ToString()));
            e.CellStyle.ForeColor = fontColor;
            e.CellStyle.SelectionForeColor = fontColor;
        }

        internal static void FillGrid(DataGridView dgv, Row[] rows)
        {
            if ((rows == null) || (dgv == null)) return;
            dgv.DataSource = null;
            var dt = PrepareDataTable();
            try
            {
                foreach (var payLine in rows)
                {
                    payLine.AddTo(dt);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Ошибка преобразования данных: {e.Message}");
            }
            dgv.DataSource = dt;
            CustomizeGrid(dgv);
        }
    }
}
