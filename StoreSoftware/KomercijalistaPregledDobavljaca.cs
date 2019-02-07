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
    public partial class KomercijalistaPregledDobavljaca : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();

        public KomercijalistaPregledDobavljaca()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DataTable dt = Komercijalista.PronadjiDobavljacaPoImenu(txtDobavljac.Text);
            dataGridDobavljac.DataSource = dt;
        }

        private void KomercijalistaPregledDobavljaca_Load(object sender, EventArgs e)
        {
            DataTable dt = Komercijalista.PrikaziDobavljaca();
            dataGridDobavljac.DataSource = dt;
        }
    }
}
