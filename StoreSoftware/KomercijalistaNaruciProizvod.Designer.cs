namespace StoreSoftware
{
    partial class KomercijalistaNaruciProizvod
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
            this.btnSviPodaci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.dataGridProizvodi = new System.Windows.Forms.DataGridView();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajUKorpu = new System.Windows.Forms.Button();
            this.btnUkloniIzKorpe = new System.Windows.Forms.Button();
            this.btnPogledajNarudzbenicu = new System.Windows.Forms.Button();
            this.btnNaruciProizvod = new System.Windows.Forms.Button();
            this.txtKvantitet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImeProizvoda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSviPodaci
            // 
            this.btnSviPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSviPodaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSviPodaci.Location = new System.Drawing.Point(813, 49);
            this.btnSviPodaci.Name = "btnSviPodaci";
            this.btnSviPodaci.Size = new System.Drawing.Size(75, 23);
            this.btnSviPodaci.TabIndex = 30;
            this.btnSviPodaci.Text = "Svi podaci";
            this.btnSviPodaci.UseVisualStyleBackColor = true;
            this.btnSviPodaci.Click += new System.EventHandler(this.btnSviPodaci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label6.Location = new System.Drawing.Point(350, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Pretraži po bilo kojoj vrednosti:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.ForeColor = System.Drawing.Color.Gray;
            this.txtPretrazi.Location = new System.Drawing.Point(506, 46);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(131, 20);
            this.txtPretrazi.TabIndex = 28;
            this.txtPretrazi.Text = "Unesite ključnu reč...";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            this.txtPretrazi.Enter += new System.EventHandler(this.txtPretrazi_Enter);
            this.txtPretrazi.Leave += new System.EventHandler(this.txtPretrazi_Leave);
            // 
            // dataGridProizvodi
            // 
            this.dataGridProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProizvodi.Location = new System.Drawing.Point(353, 88);
            this.dataGridProizvodi.Name = "dataGridProizvodi";
            this.dataGridProizvodi.Size = new System.Drawing.Size(535, 379);
            this.dataGridProizvodi.TabIndex = 27;
            this.dataGridProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProizvodi_CellContentClick);
            this.dataGridProizvodi.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProizvodi_RowHeaderMouseClick);
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDobavljac.Location = new System.Drawing.Point(177, 148);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.ReadOnly = true;
            this.txtDobavljac.Size = new System.Drawing.Size(148, 31);
            this.txtDobavljac.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(21, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dobavljač:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDodajUKorpu
            // 
            this.btnDodajUKorpu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajUKorpu.AutoSize = true;
            this.btnDodajUKorpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUKorpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnDodajUKorpu.Location = new System.Drawing.Point(12, 489);
            this.btnDodajUKorpu.Name = "btnDodajUKorpu";
            this.btnDodajUKorpu.Size = new System.Drawing.Size(215, 34);
            this.btnDodajUKorpu.TabIndex = 31;
            this.btnDodajUKorpu.Text = "Dodaj proizvod u korpu";
            this.btnDodajUKorpu.UseVisualStyleBackColor = true;
            this.btnDodajUKorpu.Click += new System.EventHandler(this.btnDodajUKorpu_Click);
            // 
            // btnUkloniIzKorpe
            // 
            this.btnUkloniIzKorpe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUkloniIzKorpe.AutoSize = true;
            this.btnUkloniIzKorpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniIzKorpe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUkloniIzKorpe.Location = new System.Drawing.Point(233, 489);
            this.btnUkloniIzKorpe.Name = "btnUkloniIzKorpe";
            this.btnUkloniIzKorpe.Size = new System.Drawing.Size(143, 34);
            this.btnUkloniIzKorpe.TabIndex = 32;
            this.btnUkloniIzKorpe.Text = "Ukloni iz korpe";
            this.btnUkloniIzKorpe.UseVisualStyleBackColor = true;
            this.btnUkloniIzKorpe.Click += new System.EventHandler(this.btnUkloniIzKorpe_Click);
            // 
            // btnPogledajNarudzbenicu
            // 
            this.btnPogledajNarudzbenicu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPogledajNarudzbenicu.AutoSize = true;
            this.btnPogledajNarudzbenicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPogledajNarudzbenicu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnPogledajNarudzbenicu.Location = new System.Drawing.Point(382, 489);
            this.btnPogledajNarudzbenicu.Name = "btnPogledajNarudzbenicu";
            this.btnPogledajNarudzbenicu.Size = new System.Drawing.Size(215, 34);
            this.btnPogledajNarudzbenicu.TabIndex = 33;
            this.btnPogledajNarudzbenicu.Text = "Pogledaj narudžbenicu";
            this.btnPogledajNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnPogledajNarudzbenicu.Click += new System.EventHandler(this.btnPogledajNarudzbenicu_Click);
            // 
            // btnNaruciProizvod
            // 
            this.btnNaruciProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNaruciProizvod.AutoSize = true;
            this.btnNaruciProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaruciProizvod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnNaruciProizvod.Location = new System.Drawing.Point(761, 493);
            this.btnNaruciProizvod.Name = "btnNaruciProizvod";
            this.btnNaruciProizvod.Size = new System.Drawing.Size(127, 30);
            this.btnNaruciProizvod.TabIndex = 34;
            this.btnNaruciProizvod.Text = "Naruči proizvod";
            this.btnNaruciProizvod.UseVisualStyleBackColor = true;
            this.btnNaruciProizvod.Click += new System.EventHandler(this.btnNaruciProizvod_Click);
            // 
            // txtKvantitet
            // 
            this.txtKvantitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKvantitet.Location = new System.Drawing.Point(177, 350);
            this.txtKvantitet.Name = "txtKvantitet";
            this.txtKvantitet.Size = new System.Drawing.Size(148, 31);
            this.txtKvantitet.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label7.Location = new System.Drawing.Point(21, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kvantitet:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(21, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ime proizvoda:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtImeProizvoda
            // 
            this.txtImeProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeProizvoda.Location = new System.Drawing.Point(177, 187);
            this.txtImeProizvoda.Name = "txtImeProizvoda";
            this.txtImeProizvoda.ReadOnly = true;
            this.txtImeProizvoda.Size = new System.Drawing.Size(148, 31);
            this.txtImeProizvoda.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Proizvođač:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProizvodjac.Location = new System.Drawing.Point(177, 230);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.ReadOnly = true;
            this.txtProizvodjac.Size = new System.Drawing.Size(148, 31);
            this.txtProizvodjac.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label4.Location = new System.Drawing.Point(21, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kategorija:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtKategorija
            // 
            this.txtKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategorija.Location = new System.Drawing.Point(177, 270);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.ReadOnly = true;
            this.txtKategorija.Size = new System.Drawing.Size(148, 31);
            this.txtKategorija.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(21, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cena:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(177, 310);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(148, 31);
            this.txtCena.TabIndex = 26;
            // 
            // KomercijalistaNaruciProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(941, 546);
            this.Controls.Add(this.txtKvantitet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNaruciProizvod);
            this.Controls.Add(this.btnPogledajNarudzbenicu);
            this.Controls.Add(this.btnUkloniIzKorpe);
            this.Controls.Add(this.btnDodajUKorpu);
            this.Controls.Add(this.btnSviPodaci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.dataGridProizvodi);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImeProizvoda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KomercijalistaNaruciProizvod";
            this.Load += new System.EventHandler(this.KomercijalistaNaruciProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSviPodaci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.DataGridView dataGridProizvodi;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajUKorpu;
        private System.Windows.Forms.Button btnUkloniIzKorpe;
        private System.Windows.Forms.Button btnPogledajNarudzbenicu;
        private System.Windows.Forms.Button btnNaruciProizvod;
        private System.Windows.Forms.TextBox txtKvantitet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImeProizvoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCena;
    }
}