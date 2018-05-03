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
    public partial class VerifyDoc : Form
    {
        public VerifyDoc()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.Docverify(textBox1.Text, specialtxt.Text, feetxt.Text, locationtxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Verified");

            }
            else
            {
                MessageBox.Show("Not Found");
            }
            specialtxt.Text = "";
            feetxt.Text = "";
            locationtxt.Text = "";
        }
    }
}
