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
    public partial class SLabAdmin : Form
    {
        public SLabAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Service1 Oserver = new server.Service1();
            List<server.Lab> list = Oserver.SearchLabAdmin(comboBox1.Text).ToList<server.Lab>();
            BindingSource S = new BindingSource();
            S.DataSource = list;
            dataGridView1.DataSource = S;
        }
    }
}
