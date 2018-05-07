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
    public partial class Medinfo : Form
    {
        public Medinfo()
        {
            InitializeComponent();
        }
        private static Medinfo Plog_frm;
        public static Medinfo getinstance()
        {
            if (Plog_frm == null)
            {
                Plog_frm = new Medinfo();
            }

            return Plog_frm;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            blood b = blood.getinstance();
            b.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search s = Search.getinstance();
            s.Show();
            this.Hide();
        }

        private void Pregbtn_Click(object sender, EventArgs e)
        {
            FindLab F = FindLab.getinstance();
            F.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Medinfo_Load(object sender, EventArgs e)
        {

        }
    }
}
