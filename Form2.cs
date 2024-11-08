using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 form7 = new Form7();

            form7.Show();

            this.Hide();
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form4 form4 = new Form4();

            form4.Show();

            this.Hide();
        }
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();

            form6.Show();

            this.Hide();
        }

        private void linkLabel7_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 form8 = new Form8();

            form8.Show();

        
            this.Hide();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();

          
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel5.Visible)
            {
                linkLabel5.Visible = true;
                linkLabel6.Visible = true;
            }
            else
            {
                linkLabel5.Visible = false;
                linkLabel6.Visible = false;
            }
           

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel7.Visible)
            {
                linkLabel7.Visible = true;
                linkLabel8.Visible = true;
            }
            else
            {
                linkLabel7.Visible = false;
                linkLabel8.Visible = false;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel9.Visible)
            {
                linkLabel9.Visible = true;
                linkLabel10.Visible = true;
            }
            else
            {
                linkLabel9.Visible = false;
                linkLabel10.Visible = false;
            }
        }
    }
}
