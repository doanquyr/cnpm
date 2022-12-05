using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Modifykhuyenmai
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifykhuyenmai() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllKHUYENMAI()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from UUDAI";
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
        public bool insert(Khuyenmai khuyenmai)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into UUDAI values(@ID_UUDAI,@DONVI)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_UUDAI", SqlDbType.NVarChar).Value = khuyenmai.Id_uudai;
                sqlCommand.Parameters.Add("@DONVI", SqlDbType.Int).Value = khuyenmai.Donvi;
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
        public bool update(Khuyenmai khuyenmai)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update UUDAI Set DONVI=@DONVI Where ID_UUDAI =@ID_UUDAI";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_UUDAI", SqlDbType.NVarChar).Value = khuyenmai.Id_uudai;
                sqlCommand.Parameters.Add("@DONVI", SqlDbType.Int).Value = khuyenmai.Donvi;
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
            string query = "delete UUDAI where ID_UUDAI =@ID_UUDAI";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_UUDAI", SqlDbType.NVarChar).Value = id;
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
    }
}
