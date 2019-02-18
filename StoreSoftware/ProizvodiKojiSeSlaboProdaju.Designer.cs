namespace StoreSoftware
{
    partial class ProizvodiKojiSeSlaboProdaju
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
            this.btnMesecPrvi = new System.Windows.Forms.Button();
            this.btnMesecDrugi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMesecTreci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridProizvodi = new System.Windows.Forms.DataGridView();
            this.txtImeProizvoda = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.txtDatumPoslednjeProdaje = new System.Windows.Forms.TextBox();
            this.txtProcenat = new System.Windows.Forms.TextBox();
            this.btnPromeniCenu = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesec dana od poslednje prodaje:";
            // 
            // btnMesecPrvi
            // 
            this.btnMesecPrvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesecPrvi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnMesecPrvi.Location = new System.Drawing.Point(229, 26);
            this.btnMesecPrvi.Name = "btnMesecPrvi";
            this.btnMesecPrvi.Size = new System.Drawing.Size(75, 23);
            this.btnMesecPrvi.TabIndex = 1;
            this.btnMesecPrvi.Text = "Pretraži";
            this.btnMesecPrvi.UseVisualStyleBackColor = true;
            this.btnMesecPrvi.Click += new System.EventHandler(this.btnMesecPrvi_Click);
            // 
            // btnMesecDrugi
            // 
            this.btnMesecDrugi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesecDrugi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnMesecDrugi.Location = new System.Drawing.Point(536, 26);
            this.btnMesecDrugi.Name = "btnMesecDrugi";
            this.btnMesecDrugi.Size = new System.Drawing.Size(75, 23);
            this.btnMesecDrugi.TabIndex = 3;
            this.btnMesecDrugi.Text = "Pretraži";
            this.btnMesecDrugi.UseVisualStyleBackColor = true;
            this.btnMesecDrugi.Click += new System.EventHandler(this.btnMesecDrugi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(348, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dva meseca od poslednje prodaje:";
            // 
            // btnMesecTreci
            // 
            this.btnMesecTreci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesecTreci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnMesecTreci.Location = new System.Drawing.Point(876, 26);
            this.btnMesecTreci.Name = "btnMesecTreci";
            this.btnMesecTreci.Size = new System.Drawing.Size(75, 23);
            this.btnMesecTreci.TabIndex = 5;
            this.btnMesecTreci.Text = "Pretraži";
            this.btnMesecTreci.UseVisualStyleBackColor = true;
            this.btnMesecTreci.Click += new System.EventHandler(this.btnMesecTreci_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(688, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tri meseca od poslednje prodaje:";
            // 
            // dataGridProizvodi
            // 
            this.dataGridProizvodi.AllowUserToAddRows = false;
            this.dataGridProizvodi.AllowUserToDeleteRows = false;
            this.dataGridProizvodi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProizvodi.Location = new System.Drawing.Point(44, 102);
            this.dataGridProizvodi.Name = "dataGridProizvodi";
            this.dataGridProizvodi.ReadOnly = true;
            this.dataGridProizvodi.Size = new System.Drawing.Size(611, 323);
            this.dataGridProizvodi.TabIndex = 6;
            this.dataGridProizvodi.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProizvodi_RowHeaderMouseClick);
            // 
            // txtImeProizvoda
            // 
            this.txtImeProizvoda.Location = new System.Drawing.Point(817, 120);
            this.txtImeProizvoda.Name = "txtImeProizvoda";
            this.txtImeProizvoda.Size = new System.Drawing.Size(134, 20);
            this.txtImeProizvoda.TabIndex = 7;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(817, 166);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(134, 20);
            this.txtProizvodjac.TabIndex = 8;
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(817, 214);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(134, 20);
            this.txtKategorija.TabIndex = 9;
            // 
            // txtDatumPoslednjeProdaje
            // 
            this.txtDatumPoslednjeProdaje.Location = new System.Drawing.Point(817, 300);
            this.txtDatumPoslednjeProdaje.Name = "txtDatumPoslednjeProdaje";
            this.txtDatumPoslednjeProdaje.Size = new System.Drawing.Size(134, 20);
            this.txtDatumPoslednjeProdaje.TabIndex = 10;
            // 
            // txtProcenat
            // 
            this.txtProcenat.Location = new System.Drawing.Point(817, 347);
            this.txtProcenat.Name = "txtProcenat";
            this.txtProcenat.Size = new System.Drawing.Size(134, 20);
            this.txtProcenat.TabIndex = 11;
            // 
            // btnPromeniCenu
            // 
            this.btnPromeniCenu.AutoSize = true;
            this.btnPromeniCenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromeniCenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnPromeniCenu.Location = new System.Drawing.Point(792, 400);
            this.btnPromeniCenu.Name = "btnPromeniCenu";
            this.btnPromeniCenu.Size = new System.Drawing.Size(84, 25);
            this.btnPromeniCenu.TabIndex = 12;
            this.btnPromeniCenu.Text = "Promeni cenu";
            this.btnPromeniCenu.UseVisualStyleBackColor = true;
            this.btnPromeniCenu.Click += new System.EventHandler(this.btnPromeniCenu_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(817, 254);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(134, 20);
            this.txtCena.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label4.Location = new System.Drawing.Point(688, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ime proizvoda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(688, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Proizvođač:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label6.Location = new System.Drawing.Point(688, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label7.Location = new System.Drawing.Point(688, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Datum poslednje prodaje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label8.Location = new System.Drawing.Point(688, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Već sniženo za:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label9.Location = new System.Drawing.Point(688, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kategorija:";
            // 
            // ProizvodiKojiSeSlaboProdaju
            // 
            this.AcceptButton = this.btnPromeniCenu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnPromeniCenu);
            this.Controls.Add(this.txtProcenat);
            this.Controls.Add(this.txtDatumPoslednjeProdaje);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtImeProizvoda);
            this.Controls.Add(this.dataGridProizvodi);
            this.Controls.Add(this.btnMesecTreci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMesecDrugi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMesecPrvi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProizvodiKojiSeSlaboProdaju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMesecPrvi;
        private System.Windows.Forms.Button btnMesecDrugi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMesecTreci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridProizvodi;
        private System.Windows.Forms.TextBox txtImeProizvoda;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.TextBox txtDatumPoslednjeProdaje;
        private System.Windows.Forms.TextBox txtProcenat;
        private System.Windows.Forms.Button btnPromeniCenu;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}