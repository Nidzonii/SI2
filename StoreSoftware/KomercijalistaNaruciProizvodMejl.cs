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
using System.Net;
using System.Net.Mail;

namespace StoreSoftware
{
    public partial class KomercijalistaNaruciProizvodMejl : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();
        private NetworkCredential login;
        private SmtpClient client;
        private MailMessage msg;

        public KomercijalistaNaruciProizvodMejl()
        {
            InitializeComponent();
        }

        private void KomercijalistaNaruciProizvodMejl_Load(object sender, EventArgs e)
        {
            try
            {
                string selektujDobavljaca = "SELECT dobavljac FROM Korpa";
                SqlCommand komandaSelektujDobavljaca = new SqlCommand(selektujDobavljaca, konekcija);
                konekcija.Open();
                string dobavljac = (string)komandaSelektujDobavljaca.ExecuteScalar();
                string selektujMejlDobavljaca = "SELECT mejl FROM Dobavljac WHERE ime=@ime";
                SqlCommand komandaSelektujMejlDobavljaca = new SqlCommand(selektujMejlDobavljaca, konekcija);
                komandaSelektujMejlDobavljaca.Parameters.AddWithValue("@ime",dobavljac);
                string dobavljacMejl = (string)komandaSelektujMejlDobavljaca.ExecuteScalar();
                txtPrimalac.Text = dobavljacMejl;
                StringBuilder artikli = new StringBuilder();
                string sveIzKorpe = "SELECT * FROM korpa";
                SqlCommand selektujSveIzKorpe = new SqlCommand(sveIzKorpe,konekcija);
                using(SqlDataReader sdr = selektujSveIzKorpe.ExecuteReader())
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
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txtKorisnickoIme.Text, txtSifra.Text);
            client = new SmtpClient(txtSmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = chkSSL.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtKorisnickoIme.Text + txtSmtp.Text.Replace("smtp.", "@"), "Komercijalista", Encoding.UTF8) };
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
            try
            {
                string ubaciUNarudzbenicu = "INSERT INTO Narudzbenica(datum_narucivanja) OUTPUT INSERTED.id_narudzbenice VALUES(@datum_narucivanja)";
                SqlCommand komandaUbaciUNarudzbenicu = new SqlCommand(ubaciUNarudzbenicu, konekcija);
                konekcija.Open();
                komandaUbaciUNarudzbenicu.Parameters.AddWithValue("@datum_narucivanja", DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                int idNarudzbenice = Convert.ToInt32(komandaUbaciUNarudzbenicu.ExecuteScalar());
                //MessageBox.Show(idNarudzbenice.ToString());
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
                            imeProizvoda.Append(sdr["ime_proizvoda"].ToString() + " ");
                            proizvodjac.Append(sdr["proizvodjac"].ToString() + " ");
                            kategorija.Append(sdr["kategorija"].ToString() + " ");
                            kvantitet.Append(sdr["kvantitet"].ToString() + " ");
                        }
                    }

                    imeProizvoda.Length = imeProizvoda.Length--;
                    proizvodjac.Length = proizvodjac.Length--;
                    kategorija.Length = kategorija.Length--;
                    kvantitet.Length = kvantitet.Length--;
                    MessageBox.Show(imeProizvoda.ToString());
                    MessageBox.Show(proizvodjac.ToString());
                    MessageBox.Show(kategorija.ToString());
                    MessageBox.Show(kvantitet.ToString());
                    string[] proizvodi = imeProizvoda.ToString().Split(' ');
                    string[] proizvodjaci = proizvodjac.ToString().Split(' ');
                    string[] kategorijaa = kategorija.ToString().Split(' ');
                    string[] kvantiteti = kvantitet.ToString().Split(' ');
                    for (int i = 0; i < proizvodi.Length; i++)
                    {
                        string nadjiIdProizvodaDobavljaca = "SELECT id_proizvoda_dobavljaca FROM ProizvodiDobavljaca WHERE ime=@ime AND proizvodjac=@proizvodjac AND kategorija=@kategorija";
                        SqlCommand komandaNadjiIdProizvodaDobavljaca = new SqlCommand(nadjiIdProizvodaDobavljaca, konekcija);
                        komandaNadjiIdProizvodaDobavljaca.Parameters.AddWithValue("@ime", proizvodi[i]);
                        komandaNadjiIdProizvodaDobavljaca.Parameters.AddWithValue("@proizvodjac", proizvodjaci[i]);
                        komandaNadjiIdProizvodaDobavljaca.Parameters.AddWithValue("@kategorija", kategorijaa[i]);
                        int idProizvodaDobavljaca = Convert.ToInt32(komandaNadjiIdProizvodaDobavljaca.ExecuteScalar());
                        string selektujDobavljaca = "SELECT dobavljac FROM Korpa";
                        SqlCommand komandaSelektujDobavljaca = new SqlCommand(selektujDobavljaca, konekcija);
                        string dobavljac = (string)komandaSelektujDobavljaca.ExecuteScalar();
                        string nadjiIdDobavljaca = "SELECT id_dobavljaca FROM Dobavljac WHERE ime='" + dobavljac + "'";
                        SqlCommand komandaNadjiIdDobavljaca = new SqlCommand(nadjiIdDobavljaca, konekcija);
                        int idDobavljaca = Convert.ToInt32(komandaNadjiIdDobavljaca.ExecuteScalar());
                        MessageBox.Show(idProizvodaDobavljaca.ToString());
                        MessageBox.Show(idDobavljaca.ToString());
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
                            MessageBox.Show("Uspesno narucen proizvod pod imenom: " + proizvodi[i]);
                        }
                        else
                        {
                            MessageBox.Show("Doslo je do nepredvidjene greske!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Doslo je do greske");
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
                    MessageBox.Show("Uspesno obrisane stavke iz korpe!");
                }
                else
                {
                    MessageBox.Show("Doslo je do greske!");
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
