using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanQLKS
{
    public partial class NhapKho : Form
    {
        Modifynhapkho modify;
        public NhapKho()
        {
            InitializeComponent();
            modify = new Modifynhapkho();
            string sql = "select * from KHO";
            List<List<string>> kho = modify.ReadData(sql);
            for (int i = 0; i < kho.Count; i++)
            {
                CbbMakho.Items.Add(kho[i][0]);
            }
            string sql1 = "select * from NHANVIEN";
            List<List<string>> nhanvien = modify.ReadData(sql1);
            for (int i = 0; i < nhanvien.Count; i++)
            {
                Cbbmanhanvien.Items.Add(nhanvien[i][0]);
            }
            string sql2 = "select * from HANGHOA";
            List<List<string>> hanghoa = modify.ReadData(sql2);
            for (int i = 0; i < hanghoa.Count; i++)
            {
                Cbbmahang.Items.Add(hanghoa[i][0]);
            }
        }
        

        private void NhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPNK.DataSource = modify.getAllNHAPKHO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        quanlynhapkho nhapkho;
        private void btnthemkh_Click(object sender, EventArgs e)
        {
            string idphieunk = this.txtMaphieunk.Text;
            string idkho = this.CbbMakho.SelectedItem.ToString();
            string idnhanvien = this.Cbbmanhanvien.SelectedItem.ToString();
            string idhanghoa = this.Cbbmahang.SelectedItem.ToString();
            DateTime ngaynk = this.dateTimePickernk.Value;
            string sln = this.txtslnk.Text;
            int slnhap = Int32.Parse(sln);
            string tt = this.txttongtien.Text;
            int tongtien = Int32.Parse(tt);
            string tennguoigiao = this.txttennguoigiao.Text;
            string ghichu = this.txtghichu.Text;
            nhapkho = new quanlynhapkho(idphieunk, idkho, idnhanvien, idhanghoa, ngaynk, slnhap, tongtien, tennguoigiao, ghichu);
            if(modify.insert(nhapkho))
            {
                dataGridViewPNK.DataSource = modify.getAllNHAPKHO();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idphieunk = this.txtMaphieunk.Text;
            string idkho = this.CbbMakho.SelectedItem.ToString();
            string idnhanvien = this.Cbbmanhanvien.SelectedItem.ToString();
            string idhanghoa = this.Cbbmahang.SelectedItem.ToString();
            DateTime ngaynk = this.dateTimePickernk.Value;
            string sln = this.txtslnk.Text;
            int slnhap = Int32.Parse(sln);
            string tt = this.txttongtien.Text;
            int tongtien = Int32.Parse(tt);
            string tennguoigiao = this.txttennguoigiao.Text;
            string ghichu = this.txtghichu.Text;
            nhapkho = new quanlynhapkho(idphieunk, idkho, idnhanvien, idhanghoa, ngaynk, slnhap, tongtien, tennguoigiao, ghichu);
            if(modify.update(nhapkho))
            {
                dataGridViewPNK.DataSource = modify.getAllNHAPKHO();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridViewPNK.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewPNK.DataSource = modify.getAllNHAPKHO();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewPNK.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaphieunk.Text = row.Cells[0].Value.ToString();
                txttongtien.Text = row.Cells[6].Value.ToString();
                txtslnk.Text = row.Cells[5].Value.ToString();
                txttennguoigiao.Text = row.Cells[7].Value.ToString();
                txtghichu.Text = row.Cells[8].Value.ToString();
            }
        }
    }
}
