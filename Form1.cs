using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar=='*')
            {
                textBox2.PasswordChar = '\0';
                pictureBox3.Image=Image.FromFile("C:/Users/maymi/OneDrive/Documents/2eme fac/S2/FRAME/PROJET/closeeye.jpg");
            }
            else if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
                pictureBox3.Image = Image.FromFile("C:/Users/maymi/OneDrive/Documents/2eme fac/S2/FRAME/PROJET/openeye.jpg");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Admin" && textBox2.Text != "Admin")
            {
                MessageBox.Show("le username et mot de passe sont erroné veuillez saisir une autre fois ");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }


         
        }
    }
}
