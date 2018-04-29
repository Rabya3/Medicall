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
    public partial class Updateinfo : Form
    {
        public Updateinfo()
        {
            InitializeComponent();
        }
        private static Updateinfo Dlog_frm;
        public static Updateinfo getinstance()
        {
            if (Dlog_frm == null)
            {
                Dlog_frm = new Updateinfo();
            }

            return Dlog_frm;
        }
        private void Pregbtn_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.Updateinfo(Dnametxt.Text,phonetxt.Text,specialtxt.Text,locationtxt.Text,timingstxt.Text,daytxt.Text,feetxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Welcome to team MEDI-CALL");
                
            }
            else
            {
                MessageBox.Show("Error: Invaid Input");
                
            }
            Dnametxt.Text = "";
            phonetxt.Text = "";
            specialtxt.Text = "";
            locationtxt.Text = "";
            timingstxt.Text = "";
            daytxt.Text = "";
            feetxt.Text = "";

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void daytxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void specialtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timingstxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void locationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Updateinfo_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
