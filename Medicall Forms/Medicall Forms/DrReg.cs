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
            bool isvalid;
            bool passed;
           
             if (checkBox1.Checked)
            {
            server.Service1 server = new server.Service1();
            server.Dregister(Dnametxt.Text, Dpasstxt.Text,idtxt.Text, DcomboBox1.Text, Danstxt.Text,specialtxt.Text,phonetxt.Text,locationtxt.Text,feetxt.Text,timingstxt.Text,daytxt.Text, out isvalid, out passed);
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
            Dnametxt.Text = "";
            Dpasstxt.Text = "";
            DcomboBox1.Text = "";
            Danstxt.Text = "";
            specialtxt.Text = "";
            locationtxt.Text = "";
            feetxt.Text = "";
            daytxt.Text = " ";
            phonetxt.Text = "";
            timingstxt.Text = "";
            idtxt.Text = "";
            
            checkBox1.Checked = false;
                
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Drlogin l = Drlogin.getinstance();
            l.Show();
            this.Hide();
        }

        private void DrReg_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void daytxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
