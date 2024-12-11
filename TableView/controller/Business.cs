using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SqlDers
{
    internal class Business
    {
        Connection connection =new Connection();
        public List<string> DataNameFinder()
        {
            List<string> tableName = new List<string>();
           
            using (connection.Baglanti())
            {
                string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';";
                using (SqlCommand cmd = new SqlCommand(query, connection.Baglanti()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tableName.Add(reader["TABLE_NAME"].ToString());
                        }
                    }
                }
            }
            return tableName;
        }

       
        public DataTable BringList(string name)
        {
            string query = "SELECT * FROM [dukkan].[dbo].[" + name + "]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.Baglanti());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public List<string> BringList2(string name)
        {
            List<string> liste = new List<string>();
            using (connection.Baglanti())
            {
                string query = "SELECT * FROM [firstTime].[dbo].[" + name + "]";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection.Baglanti()))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        string rowData = "";
                        foreach (var item in row.ItemArray)
                        {
                            rowData += item.ToString() + " ";
                        }
                        liste.Add(rowData.Trim());
                    }
                }
            }
            return liste;
        }




        public void Baglan()
        {
            try
            {
                connection.Baglanti().Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlanılamadı ya da zaten bağlı: " + ex.Message);
            }
        }
        private void BaglantiKes()
        {
            try
            {
                connection.Baglanti().Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı kesilemedi: " + ex.Message);
            }
        }


        /* public List<string> BringList(string name)
        {
            List<string> liste = new List<string>();
            using (connection.Baglanti()) 
            {
                string query = "SELECT * FROM [dukkan].[dbo].["+name+"]";
                using (SqlCommand cmd = new SqlCommand(query, connection.Baglanti()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(reader["*"].ToString());
                        }
                    }
                }

            }
            return liste;
        }*/

    }

}
