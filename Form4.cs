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

namespace PROJET
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=MAY_VIVOBOOK_20\SQLEXPRESS;Database=DonSang;Integrated Security=true;TrustServerCertificate=True;");
        SqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
        }

        private void VerQte_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select sum(Quantité_Dispo) from Stock_Sang where Groupe_S='" + comboBox2.SelectedItem.ToString() + "';", conn);
            string qte = cmd.ExecuteScalar().ToString();
            textBox1.Text = qte;
            if (Int32.Parse(textBox1.Text) < 50)
            {
                richTextBox1.Text = "le Stock est bientot epuisé veuillez faire le réapprovisionnement nesessaire ;";
            }
            else if (Int32.Parse(textBox1.Text) < 1)
            {
                richTextBox1.Text = "le Stock epuisé veuillez faire le réapprovisionnement nésessaire ;";

            }
            else
            {
                richTextBox1.Text = "votre stock pour type sanguin '" + comboBox2.SelectedItem.ToString() + "'= '" + textBox1.Text + "'";

            }
            string req = "select * from Stock_Sang where Quantité_Dispo=0 and Groupe_S='"+ comboBox2.SelectedItem.ToString() + "';";
            cmd = new SqlCommand(req, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();
        }

        private void VerEx_Click(object sender, EventArgs e)
        {
            conn.Open();
            string req = "select * from Stock_Sang where Date_Expiration < GETDATE() " +
                "and Quantité_Dispo=0 and Groupe_S='"+ comboBox2.SelectedItem.ToString() + "';";
            cmd = new SqlCommand(req, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            try
            {
                string req = "delete from Stock_Sang where Date_Expiration < GETDATE() and Quantité_Dispo=0 " +
                    "and Groupe_S='"+ comboBox2.SelectedItem.ToString() + "';";
                cmd = new SqlCommand(req, conn);
                cmd.ExecuteNonQuery();
                string req1 = "delete from Stock_Sang where Quantité_Dispo = 0;";
                cmd = new SqlCommand(req1, conn);
                cmd.ExecuteNonQuery();
                string req2 = "SELECT  * from Stock_Sang;";
                cmd = new SqlCommand(req2, conn);
                cmd.ExecuteScalar();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                MessageBox.Show("les données sont mis à jour avec succées");
            }
            catch (Exception)
            {
                MessageBox.Show("erreur de supression");
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
