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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About A = new About();
            A.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid;
            if(checkBox1.Checked && checkBox2.Checked)
            {
                valid = false;
                if (valid == false)
                {
                    MessageBox.Show("Please select one box");
                }   
            }
            else
            {
                valid = true;
                if (checkBox1.Checked && valid==true && !checkBox2.Checked)
                {
                         DrReg R = DrReg.getinstance();
                        R.Show();
                        this.Hide();    
                }
                if (checkBox2.Checked && valid == true && !checkBox1.Checked)
                {
                 
                        Patregister P = Patregister.getinstance();
                        P.Show();
                        this.Hide();
                    
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valid;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                valid = false;
                if (valid == false)
                {
                    MessageBox.Show("Please select one box");
                }
            }
            else
            {
                valid = true;
                if (checkBox1.Checked && valid == true && !checkBox2.Checked)
                {
                    Drlogin R = Drlogin.getinstance();
                    R.Show();
                    this.Hide();
                }
                if (checkBox2.Checked && valid == true && !checkBox1.Checked)
                {

                    Plogin P = Plogin.getinstance();
                    P.Show();
                    this.Hide();

                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
