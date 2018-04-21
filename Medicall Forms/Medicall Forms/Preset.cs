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
    public partial class Preset : Form
    {
        public Preset()
        {
            InitializeComponent();
        }
        private static Preset R_frm;
        public static Preset getinstance()
        {
            if (R_frm == null)
            {
                R_frm = new Preset();
            }

            return R_frm;
        }
        private void resetbtn_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool validuser;
            bool passed;
            server.Preset(rnametxt.Text, comboBox1.Text, ransertxt.Text, textBox1.Text, out validuser, out passed);
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

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
