using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoanQLKS
{
    internal class Modifyphieugiuxe
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifyphieugiuxe() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllPHIEUGIUXE()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PHIEUGX";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(datatabel);
                sqlConnection.Close();
            }
            return datatabel;
        }
        public DataTable table(string query)
        {
            DataTable datatabel = new DataTable();
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(datatabel);
                sqlConnection.Close();
            }
            return datatabel;
        }
        public bool insert(Phieugiuxe phieugiuxe)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PHIEUGX values(@ID_PGX,@TGVAO,@TGRA)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PGX", SqlDbType.NVarChar).Value = phieugiuxe.Id_pgx;
                sqlCommand.Parameters.Add("@TGVAO", SqlDbType.DateTime).Value = phieugiuxe.Tgvao.ToShortTimeString();
                sqlCommand.Parameters.Add("@TGRA", SqlDbType.DateTime).Value = phieugiuxe.Tgra.ToShortTimeString();
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(Phieugiuxe phieugiuxe)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update PHIEUGX Set TGVAO=@TGVAO,TGRA=@TGRA Where ID_PGX =@ID_PGX";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PGX", SqlDbType.NVarChar).Value = phieugiuxe.Id_pgx;
                sqlCommand.Parameters.Add("@TGVAO", SqlDbType.DateTime).Value = phieugiuxe.Tgvao.ToShortTimeString();
                sqlCommand.Parameters.Add("@TGRA", SqlDbType.DateTime).Value = phieugiuxe.Tgra.ToShortTimeString();
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete PHIEUGX where ID_PGX =@ID_PGX";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PGX", SqlDbType.NVarChar).Value = id;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public List<List<string>> ReadData(string queryString)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-F759HE4\\SQLEXPRESS;Initial Catalog=QLKS_NEW;Integrated Security=True";


                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<List<string>> list = new List<List<string>>();
                if (reader == null)
                {
                    list.Add(new List<string>());
                }
                else
                {
                    while (reader.Read())
                    {
                        List<string> listChild = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listChild.Add(reader[i].ToString());
                        }
                        list.Add(listChild);
                    }
                }

                connection.Close();

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
