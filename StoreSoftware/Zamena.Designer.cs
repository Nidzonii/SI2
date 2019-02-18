namespace StoreSoftware
{
    partial class Zamena
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivRacuna = new System.Windows.Forms.TextBox();
            this.btnPonistavanjeRacuna = new System.Windows.Forms.Button();
            this.dgvZamena = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamena)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblNaziv.Location = new System.Drawing.Point(12, 35);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(70, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv računa";
            this.lblNaziv.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNazivRacuna
            // 
            this.txtNazivRacuna.Location = new System.Drawing.Point(123, 32);
            this.txtNazivRacuna.Name = "txtNazivRacuna";
            this.txtNazivRacuna.Size = new System.Drawing.Size(100, 20);
            this.txtNazivRacuna.TabIndex = 1;
            this.txtNazivRacuna.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPonistavanjeRacuna
            // 
            this.btnPonistavanjeRacuna.AutoSize = true;
            this.btnPonistavanjeRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonistavanjeRacuna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnPonistavanjeRacuna.Location = new System.Drawing.Point(340, 29);
            this.btnPonistavanjeRacuna.Name = "btnPonistavanjeRacuna";
            this.btnPonistavanjeRacuna.Size = new System.Drawing.Size(125, 25);
            this.btnPonistavanjeRacuna.TabIndex = 2;
            this.btnPonistavanjeRacuna.Text = "Poništi račun";
            this.btnPonistavanjeRacuna.UseVisualStyleBackColor = true;
            this.btnPonistavanjeRacuna.Click += new System.EventHandler(this.btnPonistavanjeRacuna_Click);
            // 
            // dgvZamena
            // 
            this.dgvZamena.AllowUserToAddRows = false;
            this.dgvZamena.AllowUserToDeleteRows = false;
            this.dgvZamena.BackgroundColor = System.Drawing.Color.White;
            this.dgvZamena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamena.Location = new System.Drawing.Point(15, 121);
            this.dgvZamena.Name = "dgvZamena";
            this.dgvZamena.ReadOnly = true;
            this.dgvZamena.Size = new System.Drawing.Size(450, 317);
            this.dgvZamena.TabIndex = 3;
            // 
            // Zamena
            // 
            this.AcceptButton = this.btnPonistavanjeRacuna;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.dgvZamena);
            this.Controls.Add(this.btnPonistavanjeRacuna);
            this.Controls.Add(this.txtNazivRacuna);
            this.Controls.Add(this.lblNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zamena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Zamena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNazivRacuna;
        private System.Windows.Forms.Button btnPonistavanjeRacuna;
        private System.Windows.Forms.DataGridView dgvZamena;
    }
}