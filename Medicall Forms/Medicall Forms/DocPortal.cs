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
    public partial class DocPortal : Form
    {
        public DocPortal()
        {
            InitializeComponent();
        }
        private static DocPortal Dlog_frm;
        public static DocPortal getinstance()
        {
            if (Dlog_frm == null)
            {
                Dlog_frm = new DocPortal();
            }

            return Dlog_frm;
        }
        private void Pregbtn_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.AddDoctor(nametxt.Text,phonetxt.Text,specialtxt.Text,locationtxt.Text,timingstxt.Text,daytxt.Text,feetxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Welcome to team MEDI-CALL");
                
            }
            else
            {
                MessageBox.Show("Error: Invaid Input");
                
            }
            nametxt.Text = "";
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
    }
}
