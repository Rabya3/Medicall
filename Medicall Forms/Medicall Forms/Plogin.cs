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
    public partial class Plogin : Form
    {
        public Plogin()
        {
            InitializeComponent();
        }
        private static Plogin Plog_frm;
        public static Plogin getinstance()
        {
            if (Plog_frm == null)
            {
                Plog_frm = new Plogin();
            }

            return Plog_frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        bool validcall = false;
        private void button2_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool validuser;
            bool passed;
            server.Pisvalid(textBox1.Text, textBox2.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Login Successful");
                validcall = true;
            }
            else
            {
                MessageBox.Show("Invalid User");
                
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Preset p = Preset.getinstance();
            p.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (validcall == true)
            {
                Medinfo m = Medinfo.getinstance();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Call");
            }
        }

        private void Plogin_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
