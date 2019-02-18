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
    public partial class AutomatizovanaRadnjaStatistika : Form
    {
        SqlConnection konekcija = KonekcioniString.getKonekcija();

        public AutomatizovanaRadnjaStatistika()
        {
            InitializeComponent();
            SlabaProdaja();
            Dijagram();
        }

        private void AutomatizovanaRadnjaStatistika_Load(object sender, EventArgs e)
        {

        }

        public void SlabaProdaja()
        {
            var danas = DateTime.Today;
            var uslov = DateTime.Today.AddMonths(-6);


            String upit = "SELECT * FROM Proizvodi WHERE br_prodatih_proizvoda<'" + 5 + "' AND vreme_poslednje_prodaje<='" + uslov + "'";
            SqlCommand komanda = new SqlCommand(upit, konekcija);
            konekcija.Open();
            try
            {
                komanda.ExecuteNonQuery();
                SqlDataAdapter sqlDa = new SqlDataAdapter(upit, konekcija);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                sqlDa.Fill(dt);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        public void Dijagram()
        {
            chart1.Titles.Add("Proizvodi sa slabom prodajom");
            chart1.Series["Series2"].IsValueShownAsLabel = true;

            var danas = DateTime.Today;
            var uslov = DateTime.Today.AddMonths(-6);
            String meniUsluge = "SELECT id_proizvoda,ime,br_prodatih_proizvoda FROM Proizvodi WHERE br_prodatih_proizvoda<'" + 5 + "' AND vreme_poslednje_prodaje<='" + uslov + "'";
            SqlCommand komanda = new SqlCommand(meniUsluge, konekcija);
            SqlDataReader citac;
            konekcija.Open();
            try
            {
                List<String> imena = new List<string>();
                List<double> brojevi = new List<double>();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    String _id = citac["id_proizvoda"].ToString();
                    String _ime = citac["ime"].ToString();
                    String _br_prodatih_proizvoda = citac["br_prodatih_proizvoda"].ToString();
                    int id = Convert.ToInt32(_id);
                    double br = Convert.ToDouble(_br_prodatih_proizvoda);
                    imena.Add(_ime);
                    brojevi.Add(br);
                }
                chart1.Series["Series2"].Points.DataBindXY(imena, brojevi);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}
