using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicall_Forms
{
    public partial class VerifyL : Form
    {
        public VerifyL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.Labverify(textBox1.Text,locationtxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Verified");

            }
            else
            {
                MessageBox.Show("Not Found");

            }
            textBox1.Text = "";
            locationtxt.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminfunc f = adminfunc.getinstance();
            f.Show();
            this.Hide();
        }
    }
}
