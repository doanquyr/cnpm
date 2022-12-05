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
    public partial class QLTAIKHOAN : Form
    {
        public QLTAIKHOAN()
        {
            InitializeComponent();
        }
        ModifyTaikhoan modify;
        Taikhoan taikhoan;
        private void QLTAIKHOAN_Load(object sender, EventArgs e)
        {
            modify = new ModifyTaikhoan();
            try
            {
                dataGridViewtaikhoan.DataSource = modify.getAllTAIKHOAN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemtk_Click(object sender, EventArgs e)
        {
            string id = this.txtmataikhoan.Text;
            string name = this.txtmanhanvien.Text;
            string dangnhap = this.txttaikhoan.Text;
            string matkhau = this.txttaikhoan.Text;
            taikhoan =  new Taikhoan(id,dangnhap,matkhau,name);
            if (modify.insert(taikhoan))
            {
                dataGridViewtaikhoan.DataSource = modify.getAllTAIKHOAN();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuataikhoan_Click(object sender, EventArgs e)
        {
            string id = this.txtmataikhoan.Text;
            string name = this.txtmanhanvien.Text;
            string dangnhap = this.txttaikhoan.Text;
            string matkhau = this.txttaikhoan.Text;
            taikhoan = new Taikhoan(id,dangnhap,matkhau,name);
            if (modify.update(taikhoan))
            {
                dataGridViewtaikhoan.DataSource = modify.getAllTAIKHOAN();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewtaikhoan.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txttaikhoan.Text = row.Cells[0].Value.ToString();
                txtmatkhau.Text = row.Cells[1].Value.ToString();
                txtmanhanvien.Text = row.Cells[2].Value.ToString();

                //Không cho phép sửa trường STT
          
            }
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            string id = dataGridViewtaikhoan.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
               dataGridViewtaikhoan.DataSource = modify.getAllTAIKHOAN();
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
                QLTAIKHOAN_Load(sender, e);
            }
            else
            {
                string query = "Select * from TAIKHOAN Where ID_NHANVIEN like '%" + name + "%'";
                dataGridViewtaikhoan.DataSource = modify.table(query);
            }
        }
    }
}
