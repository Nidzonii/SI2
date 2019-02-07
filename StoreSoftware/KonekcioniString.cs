using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSoftware
{
    class KonekcioniString
    {
        private static SqlConnection konekcija = new SqlConnection("Data Source=LAPTOP-QQ1TU8ST;Initial Catalog=ProdavnicaRacunarskeOpreme;Integrated Security=True");

        public static SqlConnection getKonekcija()
        {
            return konekcija;
        }
    }
}
