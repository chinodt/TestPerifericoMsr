using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OposMSR_CCO;
using Microsoft.PointOfService;

namespace TestMagneticBand
{
    public partial class Form1 : Form
    {
        OPOSMSR op = new OPOSMSR();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            op.Open("MSR213U");
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op.ClaimDevice(10000);
        }

        //void myMsr_DataEvent(object sender, DataEventArgs e)
        //{

        //}

        private void cmdSetDeviceEnabled_Click(object sender, EventArgs e)
        {
            if (op.DeviceEnabled)
            {
                op.DeviceEnabled = false;
                op.DataEventEnabled = false;
                op.DecodeData = false;
            }
            else
            {
                op.DeviceEnabled = true;
                op.DataEventEnabled = true;
                op.DecodeData = true;

            }
               

        }

        private void cmdSetDataEventEnabled_Click(object sender, EventArgs e)
        {

            if (op.DeviceEnabled)
            {
                op.DataEventEnabled = true;
                this.txtTrack1.Text = op.Track1Data;
                this.txtTrack2.Text = op.Track2Data;
                this.txtTrack3.Text = op.Track3Data;
                this.txtTrack4.Text = op.Track4Data;
                this.txtCardType.Text = op.CardType;
                this.txtAccount.Text = op.AccountNumber;
                this.txtExpiration.Text = op.ExpirationDate;
                this.txtSurname.Text = op.Surname;
                this.txtFirstName.Text = op.FirstName;
                this.txtTrack1Disc.Text = op.Track1DiscretionaryData;
                this.txtTrack2Disc.Text = op.Track2DiscretionaryData;
                txtCardTypeList.Text = op.CardTypeList;
                this.txtCardPropList.Text = op.CardPropertyList;
                this.txtStatus.Text = op.ServiceCode;
                this.txtResult.Text = op.ResultCode.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op.ReleaseDevice();
        }
    }
}
