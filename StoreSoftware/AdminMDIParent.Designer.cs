namespace StoreSoftware
{
    partial class AdminMDIParent
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
            this.dodavanjeNovihProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naručivanjeProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faktureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dodavanjeNovihProizvodaToolStripMenuItem
            // 
            this.dodavanjeNovihProizvodaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodavanjeNovihProizvodaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.dodavanjeNovihProizvodaToolStripMenuItem.Name = "dodavanjeNovihProizvodaToolStripMenuItem";
            this.dodavanjeNovihProizvodaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.dodavanjeNovihProizvodaToolStripMenuItem.Text = "Početna";
            this.dodavanjeNovihProizvodaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeNovihProizvodaToolStripMenuItem_Click);
            // 
            // izmenaProizvodaToolStripMenuItem
            // 
            this.izmenaProizvodaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.izmenaProizvodaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.izmenaProizvodaToolStripMenuItem.Name = "izmenaProizvodaToolStripMenuItem";
            this.izmenaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(194, 20);
            this.izmenaProizvodaToolStripMenuItem.Text = "Dodavanje novih proizvoda";
            // 
            // naručivanjeProizvodaToolStripMenuItem
            // 
            this.naručivanjeProizvodaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.naručivanjeProizvodaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.naručivanjeProizvodaToolStripMenuItem.Name = "naručivanjeProizvodaToolStripMenuItem";
            this.naručivanjeProizvodaToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.naručivanjeProizvodaToolStripMenuItem.Text = "Izmena proizvoda";
            // 
            // faktureToolStripMenuItem
            // 
            this.faktureToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.faktureToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.faktureToolStripMenuItem.Name = "faktureToolStripMenuItem";
            this.faktureToolStripMenuItem.Size = new System.Drawing.Size(202, 20);
            this.faktureToolStripMenuItem.Text = "Naručivanje novih proizvoda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem2.Text = "Fakture";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 20);
            this.toolStripMenuItem1.Text = "Dodavanje korisnika";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeNovihProizvodaToolStripMenuItem,
            this.izmenaProizvodaToolStripMenuItem,
            this.naručivanjeProizvodaToolStripMenuItem,
            this.faktureToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdminMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "AdminMDIParent";
            this.Text = "AdminMDIParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMDIParent_FormClosing);
            this.Load += new System.EventHandler(this.AdminMDIParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem dodavanjeNovihProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naručivanjeProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faktureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}



