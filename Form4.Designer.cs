namespace PROJET
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Annuler = new System.Windows.Forms.Button();
            this.VerQte = new System.Windows.Forms.Button();
            this.VerEx = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Annuler.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Annuler.Location = new System.Drawing.Point(34, 1192);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(220, 107);
            this.Annuler.TabIndex = 56;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // VerQte
            // 
            this.VerQte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VerQte.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.VerQte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VerQte.Location = new System.Drawing.Point(1207, 291);
            this.VerQte.Name = "VerQte";
            this.VerQte.Size = new System.Drawing.Size(220, 107);
            this.VerQte.TabIndex = 57;
            this.VerQte.Text = "Vérifier Quantité ";
            this.VerQte.UseVisualStyleBackColor = false;
            this.VerQte.Click += new System.EventHandler(this.VerQte_Click);
            // 
            // VerEx
            // 
            this.VerEx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VerEx.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.VerEx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VerEx.Location = new System.Drawing.Point(1207, 664);
            this.VerEx.Name = "VerEx";
            this.VerEx.Size = new System.Drawing.Size(220, 107);
            this.VerEx.TabIndex = 58;
            this.VerEx.Text = "Vérifier date expiration";
            this.VerEx.UseVisualStyleBackColor = false;
            this.VerEx.Click += new System.EventHandler(this.VerEx_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(210, 316);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(735, 156);
            this.richTextBox1.TabIndex = 59;
            this.richTextBox1.Text = "";
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
            this.comboBox2.Location = new System.Drawing.Point(259, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(368, 42);
            this.comboBox2.TabIndex = 60;
            this.comboBox2.Text = "Entrez type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(869, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 38);
            this.textBox1.TabIndex = 61;
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Supprimer.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold);
            this.Supprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Supprimer.Location = new System.Drawing.Point(1207, 862);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(220, 107);
            this.Supprimer.TabIndex = 63;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(91, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 68);
            this.label1.TabIndex = 64;
            this.label1.Text = "Type\r\nsanguin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 563);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 535);
            this.dataGridView1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(706, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 68);
            this.label2.TabIndex = 66;
            this.label2.Text = "Qantité \r\nDisponible";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1564, 1329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.VerEx);
            this.Controls.Add(this.VerQte);
            this.Controls.Add(this.Annuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button VerQte;
        private System.Windows.Forms.Button VerEx;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}