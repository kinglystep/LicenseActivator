using Activator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            string licenseKey = new IOManager().Read("license.crf");
            if(string.IsNullOrEmpty(licenseKey) )
            {
                this.Hide();
                new Form1().ShowDialog();
                return;
            }

            string hardwareId = ActivationManager.GetInstance().GetHardwareId();    
            string keyFromActivator = Encryption.MakePassword(hardwareId, "321");
            if (licenseKey == keyFromActivator)
            {
                frmMain main = new frmMain();
                main.ShowDialog();
            }
        }
    }
}
