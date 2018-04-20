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

        private void Pregbtn_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
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

    }

    

      
    

}
