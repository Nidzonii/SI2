﻿using System;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtboxPassword.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxUsername.Focus();
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QQ1TU8ST;Initial Catalog=ProdavnicaRacunarskeOpreme;Integrated Security=True");
            string sqlQuery = "SELECT korisnicko_ime,sifra FROM Korisnik WHERE korisnicko_ime='" + txtboxUsername.Text + "' AND sifra='" + txtboxPassword.Text + "'";
            string sqlQueryRole;
            string role;
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn); ;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                sqlQueryRole = "SELECT ime_uloge FROM Uloga INNER JOIN Korisnik ON Korisnik.id_uloge=Uloga.id_uloge WHERE Korisnik.korisnicko_ime='" + txtboxUsername.Text + "' AND Korisnik.sifra='" + txtboxPassword.Text + "'";
                SqlCommand com = new SqlCommand(sqlQueryRole, conn);
                try
                {
                    conn.Open();
                    role = (string)com.ExecuteScalar();
                    switch (role)
                    {
                        case "administrator":
                            this.Hide();
                            AdminMDIParent a = new AdminMDIParent();
                            a.Show();
                            break;
                        default:
                            MessageBox.Show("Neispravna šifra i/ili korisničko ime");
                            break;
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik sa datim korisnickim imenom i/ili sifrom!");
                Clean();
            }
        }

        private void Clean()
        {
            txtboxUsername.Text = "";
            txtboxPassword.Text = "";
        }

    }
}