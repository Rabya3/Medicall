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

        private void Dregbtn_Click(object sender, EventArgs e)
        {
            bool isvalid;
           
            bool cpassword;
            server.Service1 server = new server.Service1();
            server.Dregister(Dnametxt.Text, Dpasstxt.Text,Dcpasstxt.Text, DcomboBox1.Text, Danstxt.Text,out isvalid,out cpassword);
            if(isvalid==true)
            {
                MessageBox.Show("You're Registered as Doctor");
            }
            else
            {
                MessageBox.Show("Invalid info / Info Missing");
            }
            }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
