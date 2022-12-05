using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoanQLKS
{
    internal class Modifyhanghoa
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifyhanghoa() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllHANGHOA()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from HANGHOA";
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
        public bool insert(Hanghoa hanghoa)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into HANGHOA values(@ID_HANGHOA,@ID_KHO,@TENHANG,@GIA,@DONVITINH,@SOLUONG)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = hanghoa.Id_hanghoa;
                sqlCommand.Parameters.Add("@ID_KHO", SqlDbType.NVarChar).Value = hanghoa.Id_kho;
                sqlCommand.Parameters.Add("@TENHANG", SqlDbType.NVarChar).Value = hanghoa.Tenhang;
                sqlCommand.Parameters.Add("@GIA", SqlDbType.Int).Value = hanghoa.Gia;
                sqlCommand.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = hanghoa.Donvitinh;
                sqlCommand.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = hanghoa.Soluong;
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
        public bool update(Hanghoa hanghoa)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update PHIEUNK Set ID_KHO=@ID_KHO,TENHANG =@TENHANG,GIA=@GIA,DONVITINH=@DONVITINH,SOLUONG=@SOLUONG Where ID_HANGHOA =@ID_HANGHOA";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = hanghoa.Id_hanghoa;
                sqlCommand.Parameters.Add("@ID_KHO", SqlDbType.NVarChar).Value = hanghoa.Id_kho;
                sqlCommand.Parameters.Add("@TENHANG", SqlDbType.NVarChar).Value = hanghoa.Tenhang;
                sqlCommand.Parameters.Add("@GIA", SqlDbType.Int).Value = hanghoa.Gia;
                sqlCommand.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = hanghoa.Donvitinh;
                sqlCommand.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = hanghoa.Soluong;
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
            string query = "delete HANGHOA where ID_HANGHOA =@ID_HANGHOA";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = id;
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
