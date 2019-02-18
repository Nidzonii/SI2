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
    public partial class FormaSlika : Form
    {
        public FormaSlika(int id)
        {
            InitializeComponent();
            string idPutanja = System.Convert.ToString(id);
            Bitmap bmp = new Bitmap("C:\\Users\\nikol\\source\\repos\\SI2PROJEKAT\\Slike\\" + idPutanja + ".jpg");
            pictureBox1.Image = bmp;
        }

        private void FormaSlika_Load(object sender, EventArgs e)
        {

        }
    }
}
