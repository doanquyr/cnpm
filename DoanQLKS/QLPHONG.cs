using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoanQLKS
{
    public partial class QLPHONG : Form
    {
        ModifyPhong modify;
        public QLPHONG()
        {
            InitializeComponent();
            modify = new ModifyPhong();
            string sql = "select * from LOAIPHONG";
            List<List<string>> loaiphong = modify.ReadData(sql);
            Dictionary<string,string> combosource = new Dictionary<string,string>();
            for (int i = 0;i < loaiphong.Count; i++)
            {
                combosource.Add(loaiphong[i][0], loaiphong[i][1]);
                Cbbloaiphong.DataSource = new BindingSource(combosource, null);
                Cbbloaiphong.DisplayMember = "Value";
                Cbbloaiphong.ValueMember = "Key";
            }
        }
        private void QLPHONG_Load(object sender, EventArgs e)
        {
            
            try
            {
                dataGridViewPHONG.DataSource = modify.getAllPHONG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        Phong phong;
        private void btnthemphong_Click(object sender, EventArgs e)
        {
            string idphong = this.txtmaphong.Text;
            string maloaiphong = this.txtMaLoaiPhong.Text;
            string dongia1 = this.txtDongia.Text;
            int dongia = int.Parse(dongia1);
            string tang  = this.txtTang.Text;
            string trangthai = this.TXTTRANGTHAI.Text;
            phong = new Phong(idphong,maloaiphong,dongia,tang,trangthai);
            if (modify.insert(phong))
            {
                dataGridViewPHONG.DataSource = modify.getAllPHONG();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsuaphong_Click(object sender, EventArgs e)
        {
            string idphong = this.txtmaphong.Text;
            string maloaiphong = this.txtMaLoaiPhong.Text;
            string dongia1 = this.txtDongia.Text;
            int dongia = int.Parse(dongia1);
            string tang = this.txtTang.Text;
            string trangthai = this.TXTTRANGTHAI.Text;
            phong = new Phong(idphong, maloaiphong, dongia, tang, trangthai);
            if (modify.update(phong))
            {
                dataGridViewPHONG.DataSource = modify.getAllPHONG();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoaphong_Click(object sender, EventArgs e)
        {
            string id = dataGridViewPHONG.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewPHONG.DataSource = modify.getAllPHONG();
                MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTKPHONG_TextChanged(object sender, EventArgs e)
        {
            string name = txtTKPHONG.Text.Trim();
            if (name == "")
            {
                QLPHONG_Load(sender, e);
            }
            else
            {
                string query = "Select * from PHONG Where TRANGTHAI like '%" + name + "%'";
                dataGridViewPHONG.DataSource = modify.table(query);
            }
        }
        
        private void Cbbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_LOAIPHONG = ((KeyValuePair<string,string>)Cbbloaiphong.SelectedItem).Key;
            string sql = $"select * from LOAIPHONG where ID_LOAIPHONG = '{ID_LOAIPHONG}'";
            List<List<string>> loaiphong = modify.ReadData(sql);
            txtMaLoaiPhong.Text = loaiphong[0][0];
            txtDongia.Text = loaiphong[0][3];
            txtTenLoaiPhong.Text= loaiphong[0][1];
            txtSOLUONG.Text = loaiphong[0][2];
        }

        private void dataGridViewPHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewPHONG.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmaphong.Text = row.Cells[0].Value.ToString();
                txtMaLoaiPhong.Text = row.Cells[1].Value.ToString();
                txtDongia.Text = row.Cells[2].Value.ToString();
                txtTang.Text = row.Cells[3].Value.ToString();
                TXTTRANGTHAI.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
