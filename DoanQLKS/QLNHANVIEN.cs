using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanQLKS
{
    public partial class QLNHANVIEN : Form
    {
        Modifynhanvien modify;
        public QLNHANVIEN()
        {
            InitializeComponent();
            modify = new Modifynhanvien();
            string sql = "select * from CHUCVU";
            List<List<string>> chucvu = modify.ReadData(sql);
            for (int i = 0; i < chucvu.Count; i++)
            {
                Cbbmachucvu.Items.Add(chucvu[i][0]);
            }
        }
        nhanvien nhanvien;

        private void QLNHANVIEN_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewnhanvien.DataSource = modify.getAllNHANVIEN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemnhanvien_Click(object sender, EventArgs e)
        {
            string idnhanvien = this.txtmanhanvien.Text;
            string idchucvu = this.Cbbmachucvu.SelectedItem.ToString();
            string hovaten = this.txttennhanvien.Text;
            DateTime ngaysinh = this.dateTimePickerngaysinh.Value;
            string cmnd = this.txtCCCD.Text;
            string gioitinh = this.Cbbgioitinh.SelectedItem.ToString();
            string sdt = this.txtSDT.Text;
            string diachi = this.txtDiachi.Text;
            string email = this.txtEmail.Text;
            nhanvien = new nhanvien(idnhanvien, idchucvu, hovaten,ngaysinh,cmnd,gioitinh,sdt,diachi,email);
            if (modify.insert(nhanvien))
            {
                dataGridViewnhanvien.DataSource = modify.getAllNHANVIEN();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuanhanvien_Click(object sender, EventArgs e)
        {
            string idnhanvien = this.txtmanhanvien.Text;
            string idchucvu = this.Cbbmachucvu.SelectedItem.ToString();
            string hovaten = this.txttennhanvien.Text;
            DateTime ngaysinh = this.dateTimePickerngaysinh.Value;
            string cmnd = this.txtCCCD.Text;
            string gioitinh = this.Cbbgioitinh.SelectedItem.ToString();
            string sdt = this.txtSDT.Text;
            string diachi = this.txtDiachi.Text;
            string email = this.txtEmail.Text;
            nhanvien = new nhanvien(idnhanvien, idchucvu, hovaten, ngaysinh, cmnd, gioitinh, sdt, diachi, email);
            if (modify.update(nhanvien))
            {
                dataGridViewnhanvien.DataSource = modify.getAllNHANVIEN();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoanhanvien_Click(object sender, EventArgs e)
        {
            string id = dataGridViewnhanvien.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewnhanvien.DataSource = modify.getAllNHANVIEN();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string name = txtTK.Text.Trim();
            if (name == "")
            {
                QLNHANVIEN_Load(sender, e);
            }
            else
            {
                string query = "Select * from NHANVIEN Where HOVATEN like '%" + name + "%'";
                dataGridViewnhanvien.DataSource = modify.table(query);
            }
        }
    }
}
