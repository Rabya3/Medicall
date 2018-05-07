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
    public partial class AddLab : Form
    {
        public AddLab()
        {
            InitializeComponent();
        }

        private void Pregbtn_Click(object sender, EventArgs e)
        {   bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.AddLab(Dnametxt.Text, locationtxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Sucessfully Added");

            }
            else
            {
                MessageBox.Show("Invalid");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.DelLab(Dnametxt.Text, locationtxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Sucessfully DELETED");

            }
            else
            {
                MessageBox.Show("Invalid");

            }
        }
    }
}
