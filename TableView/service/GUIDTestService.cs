using SqlDers.modell;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDers.service
{
    public class GUIDTestService
    {
        Connection _connection;
        public GUIDTestService()
        {
            _connection = new Connection();
        }
        public List<GUIDTest> getAll()
        {
            List<GUIDTest> gUIDTests = new List<GUIDTest>();
            
            string query = "SELECT * FROM [dukkan].[dbo].[GUIDTest]";
            using (SqlCommand cmd = new SqlCommand(query, _connection.Baglanti()))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GUIDTest yeni = new GUIDTest(Convert.ToInt32(reader["numara"]), reader["isim"].ToString() );
                        gUIDTests.Add(yeni);
                    }
                }
            } return gUIDTests;
               
        }
            

    }
}
