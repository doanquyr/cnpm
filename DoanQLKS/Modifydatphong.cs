using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoanQLKS
{
    internal class Modifydatphong
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifydatphong() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllDATPHONG()
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
        public bool insert(Datphong datphong)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PDATPHONG values(@ID_DATPHONG,@ID_KHACHHANG,@ID_PHONG,@ID_NHANVIEN,@NGAYDAT,@NGAYTRA,@TIENCOC,@TIENPHONG,@TRANGTHAI)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_DATPHONG", SqlDbType.NVarChar).Value = datphong.Id_datphong;
                sqlCommand.Parameters.Add("@ID_KHACHHANG", SqlDbType.NVarChar).Value = datphong.Id_khachhang;
                sqlCommand.Parameters.Add("@ID_PHONG", SqlDbType.NVarChar).Value = datphong.Id_phong;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = datphong.Id_nhanvien;
                sqlCommand.Parameters.Add("@NGAYDAT", SqlDbType.DateTime).Value = datphong.Ngaydat;
                sqlCommand.Parameters.Add("@NGAYTRA", SqlDbType.DateTime).Value = datphong.Ngaytra;
                sqlCommand.Parameters.Add("@TIENCOC", SqlDbType.Int).Value = datphong.Tiencoc;
                sqlCommand.Parameters.Add("@TIENPHONG", SqlDbType.Int).Value = datphong.Tienphong;
                sqlCommand.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = datphong.Trangthai;
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
