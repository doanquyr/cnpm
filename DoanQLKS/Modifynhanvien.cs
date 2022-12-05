using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoanQLKS
{
    internal class Modifynhanvien
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifynhanvien() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllNHANVIEN()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from NHANVIEN ";
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
        public bool insert(nhanvien nhanvien1)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into NHANVIEN values(@ID_NHANVIEN,@ID_CHUCVU,@HOVATEN,@NGAYSINH,@CMND,@GIOITINH,@SDT,@DIACHI,@EMAIL)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = nhanvien1.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_CHUCVU", SqlDbType.NVarChar).Value = nhanvien1.Id_nhanvien;
                sqlCommand.Parameters.Add("@HOVATEN", SqlDbType.NVarChar).Value = nhanvien1.Ten_nhanvien;
                sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = nhanvien1.Ngaysinh.ToShortDateString();
                sqlCommand.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = nhanvien1.Cmnd;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = nhanvien1.Gioitinh;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanvien1.Sdt;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nhanvien1.Diachi;
                sqlCommand.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = nhanvien1.Email;
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
        public bool update(nhanvien nhanvien1)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update NHANVIEN Set ID_CHUCVU=@ID_CHUCVU,HOVATEN= @HOVATEN,NGAYSINH=@NGAYSINH,CMND =@CMND,GIOITINH=@GIOITINH,SDT=@SDT,DIACHI=@DIACHI,EMAIL=@EMAIL Where ID_NHANVIEN =@ID_NHANVIEN";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = nhanvien1.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_CHUCVU", SqlDbType.NVarChar).Value = nhanvien1.Id_nhanvien;
                sqlCommand.Parameters.Add("@HOVATEN", SqlDbType.NVarChar).Value = nhanvien1.Ten_nhanvien;
                sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = nhanvien1.Ngaysinh.ToShortDateString();
                sqlCommand.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = nhanvien1.Cmnd;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = nhanvien1.Gioitinh;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanvien1.Sdt;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nhanvien1.Diachi;
                sqlCommand.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = nhanvien1.Email;
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
            string query = "delete NHANVIEN where ID_NHANVIEN =@ID_NHANVIEN";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = id;
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
