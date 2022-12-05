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
    public partial class QLKHACHHANG : Form
    {
        public QLKHACHHANG()
        {
            InitializeComponent();
        }
        Khachhang khachhang;
        ModifyQLKH modify;
        private void QLKHACHHANG_Load(object sender, EventArgs e)
        {
            modify = new ModifyQLKH();
            try
            {
                dataGridView1.DataSource = modify.getAllKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            string id = this.txtMaKh.Text;
            string name = this.txthovaten.Text;
            string diachi = this.txtDC.Text;
            string gioitinh = this.comboBox1.SelectedItem.ToString();
            DateTime ngaysinh = this.dtpKH.Value;
            string cmnd = this.txtCMND.Text;
            string sdt = this.txtSDT.Text;
            string email = this.txtEmail.Text;
            khachhang = new Khachhang(id,name, ngaysinh, cmnd, gioitinh, sdt, diachi, email);
            if (modify.insert(khachhang))
            {
                dataGridView1.DataSource = modify.getAllKH();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoakhachhang_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridView1.DataSource = modify.getAllKH();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuakh_Click(object sender, EventArgs e)
        {
            string id = this.txtMaKh.Text;
            string name = this.txthovaten.Text;
            string diachi = this.txtDC.Text;
            string gioitinh = this.comboBox1.SelectedItem.ToString();
            DateTime ngaysinh = this.dtpKH.Value;
            string cmnd = this.txtCMND.Text;
            string sdt = this.txtSDT.Text;
            string email = this.txtEmail.Text;
            khachhang = new Khachhang(id, name, ngaysinh, cmnd, gioitinh, sdt, diachi, email);
            if (modify.update(khachhang))
            {
                dataGridView1.DataSource = modify.getAllKH();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string name = txtTK.Text.Trim();
            if (name == "")
            {
                QLKHACHHANG_Load(sender, e);
            }
            else
            {
                string query = "Select * from KHACHHANG Where HOVATEN like '%" + name + "%'";
                dataGridView1.DataSource = modify.table(query);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaKh.Text = row.Cells[0].Value.ToString();
                txthovaten.Text = row.Cells[1].Value.ToString();
                txtCMND.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtDC.Text = row.Cells[6].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();
                
            }
        }
    }
}
