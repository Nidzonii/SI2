namespace StoreSoftware
{
    partial class KomercijalistaNaruciProizvodObrisiIzKorpe
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
            this.dataGridKorpa = new System.Windows.Forms.DataGridView();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImeProizvoda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKorpa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKorpa
            // 
            this.dataGridKorpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKorpa.Location = new System.Drawing.Point(269, 55);
            this.dataGridKorpa.Name = "dataGridKorpa";
            this.dataGridKorpa.Size = new System.Drawing.Size(392, 217);
            this.dataGridKorpa.TabIndex = 33;
            this.dataGridKorpa.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridKorpa_RowHeaderMouseClick);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(135, 178);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Cena:";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(135, 138);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.ReadOnly = true;
            this.txtKategorija.Size = new System.Drawing.Size(100, 20);
            this.txtKategorija.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Kategorija:";
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(135, 98);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.ReadOnly = true;
            this.txtProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjac.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Proizvođač:";
            // 
            // txtImeProizvoda
            // 
            this.txtImeProizvoda.Location = new System.Drawing.Point(135, 55);
            this.txtImeProizvoda.Name = "txtImeProizvoda";
            this.txtImeProizvoda.ReadOnly = true;
            this.txtImeProizvoda.Size = new System.Drawing.Size(100, 20);
            this.txtImeProizvoda.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ime proizvoda:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.AutoSize = true;
            this.btnObrisi.Location = new System.Drawing.Point(103, 249);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(83, 23);
            this.btnObrisi.TabIndex = 42;
            this.btnObrisi.Text = "Obrisi iz korpe";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // KomercijalistaNaruciProizvodObrisiIzKorpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 335);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImeProizvoda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridKorpa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KomercijalistaNaruciProizvodObrisiIzKorpe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KomercijalistaNaruciProizvodObrisiIzKorpe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKorpa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridKorpa;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImeProizvoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisi;
    }
}