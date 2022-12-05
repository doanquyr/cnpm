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
    public partial class QLCHUCVU : Form
    {

        public QLCHUCVU()
        {
            InitializeComponent();
        }
        Modifychucvu modify;
        private void QLCHUCVU_Load(object sender, EventArgs e)
        {
            modify = new Modifychucvu();
            try
            {
                dataGridViewchucvu.DataSource = modify.getAllCHUCVU();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Chucvu chucvu;

        private void btnthemkhuyenmai_Click(object sender, EventArgs e)
        {
            string idchucvu = this.txtmachucvu.Text;
            string tencv = this.txttencongviec.Text;
            string l = this.txtluong.Text;
            int luong = Int32.Parse(l);
            string vitri = this.txtvitri.Text;
            chucvu = new Chucvu(idchucvu,tencv,luong,vitri);
            if (modify.insert(chucvu))
            {
                dataGridViewchucvu.DataSource = modify.getAllCHUCVU();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuakhuyenmai_Click(object sender, EventArgs e)
        {
            string idchucvu = this.txtmachucvu.Text;
            string tencv = this.txttencongviec.Text;
            string l = this.txtluong.Text;
            int luong = Int32.Parse(l);
            string vitri = this.txtvitri.Text;
            chucvu = new Chucvu(idchucvu, tencv, luong, vitri);
            if (modify.update(chucvu))
            {
                dataGridViewchucvu.DataSource = modify.getAllCHUCVU();
                MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoakhuyenmai_Click(object sender, EventArgs e)
        {
            string id = dataGridViewchucvu.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewchucvu.DataSource = modify.getAllCHUCVU();
                MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                QLCHUCVU_Load(sender, e);
            }
            else
            {
                string query = "Select * from CHUCVU Where ID_CHUCVU like '%" + name + "%'";
                dataGridViewchucvu.DataSource = modify.table(query);
            }
        }
    }
}
