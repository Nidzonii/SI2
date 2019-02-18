using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSoftware
{
    public partial class KomercijalistaNaruciProizvodRadnikMejl : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();
        private NetworkCredential login;
        private SmtpClient client;
        private MailMessage msg;

        public KomercijalistaNaruciProizvodRadnikMejl()
        {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txtKorisnickoIme.Text, txtSifra.Text);
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtKorisnickoIme.Text, "Komercijalista", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtPrimalac.Text));
            msg.Subject = txtNaslov.Text;
            msg.Body = txtPoruka.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
            UnesiUBazuNarudzbenica();
            ObrisiKorpu();
        }

        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Uspešno poslat mejl!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UnesiUBazuNarudzbenica()
        {
            int brojac = 0;
            try
            {
                string ubaciUNarudzbenicu = "INSERT INTO Narudzbenica(datum_narucivanja,potvrda_narudzbenice) OUTPUT INSERTED.id_narudzbenice VALUES(@datum_narucivanja,@potvrda_narudzbenice)";
                SqlCommand komandaUbaciUNarudzbenicu = new SqlCommand(ubaciUNarudzbenicu, konekcija);
                konekcija.Open();
                komandaUbaciUNarudzbenicu.Parameters.AddWithValue("@datum_narucivanja", DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                komandaUbaciUNarudzbenicu.Parameters.AddWithValue("@potvrda_narudzbenice", 0);
                int idNarudzbenice = Convert.ToInt32(komandaUbaciUNarudzbenicu.ExecuteScalar());
                if (idNarudzbenice > 0)
                {
                    string nadjiProizvod = "SELECT * FROM Korpa";
                    SqlCommand komandaNadjiProizvod = new SqlCommand(nadjiProizvod, konekcija);
                    StringBuilder imeProizvoda = new StringBuilder();
                    StringBuilder proizvodjac = new StringBuilder();
                    StringBuilder kategorija = new StringBuilder();
                    StringBuilder kvantitet = new StringBuilder();

                    using (SqlDataReader sdr = komandaNadjiProizvod.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            imeProizvoda.Append(sdr["ime_proizvoda"].ToString() + "~");
                            proizvodjac.Append(sdr["proizvodjac"].ToString() + "~");
                            kategorija.Append(sdr["kategorija"].ToString() + "~");
                            kvantitet.Append(sdr["kvantitet"].ToString() + "~");
                            brojac++;
                        }
                    }

                    if (brojac == 1)
                    {
                        imeProizvoda.Append("s~");
                        proizvodjac.Append("s~");
                        kategorija.Append("s~");
                        kvantitet.Append("s~");
                    }

                    imeProizvoda.Length = imeProizvoda.Length--;
                    proizvodjac.Length = proizvodjac.Length--;
                    kategorija.Length = kategorija.Length--;
                    kvantitet.Length = kvantitet.Length--;
                    
                    string[] proizvodi = imeProizvoda.ToString().Split('~');
                    string[] proizvodjaci = proizvodjac.ToString().Split('~');
                    string[] kategorijaa = kategorija.ToString().Split('~');
                    string[] kvantiteti = kvantitet.ToString().Split('~');

                    for (int i = 0; i < proizvodi.Length; i++)
                    {
                        if (brojac == 1 && i == 1)
                        {
                            break;
                        }
                        string nadjiIdProizvodaDobavljaca = "SELECT id_proizvoda_dobavljaca FROM ProizvodiDobavljaca WHERE ime=@ime";
                        SqlCommand komandaNadjiIdProizvodaDobavljaca = new SqlCommand(nadjiIdProizvodaDobavljaca, konekcija);
                        komandaNadjiIdProizvodaDobavljaca.Parameters.AddWithValue("@ime", proizvodi[i]);
                        int idProizvodaDobavljaca = Convert.ToInt32(komandaNadjiIdProizvodaDobavljaca.ExecuteScalar());
                        string selektujDobavljaca = "SELECT dobavljac FROM Korpa";
                        SqlCommand komandaSelektujDobavljaca = new SqlCommand(selektujDobavljaca, konekcija);
                        string dobavljac = (string)komandaSelektujDobavljaca.ExecuteScalar();
                        string nadjiIdDobavljaca = "SELECT id_dobavljaca FROM Dobavljac WHERE ime='" + dobavljac + "'";
                        SqlCommand komandaNadjiIdDobavljaca = new SqlCommand(nadjiIdDobavljaca, konekcija);
                        int idDobavljaca = Convert.ToInt32(komandaNadjiIdDobavljaca.ExecuteScalar());
                        string nadjiCenu = "SELECT cena FROM ImaOdProizvoda WHERE id_dobavljaca=@id_dobavljaca AND id_proizvoda_dobavljaca=@id_proizvoda_dobavljaca";
                        SqlCommand komandaNadjiCenu = new SqlCommand(nadjiCenu, konekcija);
                        komandaNadjiCenu.Parameters.AddWithValue("@id_dobavljaca", idDobavljaca);
                        komandaNadjiCenu.Parameters.AddWithValue("@id_proizvoda_dobavljaca", idProizvodaDobavljaca);
                        int cena = Convert.ToInt32(komandaNadjiCenu.ExecuteScalar());
                        string naruci = "INSERT INTO DaLiJeU(id_proizvoda_dobavljaca, id_narudzbenice, kvantitet, cena) VALUES(@id_proizvoda_dobavljaca, @id_narudzbenice, @kvantitet, @cena)";
                        SqlCommand komandaNaruci = new SqlCommand(naruci, konekcija);
                        komandaNaruci.Parameters.AddWithValue("@id_proizvoda_dobavljaca", idProizvodaDobavljaca);
                        komandaNaruci.Parameters.AddWithValue("@id_narudzbenice", idNarudzbenice);
                        komandaNaruci.Parameters.AddWithValue("@kvantitet", Convert.ToInt32(kvantiteti[i]));
                        komandaNaruci.Parameters.AddWithValue("@cena", cena);
                        int proveraUspesnosti = komandaNaruci.ExecuteNonQuery();
                        if (proveraUspesnosti > 0)
                        {
                            MessageBox.Show("Uspešno naručen proizvod pod imenom: " + proizvodi[i]);

                            string promeniStanjeProizvoda = "SELECT id_proizvoda FROM Proizvodi WHERE ime=@ime";
                            SqlCommand komandaPromeniStanjeProizvoda = new SqlCommand(promeniStanjeProizvoda, konekcija);
                            komandaPromeniStanjeProizvoda.Parameters.AddWithValue("@ime", proizvodi[i]);
                            int proveraUspesnosti2 = Convert.ToInt32(komandaPromeniStanjeProizvoda.ExecuteScalar());
                            if (proveraUspesnosti2 > 0)
                            {
                                string promeniStanjeProizvoda2 = "UPDATE Narudzbine SET stanje_narudzbine='obradjeno' WHERE id_proizvoda='" + proveraUspesnosti2 + "'";
                                SqlCommand komandaPromeniStanjeProizvoda2 = new SqlCommand(promeniStanjeProizvoda2, konekcija);
                                komandaPromeniStanjeProizvoda2.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do nepredviđene greške!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Došlo je do greške");
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

        private void ObrisiKorpu()
        {
            try
            {
                string obrisiKorpu = "DELETE FROM Korpa";
                SqlCommand komandaObrisiKorpu = new SqlCommand(obrisiKorpu, konekcija);
                konekcija.Open();
                int proveraUspesnosti = komandaObrisiKorpu.ExecuteNonQuery();
                if (proveraUspesnosti > 0)
                {
                    MessageBox.Show("Uspešno obrisane stavke iz korpe!");
                }
                else
                {
                    MessageBox.Show("Došlo je do greške!");
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
        
        private void PromeniStanjeNarucenogProizvoda()
        {

        }

        private void KomercijalistaNaruciProizvodRadnikMejl_Load(object sender, EventArgs e)
        {
            try
            {
                string selektujDobavljaca = "SELECT dobavljac FROM Korpa";
                SqlCommand komandaSelektujDobavljaca = new SqlCommand(selektujDobavljaca, konekcija);
                konekcija.Open();
                string dobavljac = (string)komandaSelektujDobavljaca.ExecuteScalar();
                string selektujMejlDobavljaca = "SELECT mejl FROM Dobavljac WHERE ime=@ime";
                SqlCommand komandaSelektujMejlDobavljaca = new SqlCommand(selektujMejlDobavljaca, konekcija);
                komandaSelektujMejlDobavljaca.Parameters.AddWithValue("@ime", dobavljac);
                string dobavljacMejl = (string)komandaSelektujMejlDobavljaca.ExecuteScalar();
                txtPrimalac.Text = dobavljacMejl;
                StringBuilder artikli = new StringBuilder();
                string sveIzKorpe = "SELECT * FROM korpa";
                SqlCommand selektujSveIzKorpe = new SqlCommand(sveIzKorpe, konekcija);
                using (SqlDataReader sdr = selektujSveIzKorpe.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        string imeProizvoda = sdr["ime_proizvoda"].ToString();
                        string proizvodjac = sdr["proizvodjac"].ToString();
                        string kategorija = sdr["kategorija"].ToString();
                        string cena = sdr["cena"].ToString();
                        string kvantitet = sdr["kvantitet"].ToString();
                        artikli.Append(imeProizvoda + " " + proizvodjac + " " + kategorija + " " + cena + " " + kvantitet);
                        artikli.AppendLine();
                    }
                }
                txtPoruka.Text = artikli.ToString();
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
    }
}
