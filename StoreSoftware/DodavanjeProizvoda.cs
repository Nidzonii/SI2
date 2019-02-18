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
                konekcija.Open();

                if (String.IsNullOrEmpty(textBoxIme.Text) || String.IsNullOrEmpty(textBoxProizvodjac.Text) || String.IsNullOrEmpty(textBoxKategorija.Text) || String.IsNullOrEmpty(textBoxCena.Text) || String.IsNullOrEmpty(textBoxCena.Text) || String.IsNullOrEmpty(textBoxNabCena.Text) || String.IsNullOrEmpty(textBoxCena.Text) || String.IsNullOrEmpty(textBoxBrNaStanju.Text) || String.IsNullOrEmpty(textBoxDuzGarRoka.Text))
                {
                    MessageBox.Show("Moraju se uneti sva polja!");
                }
                else
                {
                    String proveraPostojanja = "SELECT COUNT(*) FROM Proizvodi WHERE ime='" + textBoxIme.Text + "'";
                    SqlCommand komandaProvera = new SqlCommand(proveraPostojanja, konekcija);
                    int provera1 = Convert.ToInt32(komandaProvera.ExecuteScalar());
                    if (provera1 > 0)
                    {
                        MessageBox.Show("Već postoji uneti proizvod!");
                    }
                    else
                    {
                        String dodavanje = "INSERT INTO Proizvodi (ime, opis, cena, nabavna_cena, proizvodjac, kategorija, broj_na_stanju, duzina_garantnog_roka, link, procenti_smanjenja, br_prodatih_proizvoda) VALUES (@ime, @opis, @cena, @nabavna_cena, @proizvodjac, @kategorija, @broj_na_stanju, @duzina_garantnog_roka, @link, @procenti_smanjenja, @br_prodatih_proizvoda)";
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
                        komanda.Parameters.AddWithValue("@procenti_smanjenja", 0);
                        komanda.Parameters.AddWithValue("br_prodatih_proizvoda", 0);

                        int provera = komanda.ExecuteNonQuery();
                        if (provera > 0)
                        {
                            MessageBox.Show("Uspešno unet proizvod!");
                        }
                        else
                        {
                            MessageBox.Show("Proizvod nije unet!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}
