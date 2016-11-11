using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDPConnect.SDPService;

namespace SDPConnect
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            DoSmth();
        }

        private void DoSmth()
        {
            try
            {
                var sdp = new SdpServiceClient() {ClientCredentials = { UserName = { UserName = "admin", Password = "1"}}};
                
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
    }
}
