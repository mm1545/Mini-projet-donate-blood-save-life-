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
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=MAY_VIVOBOOK_20\SQLEXPRESS;Database=DonSang;Integrated Security=true;TrustServerCertificate=True;");
        SqlCommand cmd;
        public Form6()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AfficherDemandeur_Click(object sender, EventArgs e)
        {
            conn.Open();
            string req = "select * from Demande Order by Date_Demande;";
            cmd = new SqlCommand(req, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string val1 = selectedRow.Cells["ID_Demande"].Value.ToString();
            string val2 = selectedRow.Cells["Nom_Institution"].Value.ToString();
            string val3 = selectedRow.Cells["Type_Requis"].Value.ToString();
            string val4 = selectedRow.Cells["Quantité_Demandée"].Value.ToString();
            string val5 = selectedRow.Cells["Urgence_Demande"].Value.ToString();
            idDemandeur.Text = val1;
            textBox1.Text = val2;
            textBox2.Text = val3;
            textBox3.Text = val4;
            textBox4.Text = val5;
            conn.Open();
            string req = "select SUM(Quantité_Dispo) from Stock_Sang where Groupe_S='" + textBox2.Text + "';";
            cmd = new SqlCommand(req, conn);
            int qte = (int)cmd.ExecuteScalar();
            textBox5.Text = qte.ToString();
            conn.Close();



        }

        private void AfficherStock_Click(object sender, EventArgs e)
        {
            conn.Open();
            string req = "select * from Stock_Sang where Groupe_S='" + textBox2.Text + "' Order by Date_Expiration,Quantité_Dispo desc;";
            cmd = new SqlCommand(req, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }



        private void Evaluation_Click(object sender, EventArgs e)
        {

            conn.Open();
            if (Int32.Parse(textBox3.Text) <= Int32.Parse(textBox5.Text))
            {

                    for (int index = 0; index < dataGridView1.SelectedRows.Count; index++)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[index];
                        string value = selectedRow.Cells["Quantité_Dispo"].Value.ToString();
                        string id = selectedRow.Cells["ID_Stock"].Value.ToString();
                        int indice = Int32.Parse(id);
                        int val = Int32.Parse(value);

                        if (val >= Int32.Parse(textBox3.Text))
                        {
                            string req = "update Stock_Sang set Quantité_Dispo = Quantité_Dispo - '"+ Int32.Parse(textBox3.Text) + "' where ID_Stock = '"+indice+"';";
                            cmd = new SqlCommand(req, conn);
                            cmd.ExecuteNonQuery();


                            textBox5.Text = (Int32.Parse(textBox5.Text) - Int32.Parse(textBox3.Text)).ToString();
                            textBox3.Text = "0";

                            string req1 = "update Demande set Etat = 1 where ID_Demande ='"+idDemandeur.Text+"';";
                            cmd = new SqlCommand(req1, conn);
                            cmd.ExecuteNonQuery();

                           
                            string req2 = "Delete from Demande where Etat = 1;";
                            cmd = new SqlCommand(req2, conn);
                            cmd.ExecuteNonQuery();
                        MessageBox.Show("La demande est acceptée");


                    }
                    else if (val < Int32.Parse(textBox3.Text))
                        {
                            while (Int32.Parse(textBox3.Text) > 0 && val < Int32.Parse(textBox3.Text))
                            {
                                string req = "update Stock_Sang set Quantité_Dispo = 0 where ID_Stock = @stockID;";
                                cmd = new SqlCommand(req, conn);
                                cmd.Parameters.AddWithValue("@stockID", indice);
                                cmd.ExecuteNonQuery();

                                textBox3.Text = (Int32.Parse(textBox3.Text) - val).ToString();
                                textBox5.Text = (Int32.Parse(textBox5.Text) - val).ToString();

                                int indexsuivant = index + 1;
                                if (indexsuivant < dataGridView1.SelectedRows.Count)
                                {
                                    DataGridViewRow nextSelectedRow = dataGridView1.SelectedRows[indexsuivant];
                                    string nextValue = nextSelectedRow.Cells["Quantité_Dispo"].Value.ToString();
                                    string nextIndexStr = nextSelectedRow.Cells["ID_Stock"].Value.ToString();
                                    val = Int32.Parse(nextValue);
                                    indice = Int32.Parse(nextIndexStr);
                                }
                                else
                                {
                                    break;

                                }
                            }

                            string req2 = "update Demande set Etat = 1 where ID_Demande = @demandID;";
                            cmd = new SqlCommand(req2, conn);
                            cmd.Parameters.AddWithValue("@demandID", idDemandeur.Text);
                            cmd.ExecuteNonQuery();

                        }
                    }

           
            }
           
            else
            {
                MessageBox.Show("Stock est insuffisant, la demande est mise en attente.");


            }

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            form2.Show();

            this.Hide();
        }
    }
}
