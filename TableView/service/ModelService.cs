using SqlDers.modell;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.controller.service
{
    internal class ModelService
    {
        Connection _connection;
        public ModelService()
        {
            _connection = new Connection();
        }
        public List<Model> getAll()
        {
            List<Model> Models = new List<Model>();
         
            string query = "SELECT * FROM [dukkan].[dbo].[tblModel]";
            using (SqlCommand cmd = new SqlCommand(query, _connection.Baglanti()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model yeni = new Model(Convert.ToInt32(reader["ModelKod"]), reader["Marka"].ToString(), reader["Model"].ToString());
                        Models.Add(yeni);
                    }
                }
            }
            return Models;

        }
    }
}
