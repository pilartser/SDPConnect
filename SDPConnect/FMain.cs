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
                
                var request = new CardInfoRequest()
                {
                    deviceId = "120",
                    regionId = 62,
                    sysNum = 6060,
                    agentId = "6666",
                    salepointId = "1287",
                    version = "1"
                };
               var test = sdp.CardInfo(request);
                //sdp.Open();
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
