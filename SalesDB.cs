using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject
{
    public class SalesDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\SalesDBData.mdf;"+
            "Integrated Security = True;";

            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
