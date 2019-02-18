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
    public partial class login : Form
    {
        public static string korisnickoIme;

        public login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxUsername.Focus();
            SqlConnection conn = KonekcioniString.getKonekcija();
            if (String.IsNullOrEmpty(txtboxPassword.Text) || String.IsNullOrEmpty(txtboxUsername.Text))
            {
                MessageBox.Show("Moraju se uneti sva polja!");
            }
            else
            {
                korisnickoIme = txtboxUsername.Text;
                string hesovanaSifra = HesovanjeSifre.enkripcija(txtboxPassword.Text);
                string sqlQuery = "SELECT korisnicko_ime,sifra FROM Korisnik WHERE korisnicko_ime='" + txtboxUsername.Text + "' AND sifra='" + hesovanaSifra + "'";
                string sqlQueryRole;
                string role;
                SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    sqlQueryRole = "SELECT ime_uloge FROM Uloga INNER JOIN Korisnik ON Korisnik.id_uloge=Uloga.id_uloge WHERE Korisnik.korisnicko_ime='" + txtboxUsername.Text + "' AND Korisnik.sifra='" + hesovanaSifra + "'";
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
                                AutomatizovanaRadnjaB.AutomatizovanaRadnja();
                                break;
                            case "komercijalista":
                                this.Hide();
                                KomercijalistaMDIParent k = new KomercijalistaMDIParent();
                                k.Show();
                                AutomatizovanaRadnjaB.AutomatizovanaRadnja();
                                break;
                            case "radnik":
                                this.Hide();
                                RadnikMDIParent r = new RadnikMDIParent();
                                r.Show();
                                break;
                            case "vlasnik":
                                this.Hide();
                                AdminMDIParent v = new AdminMDIParent();
                                v.Show();
                                AutomatizovanaRadnjaB.AutomatizovanaRadnja();
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
                    MessageBox.Show("Neispravno uneto korisničko ime i/ili šifra!");
                    Clean();
                }
            }
        }

        private void Clean()
        {
            txtboxUsername.Text = "";
            txtboxPassword.Text = "";
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }
    }
}