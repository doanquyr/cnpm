using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoanQLKS
{
    internal class ModifyQLKH
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        SqlCommand sqlCommand; // dung de truy van va cap nhat toi csdl
        public ModifyQLKH() { }
        // datable trả về 1 bảng 
        // dataset trả về nhiều bảng
        public DataTable getAllKH()
        {
            DataTable datatabel = new DataTable();
            string query = "select * from KHACHHANG";
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
        public bool insert(Khachhang khachhang)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into KHACHHANG values(@ID_KHACHHANG,@HOVATEN,@NGAYSINH,@CMND,@GIOITINH,@SDT,@DIACHI,@EMAIL)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_KHACHHANG", SqlDbType.NVarChar).Value = khachhang.Id_khachhang;
                sqlCommand.Parameters.Add("@HOVATEN", SqlDbType.NVarChar).Value = khachhang.Ten_Khachhang;
                sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = khachhang.Ngaysinh.ToShortDateString();
                sqlCommand.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = khachhang.Cmnd;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = khachhang.Gioitinh;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = khachhang.Sdt;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = khachhang.Diachi;
                sqlCommand.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = khachhang.Email;
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
        public bool update(Khachhang Khachhang)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query1 = "update KHACHHANG Set HOVATEN= @HOVATEN,CMND =@CMND,SDT=@SDT,DIACHI=@DIACHI,EMAIL=@EMAIL,NGAYSINH=@NGAYSINH,GIOITINH=@GIOITINH Where ID_KHACHHANG =@ID_KHACHHANG";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@ID_KHACHHANG", SqlDbType.NVarChar).Value = Khachhang.Id_khachhang;
                sqlCommand.Parameters.Add("@HOVATEN", SqlDbType.NVarChar).Value = Khachhang.Ten_Khachhang;
                sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = Khachhang.Ngaysinh.ToShortDateString();
                sqlCommand.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = Khachhang.Cmnd;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = Khachhang.Gioitinh;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = Khachhang.Sdt;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = Khachhang.Diachi;
                sqlCommand.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = Khachhang.Email;
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
            string query = "delete KHACHHANG where ID_KHACHHANG =@ID_KHACHHANG";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_KHACHHANG", SqlDbType.NVarChar).Value = id;
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

