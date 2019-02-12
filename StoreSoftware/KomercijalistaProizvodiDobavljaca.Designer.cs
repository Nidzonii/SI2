namespace StoreSoftware
{
    partial class KomercijalistaProizvodiDobavljaca
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
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.txtImeProizvoda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dataGridProizvodi = new System.Windows.Forms.DataGridView();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSviPodaci = new System.Windows.Forms.Button();
            this.btnIzmeniCenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(170, 89);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(100, 20);
            this.txtDobavljac.TabIndex = 1;
            // 
            // txtImeProizvoda
            // 
            this.txtImeProizvoda.Location = new System.Drawing.Point(170, 128);
            this.txtImeProizvoda.Name = "txtImeProizvoda";
            this.txtImeProizvoda.Size = new System.Drawing.Size(100, 20);
            this.txtImeProizvoda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime proizvoda:";
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(170, 171);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjac.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proizvođač:";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(170, 211);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(100, 20);
            this.txtKategorija.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategorija:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(170, 251);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cena:";
            // 
            // btnUbaci
            // 
            this.btnUbaci.Location = new System.Drawing.Point(65, 342);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(75, 23);
            this.btnUbaci.TabIndex = 10;
            this.btnUbaci.Text = "Ubaci";
            this.btnUbaci.UseVisualStyleBackColor = true;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(256, 342);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dataGridProizvodi
            // 
            this.dataGridProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProizvodi.Location = new System.Drawing.Point(405, 82);
            this.dataGridProizvodi.Name = "dataGridProizvodi";
            this.dataGridProizvodi.Size = new System.Drawing.Size(535, 283);
            this.dataGridProizvodi.TabIndex = 13;
            this.dataGridProizvodi.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProizvodi_RowHeaderMouseClick);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.ForeColor = System.Drawing.Color.Gray;
            this.txtPretrazi.Location = new System.Drawing.Point(558, 40);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(131, 20);
            this.txtPretrazi.TabIndex = 14;
            this.txtPretrazi.Text = "Unesite ključnu reč...";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            this.txtPretrazi.Enter += new System.EventHandler(this.txtPretrazi_Enter);
            this.txtPretrazi.Leave += new System.EventHandler(this.txtPretrazi_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pretraži po bilo kojoj vrednosti:";
            // 
            // btnSviPodaci
            // 
            this.btnSviPodaci.Location = new System.Drawing.Point(865, 43);
            this.btnSviPodaci.Name = "btnSviPodaci";
            this.btnSviPodaci.Size = new System.Drawing.Size(75, 23);
            this.btnSviPodaci.TabIndex = 16;
            this.btnSviPodaci.Text = "Svi podaci";
            this.btnSviPodaci.UseVisualStyleBackColor = true;
            this.btnSviPodaci.Click += new System.EventHandler(this.btnSviPodaci_Click);
            // 
            // btnIzmeniCenu
            // 
            this.btnIzmeniCenu.Location = new System.Drawing.Point(161, 342);
            this.btnIzmeniCenu.Name = "btnIzmeniCenu";
            this.btnIzmeniCenu.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeniCenu.TabIndex = 17;
            this.btnIzmeniCenu.Text = "Izmeni cenu";
            this.btnIzmeniCenu.UseVisualStyleBackColor = true;
            this.btnIzmeniCenu.Click += new System.EventHandler(this.btnIzmeniCenu_Click);
            // 
            // KomercijalistaProizvodiDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnIzmeniCenu);
            this.Controls.Add(this.btnSviPodaci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.dataGridProizvodi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUbaci);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KomercijalistaProizvodiDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KomercijalistaProizvodiDobavljaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.TextBox txtImeProizvoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dataGridProizvodi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSviPodaci;
        private System.Windows.Forms.Button btnIzmeniCenu;
    }
}