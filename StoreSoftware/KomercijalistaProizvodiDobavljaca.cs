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
    public partial class KomercijalistaProizvodiDobavljaca : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();

        public KomercijalistaProizvodiDobavljaca()
        {
            InitializeComponent();
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            try
            {
                string upit1 = "SELECT id_dobavljaca FROM Dobavljac WHERE ime=@ime";
                SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                komanda1.Parameters.AddWithValue("@ime", txtDobavljac.Text);
                konekcija.Open();
                int proveraUspesnosti1 = Convert.ToInt32(komanda1.ExecuteScalar()); // id dobavljaca
                MessageBox.Show(proveraUspesnosti1.ToString());
                if (proveraUspesnosti1 > 0)
                {
                    string upit2 = "SELECT id_proizvoda_dobavljaca FROM ProizvodiDobavljaca WHERE ime=@ime AND proizvodjac=@proizvodjac AND kategorija=@kategorija";
                    SqlCommand komanda2 = new SqlCommand(upit2, konekcija);
                    komanda2.Parameters.AddWithValue("@ime", txtImeProizvoda.Text);
                    komanda2.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                    komanda2.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                    int proveraUspesnosti2 = Convert.ToInt32(komanda2.ExecuteScalar()); //id proizvoda odredjenog dobavljaca
                    MessageBox.Show(proveraUspesnosti2.ToString());
                    string upit21 = "SELECT COUNT(*) FROM ImaOdProizvoda WHERE id_dobavljaca=@id_dobavljaca AND id_proizvoda_dobavljaca=@id_proizvoda_dobavljaca";
                    SqlCommand komanda21 = new SqlCommand(upit21, konekcija);
                    komanda21.Parameters.AddWithValue("@id_dobavljaca", proveraUspesnosti1);
                    komanda21.Parameters.AddWithValue("@id_proizvoda_dobavljaca", proveraUspesnosti2);
                    int proveraUspesnosti21 = Convert.ToInt32(komanda21.ExecuteScalar());
                    MessageBox.Show(proveraUspesnosti21.ToString());
                    if (proveraUspesnosti21 > 0)
                    {
                        MessageBox.Show("Vlasnik: " + txtDobavljac.Text + " vec poseduje proizvod sa unetim specifikacijama");
                    }
                    else
                    {
                        // MessageBox.Show("sve ok");
                        if (proveraUspesnosti2 < 1)
                        {
                            MessageBox.Show("Uci ces ovde!");
                            string upit4 = "INSERT INTO ProizvodiDobavljaca(ime,proizvodjac,kategorija) VALUES(@ime,@proizvodjac,@kategorija)";
                            SqlCommand komanda4 = new SqlCommand(upit4, konekcija);
                            komanda4.Parameters.AddWithValue("@ime", txtImeProizvoda.Text);
                            komanda4.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                            komanda4.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                            komanda4.ExecuteNonQuery();
                            string upit5 = "SELECT id_proizvoda_dobavljaca FROM ProizvodiDobavljaca WHERE ime=@ime AND proizvodjac=@proizvodjac AND kategorija=@kategorija";
                            SqlCommand komanda5 = new SqlCommand(upit5, konekcija);
                            komanda5.Parameters.AddWithValue("@ime", txtImeProizvoda.Text);
                            komanda5.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                            komanda5.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                            int idProizvodaDobavljaca = (int)komanda5.ExecuteScalar();
                            string upit6 = "SELECT id_dobavljaca FROM Dobavljac WHERE ime=@ime";
                            SqlCommand komanda6 = new SqlCommand(upit6, konekcija);
                            komanda6.Parameters.AddWithValue("@ime", txtDobavljac.Text);
                            int idDobavljaca = (int)komanda6.ExecuteScalar();
                            string upit66 = "INSERT INTO ImaOdProizvoda(id_dobavljaca,id_proizvoda_dobavljaca,cena) VALUES(@id_dobavljaca,@id_proizvoda_dobavljaca,@cena)";
                            SqlCommand komanda66 = new SqlCommand(upit66, konekcija);
                            komanda66.Parameters.AddWithValue("@id_dobavljaca", idDobavljaca);
                            komanda66.Parameters.AddWithValue("@id_proizvoda_dobavljaca", idProizvodaDobavljaca);
                            komanda66.Parameters.AddWithValue("@cena", Convert.ToInt32(txtCena.Text));
                            int proveraUspesnosti66 = komanda66.ExecuteNonQuery();
                            if (proveraUspesnosti66 > 0)
                            {
                                MessageBox.Show("Proizvod je uspesno dodat u bazu");
                                DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
                                dataGridProizvodi.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("Doslo je do greske!");
                            }
                        }
                        else
                        {
                            string upit7 = "INSERT INTO ImaOdProizvoda(id_dobavljaca,id_proizvoda_dobavljaca,cena) VALUES(@id_dobavljaca,@id_proizvoda_dobavljaca,@cena)";
                            SqlCommand komanda7 = new SqlCommand(upit7, konekcija);
                            komanda7.Parameters.AddWithValue("@id_dobavljaca", proveraUspesnosti1);
                            komanda7.Parameters.AddWithValue("@id_proizvoda_dobavljaca", proveraUspesnosti2);
                            komanda7.Parameters.AddWithValue("@cena", Convert.ToInt32(txtCena.Text));
                            int proveraUspesnosti7 = komanda7.ExecuteNonQuery();

                            if (proveraUspesnosti7 > 0)
                            {
                                MessageBox.Show("Proizvod je uspesno dodat u bazu");
                                DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
                                dataGridProizvodi.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("Doslo je do greske!");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji dobavljac sa unetim imenom!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void KomercijalistaProizvodiDobavljaca_Load(object sender, EventArgs e)
        {
            DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
            dataGridProizvodi.DataSource = dt;
        }

        private void dataGridProizvodi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeksReda = e.RowIndex;

            txtDobavljac.Text = dataGridProizvodi.Rows[indeksReda].Cells[0].Value.ToString();
            txtImeProizvoda.Text = dataGridProizvodi.Rows[indeksReda].Cells[1].Value.ToString();
            txtProizvodjac.Text = dataGridProizvodi.Rows[indeksReda].Cells[2].Value.ToString();
            txtKategorija.Text = dataGridProizvodi.Rows[indeksReda].Cells[3].Value.ToString();
            txtCena.Text = dataGridProizvodi.Rows[indeksReda].Cells[4].Value.ToString();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string upitIdDobavljaca = "SELECT id_dobavljaca FROM Dobavljac WHERE ime=@ime";
                SqlCommand komandaIdDobavljaca = new SqlCommand(upitIdDobavljaca, konekcija);
                komandaIdDobavljaca.Parameters.AddWithValue("@ime", txtDobavljac.Text);
                konekcija.Open();
                int idDobavljaca = Convert.ToInt32(komandaIdDobavljaca.ExecuteScalar());
                MessageBox.Show(idDobavljaca.ToString());
                string upitIdProizvodaDobavljaca = "SELECT id_proizvoda_dobavljaca FROM ProizvodiDobavljaca WHERE ime=@ime AND proizvodjac=@proizvodjac AND kategorija=@kategorija";
                SqlCommand komandaIdProizvodaDobavljaca = new SqlCommand(upitIdProizvodaDobavljaca, konekcija);
                komandaIdProizvodaDobavljaca.Parameters.AddWithValue("@ime", txtImeProizvoda.Text);
                komandaIdProizvodaDobavljaca.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                komandaIdProizvodaDobavljaca.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                int idProizvodaDobavljaca = Convert.ToInt32(komandaIdProizvodaDobavljaca.ExecuteScalar());
                MessageBox.Show(idProizvodaDobavljaca.ToString());
                if (idDobavljaca > 0 && idProizvodaDobavljaca > 0)
                {
                    string obrisiDobavljacuProizvod = "DELETE FROM ImaOdProizvoda WHERE id_dobavljaca=@id_dobavljaca AND id_proizvoda_dobavljaca=@id_proizvoda_dobavljaca";
                    SqlCommand komandaObrisi = new SqlCommand(obrisiDobavljacuProizvod, konekcija);
                    komandaObrisi.Parameters.AddWithValue("@id_dobavljaca", idDobavljaca);
                    komandaObrisi.Parameters.AddWithValue("@id_proizvoda_dobavljaca", idProizvodaDobavljaca);
                    int obrisi = Convert.ToInt32(komandaObrisi.ExecuteNonQuery());
                    if(obrisi > 0)
                    {
                        MessageBox.Show("Dobavljacu: " + txtDobavljac.Text + " je uspesno obrisan proizvod. Vise ga ne poseduje!");
                    }
                    else
                    {
                        MessageBox.Show("Doslo je do greske!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void txtPretrazi_Leave(object sender, EventArgs e)
        {
            if(txtPretrazi.Text == "" || txtPretrazi.Text == " ")
            {
                txtPretrazi.ForeColor = Color.Gray;
                txtPretrazi.Text = "Unesite ključnu reč...";
            }
        }

        private void txtPretrazi_Enter(object sender, EventArgs e)
        {
            if (txtPretrazi.Text == "Unesite ključnu reč...")
            {
                txtPretrazi.ForeColor = Color.Black;
                txtPretrazi.Text = "";
            }
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = Komercijalista.NadjiOdredjeneVrednosti(txtPretrazi.Text);
            //dataGridProizvodi.DataSource = dt;

            

            try
            {
                string upit1 = "SELECT Dobavljac.ime AS dobavljač, ProizvodiDobavljaca.ime AS proizvod, ProizvodiDobavljaca.proizvodjac AS proizvođač, ProizvodiDobavljaca.kategorija, ImaOdProizvoda.cena FROM Dobavljac INNER JOIN ImaOdProizvoda ON Dobavljac.id_dobavljaca=ImaOdProizvoda.id_dobavljaca INNER JOIN ProizvodiDobavljaca ON ImaOdProizvoda.id_proizvoda_dobavljaca=ProizvodiDobavljaca.id_proizvoda_dobavljaca WHERE Dobavljac.ime LIKE '%" + txtPretrazi.Text + "%' OR ProizvodiDobavljaca.ime LIKE '%" + txtPretrazi.Text + "%' OR ProizvodiDobavljaca.proizvodjac LIKE '%" + txtPretrazi.Text + "%' OR  ProizvodiDobavljaca.kategorija LIKE '%" + txtPretrazi.Text + "%' OR ImaOdProizvoda.cena LIKE '%" + txtPretrazi.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(upit1, konekcija);
                if (txtPretrazi.Text == "Unesite ključnu reč...")
                {
                    DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
                    dataGridProizvodi.DataSource = dt;
                }
                else {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridProizvodi.DataSource = dt;
                 }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
        }

        private void btnSviPodaci_Click(object sender, EventArgs e)
        {
            DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
            dataGridProizvodi.DataSource = dt;
        }

        private void btnIzmeniCenu_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string nadjiIdDobavljaca = "SELECT id_dobavljaca FROM Dobavljac WHERE ime='" + txtDobavljac.Text + "'";
                SqlCommand komandaNadjiIdDobavljaca = new SqlCommand(nadjiIdDobavljaca, konekcija);
                int idDobavljaca = Convert.ToInt32(komandaNadjiIdDobavljaca.ExecuteScalar());
                MessageBox.Show(idDobavljaca.ToString());
                if(idDobavljaca > 0)
                {
                    string nadjiIdProizvodaDobavljaca = "SELECT id_proizvoda_dobavljaca FROM ProizvodiDobavljaca WHERE ime='" + txtImeProizvoda.Text + "' AND proizvodjac='" + txtProizvodjac.Text + "' AND kategorija='" + txtKategorija.Text + "'";
                    SqlCommand komandaNadjiIdProizvodaDobavljaca = new SqlCommand(nadjiIdProizvodaDobavljaca, konekcija);
                    int idProizvodaDobavljaca = Convert.ToInt32(komandaNadjiIdProizvodaDobavljaca.ExecuteScalar());
                    MessageBox.Show(idProizvodaDobavljaca.ToString());
                    if (idProizvodaDobavljaca > 0)
                    {
                        string apdejtujCenu = "UPDATE ImaOdProizvoda SET cena='" + txtCena.Text + "' WHERE id_dobavljaca='" + idDobavljaca + "' AND id_proizvoda_dobavljaca='" + idProizvodaDobavljaca + "'";
                        SqlCommand komandaApdejtujCenu = new SqlCommand(apdejtujCenu, konekcija);
                        int proveraUspesnosti = komandaApdejtujCenu.ExecuteNonQuery();
                        MessageBox.Show(proveraUspesnosti.ToString());
                        if (proveraUspesnosti > 0)
                        {
                            MessageBox.Show("Uspesno promenjena cena");
                            DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
                            dataGridProizvodi.DataSource = dt;
                            //apdejtujCenuProizvodaUBazi(idProizvodaDobavljaca, txtCena.Text, txtProizvodjac.Text, txtKategorija.Text);
                            string selektujSveProizvode = "SELECT cena FROM ImaOdProizvoda WHERE id_proizvoda_dobavljaca='" + idProizvodaDobavljaca + "'";
                            SqlCommand komandaSelektujSveProizvode = new SqlCommand(selektujSveProizvode, konekcija);
                            double ukupno = 0;
                            int brojIteracija = 0;
                            double cenaUProdaji = 0;
                            using (SqlDataReader sdr = komandaSelektujSveProizvode.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    double cena = Convert.ToDouble(sdr["cena"].ToString());
                                    brojIteracija++;
                                    ukupno = ukupno + cena;
                                }
                            }
                            cenaUProdaji = ukupno / brojIteracija;
                            cenaUProdaji = cenaUProdaji + cenaUProdaji * 0.2;

                            string pronadjiProizvodUBazi = "SELECT id_proizvoda FROM Proizvodi WHERE ime='" + txtImeProizvoda.Text + "' AND proizvodjac='" + txtProizvodjac.Text + "' AND kategorija='" + txtKategorija.Text + "'";
                            SqlCommand komandaPronadjiProizvodUBazi = new SqlCommand(pronadjiProizvodUBazi, konekcija);
                            int daLiPostoji = Convert.ToInt32(komandaPronadjiProizvodUBazi.ExecuteScalar());
                            //MessageBox.Show(daLiPostoji.ToString());
                            if (daLiPostoji > 0)
                            {
                                string postaviNovuCenu = "UPDATE Proizvodi SET cena='" + cenaUProdaji + "' WHERE id_proizvoda='" + daLiPostoji + "'";
                                SqlCommand komandaPostaviNovuCenu = new SqlCommand(postaviNovuCenu, konekcija);
                                int uspesnoIliNe = komandaPostaviNovuCenu.ExecuteNonQuery();
                                if (uspesnoIliNe > 0)
                                {
                                    MessageBox.Show("Uspesno promenjena cena proizvoda u maloprodaji");
                                }
                                else
                                {
                                    MessageBox.Show("Doslo je do greske!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ne postoji proizvod u nasoj bazi!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Doslo je do greske!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji proizvod sa datim specifikacijama");
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji dobavljac sa datim ID-em");
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

        private void apdejtujCenuProizvodaUBazi(int idProizvodaDobavljaca, string imeProizvoda, string proizvodjac, string kategorija)
        {
            string selektujSveProizvode = "SELECT cena FROM ImaOdProizvoda WHERE id_proizvoda_dobavljaca='" + idProizvodaDobavljaca + "'";
            SqlCommand komandaSelektujSveProizvode = new SqlCommand(selektujSveProizvode, konekcija);
            double ukupno = 0;
            int brojIteracija = 0;
            double cenaUProdaji = 0;
            using(SqlDataReader sdr = komandaSelektujSveProizvode.ExecuteReader())
            {
                while (sdr.Read())
                {
                    double cena = Convert.ToDouble(sdr["cena"].ToString());
                    brojIteracija++;
                    ukupno = ukupno + cena;
                }
            }
            cenaUProdaji = ukupno / brojIteracija ;
            cenaUProdaji = cenaUProdaji + cenaUProdaji * 0.2;

            string pronadjiProizvodUBazi = "SELECT id_proizvoda FROM Proizvodi WHERE ime='" + imeProizvoda + "' AND proizvodjac='" + proizvodjac + "' AND kategorija='" + kategorija + "'";
            SqlCommand komandaPronadjiProizvodUBazi = new SqlCommand(pronadjiProizvodUBazi, konekcija);
            int daLiPostoji = Convert.ToInt32(komandaPronadjiProizvodUBazi.ExecuteScalar());
            MessageBox.Show(daLiPostoji.ToString());
            if(daLiPostoji > 0)
            {
                string postaviNovuCenu = "UPDATE Proizvodi SET cena='" + cenaUProdaji + "' WHERE id_proizvoda='" + daLiPostoji + "'";
                SqlCommand komandaPostaviNovuCenu = new SqlCommand(postaviNovuCenu, konekcija);
                int uspesnoIliNe = komandaPostaviNovuCenu.ExecuteNonQuery();
                if(uspesnoIliNe > 0)
                {
                    MessageBox.Show("Uspesno setovana cena");
                }
                else
                {
                    MessageBox.Show("Doslo je do greske!");
                }
            }
            else
            {
                MessageBox.Show("Ne postoji proizvod u nasoj bazi!");
            }
        }
    }
}
