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
    public partial class Pomoc : Form
    {
        private SqlConnection konekcija = KonekcioniString.getKonekcija();
        public Pomoc()
        {
            InitializeComponent();
        }

        private void Pomoc_Load(object sender, EventArgs e)
        {
            string s = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();

            try
            {
                string uloga = "SELECT id_uloge FROM Korisnik WHERE korisnicko_ime='" + login.korisnickoIme + "'";
                SqlCommand komanda = new SqlCommand(uloga, konekcija);
                konekcija.Open();
                int idUloge = Convert.ToInt32(komanda.ExecuteScalar());
                string strFileName;
                string fileText;
                if (idUloge == 1 || idUloge == 2)
                {
                    strFileName = @s + @"\Pomoc\Administrator.txt";
                    fileText = File.ReadAllText(strFileName);
                    richTextBox1.Text = fileText;
                }
                else if(idUloge == 3)
                {
                    strFileName = @s + @"\Pomoc\Komercijalista.txt";
                    fileText = File.ReadAllText(strFileName);
                    richTextBox1.Text = fileText;
                }else if(idUloge == 4)
                {
                    strFileName = @s + @"\Pomoc\Radnik.txt";
                    fileText = File.ReadAllText(strFileName);
                    richTextBox1.Text = fileText;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}
