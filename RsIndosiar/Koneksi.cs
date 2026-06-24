using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RsIndosiar
{
    public class Koneksi
    {

        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";


        public SqlConnection GetConn()
        {
            return new SqlConnection(connStr);
        }

    }
}
