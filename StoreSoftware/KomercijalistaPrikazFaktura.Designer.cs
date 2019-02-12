namespace StoreSoftware
{
    partial class KomercijalistaPrikazFaktura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KomercijalistaPrikazFaktura));
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.btnPrikaziFakturu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(39, 111);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(722, 327);
            this.axAcroPDF.TabIndex = 0;
            // 
            // btnPrikaziFakturu
            // 
            this.btnPrikaziFakturu.AutoSize = true;
            this.btnPrikaziFakturu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnPrikaziFakturu.Location = new System.Drawing.Point(39, 53);
            this.btnPrikaziFakturu.Name = "btnPrikaziFakturu";
            this.btnPrikaziFakturu.Size = new System.Drawing.Size(126, 23);
            this.btnPrikaziFakturu.TabIndex = 1;
            this.btnPrikaziFakturu.Text = "Prikaži fakturu iz arhive";
            this.btnPrikaziFakturu.UseVisualStyleBackColor = true;
            this.btnPrikaziFakturu.Click += new System.EventHandler(this.btnPrikaziFakturu_Click);
            // 
            // KomercijalistaPrikazFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikaziFakturu);
            this.Controls.Add(this.axAcroPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KomercijalistaPrikazFaktura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.Button btnPrikaziFakturu;
    }
}