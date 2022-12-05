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
    public partial class Thanhtoan : Form
    {
        ModyfiThanhtoan modify;
        public Thanhtoan()
        {
            InitializeComponent();
            modify = new ModyfiThanhtoan();
            string sql = "select * from NHANVIEN";
            List<List<string>> nhanvien = modify.ReadData(sql);
            for (int i = 0;i < nhanvien.Count; i++)
            {
                Cbbmanhanvien.Items.Add(nhanvien[i][0]);
            }
            string sql1 = "select * from UUDAI";
            List<List<string>> uudai  = modify.ReadData(sql1);
            for (int i = 0; i < uudai.Count; i++)
            {
                Cbbmakhuyenmai.Items.Add(uudai[i][0]);
            }
            string slq2 = "select * from PDATPHONG WHERE TRANGTHAI LIKE N'Đang Đặt Phòng'";
            List<List<string>> pdatphong = modify.ReadData(slq2);
            for (int i = 0; i < pdatphong.Count; i++)
            {
                Cbbphieudatphong.Items.Add(pdatphong[i][0]);
            }
        }
        Thanhtoan1 thanhtoan;
        private void btnthemdichvu_Click(object sender, EventArgs e)
        {
            string idhoadon = this.txtmahoadon.Text;
            string idnhanvien = this.Cbbmanhanvien.SelectedItem.ToString();
            string uudai = this.Cbbmakhuyenmai.SelectedItem.ToString();
            string datphong = this.Cbbphieudatphong.SelectedItem.ToString();
            string tp = this.txttienphong.Text;
            int tienphong = Int32.Parse(tp);
            string tdv = this.txttiendichvu.Text;
            int tiendv = Int32.Parse(tdv);
            string tt = this.txttongtien.Text;
            int tongtien = Int32.Parse(tt);
            thanhtoan = new Thanhtoan1(idhoadon,idnhanvien,uudai,datphong,tienphong,tiendv,tongtien);
            if (modify.insert(thanhtoan))
            {
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            doitrangthaidatphong(datphong);
            doitrangthaiphong(idphong);
        }

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.getAllHIENDATPHONG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                dataGridView2.DataSource = modify.getAllHIENDICHVU();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string idphong;
        private void Cbbphieudatphong_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            string connectionString = "Data Source=DESKTOP-F759HE4\\SQLEXPRESS;Initial Catalog=QLKS_NEW;Integrated Security=True";
            string sql = "select ID_DATPHONG,ID_PHONG,NGAYDAT,NGAYTRA,TIENCOC,TIENPHONG from PDATPHONG WHERE ID_DATPHONG" +
                $" = '{Cbbphieudatphong.SelectedItem.ToString()}' ";
            List<List<string>> datphong = modify.ReadData(sql);
            dataGridView1.Columns.Add("ID_DATPHONG", "ID_DATPHONG");
            dataGridView1.Columns.Add("ID_PHONG", "ID_PHONG");
            dataGridView1.Columns.Add("NGAYDAT", "NGAYDAT");
            dataGridView1.Columns.Add("NGAYTRA", "NGAYTRA");
            dataGridView1.Columns.Add("TIENCOC", "TIENCOC");
            dataGridView1.Columns.Add("TIENPHONG", "TIENPHONG");
            dataGridView1.Rows.Add(datphong[0].ToArray());
            string sql1 = "select ID_DATPHONG,ID_DICHVU,SOLUONG,DONGIA,DONVITINH from PDATDV WHERE ID_DATPHONG" +
                $" = '{Cbbphieudatphong.SelectedItem.ToString()}' ";
            List<List<string>> dichvu = modify.ReadData(sql1);
            dataGridView2.Columns.Add("ID_DATPHONG", "ID_DATPHONG");
            dataGridView2.Columns.Add("ID_DICHVU", "ID_DICHVU");
            dataGridView2.Columns.Add("SOLUONG", "SOLUONG");
            dataGridView2.Columns.Add("DONGIA", "DONGIA");
            dataGridView2.Columns.Add("DONVITINH", "DONVITINH");
            if(dichvu.Count > 0)
            {
                for(int i = 0;i < dichvu.Count; i++) 
                    dataGridView2.Rows.Add(dichvu[i].ToArray());
            }
            else
            {
                return;
            }
            txtmaphong.Text = datphong[0][1].ToString();
            idphong = txtmaphong.Text;
            string sql2 = $"select DATEDIFF(DAY,'{datphong[0][2]}','{datphong[0][3]}')";
            List<List<string>> tinhngay = modify.ReadData(sql2);
            int ngay = Int32.Parse(tinhngay[0][0]);
            int dongia = Int32.Parse((datphong[0][5]));
            int tiencoc = Int32.Parse(datphong[0][4]);
            int tienphong = (ngay * dongia) - tiencoc;
            txttienphong.Text = tienphong.ToString();
            int soluong = Int32.Parse(dichvu[0][2]);
            int dongia1 = Int32.Parse(dichvu[0][3]);
            int tiendichvu = soluong * dongia1;
            txttiendichvu.Text = tiendichvu.ToString();
            int tienuudai = (((ngay * dongia) - tiencoc) + (soluong * dongia1))*uudai/100;
            int tongtien = (((ngay * dongia) - tiencoc) + (soluong * dongia1))- tienuudai;
            txttongtien.Text = tongtien.ToString();


        }
        public int uudai;
        private void Cbbmakhuyenmai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql4 = "select DONVI FROM UUDAI WHERE ID_UUDAI" +
                $" = '{Cbbmakhuyenmai.SelectedItem.ToString()}'";
            List<List<string>> mauudai = modify.ReadData(sql4);
            uudai = Int32.Parse(mauudai[0][0]);
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
        private void doitrangthaiphong(string id)
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
    }
}
