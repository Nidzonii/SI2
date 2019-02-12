namespace StoreSoftware
{
    partial class KomercijalistaRegistrujNovogDobavljaca
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
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.txtMejl = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.btnRegistruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mejl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(53, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj telefona:";
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDobavljac.Location = new System.Drawing.Point(171, 27);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(129, 26);
            this.txtDobavljac.TabIndex = 3;
            // 
            // txtMejl
            // 
            this.txtMejl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMejl.Location = new System.Drawing.Point(171, 73);
            this.txtMejl.Name = "txtMejl";
            this.txtMejl.Size = new System.Drawing.Size(129, 26);
            this.txtMejl.TabIndex = 4;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojTelefona.Location = new System.Drawing.Point(171, 114);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(129, 26);
            this.txtBrojTelefona.TabIndex = 5;
            // 
            // btnRegistruj
            // 
            this.btnRegistruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistruj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnRegistruj.Location = new System.Drawing.Point(137, 174);
            this.btnRegistruj.Name = "btnRegistruj";
            this.btnRegistruj.Size = new System.Drawing.Size(84, 38);
            this.btnRegistruj.TabIndex = 6;
            this.btnRegistruj.Text = "Registruj";
            this.btnRegistruj.UseVisualStyleBackColor = true;
            this.btnRegistruj.Click += new System.EventHandler(this.btnRegistruj_Click);
            // 
            // KomercijalistaRegistrujNovogDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(354, 233);
            this.Controls.Add(this.btnRegistruj);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.txtMejl);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KomercijalistaRegistrujNovogDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KomercijalistaRegistrujNovogDobavljaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.TextBox txtMejl;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Button btnRegistruj;
    }
}