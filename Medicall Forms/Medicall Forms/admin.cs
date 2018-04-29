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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        bool validcall = false;
        private void button2_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool validuser;
            bool passed;
            server.Aregister(textBox1.Text, textBox2.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Login Successful");
                validcall = true;
            }
            else
            {
                MessageBox.Show("Invalid User");
                validcall = false;
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(validcall==true)
            {
                MessageBox.Show("Signing you in!");
                adminfunc A = adminfunc.getinstance();
                A.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaid Call");
            }
        }
    }
}
