namespace PROJET
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AfficherDemandeur = new System.Windows.Forms.Button();
            this.Evaluation = new System.Windows.Forms.Button();
            this.AfficherStock = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idDemandeur = new System.Windows.Forms.Label();
            this.Annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(820, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 38);
            this.textBox3.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 38);
            this.textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 38);
            this.textBox1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(678, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 34);
            this.label7.TabIndex = 35;
            this.label7.Text = "Urgence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(661, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 68);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quantité\r\nDemandée";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(180, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 68);
            this.label8.TabIndex = 33;
            this.label8.Text = "Type \r\nsanguin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(180, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 68);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nom\r\nInstitution";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(180, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 34);
            this.label10.TabIndex = 31;
            this.label10.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 555);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 608);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(820, 318);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 38);
            this.textBox4.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1211, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 68);
            this.label1.TabIndex = 42;
            this.label1.Text = "Quantité disponible \r\n         en stock";
            // 
            // AfficherDemandeur
            // 
            this.AfficherDemandeur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AfficherDemandeur.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.AfficherDemandeur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AfficherDemandeur.Location = new System.Drawing.Point(1248, 352);
            this.AfficherDemandeur.Name = "AfficherDemandeur";
            this.AfficherDemandeur.Size = new System.Drawing.Size(197, 91);
            this.AfficherDemandeur.TabIndex = 43;
            this.AfficherDemandeur.Text = "Afficher liste demandeurs ";
            this.AfficherDemandeur.UseVisualStyleBackColor = false;
            this.AfficherDemandeur.Click += new System.EventHandler(this.AfficherDemandeur_Click);
            // 
            // Evaluation
            // 
            this.Evaluation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Evaluation.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Evaluation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Evaluation.Location = new System.Drawing.Point(1197, 971);
            this.Evaluation.Name = "Evaluation";
            this.Evaluation.Size = new System.Drawing.Size(197, 91);
            this.Evaluation.TabIndex = 44;
            this.Evaluation.Text = "Evaluer Demande";
            this.Evaluation.UseVisualStyleBackColor = false;
            this.Evaluation.Click += new System.EventHandler(this.Evaluation_Click);
            // 
            // AfficherStock
            // 
            this.AfficherStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AfficherStock.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.AfficherStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AfficherStock.Location = new System.Drawing.Point(1197, 825);
            this.AfficherStock.Name = "AfficherStock";
            this.AfficherStock.Size = new System.Drawing.Size(197, 91);
            this.AfficherStock.TabIndex = 46;
            this.AfficherStock.Text = "Afficher liste stock ";
            this.AfficherStock.UseVisualStyleBackColor = false;
            this.AfficherStock.Click += new System.EventHandler(this.AfficherStock_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1208, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(271, 38);
            this.textBox5.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1197, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 91);
            this.button1.TabIndex = 48;
            this.button1.Text = "Selectionner";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idDemandeur
            // 
            this.idDemandeur.AutoSize = true;
            this.idDemandeur.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.idDemandeur.Location = new System.Drawing.Point(324, 99);
            this.idDemandeur.Name = "idDemandeur";
            this.idDemandeur.Size = new System.Drawing.Size(90, 34);
            this.idDemandeur.TabIndex = 49;
            this.idDemandeur.Text = "label2";
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Annuler.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Annuler.Location = new System.Drawing.Point(42, 1294);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(220, 107);
            this.Annuler.TabIndex = 50;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1564, 1426);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.idDemandeur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.AfficherStock);
            this.Controls.Add(this.Evaluation);
            this.Controls.Add(this.AfficherDemandeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AfficherDemandeur;
        private System.Windows.Forms.Button Evaluation;
        private System.Windows.Forms.Button AfficherStock;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idDemandeur;
        private System.Windows.Forms.Button Annuler;
    }
}