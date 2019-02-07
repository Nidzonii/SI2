using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSoftware
{
    class Komercijalista
    {
        private static SqlConnection konekcija = new SqlConnection("Data Source=LAPTOP-QQ1TU8ST;Initial Catalog=ProdavnicaRacunarskeOpreme;Integrated Security=True");

        public static void RegistrujDobavljaca(string mejl, string ime, string brojTelefona)
        {
            try
            {
                string upit1 = "SELECT * FROM Dobavljac WHERE mejl='" + mejl + "'";
                SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                konekcija.Open();
                int uspesnost1 = komanda1.ExecuteNonQuery();
                if(uspesnost1 > 0)
                {
                    Console.WriteLine("Postoji vec korisnik sa unetim mejlom");
                }
                else
                {
                    string upit2 = "INSERT INTO Dobavljac(ime, mejl, broj_telefona) VALUES (@ime, @mejl, @brojTelefona)";
                    SqlCommand komanda2 = new SqlCommand(upit2, konekcija);
                    int uspesnost2 = komanda2.ExecuteNonQuery();
                    if(uspesnost2 > 0)
                    {
                        Console.WriteLine("Uspesno ste uneli podatke!");
                    }
                    else
                    {
                        Console.WriteLine("Doslo je do nepredvidjene greske");
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                konekcija.Close();
            }

        }

        public static DataTable PrikaziDobavljaca()
        {
            try
            {
                string upit1 = "SELECT * FROM Dobavljac";
                SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                SqlDataAdapter sda = new SqlDataAdapter(komanda1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

        public static DataTable PronadjiDobavljacaPoImenu(string ime)
        {
            try
            {
                string upit1 = "SELECT * FROM Dobavljac WHERE ime LIKE '%" + ime + "%'";
                SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                SqlDataAdapter sda = new SqlDataAdapter(komanda1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

        public static DataTable IzlistajSveProizvodeDobavljaca()
        {
            try
            {
                string upit1 = "SELECT Dobavljac.ime AS dobavljač, ProizvodiDobavljaca.ime AS proizvod, ProizvodiDobavljaca.proizvodjac AS proizvođač, ProizvodiDobavljaca.kategorija, ImaOdProizvoda.cena FROM Dobavljac INNER JOIN ImaOdProizvoda ON Dobavljac.id_dobavljaca=ImaOdProizvoda.id_dobavljaca INNER JOIN ProizvodiDobavljaca ON ImaOdProizvoda.id_proizvoda_dobavljaca=ProizvodiDobavljaca.id_proizvoda_dobavljaca"; //INNER JOIN Kosta ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=Kosta.id_proizvoda_dobavljaca INNER JOIN Cena ON Kosta.id_cene=Cena.id_cene
                SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                SqlDataAdapter sda = new SqlDataAdapter(komanda1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

    }
}
