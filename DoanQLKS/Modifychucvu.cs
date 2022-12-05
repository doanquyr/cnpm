using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoanQLKS
{
    internal class Modifychucvu
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public Modifychucvu() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllCHUCVU()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from CHUCVU";
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
        public bool insert(Chucvu chucvu)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into CHUCVU values(@ID_CHUCVU,@TENCV,@LUONG,@VITRI)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_CHUCVU", SqlDbType.NVarChar).Value = chucvu.Id_chucvu;
                sqlCommand.Parameters.Add("@TENCV", SqlDbType.NVarChar).Value = chucvu.Tencv;
                sqlCommand.Parameters.Add("@LUONG", SqlDbType.Int).Value = chucvu.Luong;
                sqlCommand.Parameters.Add("@VITRI", SqlDbType.NVarChar).Value = chucvu.Vitri;
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
        public bool update(Chucvu chucvu)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update CHUCVU Set TENCV=@TENCV,LUONG=@LUONG,VITRI=@VITRI Where ID_CHUCVU =@ID_CHUCVU";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_CHUCVU", SqlDbType.NVarChar).Value = chucvu.Id_chucvu;
                sqlCommand.Parameters.Add("@TENCV", SqlDbType.NVarChar).Value = chucvu.Tencv;
                sqlCommand.Parameters.Add("@LUONG", SqlDbType.Int).Value = chucvu.Luong;
                sqlCommand.Parameters.Add("@VITRI", SqlDbType.NVarChar).Value = chucvu.Vitri;
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
            string query = "delete CHUCVU where ID_CHUCVU =@ID_CHUCVU";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_CHUCVU", SqlDbType.NVarChar).Value = id;
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
