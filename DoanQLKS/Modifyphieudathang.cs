using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Modifyphieudathang
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifyphieudathang() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllDATHANG()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PHIEUDH";
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
        public bool insert(Dathang dathang)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PHIEUDH values(@ID_PHIEUDH,@ID_NHANVIEN,@ID_HANGHOA,@TONGSL,@TONGTIEN,@TENNCC)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHIEUDH", SqlDbType.NVarChar).Value = dathang.Id_phieudh;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = dathang.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = dathang.Id_hanghoa;
                sqlCommand.Parameters.Add("@TONGSL", SqlDbType.Int).Value = dathang.Tongsl;
                sqlCommand.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = dathang.Tongtien;
                sqlCommand.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = dathang.Tenncc;
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
        public bool update(Dathang dathang)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update PHIEUNK Set ID_NHANVIEN=@ID_NHANVIEN,ID_HANGHOA=@ID_HANGHOA,TONGSL=@TONGSL,TONGTIEN=@TONGTIEN,TONGTIEN=@TONGTIEN,TENNCC=@TENNCC Where ID_PHIEUDH =@ID_PHIEUDH";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHIEUDH", SqlDbType.NVarChar).Value = dathang.Id_phieudh;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = dathang.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = dathang.Id_hanghoa;
                sqlCommand.Parameters.Add("@TONGSL", SqlDbType.Int).Value = dathang.Tongsl;
                sqlCommand.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = dathang.Tongtien;
                sqlCommand.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = dathang.Tenncc;
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
            string query = "delete PHIEUDH where ID_PHIEUDH =@ID_PHIEUDH";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHIEUDH", SqlDbType.NVarChar).Value = id;
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
