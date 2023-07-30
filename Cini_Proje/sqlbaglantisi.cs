using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cini_Proje
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-TOR5BH4;Initial Catalog=CiniDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
