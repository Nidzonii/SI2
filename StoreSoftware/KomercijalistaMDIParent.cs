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
    }
}
