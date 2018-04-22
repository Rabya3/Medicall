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
    public partial class Dreset : Form
    {
        public Dreset()
        {
            InitializeComponent();
        }
        private static Dreset R_frm;
        public static Dreset getinstance()
        {
            if (R_frm == null)
            {
                R_frm = new Dreset();
            }

            return R_frm;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool validuser;
            bool passed;
            server.Dreset(rnametxt.Text,comboBox1.Text,ransertxt.Text,textBox1.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Sucessfully reset");

            }
            else
            {
                MessageBox.Show("Error; Add valid info ");
            }
            rnametxt.Text = " ";
            ransertxt.Text = " ";
            textBox1.Text = " ";
            comboBox1.Text = " ";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Drlogin l = Drlogin.getinstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ransertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
