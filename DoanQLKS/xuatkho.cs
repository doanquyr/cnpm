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
    public partial class xuatkho : Form
    {
        Modifyxuatkho modify;
        public xuatkho()
        {
            InitializeComponent();
            modify = new Modifyxuatkho();
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

        private void xuatkho_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewphieuxuatkho.DataSource = modify.getAllXUATKHO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        qlxuatkho xuatkho1;
        private void btnthemkh_Click(object sender, EventArgs e)
        {
            string idpxk = this.txtmaphieuxuatkho.Text;
            string idkho = this.CbbMakho.SelectedItem.ToString();
            string idnhanvien =  this.Cbbmanhanvien.SelectedItem.ToString();
            string hanghoa = this.Cbbmahang.SelectedItem.ToString();
            DateTime ngayxk = this.dateTimePicker2.Value;
            string ss = this.txtslxuatkho.Text;
            int tongslxk = Int32.Parse(ss);
            string ss1 = this.txttongtien.Text;
            int tongtien = Int32.Parse(ss1);
            string lydoxk = this.txtlydo.Text;
            xuatkho1 = new qlxuatkho(idpxk,idkho,idnhanvien,hanghoa,ngayxk,tongslxk,tongtien,lydoxk);
            if (modify.insert(xuatkho1))
            {
                dataGridViewphieuxuatkho.DataSource = modify.getAllXUATKHO();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridViewphieuxuatkho.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewphieuxuatkho.DataSource = modify.getAllXUATKHO();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idpxk = this.txtmaphieuxuatkho.Text;
            string idkho = this.CbbMakho.SelectedItem.ToString();
            string idnhanvien = this.Cbbmanhanvien.SelectedItem.ToString();
            string hanghoa = this.Cbbmahang.SelectedItem.ToString();
            DateTime ngayxk = this.dateTimePicker2.Value;
            string ss = this.txtslxuatkho.Text;
            int tongslxk = Int32.Parse(ss);
            string ss1 = this.txttongtien.Text;
            int tongtien = Int32.Parse(ss1);
            string lydoxk = this.txtlydo.Text;
            xuatkho1 = new qlxuatkho(idpxk, idkho, idnhanvien, hanghoa, ngayxk, tongslxk, tongtien, lydoxk);
            if (modify.update(xuatkho1))
            {
                dataGridViewphieuxuatkho.DataSource = modify.getAllXUATKHO();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewphieuxuatkho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewphieuxuatkho.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmaphieuxuatkho.Text = row.Cells[0].Value.ToString();
                txtslxuatkho.Text = row.Cells[5].Value.ToString();
                txttongtien.Text = row.Cells[6].Value.ToString();
                txtlydo.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
