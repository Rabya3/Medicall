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
    public partial class Patregister : Form
    {
        public Patregister()
        {
            InitializeComponent();
        }
        private static Patregister Preg_frm;
        public static Patregister getinstance()
        {
            if (Preg_frm == null)
            {
                Preg_frm = new Patregister();
            }

            return Preg_frm;
        }

        private void Pregbtn_Click(object sender, EventArgs e)
        {   
            server.Service1 server = new server.Service1();
            if(checkBox1.Checked)
            {
                bool validuser;
                bool passed;
                server.Pregister(Pnametxt.Text, Ppasstxt.Text, Pcpasstxt.Text, PcomboBox1.Text, Panstxt.Text, out validuser, out passed);
                if (validuser == true)
                {
                    MessageBox.Show("You're Registered");
                }
                else
                {
                    MessageBox.Show("Invalid info / Info Missing");
                }
            }
            else
            {
                MessageBox.Show("Please fill all boxes");
            }
            
            Pnametxt.Text = " ";
            Ppasstxt.Text = " ";
            Pcpasstxt.Text = " ";
            Panstxt.Text = " ";

        }

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Plogin p = Plogin.getinstance();
            p.Show();
            this.Hide(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    

      
    

}
