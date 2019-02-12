namespace StoreSoftware
{
    partial class AdminDodavanjeKorisnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtboxSifra = new System.Windows.Forms.TextBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "korisničko ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "šifra:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(16, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "uloga:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxKorisnickoIme
            // 
            this.txtboxKorisnickoIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtboxKorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtboxKorisnickoIme.Location = new System.Drawing.Point(163, 79);
            this.txtboxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxKorisnickoIme.Name = "txtboxKorisnickoIme";
            this.txtboxKorisnickoIme.Size = new System.Drawing.Size(204, 22);
            this.txtboxKorisnickoIme.TabIndex = 3;
            this.txtboxKorisnickoIme.TextChanged += new System.EventHandler(this.txtboxKorisnickoIme_TextChanged);
            // 
            // txtboxSifra
            // 
            this.txtboxSifra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtboxSifra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtboxSifra.Location = new System.Drawing.Point(163, 123);
            this.txtboxSifra.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSifra.Name = "txtboxSifra";
            this.txtboxSifra.Size = new System.Drawing.Size(204, 22);
            this.txtboxSifra.TabIndex = 4;
            this.txtboxSifra.TextChanged += new System.EventHandler(this.txtboxSifra_TextChanged);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.Location = new System.Drawing.Point(20, 254);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(100, 28);
            this.btnRegistracija.TabIndex = 6;
            this.btnRegistracija.Text = "Registruj";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanje.Location = new System.Drawing.Point(268, 254);
            this.btnBrisanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(100, 28);
            this.btnBrisanje.TabIndex = 7;
            this.btnBrisanje.Text = "Obriši";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnPronadji
            // 
            this.btnPronadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadji.Location = new System.Drawing.Point(144, 254);
            this.btnPronadji.Margin = new System.Windows.Forms.Padding(4);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(100, 28);
            this.btnPronadji.TabIndex = 8;
            this.btnPronadji.Text = "Pronađi";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "administrator",
            "vlasnik",
            "komercijalista",
            "radnik"});
            this.comboBox1.Location = new System.Drawing.Point(163, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // AdminDodavanjeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(393, 311);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.txtboxSifra);
            this.Controls.Add(this.txtboxKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDodavanjeKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDodavanjeKorisnika";
            this.Load += new System.EventHandler(this.AdminDodavanjeKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxKorisnickoIme;
        private System.Windows.Forms.TextBox txtboxSifra;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}