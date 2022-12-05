using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DoanQLKS
{
    internal class Modifyxuatkho
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifyxuatkho() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllXUATKHO()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from PHIEUXK";
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
        public bool insert(qlxuatkho xuatkho)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PHIEUXK values(@ID_PXK,@ID_KHO,@ID_NHANVIEN,@ID_HANGHOA,@NGAYXK,@TONGSLXK,@TONGTIEN,@LYDOXK)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PXK", SqlDbType.NVarChar).Value = xuatkho.Id_pxk ;
                sqlCommand.Parameters.Add("@ID_KHO", SqlDbType.NVarChar).Value = xuatkho.Id_kho;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = xuatkho.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = xuatkho.Id_hanghoa;
                sqlCommand.Parameters.Add("@NGAYXK", SqlDbType.DateTime).Value = xuatkho.Ngayxk.ToShortDateString();
                sqlCommand.Parameters.Add("@TONGSLXK", SqlDbType.Int).Value = xuatkho.Tongslxk;
                sqlCommand.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = xuatkho.Tongtien;
                sqlCommand.Parameters.Add("@LYDOXK", SqlDbType.NVarChar).Value = xuatkho.Lydoxk;
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
        public bool update(qlxuatkho xuatkho)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update PHIEUXK Set ID_KHO=@ID_KHO,ID_NHANVIEN=@ID_NHANVIEN,ID_HANGHOA=@ID_HANGHOA,NGAYXK=@NGAYXK,TONGSLXK=@TONGSLXK,TONGTIEN=@TONGTIEN,LYDOXK=@LYDOXK Where ID_PXK =@ID_PXK";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PXK", SqlDbType.NVarChar).Value = xuatkho.Id_pxk;
                sqlCommand.Parameters.Add("@ID_KHO", SqlDbType.NVarChar).Value = xuatkho.Id_kho;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = xuatkho.Id_nhanvien;
                sqlCommand.Parameters.Add("@ID_HANGHOA", SqlDbType.NVarChar).Value = xuatkho.Id_hanghoa;
                sqlCommand.Parameters.Add("@NGAYXK", SqlDbType.DateTime).Value = xuatkho.Ngayxk.ToShortDateString();
                sqlCommand.Parameters.Add("@TONGSLXK", SqlDbType.Int).Value = xuatkho.Tongslxk;
                sqlCommand.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = xuatkho.Tongtien;
                sqlCommand.Parameters.Add("@LYDOXK", SqlDbType.NVarChar).Value = xuatkho.Lydoxk;
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
            string query = "delete PHIEUXK where ID_PXK =@ID_PXK";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_PXK", SqlDbType.NVarChar).Value = id;
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
