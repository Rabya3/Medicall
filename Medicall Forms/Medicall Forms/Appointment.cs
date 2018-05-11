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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment Sucessfully Made");
            this.Hide();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
           server.Doctor k= server.appoint(Utility.doc);
           textBox1.Text = k.Username;
           textBox2.Text = k.Phone;
           textBox3.Text = k.Time;
           textBox4.Text = k.Location;
        }
    }
}
