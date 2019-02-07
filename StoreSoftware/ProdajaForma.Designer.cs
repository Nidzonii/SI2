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
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorpa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proizvodjac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(125, 26);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(125, 183);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(100, 20);
            this.txtOpis.TabIndex = 6;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(125, 133);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjac.TabIndex = 7;
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(125, 80);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(100, 20);
            this.txtKategorija.TabIndex = 8;
            this.txtKategorija.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(34, 226);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 9;
            this.btnPretraga.Text = "PRETRAGA";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(280, 26);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(240, 150);
            this.dgv1.TabIndex = 10;
            this.dgv1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 309);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
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
            this.label5.Location = new System.Drawing.Point(31, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kolicina";
            // 
            // btnZamena
            // 
            this.btnZamena.Location = new System.Drawing.Point(247, 355);
            this.btnZamena.Name = "btnZamena";
            this.btnZamena.Size = new System.Drawing.Size(75, 23);
            this.btnZamena.TabIndex = 13;
            this.btnZamena.Text = "Zamena";
            this.btnZamena.UseVisualStyleBackColor = true;
            this.btnZamena.Click += new System.EventHandler(this.btnZamena_Click);
            // 
            // btnBrisanjeIzKorpe
            // 
            this.btnBrisanjeIzKorpe.Location = new System.Drawing.Point(134, 268);
            this.btnBrisanjeIzKorpe.Name = "btnBrisanjeIzKorpe";
            this.btnBrisanjeIzKorpe.Size = new System.Drawing.Size(75, 23);
            this.btnBrisanjeIzKorpe.TabIndex = 14;
            this.btnBrisanjeIzKorpe.Text = "Izbaci iz korpe";
            this.btnBrisanjeIzKorpe.UseVisualStyleBackColor = true;
            this.btnBrisanjeIzKorpe.Click += new System.EventHandler(this.btnBrisanjeIzKorpe_Click);
            // 
            // btnKorpaDodaj
            // 
            this.btnKorpaDodaj.Location = new System.Drawing.Point(34, 268);
            this.btnKorpaDodaj.Name = "btnKorpaDodaj";
            this.btnKorpaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnKorpaDodaj.TabIndex = 15;
            this.btnKorpaDodaj.Text = "dodaj u korpu";
            this.btnKorpaDodaj.UseVisualStyleBackColor = true;
            this.btnKorpaDodaj.Click += new System.EventHandler(this.btnKorpaDodaj_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(134, 226);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(111, 23);
            this.btnOsvezi.TabIndex = 16;
            this.btnOsvezi.Text = "NOVA PRETRAGA";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.Location = new System.Drawing.Point(87, 355);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrda.TabIndex = 17;
            this.btnPotvrda.Text = "potvrdi kupovinu";
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // dgvKorpa
            // 
            this.dgvKorpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorpa.Location = new System.Drawing.Point(548, 26);
            this.dgvKorpa.Name = "dgvKorpa";
            this.dgvKorpa.Size = new System.Drawing.Size(240, 150);
            this.dgvKorpa.TabIndex = 18;
            this.dgvKorpa.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKorpa_RowHeaderMouseClick);
            // 
            // ProdajaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "ProdajaForma";
            this.Text = "ProdajaForma";
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
    }
}