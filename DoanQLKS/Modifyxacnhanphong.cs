using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoanQLKS
{
    internal class Modifyxacnhanphong
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifyxacnhanphong() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllDATPHONG()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PDATPHONG";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(datatabel);
                sqlConnection.Close();
            }
            return datatabel;
        }
        public DataTable getAllXACNHANPHONG()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PHUYPHONG";
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
        public bool insert(Xacnhanphong xacnhan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PHUYPHONG values(@ID_HUYPHONG,@ID_DATPHONG,@ID_NHANVIEN,@NGAYHUY,@LYDOHUY)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_HUYPHONG", SqlDbType.NVarChar).Value = xacnhan.Id_huyphong;
                sqlCommand.Parameters.Add("@ID_DATPHONG", SqlDbType.NVarChar).Value = xacnhan.Id_datphong;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = xacnhan.Id_nhanvien;
                sqlCommand.Parameters.Add("@NGAYHUY", SqlDbType.DateTime).Value = xacnhan.Ngayhuy.ToShortDateString();
                sqlCommand.Parameters.Add("@LYDOHUY", SqlDbType.NVarChar).Value = xacnhan.Lydohuy;
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
