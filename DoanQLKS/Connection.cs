using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Connection
    {
        private static String stringConnection = @"Data Source=DESKTOP-F759HE4\SQLEXPRESS;Initial Catalog=QLKS_NEW;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
