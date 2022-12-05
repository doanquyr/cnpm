using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoanQLKS
{
    internal class Modifydatdichvu
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifydatdichvu() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllDATDICHVU()
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
        public bool insert(Datdichvu datdichvu)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into PDATDV values(@ID_DATPHONG,@ID_DICHVU,@SOLUONG,@DONGIA,@DONVITINH)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_DATPHONG", SqlDbType.NVarChar).Value = datdichvu.Id_datphong;
                sqlCommand.Parameters.Add("@ID_DICHVU", SqlDbType.NVarChar).Value = datdichvu.Id_dichvu;
                sqlCommand.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = datdichvu.Soluong;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Int).Value = datdichvu.Dongia;
                sqlCommand.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = datdichvu.Donvitinh;
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
        public bool update(Datdichvu datdichvu)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update PDATDV Set ID_DICHVU= @ID_DICHVU,SOLUONG=@SOLUONG,DONGIA=@DONGIA,DONVITINH=@DONVITINH Where ID_DATPHONG =@ID_DATPHONG";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_DATPHONG", SqlDbType.NVarChar).Value = datdichvu.Id_datphong;
                sqlCommand.Parameters.Add("@ID_DICHVU", SqlDbType.NVarChar).Value = datdichvu.Id_dichvu;
                sqlCommand.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = datdichvu.Soluong;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Int).Value = datdichvu.Dongia;
                sqlCommand.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = datdichvu.Donvitinh;
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
            string query = "delete PDATDV where ID_DATPHONG =@ID_DATPHONG";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_DATPHONG", SqlDbType.NVarChar).Value = id;
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
