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
    public partial class QLHANGHOA : Form
    {
        Modifyhanghoa modify;
        public QLHANGHOA()
        {
            InitializeComponent();
            modify = new Modifyhanghoa();
            string sql = "select * from KHO ";
            List<List<string>> kho = modify.ReadData(sql);
            for (int i = 0; i < kho.Count; i++)
            {
                Cbbmakho.Items.Add(kho[i][0]);
            }
        }

        private void QLHANGHOA_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewhanghoa.DataSource = modify.getAllHANGHOA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Hanghoa hanghoa;
        private void btnthemhanghoa_Click(object sender, EventArgs e)
        {
            string idhanghoa = this.txtmasanpham.Text;
            string idkho = this.Cbbmakho.SelectedItem.ToString();
            string tenhang = this.txttenhang.Text;
            string g = this.txtgia.Text;
            int gia = Int32.Parse(g);
            string donvitinh = this.txtdonvitinh.Text;
            string sl = this.txtsoluong.Text;
            int soluong = Int32.Parse(sl);
            hanghoa = new Hanghoa(idhanghoa,idkho,tenhang,gia,donvitinh,soluong);
            if (modify.insert(hanghoa))
            {
                dataGridViewhanghoa.DataSource = modify.getAllHANGHOA();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoahanghoa_Click(object sender, EventArgs e)
        {
            string id = dataGridViewhanghoa.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewhanghoa.DataSource = modify.getAllHANGHOA();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuahanghoa_Click(object sender, EventArgs e)
        {
            string idhanghoa = this.txtmasanpham.Text;
            string idkho = this.Cbbmakho.SelectedItem.ToString();
            string tenhang = this.txttenhang.Text;
            string g = this.txtgia.Text;
            int gia = Int32.Parse(g);
            string donvitinh = this.txtdonvitinh.Text;
            string sl = this.txtsoluong.Text;
            int soluong = Int32.Parse(sl);
            hanghoa = new Hanghoa(idhanghoa, idkho, tenhang, gia, donvitinh, soluong);
            if (modify.update(hanghoa))
            {
                dataGridViewhanghoa.DataSource = modify.getAllHANGHOA();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string name = txtTK.Text.Trim();
            if (name == "")
            {
                QLHANGHOA_Load(sender, e);
            }
            else
            {
                string query = "Select * from HANGHOA Where TENHANG like '%" + name + "%'";
                dataGridViewhanghoa.DataSource = modify.table(query);
            }
        }
    }
}
