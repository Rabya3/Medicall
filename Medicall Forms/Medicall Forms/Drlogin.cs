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
    public partial class Drlogin : Form
    {
        public Drlogin()
        {
            InitializeComponent();
        }
        private static Drlogin Dlog_frm;
        public static Drlogin getinstance()
        {
            if (Dlog_frm == null)
            {
                Dlog_frm = new Drlogin();
            }

            return Dlog_frm;
        }

        private void Drlogin_Load(object sender, EventArgs e)
        {

        }
        bool validcall;
        private void button2_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.Drisvalid(textBox1.Text, textBox2.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Login Successful as Doctor");
                validcall = true;
            }
            else
            {
                MessageBox.Show("Invalid User");
                validcall = false;
            }
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dreset r = Dreset.getinstance();
            r.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(validcall==true)
            {
                DocPortal P = DocPortal.getinstance();
                P.Show();
                this.Hide();
                MessageBox.Show("Signing you in!");
            }
            else
            {
                MessageBox.Show("Please sign in first");
            }
        }
    }
}
