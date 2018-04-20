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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            server.Service1 server = new server.Service1();
            bool validuser;
            bool passed;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                validuser = false;
                MessageBox.Show("Error; Please select one form");
            }
            if (checkBox1.Checked)
            {
                server.Drisvalid(textBox1.Text, textBox2.Text, out validuser, out passed);
                if (validuser == true)
                {
                    MessageBox.Show("Login Successful as Doctor");

                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reset r = new reset();
            r.Show();
            this.Hide();
        }
    }
}
