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
    public partial class AdminForma : Form
    {
        SqlConnection konekcija = KonekcioniString.getKonekcija();

        public AdminForma()
        {
            InitializeComponent();
            prikaziSve();
        }

        void prikaziSve()
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();
            String upit = "SELECT * FROM Proizvodi";
            SqlCommand komanda = new SqlCommand(upit, konekcija);
            SqlDataAdapter sqlDa = new SqlDataAdapter(upit, konekcija);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            sqlDa.Fill(dt);
        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            try
            {

                konekcija.Open();
                String uklanjanjeUNarudzbini = "DELETE FROM Narudzbine WHERE id_proizvoda='" + id + "'";
                SqlCommand komanda1 = new SqlCommand(uklanjanjeUNarudzbini, konekcija);

                int provera1 = komanda1.ExecuteNonQuery();
                String uklanjanje = "DELETE FROM Proizvodi WHERE id_proizvoda='" + id + "'";
                SqlCommand komanda = new SqlCommand(uklanjanje, konekcija);

                int provera = komanda.ExecuteNonQuery();
                if (provera > 0 && provera1 > 0)
                {
                    MessageBox.Show("Uspešno uklonjen proizvod!");
                    prikaziSve();
                }
                else
                {
                    MessageBox.Show("Proizvod nije uklonjen!");
                }
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

        private void txtImeProizvoda_Enter(object sender, EventArgs e)
        {
            if(txtImeProizvoda.Text == "Unesite ime proizvoda...")
            {
                txtImeProizvoda.ForeColor = Color.Black;
                txtImeProizvoda.Text = "";
            }
        }

        private void txtImeProizvoda_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtImeProizvoda.Text))
            {
                txtImeProizvoda.ForeColor = Color.Gray;
                txtImeProizvoda.Text = "Unesite ime proizvoda...";
            }
        }

        private void txtImeProizvoda_TextChanged(object sender, EventArgs e)
        {
            string pretraga = "SELECT * FROM Proizvodi WHERE ime LIKE '%" + txtImeProizvoda.Text + "%'";
            SqlCommand komandaPretraga = new SqlCommand(pretraga, konekcija);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komandaPretraga);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
