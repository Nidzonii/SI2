namespace StoreSoftware
{
    partial class KomercijalistaMDIParent
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.naručeniProizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naručiProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrujNovogDobavljačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrujNovogDobavljačaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiDobavljacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naručeniProizvodiToolStripMenuItem,
            this.naručiProizvodToolStripMenuItem,
            this.registrujNovogDobavljačaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // naručeniProizvodiToolStripMenuItem
            // 
            this.naručeniProizvodiToolStripMenuItem.Name = "naručeniProizvodiToolStripMenuItem";
            this.naručeniProizvodiToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.naručeniProizvodiToolStripMenuItem.Text = "Naručeni proizvodi";
            // 
            // naručiProizvodToolStripMenuItem
            // 
            this.naručiProizvodToolStripMenuItem.Name = "naručiProizvodToolStripMenuItem";
            this.naručiProizvodToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.naručiProizvodToolStripMenuItem.Text = "Naruči proizvod";
            // 
            // registrujNovogDobavljačaToolStripMenuItem
            // 
            this.registrujNovogDobavljačaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrujNovogDobavljačaToolStripMenuItem1,
            this.pregledProizvodaToolStripMenuItem,
            this.proizvodiDobavljacaToolStripMenuItem});
            this.registrujNovogDobavljačaToolStripMenuItem.Name = "registrujNovogDobavljačaToolStripMenuItem";
            this.registrujNovogDobavljačaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.registrujNovogDobavljačaToolStripMenuItem.Text = "Dobavljači";
            // 
            // registrujNovogDobavljačaToolStripMenuItem1
            // 
            this.registrujNovogDobavljačaToolStripMenuItem1.Name = "registrujNovogDobavljačaToolStripMenuItem1";
            this.registrujNovogDobavljačaToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.registrujNovogDobavljačaToolStripMenuItem1.Text = "Registrovanje novog dobavljača";
            this.registrujNovogDobavljačaToolStripMenuItem1.Click += new System.EventHandler(this.registrujNovogDobavljačaToolStripMenuItem1_Click);
            // 
            // pregledProizvodaToolStripMenuItem
            // 
            this.pregledProizvodaToolStripMenuItem.Name = "pregledProizvodaToolStripMenuItem";
            this.pregledProizvodaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.pregledProizvodaToolStripMenuItem.Text = "Pregled dobavljača";
            this.pregledProizvodaToolStripMenuItem.Click += new System.EventHandler(this.pregledProizvodaToolStripMenuItem_Click);
            // 
            // proizvodiDobavljacaToolStripMenuItem
            // 
            this.proizvodiDobavljacaToolStripMenuItem.Name = "proizvodiDobavljacaToolStripMenuItem";
            this.proizvodiDobavljacaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.proizvodiDobavljacaToolStripMenuItem.Text = "Proizvodi dobavljača";
            this.proizvodiDobavljacaToolStripMenuItem.Click += new System.EventHandler(this.proizvodiDobavljacaToolStripMenuItem_Click);
            // 
            // KomercijalistaMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "KomercijalistaMDIParent";
            this.Text = "KomercijalistaMDIParent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KomercijalistaMDIParent_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem naručeniProizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naručiProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrujNovogDobavljačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrujNovogDobavljačaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiDobavljacaToolStripMenuItem;
    }
}



