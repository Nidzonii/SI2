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
    public partial class KomercijalistaRegistrujNovogDobavljaca : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();

        public KomercijalistaRegistrujNovogDobavljaca()
        {
            InitializeComponent();
        }

        private void KomercijalistaRegistrujNovogDobavljaca_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            try
            {
                string upit1 = "SELECT COUNT(*) FROM Dobavljac WHERE mejl=@mejl";
                SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                komanda1.Parameters.AddWithValue("@mejl", txtMejl.Text);
                konekcija.Open();
                int uspesnost1 = (int)komanda1.ExecuteScalar();
                MessageBox.Show(uspesnost1.ToString());

                if (uspesnost1 > 0)
                {
                    MessageBox.Show("Postoji vec dobavljac sa unetim mejlom");
                }
                else
                {
                    string upit2 = "INSERT INTO Dobavljac(ime, mejl, broj_telefona) VALUES (@ime, @mejl, @brojTelefona)";

                    SqlCommand komanda2 = new SqlCommand(upit2, konekcija);
                    komanda2.Parameters.AddWithValue("@ime", txtDobavljac.Text);
                    komanda2.Parameters.AddWithValue("@mejl", txtMejl.Text);
                    komanda2.Parameters.AddWithValue("@brojTelefona", txtBrojTelefona.Text);
                    int uspesnost2 = komanda2.ExecuteNonQuery();
                    MessageBox.Show(uspesnost2.ToString());
                    if (uspesnost2 > 0)
                    {
                        MessageBox.Show("Uspesno ste uneli podatke!");
                    }
                    else
                    {
                        MessageBox.Show("Doslo je do nepredvidjene greske");
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
    }
}
