using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SDPConnect.SDPService;

namespace SDPConnect
{
    public partial class FMain : Form
    {
        private Row[] _rows;
        private bool _isControlAccepted = false;

        public FMain()
        {
            InitializeComponent();
            dgvReestr.DataSource = Row.PrepareDataTable();
            Row.CustomizeGrid(dgvReestr);
            CheckChanges();
        }


        private void DoSmth()
        {
            try
            {
                var sdp = new SdpServiceClient {ClientCredentials = {UserName = {UserName = "admin", Password = "1"}}};

                var requestCardInfo = new CardInfoRequest
                {
                    deviceId = "99999",
                    regionId = 99,
                    sysNum = 6060,
                    agentId = "1",
                    salepointId = "1",
                    version = "1"
                };

                var cardInfoResponse = sdp.CardInfo(requestCardInfo);
                var requestCardPayment = new CardPaymentRequest
                {
                    agentId = "1",
                    paymentInfo = "Какой-то платеж",
                    paymentSum = 200000,
                    salepointId = "1",
                    sessionId = cardInfoResponse.CardInformation.sessionId,
                    tariffId = "12",
                    version = "1"
                };
                tbLog.AppendText(cardInfoResponse.CardInformation.tariff.text);
                var cardPaymentResponse = sdp.CardPayment(requestCardPayment);
                tbLog.AppendText(cardPaymentResponse.CardPaymentInformation.fullSum.ToString());
            }
            catch (Exception e)
            {
                tbLog.AppendText(e.Message);
                if (e.InnerException != null)
                    tbLog.AppendText(e.InnerException.Message);
            }
        }

        private void LoadReestr()
        {
            try
            {
                WriteLog("Начинается загрузка файла");
                ofdReestr.Filter = $"Text files(*.txt)|*.txt|All files(*.*)|*.*";
                ofdReestr.InitialDirectory = Application.StartupPath;
                ofdReestr.FileName = "";
                if (ofdReestr.ShowDialog(this) != DialogResult.OK) return;
                var path = ofdReestr.FileName;
                WriteLog($"Открыт файл: {path}");
                _rows = null;
                ((DataTable)dgvReestr.DataSource)?.Clear();
                var lines = File.ReadAllLines(path, Encoding.GetEncoding(1251));
                if (lines.Length == 0) throw new Exception("В реестре не обнаружено ни одной строки");
                if ((lines.Length < 3) || (lines[lines.Length - 2] != "="))
                    throw new Exception("В реестре не обнаружен признак контрольной строки");
                var controlLine = lines[lines.Length - 1].Split(Row.Separator).ToArray();
                if (controlLine.Length != 6) throw new Exception("В контрольной строке не 6 полей");
                var payLines = lines.Select((a, i) => new {Value = a, Index = i + 1})
                    .Where(row => (row.Index < lines.Length - 1)).ToList();
                var brokenLines = payLines.Where(row => row.Value.Split(Row.Separator).Length != 15).ToList();
                if (brokenLines.Any())
                {
                    foreach (var line in brokenLines)
                    {
                        WriteLog($"!!!Строка {line.Index}, содержит не 15 полей: \"{line.Value}\"");
                    }
                    throw new Exception(
                        $"При загрузке данных найдены строки, содержащие не 15 полей.");
                }
                _rows = payLines.Select(p => new Row(p.Index, p.Value)).ToArray();
                Row.FillGrid(dgvReestr, _rows);
                _isControlAccepted = Row.CompareRows(_rows, controlLine);
                if (_isControlAccepted)
                    WriteLog("Контрольная строка совпадает с загруженными данными");
                else
                {
                    WriteLog("Контрольная строка не совпадает с загруженными данными");
                    MessageBox.Show($"Контрольная строка не совпала с загруженными данными! Для игнорирования этого факта выберите отметьте соответствующий чекбокс.",
                        $"Предупреждение о несоответствии загруженных данных контрольной строке", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                WriteLog("Загрузка файла успешно завершена");
            }
            catch (Exception e)
            {
                _rows = null;
                var errorText = $"При загрузке данных из текстового файла произошла следующая ошибка: {e.Message}";
                WriteLog(errorText);
                MessageBox.Show(errorText, $"Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CheckChanges();
        }

        private void CheckChanges()
        {
            bool isRowsExisted = (_rows != null) && (_rows.Length > 0);
            chbIgnoreControlRow.Visible = (isRowsExisted && (!_isControlAccepted));
            btnRun.Enabled = (isRowsExisted && (_isControlAccepted || chbIgnoreControlRow.Checked));
        }

        private void WriteLog(string line)
        {
            tbLog.AppendText($"{DateTime.Now.ToLongTimeString()}: {line}\r\n");
        }


        //Events
        private void btnRun_Click(object sender, EventArgs e)
        {
            foreach (var row in _rows)
            {
                var dgvRow = dgvReestr.Rows[row.Index - 1];
                WriteLog($"Отправляем сервису строку {row.Id} для оплаты {row.PaymentSum} по карте {row.Account}");
                dgvRow.Selected = true;
                dgvReestr.FirstDisplayedScrollingRowIndex = dgvRow.Index;
                dgvRow.Cells["colStatus"].Value = (int) RowStatus.Treated;
                dgvReestr.Refresh();
                DoSmth();
                Thread.Sleep(2000);
                WriteLog($"Сделали вид что все ОК");
                dgvRow.Cells["colStatus"].Value = (int)RowStatus.Finished;
                dgvReestr.Refresh();
            }
            WriteLog("Выгрузка успешно завершена");
        }

        private void btnLoadReestr_Click(object sender, EventArgs e)
        {
            LoadReestr();
        }

        private void chbIgnoreControlRow_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }
    }
}
