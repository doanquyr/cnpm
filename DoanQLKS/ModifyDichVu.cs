using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoanQLKS
{
    internal class ModifyDichVu
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public ModifyDichVu() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllDICHVU()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from DICHVU";
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
        public bool insert(Dichvu dichvu)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into DICHVU values(@ID_DICHVU,@ID_LDV,@TENDV,@DONGIA,@DONVITINH)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_DICHVU", SqlDbType.NVarChar).Value = dichvu.Id_dichvu;
                sqlCommand.Parameters.Add("@ID_LDV", SqlDbType.NVarChar).Value = dichvu.Id_loaidichvu;
                sqlCommand.Parameters.Add("@TENDV", SqlDbType.NVarChar).Value = dichvu.Tendichvu;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Int).Value = dichvu.Dongia;
                sqlCommand.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = dichvu.Donvitinh;
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
        public bool update(Dichvu dichvu)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update DICHVU Set ID_LDV= @ID_LDV,TENDV=@TENDV,DONGIA=@DONGIA,DONVITINH=@DONVITINH Where ID_DICHVU =@ID_DICHVU";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_DICHVU", SqlDbType.NVarChar).Value = dichvu.Id_dichvu;
                sqlCommand.Parameters.Add("@ID_LDV", SqlDbType.NVarChar).Value = dichvu.Id_loaidichvu;
                sqlCommand.Parameters.Add("@TENDV", SqlDbType.NVarChar).Value = dichvu.Tendichvu;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Int).Value = dichvu.Dongia;
                sqlCommand.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = dichvu.Donvitinh;
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
            string query = "delete DICHVU where ID_DICHVU =@ID_DICHVU";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_DICHVU", SqlDbType.NVarChar).Value = id;
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
