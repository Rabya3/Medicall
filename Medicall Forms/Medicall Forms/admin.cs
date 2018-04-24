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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool validuser;
            bool passed;
            server.Aregister(textBox1.Text, textBox2.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Login Successful");

            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
