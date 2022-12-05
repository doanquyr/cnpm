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
    public partial class QLKHUYENMAI : Form
    {
        Khuyenmai khuyenmai;
        public QLKHUYENMAI()
        {
            InitializeComponent();
        }
        Modifykhuyenmai modify;
        private void QLKHUYENMAI_Load(object sender, EventArgs e)
        {
            modify = new Modifykhuyenmai();
            try
            {
                dataGridViewKhuyenmai.DataSource = modify.getAllKHUYENMAI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemkhuyenmai_Click(object sender, EventArgs e)
        {
            string id = this.txtTENKHUYENMAI.Text;
            string ptg1 = this.txtGIAMGIA.Text;
            int donvi = Int32.Parse(ptg1);
            khuyenmai = new Khuyenmai(id,donvi);
            if (modify.insert(khuyenmai))
            {
                dataGridViewKhuyenmai.DataSource = modify.getAllKHUYENMAI();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoakhuyenmai_Click(object sender, EventArgs e)
        {
            string id = dataGridViewKhuyenmai.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewKhuyenmai.DataSource = modify.getAllKHUYENMAI();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string id_uudai;
        private void btnsuakhuyenmai_Click(object sender, EventArgs e)
        {
            string id = this.txtTENKHUYENMAI.Text;
            string ptg1 = this.txtGIAMGIA.Text;
            int donvi = Int32.Parse(ptg1);
            khuyenmai = new Khuyenmai(id,donvi);
            if (modify.update(khuyenmai))
            {
                dataGridViewKhuyenmai.DataSource = modify.getAllKHUYENMAI();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewKhuyenmai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewKhuyenmai.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtTENKHUYENMAI.Text = row.Cells[0].Value.ToString();
                txtGIAMGIA.Text = row.Cells[1].Value.ToString();
                
                //Không cho phép sửa trường STT
                id_uudai = row.Cells[0].Value.ToString();
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string name = txtTK.Text.Trim();
            if (name == "")
            {
                QLKHUYENMAI_Load(sender, e);
            }
            else
            {
                string query = "Select * from UUDAI Where DONVI like '%" + name + "%'";
                dataGridViewKhuyenmai.DataSource = modify.table(query);
            }
        }
    }
}
