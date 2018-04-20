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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrReg D = new DrReg();
            D.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patregister P = new Patregister();
            P.Show();
            this.Hide();
        }
    }
}
