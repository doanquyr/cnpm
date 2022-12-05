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
    public partial class QLDATPHONG : Form
    {
        Modifydatphong modify;
        public QLDATPHONG()
        {
            InitializeComponent();
            modify = new Modifydatphong();
            string sql = "select * from KHACHHANG";
            List<List<string>> khachhang = modify.ReadData(sql);
            Dictionary<string, string> combosource = new Dictionary<string, string>();
            for (int i = 0; i < khachhang.Count; i++)
            {
                combosource.Add(khachhang[i][0],khachhang[i][1]);
                Cbbtenkhachhang.DataSource = new BindingSource(combosource, null);
                Cbbtenkhachhang.DisplayMember = "Value";
                Cbbtenkhachhang.ValueMember = "Key";
            }
            string sql1 = "select * from NHANVIEN";
            List<List<string>> nhanvien = modify.ReadData(sql1);
            for (int i = 0; i < nhanvien.Count; i++)
            {
                Cbbmanhienvien.Items.Add(nhanvien[i][0]);
            }
        }

        private void QLDATPHONG_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewdatphong.DataSource = modify.getAllDATPHONG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Datphong datphong;
        private void btndatphong_Click(object sender, EventArgs e)
        {
            string iddatphong = this.txtmadatphong.Text;
            string idkhachhang = this.txtMakhachhang.Text;
            string idphong = this.txtmaphong.Text;
            string idnhanvien = this.Cbbmanhienvien.SelectedItem.ToString();
            DateTime ngaydat = this.dateTimePickerngayden.Value;
            DateTime ngaytra = this.dateTimePickerngaydi.Value;
            string tc = this.txttiencoc.Text;
            int tiencoc = Int32.Parse(tc);
            string tp = this.txttienphong.Text;
            int tienphong = Int32.Parse(tp);
            string trangthai = this.txttrangthai.Text;
            datphong = new Datphong(iddatphong,idkhachhang,idphong,idnhanvien,ngaydat,ngaytra,tiencoc,tienphong,trangthai);
            if (modify.insert(datphong))
            {
                dataGridViewdatphong.DataSource = modify.getAllDATPHONG();
                MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            doitrangthai(idphong);
            QLDATPHONG_Load(sender,e);
        }

        private void dataGridViewdatphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewdatphong.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmaphong.Text = row.Cells[0].Value.ToString();
                txttienphong.Text = row.Cells[2].Value.ToString();                
            }
        }

        private void Cbbmakhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_KHACHHANG = ((KeyValuePair<string, string>)Cbbtenkhachhang.SelectedItem).Key;
            string sql = $"select * from KHACHHANG where ID_KHACHHANG = '{ID_KHACHHANG}'";
            List<List<string>> loaiphong = modify.ReadData(sql);
            txtMakhachhang.Text = loaiphong[0][0];
            
        }
        private void doitrangthai(string id)
        {
            string connectionString = "Data Source=DESKTOP-F759HE4\\SQLEXPRESS;Initial Catalog=QLKS_NEW;Integrated Security=True";
            string sql = "UPDATE PHONG" +
                          " SET TRANGTHAI = N'Đang Đặt'" +
                          $"WHERE ID_PHONG = '{id}'";
            SqlConnection sqlConnection= new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
