using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDPConnect.SDPService;

namespace SDPConnect
{
    public partial class FMain : Form
    {
        private const char _separator = ';';

        public FMain()
        {
            InitializeComponent();
        }


        private void DoSmth()
        {
            try
            {
                var sdp = new SdpServiceClient() {ClientCredentials = {UserName = {UserName = "admin", Password = "1"}}};

                var requestCardInfo = new CardInfoRequest()
                {
                    deviceId = "99999",
                    regionId = 99,
                    sysNum = 6060,
                    agentId = "1",
                    salepointId = "1",
                    version = "1"
                };

                var cardInfoResponse = sdp.CardInfo(requestCardInfo);
                var requestCardPayment = new CardPaymentRequest()
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
                tbReestrPath.Text = path;
                var lines = File.ReadAllLines(path, Encoding.GetEncoding(1251));
                if (lines.Length == 0) throw new Exception("В реестре не обнаружено ни одной строки");
                if ((lines.Length < 3) || (lines[lines.Length - 2] != "="))
                    throw new Exception("В реестре не обнаружен признак контрольной строки");
                var controlLine = lines[lines.Length - 1].Split(_separator);
                if (controlLine.Length != 6) throw new Exception("В контрольной строке не 6 полей");
                var payLines = lines.Select((a, i) => new {Value = a, Index = i + 1})
                    .Where(row => (row.Index < lines.Length - 1)).ToList();
                var brokenLines = payLines.Where(row => row.Value.Split(_separator).Length != 15).ToList();
                if (brokenLines.Any())
                {
                    foreach (var line in brokenLines)
                    {
                        WriteLog($"!!!Строка {line.Index}, содержит не 15 полей: \"{line.Value}\"");
                    }
                    throw new Exception(
                        $"При загрузке данных найдены строки, содержащие не 15 полей.");
                }
                dgvReestr.DataSource = null;

                var dt = Row.PrepareDataTable();
                try
                {
                    foreach (var payLine in payLines.Select(p => new Row(index: p.Index, str: p.Value)))
                    {
                        payLine.AddTo(dt);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Ошибка преобразования данных: {e.Message}");
                }
                dgvReestr.DataSource = dt;
                Row.CustomizeReestrGrid(dgvReestr);

                WriteLog("Загрузка файла успешно завершена");
            }
            catch (Exception e)
            {
                var errorText = $"При загрузке данных из текстового файла произошла следующая ошибка: {e.Message}";
                WriteLog(errorText);
                MessageBox.Show(errorText, $"Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteLog(string line)
        {
            tbLog.AppendText($"{DateTime.Now.ToLongTimeString()}: {line}\r\n");
        }


        //Events
        private void btnRun_Click(object sender, EventArgs e)
        {
            DoSmth();
        }

        private void btnLoadReestr_Click(object sender, EventArgs e)
        {
            LoadReestr();
        }
    }
}
