using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management;

using Activator;

namespace DemoClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string hardwareId = txtHardwareId.Text;
            string productkey = txtProductKey.Text;
            string keyFromActivator = Encryption.MakePassword(hardwareId, "321");

            if (string.IsNullOrEmpty(txtHardwareId.Text))
            {
                MessageBox.Show("please enter hardware id");
            }else if(string.IsNullOrEmpty(txtProductKey.Text))
            {
                MessageBox.Show("please enter produck key ");
            }
            else if(productkey != keyFromActivator )
            {
                MessageBox.Show("please input valid key");
            }
            else
            {
                
                if(productkey == keyFromActivator)
                {
                    new IOManager().Write("license.crf",keyFromActivator);
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hardwareID = ActivationManager.GetInstance().GetHardwareId();
            txtHardwareId.Text = hardwareID;
        }
    }
}
