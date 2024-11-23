using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        private string connectionString = "Data Source=DESKTOP-E73LS7L\\SQLEXPRESS;Initial Catalog=GROCERY_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        protected SqlConnection conn;

        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
