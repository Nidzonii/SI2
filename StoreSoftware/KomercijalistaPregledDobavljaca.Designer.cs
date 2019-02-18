namespace StoreSoftware
{
    partial class KomercijalistaPregledDobavljaca
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
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.dataGridDobavljac = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDobavljac)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtDobavljac.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDobavljac.Location = new System.Drawing.Point(233, 75);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(191, 21);
            this.txtDobavljac.TabIndex = 1;
            this.txtDobavljac.Text = "Unesite ključnu reč...";
            this.txtDobavljac.TextChanged += new System.EventHandler(this.txtDobavljac_TextChanged);
            this.txtDobavljac.Enter += new System.EventHandler(this.txtDobavljac_Enter);
            this.txtDobavljac.Leave += new System.EventHandler(this.txtDobavljac_Leave);
            // 
            // dataGridDobavljac
            // 
            this.dataGridDobavljac.AllowUserToAddRows = false;
            this.dataGridDobavljac.AllowUserToDeleteRows = false;
            this.dataGridDobavljac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDobavljac.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDobavljac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDobavljac.Location = new System.Drawing.Point(73, 106);
            this.dataGridDobavljac.Name = "dataGridDobavljac";
            this.dataGridDobavljac.ReadOnly = true;
            this.dataGridDobavljac.Size = new System.Drawing.Size(652, 241);
            this.dataGridDobavljac.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretražite dobavljače:";
            // 
            // KomercijalistaPregledDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDobavljac);
            this.Controls.Add(this.txtDobavljac);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "KomercijalistaPregledDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KomercijalistaPregledDobavljaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDobavljac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.DataGridView dataGridDobavljac;
        private System.Windows.Forms.Label label1;
    }
}