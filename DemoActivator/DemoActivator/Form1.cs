using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Activator;

namespace DemoActivator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHardwareId.Text))
            {
                MessageBox.Show("please add hardware id!");
            }
            else
            {
                string productKey = Encryption.MakePassword(txtHardwareId.Text, "321");
                txtProductKey.Text = productKey;
            }
        }
    }
}
