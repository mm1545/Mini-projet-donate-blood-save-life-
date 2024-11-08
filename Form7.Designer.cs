namespace PROJET
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.TypeS = new System.Windows.Forms.Button();
            this.Région = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AfficherTous = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Button();
            this.Chercher = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeS
            // 
            this.TypeS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TypeS.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.TypeS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TypeS.Location = new System.Drawing.Point(1262, 556);
            this.TypeS.Name = "TypeS";
            this.TypeS.Size = new System.Drawing.Size(234, 134);
            this.TypeS.TabIndex = 48;
            this.TypeS.Text = "Selon groupe sanguin";
            this.TypeS.UseVisualStyleBackColor = false;
            this.TypeS.Click += new System.EventHandler(this.TypeS_Click);
            // 
            // Région
            // 
            this.Région.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Région.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Région.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Région.Location = new System.Drawing.Point(1262, 364);
            this.Région.Name = "Région";
            this.Région.Size = new System.Drawing.Size(234, 134);
            this.Région.TabIndex = 47;
            this.Région.Text = "Selon Région";
            this.Région.UseVisualStyleBackColor = false;
            this.Région.Click += new System.EventHandler(this.Region_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 738);
            this.dataGridView1.TabIndex = 46;
            // 
            // AfficherTous
            // 
            this.AfficherTous.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AfficherTous.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.AfficherTous.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AfficherTous.Location = new System.Drawing.Point(1262, 165);
            this.AfficherTous.Name = "AfficherTous";
            this.AfficherTous.Size = new System.Drawing.Size(234, 134);
            this.AfficherTous.TabIndex = 49;
            this.AfficherTous.Text = "Afficher tous les donneurs";
            this.AfficherTous.UseVisualStyleBackColor = false;
            this.AfficherTous.Click += new System.EventHandler(this.AfficherTous_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 1009);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 38);
            this.textBox1.TabIndex = 50;
            this.textBox1.Visible = false;
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Date.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Date.Location = new System.Drawing.Point(1262, 736);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(234, 134);
            this.Date.TabIndex = 51;
            this.Date.Text = "Selon année de naissance";
            this.Date.UseVisualStyleBackColor = false;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Chercher
            // 
            this.Chercher.BackColor = System.Drawing.SystemColors.Info;
            this.Chercher.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Chercher.Location = new System.Drawing.Point(680, 976);
            this.Chercher.Name = "Chercher";
            this.Chercher.Size = new System.Drawing.Size(297, 107);
            this.Chercher.TabIndex = 52;
            this.Chercher.Text = "Chercher ";
            this.Chercher.UseVisualStyleBackColor = false;
            this.Chercher.Visible = false;
            this.Chercher.Click += new System.EventHandler(this.Chercher_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ariana",
            "Béja",
            "Ben Arous",
            "Bizerte",
            "Gabès",
            "Gafsa",
            "Jendouba",
            "Kairouan",
            "Kasserine",
            "Kébili",
            "Kef",
            "Mahdia",
            "Manouba",
            "Médenine",
            "Monastir",
            "Nabeul",
            "Sfax",
            "Sidi Bouzid",
            "Siliana",
            "Sousse",
            "Tataouine",
            "Tozeur",
            "Tunis",
            "Zaghouan"});
            this.comboBox1.Location = new System.Drawing.Point(234, 1007);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 39);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.Text = "Entrez Région";
            this.comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownWidth = 239;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox2.Location = new System.Drawing.Point(234, 1004);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(368, 42);
            this.comboBox2.TabIndex = 54;
            this.comboBox2.Text = "Entrez type";
            this.comboBox2.Visible = false;
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Annuler.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Annuler.Location = new System.Drawing.Point(63, 1201);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(220, 107);
            this.Annuler.TabIndex = 55;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1638, 1362);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Chercher);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AfficherTous);
            this.Controls.Add(this.TypeS);
            this.Controls.Add(this.Région);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TypeS;
        private System.Windows.Forms.Button Région;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AfficherTous;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Date;
        private System.Windows.Forms.Button Chercher;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Annuler;
    }
}