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
    

    public partial class Zamena : Form
    {
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
                String sql = "Select * From Racuni";
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
        #region Search User in Database on KEYBOARD
        public DataTable Search(string keywords)
        {
            //Static method to connect DB
            SqlConnection con = KonekcioniString.getKonekcija();
            //to hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //sql query to get data
                String sql = "Select * From Racuni WHERE vreme like '%" + keywords + "%'";
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

        public Zamena()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtNazivRacuna.Text;
            if (keywords != null)
            {
                DataTable dt = Search(keywords);
                dgvZamena.DataSource = dt;
            }
            else
            {
                DataTable dt = Select();
                dgvZamena.DataSource = dt;
            }
        }

        private void Zamena_Load(object sender, EventArgs e)
        {
            DataTable dt = Select();
            dgvZamena.DataSource = dt;
        }

        private void btnPonistavanjeRacuna_Click(object sender, EventArgs e)
        {
            string id = dgvZamena.CurrentRow.Cells[0].Value.ToString();
            SqlConnection con = KonekcioniString.getKonekcija();
            string sql = "UPDATE Racuni SET flag = 1 WHERE id_racuna = " + id;
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ponistili ste racun!!!");
        }
    }
}
