﻿using System;
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
    public partial class adddoc : Form
    {
        public adddoc()
        {
            InitializeComponent();
        }
        private static adddoc Dlog_frm;
        public static adddoc getinstance()
        {
            if (Dlog_frm == null)
            {
                Dlog_frm = new adddoc();
            }

            return Dlog_frm;
        }

        private void Pregbtn_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.AddDoctor(Dnametxt.Text,idtxt.Text, phonetxt.Text, specialtxt.Text, locationtxt.Text, timingstxt.Text, daytxt.Text, feetxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Sucessfully Added");

            }
            else
            {
                MessageBox.Show("Invalid");

            }
            Dnametxt.Text = "";
            idtxt.Text = "";
            phonetxt.Text = "";
            specialtxt.Text = "";
            locationtxt.Text = "";
            timingstxt.Text = "";
            feetxt.Text = "";
            daytxt.Text = "";
        }

        private void adddoc_Load(object sender, EventArgs e)
        {

        }

        private void specialtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validuser;
            bool passed;
            server.Service1 server = new server.Service1();
            server.DelD(Dnametxt.Text,specialtxt.Text, out validuser, out passed);
            if (validuser == true)
            {
                MessageBox.Show("Sucessfully DELETED");

            }
            else
            {
                MessageBox.Show("Invalid");

            }
            Dnametxt.Text = "";
            phonetxt.Text = "";
            specialtxt.Text = "";
            locationtxt.Text = "";
            timingstxt.Text = "";
            feetxt.Text = "";
            daytxt.Text = "";
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminfunc f = adminfunc.getinstance();
            f.Show();
            this.Hide();
        }
    }
}
