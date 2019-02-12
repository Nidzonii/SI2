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

        private void txtDobavljac_Leave(object sender, EventArgs e)
        {
            if(txtDobavljac.Text == "" || txtDobavljac.Text == " ")
            {
                txtDobavljac.Text = "Unesite ključnu reč...";
                txtDobavljac.ForeColor = Color.Gray;
            }
        }

        private void txtDobavljac_Enter(object sender, EventArgs e)
        {
            if (txtDobavljac.Text == "Unesite ključnu reč...")
            {
                txtDobavljac.ForeColor = Color.Black;
                txtDobavljac.Text = "";
            }
        }

        private void txtDobavljac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string upit1 = "SELECT * FROM Dobavljac WHERE ime LIKE '%" + txtDobavljac.Text + "%' OR mejl LIKE '%" + txtDobavljac.Text + "%' OR broj_telefona LIKE '%" + txtDobavljac.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(upit1, konekcija);
                if (txtDobavljac.Text == "Unesite ključnu reč...")
                {
                    DataTable dt = Komercijalista.IzlistajSveDobavljace();
                    dataGridDobavljac.DataSource = dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridDobavljac.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
