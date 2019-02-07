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
    public partial class DodavanjeProizvoda : Form
    {
        public DodavanjeProizvoda()
        {
            InitializeComponent();
        }

        private void Dodavanje_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();
            try
            {
                String dodavanje = "INSERT INTO Proizvodi (ime, opis, cena, nabavna_cena, proizvodjac, kategorija, broj_na_stanju, duzina_garantnog_roka, link) VALUES (@ime, @opis, @cena, @nabavna_cena, @proizvodjac, @kategorija, @broj_na_stanju, @duzina_garantnog_roka, @link)  ";
                SqlCommand komanda = new SqlCommand(dodavanje, konekcija);
                komanda.Parameters.AddWithValue("@ime", textBoxIme.Text);
                komanda.Parameters.AddWithValue("@opis", textBoxOpis.Text);
                komanda.Parameters.AddWithValue("@cena", textBoxCena.Text);
                komanda.Parameters.AddWithValue("@nabavna_cena", textBoxNabCena.Text);
                komanda.Parameters.AddWithValue("@proizvodjac", textBoxProizvodjac.Text);
                komanda.Parameters.AddWithValue("@kategorija", textBoxKategorija.Text);
                komanda.Parameters.AddWithValue("@broj_na_stanju", textBoxBrNaStanju.Text);
                komanda.Parameters.AddWithValue("@duzina_garantnog_roka", textBoxDuzGarRoka.Text);
                komanda.Parameters.AddWithValue("@link", textBoxLink.Text);

                konekcija.Open();
                int provera = komanda.ExecuteNonQuery();
                if (provera > 0)
                {
                    MessageBox.Show("Uspesno unet proizvod!");
                }
                else
                {
                    MessageBox.Show("Proizvod nije unet!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
