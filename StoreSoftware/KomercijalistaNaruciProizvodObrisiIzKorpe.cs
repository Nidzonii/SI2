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
    public partial class KomercijalistaNaruciProizvodObrisiIzKorpe : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();

        public KomercijalistaNaruciProizvodObrisiIzKorpe()
        {
            InitializeComponent();
        }

        private void KomercijalistaNaruciProizvodObrisiIzKorpe_Load(object sender, EventArgs e)
        {
            DataTable dt = Komercijalista.IzlistajSveUKorpi();
            dataGridKorpa.DataSource = dt;
        }

        private void dataGridKorpa_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeksReda = e.RowIndex;

            txtImeProizvoda.Text = dataGridKorpa.Rows[indeksReda].Cells[1].Value.ToString();
            txtProizvodjac.Text = dataGridKorpa.Rows[indeksReda].Cells[2].Value.ToString();
            txtKategorija.Text = dataGridKorpa.Rows[indeksReda].Cells[3].Value.ToString();
            txtCena.Text = dataGridKorpa.Rows[indeksReda].Cells[4].Value.ToString();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string upit = "DELETE FROM Korpa WHERE ime_proizvoda=@ime_proizvoda AND proizvodjac=@proizvodjac AND kategorija=@kategorija AND cena=@cena";
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                konekcija.Open();
                komanda.Parameters.AddWithValue("@ime_proizvoda", txtImeProizvoda.Text);
                komanda.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                komanda.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                komanda.Parameters.AddWithValue("@cena", txtCena.Text);
                int proveraUspesnosti = komanda.ExecuteNonQuery();
                if (proveraUspesnosti > 0)
                {
                    MessageBox.Show("Uspešno obrisan artikal iz korpe!");
                    DataTable dt = Komercijalista.IzlistajSveUKorpi();
                    dataGridKorpa.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Proizvod nije obrisan!");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}
