using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ilerinesnetaban
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=Otobus_Db;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
