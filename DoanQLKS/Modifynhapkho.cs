using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoanQLKS
{
    internal class Modifynhapkho
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifynhapkho() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllNHAPKHO()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PHIEUNK";
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
        public bool insert(quanlynhapkho nhapkho)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PHIEUNK values(@ID_PHIEUNK,@ID_KHO,@ID_NHANVIEN,@ID_HANGHOA,@NGAYNK,@SLNHAP,@TONGTIEN,@TENNGUOIGIAO,@GHICHU)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHIEUNK", SqlDbType.NVarChar).Value = nhapkho.Id_phieunk;
                sqlCommand.Parameters.Add("@ID_KHO", SqlDbType.NVarChar).Value = nhapkho.Id_kho;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = nhapkho.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = nhapkho.Id_hanghoa;
                sqlCommand.Parameters.Add("@NGAYNK", SqlDbType.DateTime).Value = nhapkho.Ngaynk.ToShortDateString();
                sqlCommand.Parameters.Add("@SLNHAP", SqlDbType.Int).Value = nhapkho.Slnhap;
                sqlCommand.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = nhapkho.Tongtien;
                sqlCommand.Parameters.Add("@TENNGUOIGIAO", SqlDbType.NVarChar).Value = nhapkho.Tennguoigiao;
                sqlCommand.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = nhapkho.Ghichu;
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
        public bool update(quanlynhapkho nhapkho)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update PHIEUNK Set ID_KHO=@ID_KHO,ID_NHANVIEN=@ID_NHANVIEN,ID_HANGHOA=@ID_HANGHOA,NGAYNK=@NGAYNK,SLNHAP=@SLNHAP,TONGTIEN=@TONGTIEN,TENNGUOIGIAO=@TENNGUOIGIAO,GHICHU=@GHICHU Where ID_PHIEUNK =@ID_PHIEUNK";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHIEUNK", SqlDbType.NVarChar).Value = nhapkho.Id_phieunk;
                sqlCommand.Parameters.Add("@ID_KHO", SqlDbType.NVarChar).Value = nhapkho.Id_kho;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = nhapkho.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = nhapkho.Id_hanghoa;
                sqlCommand.Parameters.Add("@NGAYNK", SqlDbType.DateTime).Value = nhapkho.Ngaynk.ToShortDateString();
                sqlCommand.Parameters.Add("@SLNHAP", SqlDbType.Int).Value = nhapkho.Slnhap;
                sqlCommand.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = nhapkho.Tongtien;
                sqlCommand.Parameters.Add("@TENNGUOIGIAO", SqlDbType.NVarChar).Value = nhapkho.Tennguoigiao;
                sqlCommand.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = nhapkho.Ghichu;
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
            string query = "delete PHIEUNK where ID_PHIEUNK =@ID_PHIEUNK";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PHIEUNK", SqlDbType.NVarChar).Value = id;
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
