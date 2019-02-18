using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSoftware
{
    public partial class RadnikMDIParent : Form
    {
        public RadnikMDIParent()
        {
            InitializeComponent();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.korisnickoIme = "";
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void RadnikMDIParent_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            ProdajaForma pf = new ProdajaForma();
            pf.MdiParent = this;
            pf.Dock = DockStyle.Fill;
            pf.Show();
        }

        private void RadnikMDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pomoc p = new Pomoc();
            p.Show();
        }
    }
}
