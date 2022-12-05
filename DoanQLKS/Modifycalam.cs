using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DoanQLKS
{
    internal class Modifycalam
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifycalam() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllCALAM()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from CALAM";
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
        public bool insert(Calam calam)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into CALAM values(@ID_CALAM,@ID_NHANVIEN,@THOIGIANBD,@THOIGIANKT)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_CALAM", SqlDbType.NVarChar).Value = calam.Id_calam;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = calam.Id_nhanvien;
                sqlCommand.Parameters.Add("@THOIGIANBD", SqlDbType.DateTime).Value = calam.Thoigianbd.ToShortTimeString();
                sqlCommand.Parameters.Add("@THOIGIANKT", SqlDbType.DateTime).Value = calam.Thoigiankt.ToShortTimeString();
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
        public bool update(Calam calam)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update CALAM Set ID_NHANVIEN= @ID_NHANVIEN,THOIGIANBD=@THOIGIANKT Where ID_CALAM =@ID_CALAM";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_CALAM", SqlDbType.NVarChar).Value = calam.Id_calam;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = calam.Id_nhanvien;
                sqlCommand.Parameters.Add("@THOIGIANBD", SqlDbType.DateTime).Value = calam.Thoigianbd.ToShortTimeString();
                sqlCommand.Parameters.Add("@THOIGIANKT", SqlDbType.DateTime).Value = calam.Thoigiankt.ToShortTimeString();
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
            string query = "delete CALAM where ID_CALAM =@ID_CALAM";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_CALAM", SqlDbType.NVarChar).Value = id;
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
