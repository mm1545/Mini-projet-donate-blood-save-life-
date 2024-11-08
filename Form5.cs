using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=MAY_VIVOBOOK_20\SQLEXPRESS;Database=DonSang;Integrated Security=true;TrustServerCertificate=True;");
        SqlCommand cmd;
        public Form5()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            conn.Open();
            string statue;
            string id = idDemandeur.Text;
            if (Chercher_Client(id, conn) == 1)
            {
                MessageBox.Show("Demande existe déjà");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    statue = "Urgent";
                }
                else if (radioButton2.Checked)
                {
                    statue = "Normal";
                }
                else
                {
                    MessageBox.Show("Erreur: Sélectionnez l'urgence est OBLIGATOIRE!!!");
                  
                    return;
                }
                using (SqlCommand cmd1 = new SqlCommand("SET IDENTITY_INSERT Demande ON;", conn))
                {
                    cmd1.ExecuteNonQuery();
                }
                cmd = new SqlCommand("INSERT INTO Demande (ID_Demande,Nom_Institution,Type_Requis,Quantité_Demandée" +
                    ",Urgence_Demande,Date_Demande,Région) VALUES " +
                    "('" +Int32.Parse(id) + "','" + textBox1.Text + "','" + comboBox1.SelectedItem.ToString() + "'," +
                    "'" + textBox3.Text + "','" + statue + "','" +dateTimePicker1.Value+ "','" +comboBox2.SelectedItem.ToString()+ "');", conn);
                cmd.ExecuteNonQuery();
                using (SqlCommand cmd2 = new SqlCommand("SET IDENTITY_INSERT Demande OFF;", conn))
                {
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("Demande ajouté avec succès");
            }
            conn.Close();
        }
        public int Chercher_Client(string code, SqlConnection conn)
        {
            int exist = 0;
            try
            {
                string rq = "SELECT COUNT(*) FROM Demande WHERE ID_Demande='" + Int32.Parse(code) + "'";
                using (SqlCommand cmd = new SqlCommand(rq, conn))
                {
                    exist = (int)cmd.ExecuteScalar();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return exist;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            form2.Show();

            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                using (SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Demande) FROM Demande", conn))
                {
                    int value = (int)cmd.ExecuteScalar();
                    value += 1;
                    idDemandeur.Text = value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}

