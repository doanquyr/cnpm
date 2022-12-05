using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoanQLKS
{
    internal class ModifyTaikhoan
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl

        public ModifyTaikhoan() { }
        public DataTable getAllTAIKHOAN()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from TAIKHOAN";
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
        public bool insert(Taikhoan taikhoan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into TAIKHOAN values(@ID_TK,@TENTK,@MATKHAU,@ID_NHANVIEN)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_TK", SqlDbType.NVarChar).Value = taikhoan.Id_tk;
                sqlCommand.Parameters.Add("@TENTK", SqlDbType.NVarChar).Value = taikhoan.Tentk;
                sqlCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = taikhoan.Matkhau;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = taikhoan.Id_nhanvien;
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
        public bool update(Taikhoan taikhoan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update TAIKHOAN Set TENTK =@TENTK,MATKHAU=@MATKHAU,ID_NHANVIEN=@ID_NHANVIEN Where ID_TK=@ID_TK";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@TENTK", SqlDbType.NVarChar).Value = taikhoan.Tentk;
                sqlCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = taikhoan.Matkhau;
                sqlCommand.Parameters.Add("@ID_NHANVIEN", SqlDbType.NVarChar).Value = taikhoan.Id_nhanvien;
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
            string query = "delete TAIKHOAN where ID_TK =@ID_TK";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_TK", SqlDbType.NVarChar).Value = id;
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
