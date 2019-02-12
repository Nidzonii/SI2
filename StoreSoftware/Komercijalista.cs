using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

        public static DataTable IzlistajSveDobavljace()
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
        
        public static DataTable IzlistajSveUKorpi()
        {
            try
            {
                string upit1 = "SELECT * FROM korpa";
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

        public static DataTable IzlistajNaruceneProizvode()
        {
            try
            {
                string upit1 = "SELECT ime AS 'ime proizvoda', proizvodjac, kategorija, cena AS 'Nabavna cena', kvantitet, datum_narucivanja AS 'datum narucivanja', potvrda_narudzbenice AS 'potvrda narudzbenice' FROM ProizvodiDobavljaca INNER JOIN DaLiJeU ON ProizvodiDobavljaca.id_proizvoda_dobavljaca=DaLiJeU.id_proizvoda_dobavljaca INNER JOIN Narudzbenica ON DaLiJeU.id_narudzbenice=Narudzbenica.id_narudzbenice";
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

        public static void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            double cena = 0;
            int kvantitet = 0;
            double racun = 0;
            string format = "dd/MM/yyyy HH:mm";
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor,8,2);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            //prgAuthor.Add(new Chunk("Prodavac : Dotnet Mob", fntAuthor));
            prgAuthor.Add(new Chunk("\nVreme potvrdjivanja narudzbenice: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader,9,1, BaseColor.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    if (j == 5)
                    {
                        DateTime vreme = (DateTime)dtblTable.Rows[i][j];
                        table.AddCell(vreme.ToString(format));
                    }
                    else
                    {
                        if (j == 3)
                        {
                            cena = Convert.ToDouble(dtblTable.Rows[i][j]);
                        }
                        if (j == 4)
                        {
                            kvantitet = Convert.ToInt32(dtblTable.Rows[i][j]);
                        }
                        table.AddCell(dtblTable.Rows[i][j].ToString());
                    }
                }
                racun += cena * kvantitet;
            }

            document.Add(table);

            Paragraph prgUkupnaCena = new Paragraph();
            prgUkupnaCena.Alignment = Element.ALIGN_LEFT;
            prgUkupnaCena.Add(new Chunk("\nRacun: " + racun, fntAuthor));
            document.Add(prgUkupnaCena);
            document.Close();
            writer.Close();
            fs.Close();
        }
    }

}
