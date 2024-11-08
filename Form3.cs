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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROJET
{
    public partial class Form3 : Form
    {   
        SqlConnection conn = new SqlConnection(@"Server=MAY_VIVOBOOK_20\SQLEXPRESS;Database=DonSang;Integrated Security=true;TrustServerCertificate=True;");
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {


            conn.Open();
            string statue;
            string id=idDonneur.Text;
            if (Chercher_Client(id, conn) == 1)
            {
                MessageBox.Show("Client existe déjà");
            }
            else
            {

                    if (radioButton1.Checked)
                    {
                        statue = "Femme";
                    }
                    else if (radioButton2.Checked)
                    {
                        statue = "Homme";
                    }
                    else
                {
                    MessageBox.Show("Erreur : Sélectionnez le Genre est OBLIGATOIRE!!!");
                    return;
                }


                using (SqlCommand cmd1 = new SqlCommand("SET IDENTITY_INSERT Donneur ON;", conn))
                {
                    cmd1.ExecuteNonQuery();
                }

                cmd = new SqlCommand("INSERT INTO Donneur (ID_Donneur,CIN,Nom, Prénom, DateN, Genre, Région, Adresse, Telephone, Groupe_S, Antécédents_Médicaux) VALUES ('"+Int32.Parse(idDonneur.Text) +"','"+textBox5.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+dateTimePicker1.Value+"','"+statue+"','"+comboBox2.SelectedItem.ToString()+"','"+textBox3.Text+"','"+textBox4.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+richTextBox1.Text+"');",conn);

                cmd.ExecuteNonQuery();
                using (SqlCommand cmd2 = new SqlCommand("SET IDENTITY_INSERT Donneur OFF;", conn))
                {
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("Donneur ajouté avec succès");

            }
            conn.Close();
        }

        public int Chercher_Client(string code, SqlConnection conn)
        {
            int exist = 0;
            try
            {
                string rq = "SELECT COUNT(*) FROM Donneur WHERE ID_Donneur=@ID_Donneur";
                using (SqlCommand cmd = new SqlCommand(rq, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Donneur", Int32.Parse(code));
                    exist = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return exist;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=MAY_VIVOBOOK_20\SQLEXPRESS;Database=DonSang;Integrated Security=true;TrustServerCertificate=True;");
            try
            {
                conn.Open();


                using (SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Donneur) FROM Donneur", conn))
                {
                    int value = (int)cmd.ExecuteScalar();
                    value += 1;
                    idDonneur.Text = value.ToString();
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

        private void Annuler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

           
            form2.Show();
            this.Hide();

         
         
        }

   

        private void Chercher_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox5.Text;
                string statue;
                conn.Open();
                string req1 = "SELECT * FROM Donneur WHERE CIN='"+code+"';";
                SqlCommand cmd = new SqlCommand(req1, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    try
                    {  
                        idDonneur.Text = rd.GetValue(0).ToString();
                        textBox1.Text = rd.GetString(2);
                        textBox2.Text = rd.GetString(3);
                        DateTime dateNaissance = Convert.ToDateTime(rd.GetValue(4));
                        dateTimePicker1.Value = dateNaissance;
                    }
                    catch(Exception) { MessageBox.Show("erreur d'insertion"); }
                   
                    statue=rd.GetString(5);
                    if (statue == "Femme")
                    {
                        radioButton1.Checked = true;
                    }
                    else {  radioButton2.Checked = true; }
                    comboBox2.SelectedItem = rd.GetString(6);
                    textBox3.Text = rd.GetString(7);
                    textBox4.Text = rd.GetValue(8).ToString();
                    comboBox1.SelectedItem = rd.GetString(9);
                    richTextBox1.Text = rd.GetString(10);
                }
                else
                {
                    MessageBox.Show("Client introuvable");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string statue;

                if (radioButton1.Checked)
                {
                    statue = "Femme";
                }
                else if (radioButton2.Checked)
                {
                    statue = "Homme";
                }
                else
                {
                    MessageBox.Show("Erreur : Sélectionnez le Genre est OBLIGATOIRE!!!");
                    return;
                }

                string req1 = "UPDATE Donneur  SET Nom='" + textBox1.Text + "', Prénom='" + textBox2.Text + "', DateN='" + dateTimePicker1.Value + "',Genre='" + statue + "',Région='" + comboBox2.SelectedItem.ToString() + "' " +
                    ",Adresse='" + textBox3.Text + "',Telephone='" + textBox4.Text + "', Groupe_S='" + comboBox1.SelectedItem.ToString() + "',Antécédents_Médicaux ='" + richTextBox1.Text + "' WHERE ID_Donneur ='" + Int32.Parse(idDonneur.Text) + "';";
                cmd = new SqlCommand(req1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Donneur modifié avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification du donneur : " + ex.Message);
            }
            conn.Close();   


        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string req1 = "Delete FROM Donneur WHERE ID_Donneur ='" + Int32.Parse(idDonneur.Text) + "';";
            cmd = new SqlCommand(req1, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Donneur supprimé avec succès");
            conn.Close() ;  
        }
    }
}
