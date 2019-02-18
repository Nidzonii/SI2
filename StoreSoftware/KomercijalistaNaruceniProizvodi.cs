using System;
using System.Collections;
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
    public partial class KomercijalistaNaruceniProizvodi : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();
        
        public KomercijalistaNaruceniProizvodi()
        {
            InitializeComponent();
        }

        private void KomercijalistaNaruceniProizvodi_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm";
            DataTable dt = Komercijalista.IzlistajNaruceneProizvode();
            dataGridNaruceniProizvodi.DataSource = dt;
        }

        private void Duplikati()
        {

        }

        private void btnPretraziPoDatumu_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMilliseconds(-dateTimePicker1.Value.Millisecond);
                dateTimePicker1.Value = dateTimePicker1.Value.AddSeconds(-dateTimePicker1.Value.Second);
                string upit1 = "SELECT ime AS 'ime proizvoda', proizvodjac, kategorija, cena AS 'Nabavna cena', kvantitet, datum_narucivanja AS 'datum narucivanja', potvrda_narudzbenice AS 'potvrda narudzbenice' FROM ProizvodiDobavljaca INNER JOIN DaLiJeU ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=DaLiJeU.id_proizvoda_dobavljaca INNER JOIN Narudzbenica ON DaLiJeU.id_narudzbenice=Narudzbenica.id_narudzbenice WHERE Narudzbenica.datum_narucivanja='" + dateTimePicker1.Value + "'";
                SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                SqlDataAdapter sda = new SqlDataAdapter(komanda1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridNaruceniProizvodi.DataSource = dt;
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

        private void btnPretraziPoIdu_Click(object sender, EventArgs e)
        {
            string upit1 = "SELECT ime AS 'ime proizvoda', proizvodjac, kategorija, cena AS 'Nabavna cena', kvantitet, datum_narucivanja AS 'datum narucivanja', potvrda_narudzbenice AS 'potvrda narudzbenice' FROM ProizvodiDobavljaca INNER JOIN DaLiJeU ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=DaLiJeU.id_proizvoda_dobavljaca INNER JOIN Narudzbenica ON DaLiJeU.id_narudzbenice=Narudzbenica.id_narudzbenice WHERE Narudzbenica.id_narudzbenice LIKE '%" + txtPretragaPoIdu.Text + "%' AND Narudzbenica.potvrda_narudzbenice='0'";
            SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
            SqlDataAdapter sda = new SqlDataAdapter(komanda1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridNaruceniProizvodi.DataSource = dt;

        }

        private void btnObrisiNarudzbenicu_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                if (String.IsNullOrEmpty(txtPretragaPoIdu.Text) || txtPretragaPoIdu.Text == "Unesite id narudžbenice...")
                {
                    dateTimePicker1.Value = dateTimePicker1.Value.AddMilliseconds(-dateTimePicker1.Value.Millisecond);
                    dateTimePicker1.Value = dateTimePicker1.Value.AddSeconds(-dateTimePicker1.Value.Second);
                    string nadjiIdNarudzbenice = "SELECT id_narudzbenice FROM Narudzbenica WHERE datum_narucivanja='" + dateTimePicker1.Value + "'";
                    SqlCommand komandaNadjiIdNarudzbenice = new SqlCommand(nadjiIdNarudzbenice, konekcija);
                    int idNarudzbenice = Convert.ToInt32(komandaNadjiIdNarudzbenice.ExecuteScalar());
                    if (idNarudzbenice > 0)
                    {
                        string obrisiVezu = "DELETE FROM DaLiJeU WHERE id_narudzbenice='" + idNarudzbenice + "'";
                        SqlCommand komandaObrisiVezu = new SqlCommand(obrisiVezu, konekcija);
                        int proveraUspesnosti1 = komandaObrisiVezu.ExecuteNonQuery();
                        string obrisiNarudzbenicu = "DELETE FROM Narudzbenica WHERE id_narudzbenice='" + idNarudzbenice + "'";
                        SqlCommand komandaObrisiNarudzbenicu = new SqlCommand(obrisiNarudzbenicu, konekcija);
                        int proveraUspesnosti2 = komandaObrisiNarudzbenicu.ExecuteNonQuery();
                        if (proveraUspesnosti1 > 0 && proveraUspesnosti2 > 0)
                        {
                            MessageBox.Show("Uspešno poništena narudžbenica sa ID-em: " + idNarudzbenice);
                            DataTable dt = Komercijalista.IzlistajNaruceneProizvode();
                            dataGridNaruceniProizvodi.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do greške");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji tražena narudžbenica!");
                    }
                }
                else
                {
                    int idNarudzbenice = Convert.ToInt32(txtPretragaPoIdu.Text);
                    string obrisiVezu = "DELETE FROM DaLiJeU WHERE id_narudzbenice='" + idNarudzbenice + "'";
                    SqlCommand komandaObrisiVezu = new SqlCommand(obrisiVezu, konekcija);
                    int proveraUspesnosti1 = komandaObrisiVezu.ExecuteNonQuery();
                    string obrisiNarudzbenicu = "DELETE FROM Narudzbenica WHERE id_narudzbenice='" + idNarudzbenice + "'";
                    SqlCommand komandaObrisiNarudzbenicu = new SqlCommand(obrisiNarudzbenicu, konekcija);
                    int proveraUspesnosti2 = komandaObrisiNarudzbenicu.ExecuteNonQuery();
                    if (proveraUspesnosti1 > 0 && proveraUspesnosti2 > 0)
                    {
                        MessageBox.Show("Uspešno poništena narudžbenica sa ID-em: " + idNarudzbenice);
                        DataTable dt = Komercijalista.IzlistajNaruceneProizvode();
                        dataGridNaruceniProizvodi.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške");
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

        private void btnPrijemRobe_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string s = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                int brojacArtikla = 0;
                bool bit = true;

                if (String.IsNullOrEmpty(txtPretragaPoIdu.Text) || txtPretragaPoIdu.Text == "Unesite id narudžbenice...")
                {
                    dateTimePicker1.Value = dateTimePicker1.Value.AddMilliseconds(-dateTimePicker1.Value.Millisecond);
                    dateTimePicker1.Value = dateTimePicker1.Value.AddSeconds(-dateTimePicker1.Value.Second);
                    string napraviTabelu = "SELECT ime AS 'ime proizvoda', proizvodjac, kategorija, cena AS 'nabavna cena', kvantitet, datum_narucivanja AS 'datum narucivanja' FROM ProizvodiDobavljaca INNER JOIN DaLiJeU ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=DaLiJeU.id_proizvoda_dobavljaca INNER JOIN Narudzbenica ON DaLiJeU.id_narudzbenice=Narudzbenica.id_narudzbenice WHERE Narudzbenica.datum_narucivanja='" + dateTimePicker1.Value + "'";
                    SqlCommand komandaNapraviTabelu = new SqlCommand(napraviTabelu, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komandaNapraviTabelu);
                    DataTable tabela = new DataTable();
                    sda.Fill(tabela);
                    String datumVreme = DateTime.Now.ToString("dd_MM_yyyy-HH_mm");
                    
                    String datumProdaje = String.Format(@s + @"\Fakture\{0}.pdf", datumVreme);
                    Komercijalista.ExportDataTableToPdf(tabela, datumProdaje, "PRIJEM ROBE");

                    string postaviFleg = "UPDATE Narudzbenica SET potvrda_narudzbenice='" + bit + "' WHERE datum_narucivanja='" + dateTimePicker1.Value + "'";
                    SqlCommand komandaPostaviFleg = new SqlCommand(postaviFleg, konekcija);
                    int fleg = komandaPostaviFleg.ExecuteNonQuery();
                    if (fleg > 0)
                    {
                        string dobavljanjePotrebnihInformacija = "SELECT ime, proizvodjac, kategorija, cena, kvantitet FROM ProizvodiDobavljaca INNER JOIN DaLiJeU ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=DaLiJeU.id_proizvoda_dobavljaca INNER JOIN Narudzbenica ON DaLiJeU.id_narudzbenice=Narudzbenica.id_narudzbenice WHERE Narudzbenica.datum_narucivanja='" + dateTimePicker1.Value + "' AND Narudzbenica.potvrda_narudzbenice='" + bit + "'";
                        SqlCommand komandaDobavljanjePotrebnihInformacija = new SqlCommand(dobavljanjePotrebnihInformacija, konekcija);
                        StringBuilder imeProizvoda = new StringBuilder();
                        StringBuilder proizvodjac = new StringBuilder();
                        StringBuilder kategorija = new StringBuilder();
                        StringBuilder kvantitet = new StringBuilder();
                        StringBuilder cena = new StringBuilder();
                        using (SqlDataReader sdr = komandaDobavljanjePotrebnihInformacija.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                imeProizvoda.Append(sdr["ime"].ToString() + "~");
                                proizvodjac.Append(sdr["proizvodjac"].ToString() + "~");
                                kategorija.Append(sdr["kategorija"].ToString() + "~");
                                kvantitet.Append(sdr["kvantitet"].ToString() + "~");
                                cena.Append(sdr["cena"].ToString() + "~");
                                brojacArtikla++;
                            }
                        }

                        if (brojacArtikla == 1)
                        {
                            imeProizvoda.Append("s~");
                            proizvodjac.Append("s~");
                            kategorija.Append("s~");
                            kvantitet.Append("s~");
                            cena.Append("s~");
                        }

                        imeProizvoda.Length = imeProizvoda.Length--;
                        proizvodjac.Length = proizvodjac.Length--;
                        kategorija.Length = kategorija.Length--;
                        kvantitet.Length = kvantitet.Length--;
                        cena.Length = cena.Length--;
                        
                        string[] proizvodi = imeProizvoda.ToString().Split('~');
                        string[] proizvodjaci = proizvodjac.ToString().Split('~');
                        string[] kategorijaa = kategorija.ToString().Split('~');
                        string[] cene = cena.ToString().Split('~');
                        string[] kvantiteti = kvantitet.ToString().Split('~');

                        for (int i = 0; i < proizvodi.Length; i++)
                        {
                            if(brojacArtikla == 1 && i == 1)
                            {
                                break;
                            }
                            string pr = proizvodi[i];
                            string pro = proizvodjaci[i];
                            string kat = kategorijaa[i];
                            double cen = Convert.ToDouble(cene[i]);
                            int kva = Convert.ToInt32(kvantiteti[i]);
                            double nabavnaCena = cen;
                            double cenaArtikla = cen + cen * 0.2;
                            string ispitajDaLiPostojiUBazi = "SELECT COUNT(*) FROM Proizvodi WHERE ime='" + pr + "'";

                            SqlCommand komandaIspitajDaLiPostojiUBazi = new SqlCommand(ispitajDaLiPostojiUBazi, konekcija);
                            int proveraUspesnosti = (int)komandaIspitajDaLiPostojiUBazi.ExecuteScalar();
                            if (proveraUspesnosti > 0)
                            {
                                string apdejtujBrojNaStanju = "UPDATE Proizvodi SET broj_na_stanju=broj_na_stanju + '" + kva + "' WHERE ime='" + pr + "'";
                                SqlCommand komandaApdejtujBrojNaStanju = new SqlCommand(apdejtujBrojNaStanju, konekcija);
                                int apdejtuj = komandaApdejtujBrojNaStanju.ExecuteNonQuery();
                                if (apdejtuj > 0)
                                {
                                    MessageBox.Show("Artikal već postoji. Uspešno dodata količina proizvoda na već postojeću!");
                                    DataTable dt = Komercijalista.IzlistajNaruceneProizvode();
                                    dataGridNaruceniProizvodi.DataSource = dt;
                                }
                                else
                                {
                                    MessageBox.Show("Došlo je do greške!");
                                }
                            }
                            else
                            {
                                string ubaciUBazuProizvodi = "INSERT INTO Proizvodi(ime,opis,cena,nabavna_cena,proizvodjac,kategorija,broj_na_stanju,duzina_garantnog_roka,link,procenti_smanjenja,br_prodatih_proizvoda) VALUES(@ime,@opis,@cena,@nabavnaCena,@proizvodjac,@kategorija,@brojNaStanju,@duzinaGarantnogRoka,@link,@procentiSmanjenja,@br)";
                                SqlCommand komandaUbaciUBazuProizvodi = new SqlCommand(ubaciUBazuProizvodi, konekcija);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@ime", pr);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@opis", "/");
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@cena", cenaArtikla);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@nabavnaCena", nabavnaCena);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@proizvodjac", pro);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@kategorija", kat);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@brojNaStanju", kva);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@duzinaGarantnogRoka", 0);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@link", "/");
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@procentiSmanjenja", 0);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@br", 0);
                                int proveraUspesnosti2 = komandaUbaciUBazuProizvodi.ExecuteNonQuery();
                                if (proveraUspesnosti2 > 0)
                                {
                                    MessageBox.Show("Proizvod uspešno dodat u bazu!");
                                    DataTable dt = Komercijalista.IzlistajNaruceneProizvode();
                                    dataGridNaruceniProizvodi.DataSource = dt;
                                }
                                else
                                {
                                    MessageBox.Show("Došlo je do greške!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji tražena narudžbenica!");
                    }


                }
                else
                {
                    string napraviTabelu = "SELECT ime AS 'ime proizvoda', proizvodjac, kategorija, cena AS 'nabavna cena', kvantitet, datum_narucivanja AS 'datum narucivanja' FROM ProizvodiDobavljaca INNER JOIN DaLiJeU ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=DaLiJeU.id_proizvoda_dobavljaca INNER JOIN Narudzbenica ON DaLiJeU.id_narudzbenice=Narudzbenica.id_narudzbenice WHERE Narudzbenica.id_narudzbenice='" + txtPretragaPoIdu.Text + "'";
                    SqlCommand komandaNapraviTabelu = new SqlCommand(napraviTabelu, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komandaNapraviTabelu);
                    DataTable tabela = new DataTable();
                    sda.Fill(tabela);
                    String datumVreme = DateTime.Now.ToString("dd_MM_yyyy-HH_mm");
                    String datumProdaje = String.Format(@s + @"\Fakture\{0}.pdf", datumVreme);
                    Komercijalista.ExportDataTableToPdf(tabela, datumProdaje, "PRIJEM ROBE");
                    string postaviFleg = "UPDATE Narudzbenica SET potvrda_narudzbenice='" + bit + "' WHERE id_narudzbenice='" + txtPretragaPoIdu.Text + "'";
                    SqlCommand komandaPostaviFleg = new SqlCommand(postaviFleg, konekcija);
                    int fleg = komandaPostaviFleg.ExecuteNonQuery();
                    if (fleg > 0)
                    {
                        string dobavljanjePotrebnihInformacija = "SELECT ime, proizvodjac, kategorija, cena, kvantitet FROM ProizvodiDobavljaca INNER JOIN DaLiJeU ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=DaLiJeU.id_proizvoda_dobavljaca INNER JOIN Narudzbenica ON DaLiJeU.id_narudzbenice=Narudzbenica.id_narudzbenice WHERE Narudzbenica.id_narudzbenice='" + txtPretragaPoIdu.Text + "' AND Narudzbenica.potvrda_narudzbenice='" + bit + "'";
                        SqlCommand komandaDobavljanjePotrebnihInformacija = new SqlCommand(dobavljanjePotrebnihInformacija, konekcija);
                        StringBuilder imeProizvoda = new StringBuilder();
                        StringBuilder proizvodjac = new StringBuilder();
                        StringBuilder kategorija = new StringBuilder();
                        StringBuilder kvantitet = new StringBuilder();
                        StringBuilder cena = new StringBuilder();
                        using (SqlDataReader sdr = komandaDobavljanjePotrebnihInformacija.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                imeProizvoda.Append(sdr["ime"].ToString() + "~");
                                proizvodjac.Append(sdr["proizvodjac"].ToString() + "~");
                                kategorija.Append(sdr["kategorija"].ToString() + "~");
                                kvantitet.Append(sdr["kvantitet"].ToString() + "~");
                                cena.Append(sdr["cena"].ToString() + "~");

                                brojacArtikla++;
                            }
                        }

                        if (brojacArtikla == 1)
                        {
                            imeProizvoda.Append("s~");
                            proizvodjac.Append("s~");
                            kategorija.Append("s~");
                            kvantitet.Append("s~");
                            cena.Append("s~");
                        }

                        imeProizvoda.Length = imeProizvoda.Length--;
                        proizvodjac.Length = proizvodjac.Length--;
                        kategorija.Length = kategorija.Length--;
                        kvantitet.Length = kvantitet.Length--;
                        cena.Length = cena.Length--;
                        
                        string[] proizvodi = imeProizvoda.ToString().Split('~');
                        string[] proizvodjaci = proizvodjac.ToString().Split('~');
                        string[] kategorijaa = kategorija.ToString().Split('~');
                        string[] cene = cena.ToString().Split('~');
                        string[] kvantiteti = kvantitet.ToString().Split('~');

                        for (int i = 0; i < proizvodi.Length; i++)
                        {
                            if(brojacArtikla == 1 && i == 1)
                            {
                                break;
                            }
                            string pr = proizvodi[i];
                            string pro = proizvodjaci[i];
                            string kat = kategorijaa[i];
                            double cen = Convert.ToDouble(cene[i]);
                            int kva = Convert.ToInt32(kvantiteti[i]);
                            double nabavnaCena = cen;
                            double cenaArtikla = cen + cen * 0.2;
                            string ispitajDaLiPostojiUBazi = "SELECT COUNT(*) FROM Proizvodi WHERE ime='" + pr + "'";
                            SqlCommand komandaIspitajDaLiPostojiUBazi = new SqlCommand(ispitajDaLiPostojiUBazi, konekcija);
                            int proveraUspesnosti = (int)komandaIspitajDaLiPostojiUBazi.ExecuteScalar();
                            if (proveraUspesnosti > 0)
                            {
                                string apdejtujBrojNaStanju = "UPDATE Proizvodi SET broj_na_stanju=broj_na_stanju + '" + kva + "' WHERE ime='" + pr + "'";// AND proizvodjac='" + pro + "' AND kategorija='" + kat + "'";
                                SqlCommand komandaApdejtujBrojNaStanju = new SqlCommand(apdejtujBrojNaStanju, konekcija);
                                int apdejtuj = komandaApdejtujBrojNaStanju.ExecuteNonQuery();
                                if (apdejtuj > 0)
                                {
                                    MessageBox.Show("Artikal već postoji. Uspešno dodata količina proizvoda na već postojeću!");
                                    DataTable dt = Komercijalista.IzlistajNaruceneProizvode();
                                    dataGridNaruceniProizvodi.DataSource = dt;
                                }
                                else
                                {
                                    MessageBox.Show("Došlo je do greške!");
                                }
                            }
                            else
                            {
                                string ubaciUBazuProizvodi = "INSERT INTO Proizvodi(ime,opis,cena,nabavna_cena,proizvodjac,kategorija,broj_na_stanju,duzina_garantnog_roka,link) VALUES(@ime,@opis,@cena,@nabavnaCena,@proizvodjac,@kategorija,@brojNaStanju,@duzinaGarantnogRoka,@link)";
                                SqlCommand komandaUbaciUBazuProizvodi = new SqlCommand(ubaciUBazuProizvodi, konekcija);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@ime", pr);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@opis", "/");
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@cena", cenaArtikla);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@nabavnaCena", nabavnaCena);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@proizvodjac", pro);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@kategorija", kat);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@brojNaStanju", kva);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@duzinaGarantnogRoka", 0);
                                komandaUbaciUBazuProizvodi.Parameters.AddWithValue("@link", "/");
                                int proveraUspesnosti2 = komandaUbaciUBazuProizvodi.ExecuteNonQuery();
                                if (proveraUspesnosti2 > 0)
                                {
                                    MessageBox.Show("Proizvod uspešno dodat u bazu!");
                                    DataTable dt = Komercijalista.IzlistajNaruceneProizvode();
                                    dataGridNaruceniProizvodi.DataSource = dt;
                                }
                                else
                                {
                                    MessageBox.Show("Došlo je do greške!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji tražena narudžbenica!");
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

        private void txtPretragaPoIdu_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPretragaPoIdu.Text))
            {
                txtPretragaPoIdu.ForeColor = Color.Gray;
                txtPretragaPoIdu.Text = "Unesite id narudžbenice...";
            }
        }

        private void txtPretragaPoIdu_Enter(object sender, EventArgs e)
        {
            if (txtPretragaPoIdu.Text == "Unesite id narudžbenice...")
            {
                txtPretragaPoIdu.ForeColor = Color.Black;
                txtPretragaPoIdu.Text = "";
            }
        }

       
    }
}
