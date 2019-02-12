using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSoftware
{
    public partial class KomercijalistaPrikazFaktura : Form
    {
        public KomercijalistaPrikazFaktura()
        {
            InitializeComponent();
        }

        private void btnPrikaziFakturu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:/Users/nikol/source/repos/SI2PROJEKAT/Racuni";
            ofd.Filter = "PDF fajlovi (.pdf) | *.pdf";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF.src = ofd.FileName;
            }
        }
    }
}
