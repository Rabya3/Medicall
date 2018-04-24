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
    public partial class blood : Form
    {
        public blood()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pregbtn_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool validuser;
            bool passed;
            server.bregister(textBox3.Text,textBox2.Text,textBox1.Text,Pnametxt.Text,out validuser,out passed);
            if (validuser == true)
            {
                MessageBox.Show("You're registered");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
            textBox2.Text = "";
            Pnametxt.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
