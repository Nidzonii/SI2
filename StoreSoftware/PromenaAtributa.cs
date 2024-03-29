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
    public partial class PromenaAtributa : Form
    {
        public PromenaAtributa()
        {
            InitializeComponent();
            PadajuciMeniKriterijum();
            PadajuciMeniProizvodi();
            PadajuciMeniKriterijumCena();
        }

        void PadajuciMeniProizvodi()
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();

            String meniProizvod = "SELECT ime FROM Proizvodi";
            SqlCommand komanda = new SqlCommand(meniProizvod, konekcija);
            SqlDataReader citac;
            konekcija.Open();
            try
            {
                
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    String _ime = citac["ime"].ToString();
                    comboBox1.Items.Add(_ime);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konekcija.Close();

                

        }

        void PadajuciMeniKriterijum()
        {
            comboBox2.Items.Add("ime");
            comboBox2.Items.Add("opis");
            comboBox2.Items.Add("cena");
            comboBox2.Items.Add("nabavna_cena");
            comboBox2.Items.Add("proizvodjac");
            comboBox2.Items.Add("kategorija");
            comboBox2.Items.Add("broj_na_stanju");
            comboBox2.Items.Add("duzina_garantnog_roka");
            comboBox2.Items.Add("link");
        }

        void PadajuciMeniKriterijumCena()
        {

            comboBox3.Items.Add("proizvodjac");
            comboBox3.Items.Add("kategorija");


        }
        private void PromenaAtr_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();

            try
            {
                konekcija.Open();
                if (textBoxNovaVr.Text is String)
                {
                    String promena = "UPDATE Proizvodi SET " + comboBox2.Text + " = '" + textBoxNovaVr.Text + "' WHERE ime = '" + comboBox1.Text + "'";
                    SqlCommand komanda = new SqlCommand(promena, konekcija);

                    int provera = komanda.ExecuteNonQuery();
                    if (provera > 0)
                    {
                        MessageBox.Show("Proizvod je uspešno izmenjen!");
                    }
                    else
                    {
                        MessageBox.Show("Proizvod nije izmenjen!");
                    }


                }
                else
                {
                    String promena = "UPDATE Proizvodi SET " + comboBox2.Text + " = " + textBoxNovaVr.Text + " WHERE ime = '" + comboBox1.Text + "'";
                    SqlCommand komanda = new SqlCommand(promena, konekcija);

                    int provera = komanda.ExecuteNonQuery();
                    if (provera > 0)
                    {
                        MessageBox.Show("Proizvod je uspešno izmenjen!");
                    }
                    else
                    {
                        MessageBox.Show("Proizvod nije izmenjen!");
                    }
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

        private void promenaCene_Click_1(object sender, EventArgs e)
        {
            SqlConnection konekcija = KonekcioniString.getKonekcija();
            try
            {
                string izbor = comboBox3.Text;
                string promena = "UPDATE Proizvodi SET cena='" + textBoxCena.Text + "' WHERE " + izbor + "='" + textBoxNaziv.Text + "'";
                SqlCommand komanda = new SqlCommand(promena, konekcija);

                konekcija.Open();
                int provera = komanda.ExecuteNonQuery();
                if (provera > 0)
                {
                    MessageBox.Show("Cena grupe proizvoda je uspešno izmenjena!");
                }
                else
                {
                    MessageBox.Show("Cena grupe proizvoda nije izmenjena!");

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
    }
}
