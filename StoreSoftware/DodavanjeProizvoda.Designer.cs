namespace StoreSoftware
{
    partial class DodavanjeProizvoda
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxNabCena = new System.Windows.Forms.TextBox();
            this.textBoxDuzGarRoka = new System.Windows.Forms.TextBox();
            this.textBoxBrNaStanju = new System.Windows.Forms.TextBox();
            this.textBoxKategorija = new System.Windows.Forms.TextBox();
            this.textBoxProizvodjac = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.Dodavanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(97, 56);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 0;
            this.textBoxIme.Text = "Ime";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(97, 404);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(100, 20);
            this.textBoxLink.TabIndex = 2;
            this.textBoxLink.Text = "Link";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(97, 317);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCena.TabIndex = 3;
            this.textBoxCena.Text = "Cena";
            // 
            // textBoxNabCena
            // 
            this.textBoxNabCena.Location = new System.Drawing.Point(97, 274);
            this.textBoxNabCena.Name = "textBoxNabCena";
            this.textBoxNabCena.Size = new System.Drawing.Size(100, 20);
            this.textBoxNabCena.TabIndex = 4;
            this.textBoxNabCena.Text = "Nabavna cena";
            // 
            // textBoxDuzGarRoka
            // 
            this.textBoxDuzGarRoka.Location = new System.Drawing.Point(97, 231);
            this.textBoxDuzGarRoka.Name = "textBoxDuzGarRoka";
            this.textBoxDuzGarRoka.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuzGarRoka.TabIndex = 5;
            this.textBoxDuzGarRoka.Text = "Duzina garantnog roka";
            // 
            // textBoxBrNaStanju
            // 
            this.textBoxBrNaStanju.Location = new System.Drawing.Point(97, 187);
            this.textBoxBrNaStanju.Name = "textBoxBrNaStanju";
            this.textBoxBrNaStanju.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrNaStanju.TabIndex = 6;
            this.textBoxBrNaStanju.Text = "Broj na stanju";
            // 
            // textBoxKategorija
            // 
            this.textBoxKategorija.Location = new System.Drawing.Point(97, 142);
            this.textBoxKategorija.Name = "textBoxKategorija";
            this.textBoxKategorija.Size = new System.Drawing.Size(100, 20);
            this.textBoxKategorija.TabIndex = 7;
            this.textBoxKategorija.Text = "Kategorija";
            // 
            // textBoxProizvodjac
            // 
            this.textBoxProizvodjac.Location = new System.Drawing.Point(97, 104);
            this.textBoxProizvodjac.Name = "textBoxProizvodjac";
            this.textBoxProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.textBoxProizvodjac.TabIndex = 8;
            this.textBoxProizvodjac.Text = "Proizvodjac";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(97, 356);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(100, 20);
            this.textBoxOpis.TabIndex = 9;
            this.textBoxOpis.Text = "Opis";
            // 
            // Dodavanje
            // 
            this.Dodavanje.Location = new System.Drawing.Point(343, 208);
            this.Dodavanje.Name = "Dodavanje";
            this.Dodavanje.Size = new System.Drawing.Size(75, 23);
            this.Dodavanje.TabIndex = 10;
            this.Dodavanje.Tag = "";
            this.Dodavanje.Text = "Dodaj";
            this.Dodavanje.UseVisualStyleBackColor = true;
            this.Dodavanje.Click += new System.EventHandler(this.Dodavanje_Click);
            // 
            // DodavanjeProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dodavanje);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxProizvodjac);
            this.Controls.Add(this.textBoxKategorija);
            this.Controls.Add(this.textBoxBrNaStanju);
            this.Controls.Add(this.textBoxDuzGarRoka);
            this.Controls.Add(this.textBoxNabCena);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.textBoxIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodavanjeProizvoda";
            this.Text = "DodavanjeProizvoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxNabCena;
        private System.Windows.Forms.TextBox textBoxDuzGarRoka;
        private System.Windows.Forms.TextBox textBoxBrNaStanju;
        private System.Windows.Forms.TextBox textBoxKategorija;
        private System.Windows.Forms.TextBox textBoxProizvodjac;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Button Dodavanje;
    }
}