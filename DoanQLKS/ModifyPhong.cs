using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Data.Common;

namespace DoanQLKS
{
    internal class ModifyPhong
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public ModifyPhong() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllPHONG()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PHONG";
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
        public bool insert(Phong phong)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PHONG values(@ID_PHONG,@ID_LOAIPHONG,@DONGIA,@TANG,@TRANGTHAI)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHONG", SqlDbType.NVarChar).Value = phong.Id_phong;
                sqlCommand.Parameters.Add("@ID_LOAIPHONG", SqlDbType.NVarChar).Value = phong.Id_loaiphong;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Int).Value = phong.Dongia;
                sqlCommand.Parameters.Add("@TANG", SqlDbType.NVarChar).Value = phong.Tang;
                sqlCommand.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = phong.Trangthai;
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
        public bool update(Phong phong)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update PHONG Set ID_LOAIPHONG=@ID_LOAIPHONG,DONGIA =@DONGIA,TANG=@TANG,TRANGTHAI=@TRANGTHAI Where ID_PHONG =@ID_PHONG";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHONG", SqlDbType.NVarChar).Value = phong.Id_phong;
                sqlCommand.Parameters.Add("@ID_LOAIPHONG", SqlDbType.NVarChar).Value = phong.Id_loaiphong;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Int).Value = phong.Dongia;
                sqlCommand.Parameters.Add("@TANG", SqlDbType.NVarChar).Value = phong.Tang;
                sqlCommand.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = phong.Trangthai;
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
            string query = "delete PHONG where ID_PHONG =@ID_PHONG";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHONG", SqlDbType.NVarChar).Value = id;
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
