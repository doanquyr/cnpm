using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoanQLKS
{
    internal class Modifythexe
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifythexe() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllTHEXE()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from THEXE";
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
        public bool insert(Thexe thexe)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into THEXE values(@ID_THEXE,@ID_KHACHHANG,@ID_PGX,@SOXE,@LOAIXE)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_THEXE", SqlDbType.NVarChar).Value = thexe.Id_thexe;
                sqlCommand.Parameters.Add("@ID_KHACHHANG", SqlDbType.NVarChar).Value = thexe.Id_khachhang;
                sqlCommand.Parameters.Add("@ID_PGX", SqlDbType.NVarChar).Value = thexe.Id_pgx;
                sqlCommand.Parameters.Add("@SOXE", SqlDbType.NVarChar).Value = thexe.Soxe;
                sqlCommand.Parameters.Add("@LOAIXE", SqlDbType.NVarChar).Value = thexe.Loaixe;
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
        public bool update(Thexe thexe)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update THEXE Set ID_KHACHHANG=@ID_KHACHHANG,ID_PGX=@ID_PGX,SOXE=@SOXE,LOAIXE=@LOAIXE Where ID_THEXE =@ID_THEXE";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_THEXE", SqlDbType.NVarChar).Value = thexe.Id_thexe;
                sqlCommand.Parameters.Add("@ID_KHACHHANG", SqlDbType.NVarChar).Value = thexe.Id_khachhang;
                sqlCommand.Parameters.Add("@ID_PGX", SqlDbType.NVarChar).Value = thexe.Id_pgx;
                sqlCommand.Parameters.Add("@SOXE", SqlDbType.NVarChar).Value = thexe.Soxe;
                sqlCommand.Parameters.Add("@LOAIXE", SqlDbType.NVarChar).Value = thexe.Loaixe;
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
            string query = "delete THEXE where ID_THEXE =@ID_THEXE";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_THEXE", SqlDbType.NVarChar).Value = id;
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
