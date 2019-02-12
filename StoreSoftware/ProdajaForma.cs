using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSoftware
{
    public partial class ProdajaForma : Form
    {
        string ime, opis, proizvodjac, kategorija, link;
        int id, duzina_gar_roka;
        double cena;
        DataTable dtKorpa = new DataTable();
        DataRow row;
        double ukupnaCena = 0.0;


        int izabranRed;

        #region Functions
        DataTable MakeDataTable()
        {
            //Create friend table object
            DataTable racun = new DataTable();

            //Define columns
            racun.Columns.Add("Id_Proizvoda");
            racun.Columns.Add("Naziv");
            racun.Columns.Add("Kolicina");
            racun.Columns.Add("Cena");
            racun.Columns.Add("Ukupna Cena");



            foreach (DataGridViewRow red in dgvKorpa.Rows)
            {
                int cenaPoProizvodu;
                cenaPoProizvodu = System.Convert.ToInt32(red.Cells["cena"].Value) * System.Convert.ToInt32(red.Cells["kolicina"].Value);
                racun.Rows.Add(System.Convert.ToString(red.Cells["id"].Value), red.Cells["ime"].Value, System.Convert.ToString(red.Cells["kolicina"].Value), System.Convert.ToString(red.Cells["cena"].Value), System.Convert.ToString(cenaPoProizvodu));

                ukupnaCena += cenaPoProizvodu;
            }

            return racun;
        }
        #endregion

        #region Events
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {

            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font();
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk());
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font();
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            //prgAuthor.Add(new Chunk("Prodavac : Dotnet Mob", fntAuthor));
            prgAuthor.Add(new Chunk("\nVreme prodaje: " + DateTime.Now.ToString(), fntAuthor));
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
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font();
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                //cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);

            Paragraph prgUkupnaCena = new Paragraph();
            prgUkupnaCena.Alignment = Element.ALIGN_RIGHT;
            prgUkupnaCena.Add(new Chunk("Ukupna cena: " + ukupnaCena, fntAuthor));
            document.Add(prgUkupnaCena);
            ukupnaCena = 0.0;

            document.Close();
            writer.Close();
            fs.Close();
        }


        #endregion

        #region Select Data from Database
        public DataTable Select()
        {
            //Static method to connect DB
            SqlConnection con = KonekcioniString.getKonekcija();
            //to hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //sql query to get data
                String sql = "Select * From Proizvodi";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, con);
                //getting data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //open connection
                con.Open();
                //fill data in our datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            //return the value in datatablr
            return dt;
        }
        #endregion

        #region Search
        public DataTable Search(string ime, string kategorija, string proizvodjac, string opis, bool imaNaStanju)
        {
            //Static method to connect DB
            SqlConnection con = KonekcioniString.getKonekcija(); 
            //to hold the data from database
            DataTable dt = new DataTable();

            if (!imaNaStanju)
            {
                try
                {
                    //sql query to get data
                    String sql = "Select * From Proizvodi WHERE ime like '%" + ime + "%' AND kategorija like '%" + kategorija + "%' AND proizvodjac like '%" + proizvodjac + "%' AND opis like '%" + opis + "%' ";
                    //for executing command
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //getting data from db
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //open connection
                    con.Open();
                    //fill data in our datatable
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                //return the value in datatablr
                return dt;
            }
            else
            {
                try
                {
                    //sql query to get data
                    String sql = "Select * From Proizvodi WHERE ime like '%" + ime + "%' AND kategorija like '%" + kategorija + "%' AND proizvodjac like '%" + proizvodjac + "%' AND opis like '%" + opis + "%' AND broj_na_stanju = 0 ";
                    //for executing command
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //getting data from db
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //open connection
                    con.Open();
                    //fill data in our datatable
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                //return the value in datatablr
                return dt;
            }
           
        }

        #endregion

        #region Insert Data in Database
        public void upisiRacun(string vreme)
        {
            SqlConnection con = KonekcioniString.getKonekcija();

            try
            {
                String sql = "Insert into Racuni (vreme, flag, prodavac) VALUES ( @vreme, @flag, @prodavac)";
                SqlCommand cmd = new SqlCommand(sql, con);

                //cmd.Parameters.AddWithValue("@ime", "racun");
                cmd.Parameters.AddWithValue("@vreme", vreme);
                cmd.Parameters.AddWithValue("@flag", "0");
                cmd.Parameters.AddWithValue("@prodavac", "radnik");
                con.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query is executed then the value of rows will be greater then  0 else it will be less then 0 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        public ProdajaForma()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            //get keyword from text boox
            string ime = txtIme.Text;
            string opis = txtOpis.Text;
            string proizvodjac = txtProizvodjac.Text;
            string kategorija = txtKategorija.Text;

            if (ime != null || opis != null || proizvodjac != null || kategorija != null || checkBox1.Checked)
            {
                DataTable dt = Search(ime, kategorija, proizvodjac, opis, checkBox1.Checked);
                dgv1.DataSource = dt;
            }
            else
            {
                DataTable dt = Select();
                dgv1.DataSource = dt;
            }
        }

        private void ProdajaForma_Load(object sender, EventArgs e)
        {
            makeDataTable(dtKorpa);
            DataTable dt = Select();
            dgv1.DataSource = dt;
        }

        private int proveriUbacivanje()
        {
            foreach (DataGridViewRow row2 in dgvKorpa.Rows)
            {
                if (System.Convert.ToInt32(dgv1.SelectedCells[0].Value) == System.Convert.ToInt32(row2.Cells["id"].Value))
                {
                    MessageBox.Show("Artikal je vec dodat u korpu!");
                    return 1;
                }
                if (numericUpDown1.Value > System.Convert.ToInt32(dgv1.SelectedCells[7].Value))
                {
                    MessageBox.Show("Nema dovoljno proizvoda na stanju!!");
                    return 1;
                }
            }
            return 0;
        }

        private void dgvKorpa_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            izabranRed = e.RowIndex;
            dtKorpa.AcceptChanges();
            dgvKorpa.DataSource = dtKorpa;
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            clear();
            DataTable dt = Select();
            dgv1.DataSource = dt;
        }

        private int skiniSaStanja()
        {

            foreach (DataGridViewRow row2 in dgvKorpa.Rows)
            {
                SqlConnection con = KonekcioniString.getKonekcija();
                string odbitak = System.Convert.ToString(row2.Cells["kolicina"].Value);
                string id = System.Convert.ToString(row2.Cells["ime"].Value);

                String sql = "Update Proizvodi SET broj_na_stanju = broj_na_stanju - @odbitak WHERE ime = @ime";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@odbitak", odbitak);
                cmd.Parameters.AddWithValue("@ime", ime);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }

            return 0;
        }

        private void clear()
        {
            txtIme.Text = "";
            txtKategorija.Text = "";
            txtProizvodjac.Text = "";
            txtOpis.Text = "";

        }

        private void makeDataTable(DataTable dtKorpa)
        {
            DataColumn column;

            DataView view;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ime";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "kolicina";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "opis";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "cena";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "proizvodjac";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "kategorija";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "duzina_garantnog_roka";
            dtKorpa.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "link";
            dtKorpa.Columns.Add(column);

            // Create a DataView using the DataTable.
            view = new DataView(dtKorpa);

            // Set a DataGrid control's DataSource to the DataView.
            dgvKorpa.DataSource = view;

        }

        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get an index for particular row, klik i dobijanje informacija
            int rowIndex = e.RowIndex;

            id = System.Convert.ToInt32(dgv1.Rows[rowIndex].Cells[0].Value.ToString());
            ime = dgv1.Rows[rowIndex].Cells[1].Value.ToString();
            opis = dgv1.Rows[rowIndex].Cells[2].Value.ToString();
            cena = System.Convert.ToDouble(dgv1.Rows[rowIndex].Cells[3].Value.ToString());
            //dgvKorpa.Rows[brojac].Cells[4].Value = dgv1.Rows[rowIndex].Cells[4].Value.ToString();
            proizvodjac = dgv1.Rows[rowIndex].Cells[5].Value.ToString();
            kategorija = dgv1.Rows[rowIndex].Cells[6].Value.ToString();
            duzina_gar_roka = System.Convert.ToInt32(dgv1.Rows[rowIndex].Cells[7].Value.ToString());
            link = dgv1.Rows[rowIndex].Cells[8].Value.ToString();
            //dgvKorpa.Rows[brojac].Cells[9].Value = dgv1.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNarucivanje_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li zelite da narucite?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = KonekcioniString.getKonekcija();
                try
                {
                    String sql = "Insert into Narudzbine (id_proizvoda, narucena_kolicina, vreme_narudzbine, stanje_narudzbine) VALUES ( @id, @kolicina, @vreme_narudzbine, @stanje)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    //cmd.Parameters.AddWithValue("@ime", "racun");
                    cmd.Parameters.AddWithValue("@vreme_narudzbine", DateTime.Now);
                    cmd.Parameters.AddWithValue("@kolicina", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@stanje", "radnik_narucio");
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    //if the query is executed then the value of rows will be greater then  0 else it will be less then 0 

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void addRow(DataTable dt, DataRow dr)
        {
            dr = dt.NewRow();
            dr["id"] = id;
            dr["ime"] = ime;
            dr["kolicina"] = numericUpDown1.Value;
            dr["opis"] = opis;
            dr["cena"] = cena;
            dr["proizvodjac"] = proizvodjac;
            dr["kategorija"] = kategorija;
            dr["duzina_garantnog_roka"] = duzina_gar_roka;
            dr["link"] = link;

            dt.Rows.Add(dr);
        }

        private void btnKorpaDodaj_Click(object sender, EventArgs e)
        {

            if (proveriUbacivanje() == 0)
            {
                this.addRow(dtKorpa, row);
            }
        }

        private void btnBrisanjeIzKorpe_Click(object sender, EventArgs e)
        {
            dtKorpa.Rows[izabranRed].Delete();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            if (dtKorpa.Rows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da zavrsite kupovinu?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        DataTable dtbl = MakeDataTable();
                        var time = DateTime.Now;
                        String vreme = time.ToString("dd_MM_yyyy-hh_mm_ss");
                        String path = String.Format("C:/Users/Sofi/Desktop/New folder/Racuni/{0}.pdf", vreme);
                        ExportDataTableToPdf(dtbl, path, "Racun");
                        upisiRacun(vreme);
                        skiniSaStanja();
                        MessageBox.Show("Uspesno ste zavrsili kupovinu!");
                        dtKorpa.Rows.Clear();
                        dgvKorpa.Refresh();
                        DataTable dt = Select();
                        dgv1.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message");
                    }
                }
            }
            else
            {
                MessageBox.Show("Korpa je prazna!");
            }
        }

        private void btnZamena_Click(object sender, EventArgs e)
        {
            Zamena z = new Zamena();
            z.Show();
            
        }
    }
}
