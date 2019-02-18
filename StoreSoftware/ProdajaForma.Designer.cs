namespace StoreSoftware
{
    partial class ProdajaForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZamena = new System.Windows.Forms.Button();
            this.btnBrisanjeIzKorpe = new System.Windows.Forms.Button();
            this.btnKorpaDodaj = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.dgvKorpa = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKorpa = new System.Windows.Forms.Label();
            this.btnNarucivanje = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorpa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proizvođač";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis";
            // 
            // txtIme
            // 
            this.txtIme.ForeColor = System.Drawing.Color.Black;
            this.txtIme.Location = new System.Drawing.Point(212, 70);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(199, 20);
            this.txtIme.TabIndex = 4;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.ForeColor = System.Drawing.Color.Black;
            this.txtOpis.Location = new System.Drawing.Point(212, 223);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(199, 20);
            this.txtOpis.TabIndex = 6;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.ForeColor = System.Drawing.Color.Black;
            this.txtProizvodjac.Location = new System.Drawing.Point(212, 171);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(199, 20);
            this.txtProizvodjac.TabIndex = 7;
            // 
            // txtKategorija
            // 
            this.txtKategorija.ForeColor = System.Drawing.Color.Black;
            this.txtKategorija.Location = new System.Drawing.Point(212, 116);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(199, 20);
            this.txtKategorija.TabIndex = 8;
            // 
            // btnPretraga
            // 
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraga.Location = new System.Drawing.Point(638, 68);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(129, 46);
            this.btnPretraga.TabIndex = 9;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(57, 387);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.Size = new System.Drawing.Size(514, 219);
            this.dgv1.TabIndex = 10;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(719, 234);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Količina";
            // 
            // btnZamena
            // 
            this.btnZamena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamena.Location = new System.Drawing.Point(1128, 116);
            this.btnZamena.Name = "btnZamena";
            this.btnZamena.Size = new System.Drawing.Size(129, 45);
            this.btnZamena.TabIndex = 13;
            this.btnZamena.Text = "Zamena";
            this.btnZamena.UseVisualStyleBackColor = true;
            this.btnZamena.Click += new System.EventHandler(this.btnZamena_Click);
            // 
            // btnBrisanjeIzKorpe
            // 
            this.btnBrisanjeIzKorpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisanjeIzKorpe.Location = new System.Drawing.Point(864, 145);
            this.btnBrisanjeIzKorpe.Name = "btnBrisanjeIzKorpe";
            this.btnBrisanjeIzKorpe.Size = new System.Drawing.Size(129, 46);
            this.btnBrisanjeIzKorpe.TabIndex = 14;
            this.btnBrisanjeIzKorpe.Text = "Izbaci iz korpe";
            this.btnBrisanjeIzKorpe.UseVisualStyleBackColor = true;
            this.btnBrisanjeIzKorpe.Click += new System.EventHandler(this.btnBrisanjeIzKorpe_Click);
            // 
            // btnKorpaDodaj
            // 
            this.btnKorpaDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorpaDodaj.Location = new System.Drawing.Point(864, 68);
            this.btnKorpaDodaj.Name = "btnKorpaDodaj";
            this.btnKorpaDodaj.Size = new System.Drawing.Size(129, 46);
            this.btnKorpaDodaj.TabIndex = 15;
            this.btnKorpaDodaj.Text = "Dodaj u korpu";
            this.btnKorpaDodaj.UseVisualStyleBackColor = true;
            this.btnKorpaDodaj.Click += new System.EventHandler(this.btnKorpaDodaj_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvezi.Location = new System.Drawing.Point(638, 143);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(129, 46);
            this.btnOsvezi.TabIndex = 16;
            this.btnOsvezi.Text = "Nova pretraga";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrda.Location = new System.Drawing.Point(864, 222);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(129, 46);
            this.btnPotvrda.TabIndex = 17;
            this.btnPotvrda.Text = "Potvrdi kupovinu";
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // dgvKorpa
            // 
            this.dgvKorpa.AllowUserToAddRows = false;
            this.dgvKorpa.AllowUserToDeleteRows = false;
            this.dgvKorpa.BackgroundColor = System.Drawing.Color.White;
            this.dgvKorpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorpa.Location = new System.Drawing.Point(757, 387);
            this.dgvKorpa.Name = "dgvKorpa";
            this.dgvKorpa.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvKorpa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKorpa.Size = new System.Drawing.Size(500, 219);
            this.dgvKorpa.TabIndex = 18;
            this.dgvKorpa.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKorpa_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(264, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "PRETRAGA";
            // 
            // lblKorpa
            // 
            this.lblKorpa.AutoSize = true;
            this.lblKorpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorpa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKorpa.Location = new System.Drawing.Point(978, 352);
            this.lblKorpa.Name = "lblKorpa";
            this.lblKorpa.Size = new System.Drawing.Size(75, 24);
            this.lblKorpa.TabIndex = 25;
            this.lblKorpa.Text = "KORPA";
            // 
            // btnNarucivanje
            // 
            this.btnNarucivanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNarucivanje.Location = new System.Drawing.Point(1128, 197);
            this.btnNarucivanje.Name = "btnNarucivanje";
            this.btnNarucivanje.Size = new System.Drawing.Size(129, 45);
            this.btnNarucivanje.TabIndex = 26;
            this.btnNarucivanje.Text = "Naručivanje proizvoda";
            this.btnNarucivanje.UseVisualStyleBackColor = true;
            this.btnNarucivanje.Click += new System.EventHandler(this.btnNarucivanje_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(44, 294);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(280, 22);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Prikaži proizvode kojih nema na stanju";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSlika
            // 
            this.btnSlika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlika.Location = new System.Drawing.Point(619, 424);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(91, 37);
            this.btnSlika.TabIndex = 28;
            this.btnSlika.Text = "Prikaži sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternet.Location = new System.Drawing.Point(619, 486);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(91, 37);
            this.btnInternet.TabIndex = 29;
            this.btnInternet.Text = "Otvori vezu u pretraživaču";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // ProdajaForma
            // 
            this.AcceptButton = this.btnKorpaDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1262, 609);
            this.Controls.Add(this.btnInternet);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnNarucivanje);
            this.Controls.Add(this.lblKorpa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvKorpa);
            this.Controls.Add(this.btnPotvrda);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnKorpaDodaj);
            this.Controls.Add(this.btnBrisanjeIzKorpe);
            this.Controls.Add(this.btnZamena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdajaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProdajaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorpa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnZamena;
        private System.Windows.Forms.Button btnBrisanjeIzKorpe;
        private System.Windows.Forms.Button btnKorpaDodaj;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.DataGridView dgvKorpa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKorpa;
        private System.Windows.Forms.Button btnNarucivanje;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Button btnInternet;
    }
}