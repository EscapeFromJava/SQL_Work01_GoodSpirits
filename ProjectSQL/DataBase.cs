using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectSQL
{
    class DataBase
    {
        private readonly string _connstring;

        public struct Store
        {
            public string From { get; set; }
            public string To { get; set; }
            public int Cost { get; set; }
        }

        public DataBase(string connstring)
        {
            _connstring = connstring;
        }

        public IEnumerable<Store> GetProdList()
        {
            var connection = new SqlConnection(_connstring);
            try
            {
                connection.Open();
                var prodList = new List<Store>();
                var select = new SqlCommand("select * from dbo.universe", connection);
                var reader = select.ExecuteReader();

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var newProd = new Store
                        {
                            From = reader[0].ToString(),
                            To = reader[1].ToString(),
                            Cost = int.Parse(reader[2].ToString())
                        };
                        prodList.Add(newProd);
                    }
                    reader.Close();
                }
                connection.Close();
                return prodList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Store>();
            }
        }

        public bool AddNewProd(string fromP, string toP, int costP)
        {
            var connection = new SqlConnection(_connstring);
            try
            {
                connection.Open();
                string cmd = "insert into dbo.universe([from planet],[to planet],[cost transition]) values('" + fromP + "', '" + toP + "', " + costP + @")";
                var insert = new SqlCommand(cmd, connection);
                insert.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
                return false;
            }
        }

        public bool DeleteProd(int id)
        {
            var connection = new SqlConnection(_connstring);
            try
            {
                connection.Open();
                string cmd = "delete from universe WHERE id = " + id;
                var insert = new SqlCommand(cmd, connection);
                insert.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
                return false;
            }
        }
    }
}
