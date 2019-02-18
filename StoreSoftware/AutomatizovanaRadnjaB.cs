using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSoftware
{
    class AutomatizovanaRadnjaB
    {
        public static void AutomatizovanaRadnja()
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();

            try
            {
                konekcija.Open();
                DateTime trenutnoVreme = DateTime.Now;
                DateTime mesecDana = trenutnoVreme.AddMonths(-1);
                DateTime dvaMeseca = trenutnoVreme.AddMonths(-2);
                DateTime triMeseca = trenutnoVreme.AddMonths(-3);
                int pet = 5;
                int deset = 10;
                int petnaest = 15;
                //MessageBox.Show(trenutnoVreme.ToString() + "\n" + mesecDana.ToString());
                string selektujSve = "SELECT COUNT(*) FROM Proizvodi WHERE (vreme_poslednje_prodaje<=@vremeJedan AND vreme_poslednje_prodaje>@vremeDva AND procenti_smanjenja<@pet) OR (vreme_poslednje_prodaje<=@vremeDva AND vreme_poslednje_prodaje>@vremeTri AND procenti_smanjenja<@deset) OR (vreme_poslednje_prodaje<=@vremeTri AND procenti_smanjenja<@petnaest)";
                SqlCommand komandaSelektujSve = new SqlCommand(selektujSve, konekcija);
                komandaSelektujSve.Parameters.AddWithValue("@vremeJedan", mesecDana);
                komandaSelektujSve.Parameters.AddWithValue("@vremeDva", dvaMeseca);
                komandaSelektujSve.Parameters.AddWithValue("@vremeTri", triMeseca);
                komandaSelektujSve.Parameters.AddWithValue("@pet", pet);
                komandaSelektujSve.Parameters.AddWithValue("@deset", deset);
                komandaSelektujSve.Parameters.AddWithValue("@petnaest", petnaest);
                int proveraUspesnosti = Convert.ToInt32(komandaSelektujSve.ExecuteScalar());
                //MessageBox.Show(proveraUspesnosti.ToString());
                if (proveraUspesnosti > 0)
                {
                    DialogResult poruka = MessageBox.Show("Neki proizvodi se ne prodaju najbolje. Želite li da pogledate te proizvode?", "Obaveštenje", MessageBoxButtons.YesNo);
                    if (poruka == DialogResult.Yes)
                    {
                        ProizvodiKojiSeSlaboProdaju pkssp = new ProizvodiKojiSeSlaboProdaju();
                        pkssp.Show();
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
