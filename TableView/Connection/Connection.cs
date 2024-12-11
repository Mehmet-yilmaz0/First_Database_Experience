using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlDers
{
    internal class Connection
    {
        public SqlConnection Baglanti()
        {
            //SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-2IMIUFP\SQLEXPRESS;Integrated Security=True; TrustServerCertificate=True");
            string connectionString = "Server=DESKTOP-2IMIUFP\\SQLEXPRESS; Database=dukkan;Integrated Security=True;";
            SqlConnection baglan = new SqlConnection(connectionString);
            baglan.Open();
            return baglan;
        }
    }
}