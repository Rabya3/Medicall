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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        private static Search S_frm;
        public static Search getinstance()
        {
            if (S_frm == null)
            {
                S_frm = new Search();
            }

            return S_frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Service1 Oserver = new server.Service1();
            List<server.Doctor> list=Oserver.SearchDoc(specialtxt.Text, comboBox1.Text, feetxt.Text).ToList<server.Doctor>();
            BindingSource S = new BindingSource();
            S.DataSource = list;
            dataGridView1.DataSource = S;
           
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void locationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void specialtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
