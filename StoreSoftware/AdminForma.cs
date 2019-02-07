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
        public AdminForma()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void izmenaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();
            try
            {
                String uklanjanje = "DELETE FROM Proizvodi WHERE id_proizvoda='" + textBoxBarcode.Text + "'";
                SqlCommand komanda = new SqlCommand(uklanjanje, konekcija);

                konekcija.Open();
                int provera = komanda.ExecuteNonQuery();
                if (provera > 0)
                {
                    MessageBox.Show("Uspesno uklonjen proizvod!");
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
        }
    }
}
