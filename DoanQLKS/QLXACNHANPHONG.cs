using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanQLKS
{
    public partial class QLXACNHANPHONG : Form
    {
        Modifyxacnhanphong modify;
        public QLXACNHANPHONG()
        {
            modify = new Modifyxacnhanphong();
            InitializeComponent();
            string sql = "select * from NHANVIEN";
            List<List<string>> nhanvien = modify.ReadData(sql);
            for (int i = 0; i < nhanvien.Count; i++) 
            {
                Cbbmanhanvien.Items.Add(nhanvien[i][0]);
            }
        }

        private void QLXACNHANPHONG_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewhuyphong.DataSource = modify.getAllXACNHANPHONG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                dataGridViewdatphong.DataSource = modify.getAllDATPHONG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Xacnhanphong xacnhan;
        private void btnthemkh_Click(object sender, EventArgs e)
        {
            string idhuyphong = this.txtmahuyphong.Text;
            string iddatphong = this.txtMadatphong.Text;
            string idphong = this.txtidphong.Text;
            string idnhanvien = this.Cbbmanhanvien.SelectedItem.ToString();
            DateTime ngayhuy = this.dateTimePickerngayhuy.Value;
            string lydohuy = this.txtLydo.Text;
            xacnhan = new Xacnhanphong(idhuyphong,iddatphong,idnhanvien,ngayhuy,lydohuy);
            if (modify.insert(xacnhan))
            {
                dataGridViewhuyphong.DataSource = modify.getAllXACNHANPHONG();
                MessageBox.Show("Xác nhận hủy thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            doitrangthaiphong(idphong);
            doitrangthaidatphong(iddatphong);
            QLXACNHANPHONG_Load(sender, e);
        }

        private void dataGridViewdatphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewdatphong.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMadatphong.Text = row.Cells[0].Value.ToString();
                txtidphong.Text = row.Cells[2].Value.ToString();
            }
        }private void doitrangthaiphong(string id)
        {
            string connectionString = "Data Source=DESKTOP-F759HE4\\SQLEXPRESS;Initial Catalog=QLKS_NEW;Integrated Security=True";
            string sql = "UPDATE PHONG" +
                          " SET TRANGTHAI = N'Trống'" +
                          $"WHERE ID_PHONG = '{id}'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        
        private void doitrangthaidatphong(string id)
        {
            string connectionString = "Data Source=DESKTOP-F759HE4\\SQLEXPRESS;Initial Catalog=QLKS_NEW;Integrated Security=True";
            string sql = "UPDATE PDATPHONG" +
                          " SET TRANGTHAI = N'Đã Thanh Toán'" +
                          $"WHERE ID_DATPHONG = '{id}'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iddatphong = this.txtMadatphong.Text;
            doitrangthaidatphong1(iddatphong);
            MessageBox.Show("Xác nhận thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            QLXACNHANPHONG_Load(sender, e);

        }
        private void doitrangthaidatphong1(string id)
        {
            string connectionString = "Data Source=DESKTOP-F759HE4\\SQLEXPRESS;Initial Catalog=QLKS_NEW;Integrated Security=True";
            string sql = "UPDATE PDATPHONG" +
                          " SET TRANGTHAI = N'Đang Đặt Phòng'" +
                          $"WHERE ID_DATPHONG = '{id}'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
