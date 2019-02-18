using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSoftware
{
    public partial class KomercijalistaMDIParent : Form
    {

        public KomercijalistaMDIParent()
        {
            InitializeComponent();
        }

        private void KomercijalistaMDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registrujNovogDobavljačaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KomercijalistaRegistrujNovogDobavljaca krnd = new KomercijalistaRegistrujNovogDobavljaca();
            krnd.Show();
        }

        private void pregledProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaPregledDobavljaca kpd = new KomercijalistaPregledDobavljaca();
            kpd.Show();
        }

        private void proizvodiDobavljacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaProizvodiDobavljaca kpd = new KomercijalistaProizvodiDobavljaca();
            kpd.Show();
        }

        private void naručiProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaNaruciProizvod knp = new KomercijalistaNaruciProizvod();
            knp.MdiParent = this;
            knp.Dock = DockStyle.Fill;
            knp.Show();
        }

        private void naručeniProizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaNaruceniProizvodi knp = new KomercijalistaNaruceniProizvodi();
            knp.MdiParent = this;
            knp.Dock = DockStyle.Fill;
            knp.Show();
        }

        private void prikazFakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaPrikazFaktura kpf = new KomercijalistaPrikazFaktura();
            kpf.MdiParent = this;
            kpf.Dock = DockStyle.Fill;
            kpf.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.korisnickoIme = "";
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void KomercijalistaMDIParent_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            KomercijalistaNaruceniProizvodi knp = new KomercijalistaNaruceniProizvodi();
            knp.MdiParent = this;
            knp.Dock = DockStyle.Fill;
            knp.Show();
            AutomatizovanaRadnjaB.AutomatizovanaRadnja();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KomercijalistaNarucenoOdRadnika knor = new KomercijalistaNarucenoOdRadnika();
            knor.MdiParent = this;
            knor.Dock = DockStyle.Fill;
            knor.Show();
            KomercijalistaNarucenoOdRadnika.PrikazivanjePorukeUkolikoPostojiNeobradjenaNarudzbina();
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pomoc p = new Pomoc();
            p.Show();
        }
    }
}
