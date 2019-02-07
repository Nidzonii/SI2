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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.dataGridDobavljac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDobavljac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(238, 32);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 0;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(73, 34);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(147, 20);
            this.txtDobavljac.TabIndex = 1;
            // 
            // dataGridDobavljac
            // 
            this.dataGridDobavljac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDobavljac.Location = new System.Drawing.Point(73, 106);
            this.dataGridDobavljac.Name = "dataGridDobavljac";
            this.dataGridDobavljac.Size = new System.Drawing.Size(554, 241);
            this.dataGridDobavljac.TabIndex = 2;
            // 
            // KomercijalistaPregledDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDobavljac);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.btnPretrazi);
            this.Name = "KomercijalistaPregledDobavljaca";
            this.Text = "KomercijalistaPregledDobavljaca";
            this.Load += new System.EventHandler(this.KomercijalistaPregledDobavljaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDobavljac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.DataGridView dataGridDobavljac;
    }
}