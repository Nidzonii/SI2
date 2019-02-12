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
    public partial class AdminDodavanjeKorisnika : Form
    {
        public AdminDodavanjeKorisnika()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string[] uloge = { "administrator", "vlasnik", "radnik", "komercijalista" };
            SqlConnection konekcija = KonekcioniString.getKonekcija();
            if (txtboxKorisnickoIme.Text.Length < 5 || txtboxSifra.Text.Length < 5)
            {
                MessageBox.Show("Korisničko ime i šifra moraju biti barem 5 karaktera dugački!");
            }
            else
            {
                for (int i = 0; i < uloge.Length; i++)
                {
                    if (comboBox1.Text == uloge[i])
                    {
                        try
                        {
                            string sql1 = "SELECT id_uloge FROM Uloga WHERE ime_uloge='" + comboBox1.Text + "'";
                            SqlCommand komanda1 = new SqlCommand(sql1, konekcija);
                            konekcija.Open();
                            int pozicijaUloge = (int)komanda1.ExecuteScalar(); //RADI
                            string sql2 = "INSERT INTO Korisnik(korisnicko_ime, sifra, id_uloge) VALUES (@korisnicko_ime, @sifra, @id_uloge)";
                            SqlCommand komanda2 = new SqlCommand(sql2, konekcija);
                            txtboxSifra.Text = HesovanjeSifre.enkripcija(txtboxSifra.Text);
                            komanda2.Parameters.AddWithValue("@korisnicko_ime", txtboxKorisnickoIme.Text);
                            komanda2.Parameters.AddWithValue("@sifra", txtboxSifra.Text);
                            komanda2.Parameters.AddWithValue("@id_uloge", pozicijaUloge);
                            int proveraUspesnosti = komanda2.ExecuteNonQuery();
                            if(proveraUspesnosti > 0)
                            {
                                MessageBox.Show("Uspešno registrovan korisnik!");
                                PrazanTekst();
                            }
                            else
                            {
                                MessageBox.Show("Došlo je do neke greške. Pokušajte ponovo.");
                                PrazanTekst();
                            }
                            break;
                        } catch(Exception ex)
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
        }

        private void AdminDodavanjeKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();
            try
            {
                string sql = "DELETE FROM Korisnik WHERE korisnicko_ime='" + txtboxKorisnickoIme.Text + "'";
                SqlCommand komanda = new SqlCommand(sql, konekcija);
                konekcija.Open();
                if(comboBox1.Text != "vlasnik")
                {
                    int proveraUspesnosti = komanda.ExecuteNonQuery();
                    if (proveraUspesnosti > 0)
                    {
                        MessageBox.Show("Uspešno obrisan korisnik!");
                        PrazanTekst();
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji korisnik sa korisnickim imenom " + txtboxKorisnickoIme.Text);
                    }
                }
                else if(comboBox1.Text == "vlasnik")
                {
                    MessageBox.Show("Nemoguće obrisati vlasnika softvera!");
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

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();
            try
            {
                string sql1 = "SELECT sifra, ime_uloge FROM Korisnik INNER JOIN Uloga ON Uloga.id_uloge = Korisnik.id_uloge WHERE korisnicko_ime='" + txtboxKorisnickoIme.Text + "'";
                SqlCommand komanda1 = new SqlCommand(sql1, konekcija);
                konekcija.Open();
                SqlDataReader citac = komanda1.ExecuteReader();
                if (citac.Read())
                {
                    txtboxSifra.Text = (citac["sifra"].ToString());
                    txtboxSifra.Text = HesovanjeSifre.dekripcija(txtboxSifra.Text);
                    comboBox1.Text = (citac["ime_uloge"].ToString());
                }
                else
                {
                    MessageBox.Show("Ne postoji korisnik sa korisnickim imenom " + txtboxKorisnickoIme.Text);
                    PrazanTekst();
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

        private void PrazanTekst()
        {
            txtboxKorisnickoIme.Text = "";
            txtboxSifra.Text = "";
            comboBox1.Text = "";
        }

        private void txtboxKorisnickoIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxUloga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSifra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
