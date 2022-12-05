using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoanQLKS
{
    internal class ModyfiThanhtoan
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public ModyfiThanhtoan() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllDATDICHVU()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from HOADON";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(datatabel);
                sqlConnection.Close();
            }
            return datatabel;
        }
        public DataTable getAllHIENDATPHONG()
        {
            DataTable datatabel = new DataTable();
            string query = "select ID_DATPHONG,ID_PHONG,NGAYDAT,NGAYTRA,TIENCOC,TIENPHONG from PDATPHONG WHERE TRANGTHAI LIKE N'Đang Đặt Phòng'";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(datatabel);
                sqlConnection.Close();
            }
            return datatabel;
        }
        public DataTable getAllHIENDICHVU()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PDATDV";
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
        public bool insert(Thanhtoan1 thanhtoan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into HOADON values(@ID_HOADON,@ID_NHANVIEN,@ID_UUDAI,@ID_DATPHONG,@TIENPHONG,@TIENDV,@TONGTIEN)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_HOADON", SqlDbType.NVarChar).Value = thanhtoan.Id_hoadon;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = thanhtoan.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_UUDAI", SqlDbType.NVarChar).Value = thanhtoan.Id_uudai;
                sqlCommand.Parameters.Add("@ID_DATPHONG", SqlDbType.NVarChar).Value = thanhtoan.Id_datphong;
                sqlCommand.Parameters.Add("@TIENPHONG", SqlDbType.Int).Value = thanhtoan.Tienphong;
                sqlCommand.Parameters.Add("@TIENDV", SqlDbType.Int).Value = thanhtoan.Tiendv;
                sqlCommand.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = thanhtoan.Tongtien;
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
