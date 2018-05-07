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

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showDoc s = showDoc.getinstance();
            s.Show();
            this.Hide();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchAdminDoc D = new SearchAdminDoc();
            D.Show();
            this.Hide();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLAb s = new ShowLAb();
            s.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SLabAdmin s = new SLabAdmin();
            s.Show();
            this.Hide();
        }

        private void linkLabel11_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllDonors d = new AllDonors();
            d.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
