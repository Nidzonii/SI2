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
    public partial class KomercijalistaNaruciProizvod : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();

        public KomercijalistaNaruciProizvod()
        {
            InitializeComponent();
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string upit1 = "SELECT Dobavljac.ime AS dobavljač, ProizvodiDobavljaca.ime AS proizvod, ProizvodiDobavljaca.proizvodjac AS proizvođač, ProizvodiDobavljaca.kategorija, ImaOdProizvoda.cena FROM Dobavljac INNER JOIN ImaOdProizvoda ON Dobavljac.id_dobavljaca=ImaOdProizvoda.id_dobavljaca INNER JOIN ProizvodiDobavljaca ON ImaOdProizvoda.id_proizvoda_dobavljaca=ProizvodiDobavljaca.id_proizvoda_dobavljaca WHERE Dobavljac.ime LIKE '%" + txtPretrazi.Text + "%' OR ProizvodiDobavljaca.ime LIKE '%" + txtPretrazi.Text + "%' OR ProizvodiDobavljaca.proizvodjac LIKE '%" + txtPretrazi.Text + "%' OR  ProizvodiDobavljaca.kategorija LIKE '%" + txtPretrazi.Text + "%' OR ImaOdProizvoda.cena LIKE '%" + txtPretrazi.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(upit1, konekcija);
                if (txtPretrazi.Text == "Unesite ključnu reč...")
                {
                    DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
                    dataGridProizvodi.DataSource = dt;
                }
                else
                {
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

        private void dataGridProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KomercijalistaNaruciProizvod_Load(object sender, EventArgs e)
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

        private void txtPretrazi_Leave(object sender, EventArgs e)
        {
            if (txtPretrazi.Text == "" || txtPretrazi.Text == " ")
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

        private void btnSviPodaci_Click(object sender, EventArgs e)
        {
            DataTable dt = Komercijalista.IzlistajSveProizvodeDobavljaca();
            dataGridProizvodi.DataSource = dt;
        }

        private void btnDodajUKorpu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDobavljac.Text.Trim()) || String.IsNullOrEmpty(txtImeProizvoda.Text.Trim()) || String.IsNullOrEmpty(txtKategorija.Text.Trim()) || String.IsNullOrEmpty(txtProizvodjac.Text.Trim()) || String.IsNullOrEmpty(txtCena.Text.Trim()) || String.IsNullOrEmpty(txtKvantitet.Text.Trim()))
            {
                MessageBox.Show("Sva polja moraju biti uneta!");
            }
            else
            {
                try
                {
                    int brojac = 0; // Broj elemenata u korpi
                    string daLiJeKorpaPrazna = "SELECT COUNT(*) FROM Korpa";
                    SqlCommand komandaDaLiJeKorpaPrazna = new SqlCommand(daLiJeKorpaPrazna, konekcija);
                    konekcija.Open();
                    int proveriKorpu = (int)komandaDaLiJeKorpaPrazna.ExecuteScalar();
                    //MessageBox.Show(proveriKorpu.ToString());
                    if (proveriKorpu > 0)
                    {
                        brojac = proveriKorpu;
                        //MessageBox.Show("Ovde?");
                    }
                    else
                    {
                        brojac = 0;
                        //  MessageBox.Show("Ili mozda ovde?");
                    }


                    if (brojac > 0)
                    {
                        string proveriDobavljaca = "SELECT dobavljac FROM Korpa";
                        SqlCommand komandaProveriDobavljaca = new SqlCommand(proveriDobavljaca, konekcija);
                        string dobavljac = (string)komandaProveriDobavljaca.ExecuteScalar();
                        if (dobavljac == txtDobavljac.Text)
                        {
                            string proveriDaLiJeProizvodVecUKorpi = "SELECT COUNT(*) FROM Korpa WHERE dobavljac=@dobavljac AND ime_proizvoda=@ime_proizvoda AND proizvodjac=@proizvodjac AND kategorija=@kategorija AND cena=@cena";
                            SqlCommand komandaProveriDaLiJeProizvodVecUKorpi = new SqlCommand(proveriDaLiJeProizvodVecUKorpi, konekcija);
                            komandaProveriDaLiJeProizvodVecUKorpi.Parameters.AddWithValue("@dobavljac", txtDobavljac.Text);
                            komandaProveriDaLiJeProizvodVecUKorpi.Parameters.AddWithValue("@ime_proizvoda", txtImeProizvoda.Text);
                            komandaProveriDaLiJeProizvodVecUKorpi.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                            komandaProveriDaLiJeProizvodVecUKorpi.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                            komandaProveriDaLiJeProizvodVecUKorpi.Parameters.AddWithValue("@cena", txtCena.Text);
                            komandaProveriDaLiJeProizvodVecUKorpi.Parameters.AddWithValue("@kvantitet", txtKvantitet.Text);
                            int uKorpiIliNe = (int)komandaProveriDaLiJeProizvodVecUKorpi.ExecuteScalar();
                            //MessageBox.Show(uKorpiIliNe.ToString());
                            if (uKorpiIliNe > 0)
                            {
                                MessageBox.Show("Uneti proizvod je vec u korpi!");
                            }
                            else
                            {
                                if (Convert.ToInt32(txtKvantitet.Text) > 0) { 
                                    string upit1 = "INSERT INTO Korpa(dobavljac,ime_proizvoda,proizvodjac,kategorija,cena,kvantitet) VALUES(@dobavljac,@ime_proizvoda,@proizvodjac,@kategorija,@cena,@kvantitet)";
                                    SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                                    komanda1.Parameters.AddWithValue("@dobavljac", txtDobavljac.Text);
                                    komanda1.Parameters.AddWithValue("@ime_proizvoda", txtImeProizvoda.Text);
                                    komanda1.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                                    komanda1.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                                    komanda1.Parameters.AddWithValue("@cena", txtCena.Text);//Convert.ToInt32(txtCena.Text)); 
                                    komanda1.Parameters.AddWithValue("@kvantitet", txtKvantitet.Text);//Convert.ToInt32(txtKvantitet.Text));
                                    int proveraUspesnosti1 = komanda1.ExecuteNonQuery();
                                    // MessageBox.Show(proveraUspesnosti1.ToString());
                                    if (proveraUspesnosti1 > 0)
                                    {
                                        MessageBox.Show("Uspesno ubačen proizvod u korpu!");
                                        ObrisiSvaPolja();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Došlo je do greške");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Kvantitet mora biti veci od nule!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ne mogu se mešati dobavljači u okviru jedne narudžbenice! (Moguće birati proizvode dobavljača pod imenom - " + dobavljac + ")");
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(txtKvantitet.Text) > 0)
                        {
                            string upit1 = "INSERT INTO Korpa(dobavljac,ime_proizvoda,proizvodjac,kategorija,cena,kvantitet) VALUES(@dobavljac,@ime_proizvoda,@proizvodjac,@kategorija,@cena,@kvantitet)";
                            SqlCommand komanda1 = new SqlCommand(upit1, konekcija);
                            komanda1.Parameters.AddWithValue("@dobavljac", txtDobavljac.Text);
                            komanda1.Parameters.AddWithValue("@ime_proizvoda", txtImeProizvoda.Text);
                            komanda1.Parameters.AddWithValue("@proizvodjac", txtProizvodjac.Text);
                            komanda1.Parameters.AddWithValue("@kategorija", txtKategorija.Text);
                            komanda1.Parameters.AddWithValue("@cena", txtCena.Text);//Convert.ToInt32(txtCena.Text)); 
                            komanda1.Parameters.AddWithValue("@kvantitet", txtKvantitet.Text);//Convert.ToInt32(txtKvantitet.Text));
                            int proveraUspesnosti1 = komanda1.ExecuteNonQuery();
                            // MessageBox.Show(proveraUspesnosti1.ToString());
                            if (proveraUspesnosti1 > 0)
                            {
                                MessageBox.Show("Uspesno ubačen proizvod u korpu!");
                                ObrisiSvaPolja();
                            }
                            else
                            {
                                MessageBox.Show("Došlo je do greške");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kvantitet mora biti veci od nule!");
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

        private void btnUkloniIzKorpe_Click(object sender, EventArgs e)
        {
            KomercijalistaNaruciProizvodObrisiIzKorpe knpoip = new KomercijalistaNaruciProizvodObrisiIzKorpe();
            knpoip.Show();
        }

        private void btnPogledajNarudzbenicu_Click(object sender, EventArgs e)
        {
            try
            {
                string upit = "SELECT * FROM Korpa";
                StringBuilder poruka = new StringBuilder();
                poruka.Append("NARUDŽBENICA\n\n\n\n");
                double racun = 0;
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                konekcija.Open();
                using (SqlDataReader sdr = komanda.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        string dobavljac = sdr["dobavljac"].ToString();
                        string imeProizvoda = sdr["ime_proizvoda"].ToString();
                        string proizvodjac = sdr["proizvodjac"].ToString();
                        string kategorija = sdr["kategorija"].ToString();
                        string cena = sdr["cena"].ToString();
                        string kvantitet = sdr["kvantitet"].ToString();
                        racun = racun + Convert.ToDouble(cena) * Convert.ToInt32(kvantitet);
                        poruka.Append(dobavljac + " " + imeProizvoda + " " + proizvodjac + " " + kategorija + " " + cena + " " + kvantitet + "\n\n");
                    }
                }
                poruka.Append("\n\nUKUPAN RAČUN: " + racun.ToString());
                MessageBox.Show(poruka.ToString());
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

        private void btnNaruciProizvod_Click(object sender, EventArgs e)
        {
            KomercijalistaNaruciProizvodMejl knpm = new KomercijalistaNaruciProizvodMejl();
            knpm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtImeProizvoda_TextChanged(object sender, EventArgs e)
        {
            //txtImeProizvoda.Text = txtImeProizvoda.Text.Replace(" ", "");
        }

        private void ObrisiSvaPolja()
        {
            txtDobavljac.Text = " ";
            txtImeProizvoda.Text = " ";
            txtProizvodjac.Text = " ";
            txtKategorija.Text = " ";
            txtKvantitet.Text = " ";
            txtCena.Text = " ";
        }
    }
}
