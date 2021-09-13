using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class SqlConnect
    {
        public SqlConnection connect2()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-eqb12pp;Initial Catalog=StaffRegDB;Integrated Security=True");
            baglanti.Open();
            return baglanti;

        }



    }
}
