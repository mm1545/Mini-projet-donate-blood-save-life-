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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET
{
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=MAY_VIVOBOOK_20\SQLEXPRESS;Database=DonSang;Integrated Security=true;TrustServerCertificate=True;");
        SqlCommand cmd;
        public Form8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string id = idStock.Text;
                int cin = Int32.Parse(textBox3.Text);

                string idDQuery = "SELECT ID_Donneur FROM Donneur WHERE CIN='" + cin + "'";
                cmd = new SqlCommand(idDQuery, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    int idDon = rd.GetInt32(0);
                    rd.Close();
                    using (SqlCommand cmd1 = new SqlCommand("SET IDENTITY_INSERT Stock_Sang ON;", conn))
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    string insertQuery = "INSERT INTO Stock_Sang (ID_Stock, Groupe_S, Quantité_Dispo, Date_Expiration, ID_Donneur) " +
                                         "VALUES ('" + Int32.Parse(id) + "', '" + comboBox1.SelectedItem.ToString() + "', '" + textBox4.Text + "', '" + dateTimePicker1.Value + "', '" + idDon + "')";
                    cmd = new SqlCommand(insertQuery, conn);
                    cmd.ExecuteNonQuery();
                    using (SqlCommand cmd2 = new SqlCommand("SET IDENTITY_INSERT Stock_Sang OFF;", conn))
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Stock ajouté avec succès");
                }
                else
                {
                    MessageBox.Show("CIN non trouvé");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'insertion Stock : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            form2.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                using (SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Stock) FROM Stock_Sang", conn))
                {
                    int value = (int)cmd.ExecuteScalar();
                    value += 1;
                    idStock.Text = value.ToString();
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
