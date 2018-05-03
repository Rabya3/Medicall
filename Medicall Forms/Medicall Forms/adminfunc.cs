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
    public partial class adminfunc : Form
    {
        public adminfunc()
        {
            InitializeComponent();
        }
        private static adminfunc Dlog_frm;
        public static adminfunc getinstance()
        {
            if (Dlog_frm == null)
            {
                Dlog_frm = new adminfunc();
            }

            return Dlog_frm;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adddoc d = adddoc.getinstance();
            d.Show();
            this.Hide();
        }

        private void adminfunc_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerifyDoc v = new VerifyDoc();
            v.Show();
            this.Hide();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerifyL L = new VerifyL();
            L.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddLab l = new AddLab();
            l.Show();
            this.Hide();
        }
    }
}
