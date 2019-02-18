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
    public partial class ProizvodiKojiSeSlaboProdaju : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();

        public ProizvodiKojiSeSlaboProdaju()
        {
            InitializeComponent();
        }

        private void btnMesecPrvi_Click(object sender, EventArgs e)
        {
            DateTime trenutnoVreme = DateTime.Now;
            DateTime mesecDana = trenutnoVreme.AddMonths(-1);
            DateTime dvaMeseca = trenutnoVreme.AddMonths(-2);
            int pet = 5;
            string selektujSve = "SELECT * FROM Proizvodi WHERE vreme_poslednje_prodaje<=@vremeJedan AND vreme_poslednje_prodaje>@vremeDva AND procenti_smanjenja<@pet";// OR (vreme_poslednje_prodaje<=@vremeJedan AND vreme_poslednje_prodaje>@vremeDva AND procenti_povecanja<@deset) OR (vreme_poslednje_prodaje<=@vremeTri AND procenti_povecanja<@petnaest)";
            SqlCommand komandaSelektujSve = new SqlCommand(selektujSve, konekcija);
            komandaSelektujSve.Parameters.AddWithValue("@vremeJedan", mesecDana);
            komandaSelektujSve.Parameters.AddWithValue("@vremeDva", dvaMeseca);
            komandaSelektujSve.Parameters.AddWithValue("@pet", pet);
            SqlDataAdapter sda = new SqlDataAdapter(komandaSelektujSve);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridProizvodi.DataSource = dt;
        }

        private void btnMesecDrugi_Click(object sender, EventArgs e)
        {
            DateTime trenutnoVreme = DateTime.Now;
            DateTime dvaMeseca = trenutnoVreme.AddMonths(-2);
            DateTime triMeseca = trenutnoVreme.AddMonths(-3);
            int deset = 10;
            string selektujSve = "SELECT * FROM Proizvodi WHERE vreme_poslednje_prodaje<=@vremeDva AND vreme_poslednje_prodaje>@vremeTri AND procenti_smanjenja<@deset";// OR (vreme_poslednje_prodaje<=@vremeJedan AND vreme_poslednje_prodaje>@vremeDva AND procenti_povecanja<@deset) OR (vreme_poslednje_prodaje<=@vremeTri AND procenti_povecanja<@petnaest)";
            SqlCommand komandaSelektujSve = new SqlCommand(selektujSve, konekcija);
            komandaSelektujSve.Parameters.AddWithValue("@vremeDva", dvaMeseca);
            komandaSelektujSve.Parameters.AddWithValue("@vremeTri", triMeseca);
            komandaSelektujSve.Parameters.AddWithValue("@deset", deset);
            SqlDataAdapter sda = new SqlDataAdapter(komandaSelektujSve);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridProizvodi.DataSource = dt;
        }

        private void dataGridProizvodi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;
            txtImeProizvoda.Text = dataGridProizvodi.Rows[indeks].Cells[1].Value.ToString();
            txtProizvodjac.Text = dataGridProizvodi.Rows[indeks].Cells[5].Value.ToString();
            txtKategorija.Text = dataGridProizvodi.Rows[indeks].Cells[6].Value.ToString();
            txtCena.Text = dataGridProizvodi.Rows[indeks].Cells[3].Value.ToString();
            txtDatumPoslednjeProdaje.Text = dataGridProizvodi.Rows[indeks].Cells[10].Value.ToString();
            txtProcenat.Text = dataGridProizvodi.Rows[indeks].Cells[11].Value.ToString();
        }

        private void btnPromeniCenu_Click(object sender, EventArgs e)
        {
            DateTime sada = DateTime.Now;
            DateTime mesecDana = sada.AddMonths(-1);
            DateTime dvaMeseca = sada.AddMonths(-2);
            DateTime triMeseca = sada.AddMonths(-3);
            DateTime vremePoslednjeProdaje = DateTime.Parse(txtDatumPoslednjeProdaje.Text);
            int procenat = Convert.ToInt32(txtProcenat.Text);
            string imeProizvoda = txtImeProizvoda.Text;
            string proizvodjac = txtProizvodjac.Text;
            string kategorija = txtKategorija.Text;
            double cena = Convert.ToDouble(txtCena.Text);
            string upit = "UPDATE Proizvodi SET cena=@cena, procenti_smanjenja=@procenat WHERE ime=@ime AND proizvodjac=@proizvodjac AND kategorija=@kategorija";
            konekcija.Open();
            try
            {
                if (vremePoslednjeProdaje <= mesecDana && vremePoslednjeProdaje > dvaMeseca && procenat < 5)
                {
                    double novaCena = cena - cena * 0.05;
                    SqlCommand komandaUpit = new SqlCommand(upit, konekcija);
                    komandaUpit.Parameters.AddWithValue("@cena", novaCena);
                    komandaUpit.Parameters.AddWithValue("@procenat", 5);
                    komandaUpit.Parameters.AddWithValue("@ime", imeProizvoda);
                    komandaUpit.Parameters.AddWithValue("@proizvodjac", proizvodjac);
                    komandaUpit.Parameters.AddWithValue("@kategorija", kategorija);
                    int proveraUspesnosti = komandaUpit.ExecuteNonQuery();
                    if(proveraUspesnosti > 0)
                    {
                        MessageBox.Show("Uspesno snižena cena proizvoda za " + 5 + "%");
                    }
                }

                else if(vremePoslednjeProdaje <= dvaMeseca && vremePoslednjeProdaje > triMeseca && procenat < 10)
                {
                    double novaCena = cena - cena * 0.1;
                    SqlCommand komandaUpit = new SqlCommand(upit, konekcija);
                    komandaUpit.Parameters.AddWithValue("@cena", novaCena);
                    komandaUpit.Parameters.AddWithValue("@procenat", 10);
                    komandaUpit.Parameters.AddWithValue("@ime", imeProizvoda);
                    komandaUpit.Parameters.AddWithValue("@proizvodjac", proizvodjac);
                    komandaUpit.Parameters.AddWithValue("@kategorija", kategorija);
                    int proveraUspesnosti = komandaUpit.ExecuteNonQuery();
                    if (proveraUspesnosti > 0)
                    {
                        MessageBox.Show("Uspesno snižena cena proizvoda za " + 10 +"%");
                    }
                }

                else if(vremePoslednjeProdaje <= triMeseca && procenat < 15)
                {
                    double novaCena = cena - cena * 0.15;
                    SqlCommand komandaUpit = new SqlCommand(upit, konekcija);
                    komandaUpit.Parameters.AddWithValue("@cena", novaCena);
                    komandaUpit.Parameters.AddWithValue("@procenat", 15);
                    komandaUpit.Parameters.AddWithValue("@ime", imeProizvoda);
                    komandaUpit.Parameters.AddWithValue("@proizvodjac", proizvodjac);
                    komandaUpit.Parameters.AddWithValue("@kategorija", kategorija);
                    int proveraUspesnosti = komandaUpit.ExecuteNonQuery();
                    if (proveraUspesnosti > 0)
                    {
                        MessageBox.Show("Uspesno snižena cena proizvoda za " + 15 + "%");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnMesecTreci_Click(object sender, EventArgs e)
        {
            DateTime trenutnoVreme = DateTime.Now;
            DateTime triMeseca = trenutnoVreme.AddMonths(-3);
            int petnaest = 15;
            string selektujSve = "SELECT * FROM Proizvodi WHERE vreme_poslednje_prodaje<=@vremeTri AND procenti_smanjenja<@petnaest";// OR (vreme_poslednje_prodaje<=@vremeJedan AND vreme_poslednje_prodaje>@vremeDva AND procenti_povecanja<@deset) OR (vreme_poslednje_prodaje<=@vremeTri AND procenti_povecanja<@petnaest)";
            SqlCommand komandaSelektujSve = new SqlCommand(selektujSve, konekcija);
            komandaSelektujSve.Parameters.AddWithValue("@vremeTri", triMeseca);
            komandaSelektujSve.Parameters.AddWithValue("@petnaest", petnaest);
            SqlDataAdapter sda = new SqlDataAdapter(komandaSelektujSve);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridProizvodi.DataSource = dt;
        }
    }
}
