using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET
{
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=MAY_VIVOBOOK_20\SQLEXPRESS;Database=DonSang;Integrated Security=true;TrustServerCertificate=True;");
        SqlCommand cmd;
        public Form7()
        {
            InitializeComponent();
        }

        private void AfficherTous_Click(object sender, EventArgs e)
        {
            conn.Open();
            string req = "select * from Donneur;";
            cmd = new SqlCommand(req, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void Region_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            Chercher.Visible = true;
            comboBox2.Visible = false;
            textBox1.Visible = false;



        }

        private void TypeS_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox1.Visible = false;
            Chercher.Visible = true;
            textBox1.Visible = false;
        }

        private void Date_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            Chercher.Visible = true;
            comboBox2.Visible = false;
            comboBox1.Visible = false;

        }

        private void Chercher_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (comboBox1.Visible)
            {
                string req = "select * from Donneur where Région='" + comboBox1.SelectedItem.ToString() + "';";
                cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
               

            }
            else if(comboBox2.Visible)
            {
                string req = "select * from Donneur where Groupe_S ='" + comboBox2.SelectedItem.ToString() + "';";
                cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                

            }
            else if (textBox1.Visible)
            {
                string req = "select * from Donneur where DateN like %'" + textBox1.Text + "'%;";
                cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            conn.Close();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            form2.Show();
           
            this.Hide();
        }

  
    }
}
