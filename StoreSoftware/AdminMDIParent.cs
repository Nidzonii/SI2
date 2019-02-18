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
    public partial class AdminMDIParent : Form
    {
        private int childFormNumber = 0;

        public AdminMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void dodavanjeNovihProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForma af = new AdminForma();
            af.MdiParent = this;
            af.Dock = DockStyle.Fill;
            af.Show();
        }

        private void AdminMDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMDIParent_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            AdminForma af = new AdminForma();
            af.MdiParent = this;
            af.Dock = DockStyle.Fill;
            af.Show();
            AutomatizovanaRadnjaB.AutomatizovanaRadnja();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminDodavanjeKorisnika adk = new AdminDodavanjeKorisnika();
            adk.Show();
        }

        private void dodavanjeNovihProizvodaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void izmenaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromenaAtributa a = new PromenaAtributa();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void naručivanjeProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaNaruciProizvod knp = new KomercijalistaNaruciProizvod();
            knp.MdiParent = this;
            knp.Dock = DockStyle.Fill;
            knp.Show();
        }

        private void faktureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaPrikazFaktura kpf = new KomercijalistaPrikazFaktura();
            kpf.MdiParent = this;
            kpf.Dock = DockStyle.Fill;
            kpf.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KomercijalistaNaruceniProizvodi knp = new KomercijalistaNaruceniProizvodi();
            knp.MdiParent = this;
            knp.Dock = DockStyle.Fill;
            knp.Show();
        }

        private void registrovanjeNovogDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaRegistrujNovogDobavljaca krnd = new KomercijalistaRegistrujNovogDobavljaca();
            krnd.Show();
        }

        private void pregledDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaPregledDobavljaca kpd = new KomercijalistaPregledDobavljaca();
            kpd.Show();
        }

        private void proizvodiDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomercijalistaProizvodiDobavljaca kpd = new KomercijalistaProizvodiDobavljaca();
            kpd.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ProdajaForma pf = new ProdajaForma();
            pf.MdiParent = this;
            pf.Dock = DockStyle.Fill;
            pf.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.korisnickoIme = "";
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AutomatizovanaRadnjaStatistika ars = new AutomatizovanaRadnjaStatistika();
            ars.MdiParent = this;
            ars.Dock = DockStyle.Fill;
            ars.Show();
        }

        private void dodavanjeNovihProizvodaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DodavanjeProizvoda dp = new DodavanjeProizvoda();
            dp.MdiParent = this;
            dp.Dock = DockStyle.Fill;
            dp.Show();
        }

        private void izmenaProizvodaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PromenaAtributa a = new PromenaAtributa();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pomoc p = new Pomoc();
            p.Show();
        }
    }
}
