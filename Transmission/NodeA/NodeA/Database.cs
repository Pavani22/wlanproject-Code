using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace NodeA
{
    class Database
    {
        public static SqlConnection Connection {
            get {
                return new SqlConnection(@"Data Source=HOME-CDFAD16DF2;Initial Catalog=WLS;Integrated Security=True");
            }
        }
    }
}
