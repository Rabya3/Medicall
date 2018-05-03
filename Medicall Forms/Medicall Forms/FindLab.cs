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
    public partial class FindLab : Form
    {
        public FindLab()
        {
            InitializeComponent();
        }
        private static FindLab Preg_frm;
        public static FindLab getinstance()
        {
            if (Preg_frm == null)
            {
                Preg_frm = new FindLab();
            }

            return Preg_frm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            server.Service1 Oserver = new server.Service1();
            List<server.Lab> list = Oserver.SearchLab(locationtxt.Text).ToList<server.Lab>();
            BindingSource S = new BindingSource();
            S.DataSource = list;
            dataGridView1.DataSource = S;
            locationtxt.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindLab_Load(object sender, EventArgs e)
        {

        }
    }
}
