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
    public partial class showDoc : Form
    {
        public showDoc()
        {
            InitializeComponent();
        }
        private static showDoc Dlog_frm;
        public static showDoc getinstance()
        {
            if (Dlog_frm == null)
            {
                Dlog_frm = new showDoc();
            }

            return Dlog_frm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            server.Service1 Oserver = new server.Service1();
            List<server.Doctor> list = Oserver.ShowDoc().ToList<server.Doctor>();
            BindingSource S = new BindingSource();
            S.DataSource = list;
            dataGridView1.DataSource = S;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminfunc f = adminfunc.getinstance();
            f.Show();
            this.Hide();
        }
    }
}
