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
    public partial class DrReg : Form
    {
        public DrReg()
        {
            InitializeComponent();
        }
        private static DrReg Dreg_frm;
        public static DrReg getinstance()
        {
            if (Dreg_frm == null)
            {
                Dreg_frm = new DrReg();
            }

            return Dreg_frm;
        }

        private void Dregbtn_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            if (checkBox1.Checked)
            {
            bool isvalid;
            bool passed;
            
            server.Dregister(Dnametxt.Text, Dpasstxt.Text, Dcpasstxt.Text, DcomboBox1.Text, Danstxt.Text, out isvalid, out passed);
            if (isvalid == true)
            {
                MessageBox.Show("You're Registered as Doctor");
            }
            else
            {
                MessageBox.Show("Invalid info / Info Missing");
            }
        }
            else
            {
                MessageBox.Show("Please fill all boxes");
            }
            Dnametxt.Text = " ";
            Dpasstxt.Text = " ";
            Dcpasstxt.Text = " ";
            DcomboBox1.Text = " ";
            Danstxt.Text = " ";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dlogin l = Dlogin.getinstance();
            l.Show();
            this.Hide();
        }
    }
}
