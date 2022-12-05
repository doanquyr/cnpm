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
    public partial class QLDATHANG : Form
    {
        Modifyphieudathang modify;
        public QLDATHANG()
        {
            InitializeComponent();
            modify = new Modifyphieudathang();
            string sql = "select * from NHANVIEN";
            List<List<string>> nhanvien = modify.ReadData(sql);
            for (int i = 0; i < nhanvien.Count; i++)
            {
                Cbbmanhanvien.Items.Add(nhanvien[i][0]);
            }
            string sql1 = "select * from HANGHOA";
            List<List<string>> hanghoa = modify.ReadData(sql1);
            Dictionary<string, string> combosource = new Dictionary<string, string>();
            for (int i = 0; i < hanghoa.Count; i++)
            {
                combosource.Add(hanghoa[i][0], hanghoa[i][1]);
                Cbbtenhang.DataSource = new BindingSource(combosource, null);
                Cbbtenhang.DisplayMember = "Value";
                Cbbtenhang.ValueMember = "Key";
            }
        }

        private void QLDATHANG_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewdathang.DataSource = modify.getAllDATHANG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Dathang dathang;

        private void btnthemdathang_Click(object sender, EventArgs e)
        {
            string id_phieudh = this.txtmadathang.Text;
            string id_nhanvien = this.Cbbmanhanvien.SelectedItem.ToString();
            string id_hanghoa = this.txtmahang.Text;
            string tsl = this.txttongsoluong.Text;
            int tongsl = Int32.Parse(tsl);
            string tt = this.txttongtien.Text;
            int tongtien = Int32.Parse(tt);
            string tenncc = this.txttennhacungcap.Text;
            dathang = new Dathang(id_phieudh,id_nhanvien,id_hanghoa,tongsl,tongtien,tenncc);
            if (modify.insert(dathang))
            {
                dataGridViewdathang.DataSource = modify.getAllDATHANG();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoadathang_Click(object sender, EventArgs e)
        {
            string id = dataGridViewdathang.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewdathang.DataSource = modify.getAllDATHANG();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuadathang_Click(object sender, EventArgs e)
        {
            string id_phieudh = this.txtmadathang.Text;
            string id_nhanvien = this.Cbbmanhanvien.SelectedItem.ToString();
            string id_hanghoa = this.txtmahang.Text;
            string tsl = this.txttongsoluong.Text;
            int tongsl = Int32.Parse(tsl);
            string tt = this.txttongtien.Text;
            int tongtien = Int32.Parse(tt);
            string tenncc = this.txttennhacungcap.Text;
            dathang = new Dathang(id_phieudh, id_nhanvien, id_hanghoa, tongsl, tongtien, tenncc);
            if (modify.update(dathang))
            {
                dataGridViewdathang.DataSource = modify.getAllDATHANG();
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
                QLDATHANG_Load(sender, e);
            }
            else
            {
                string query = "Select * from PHIEUDH Where ID_HANGHOA like '%" + name + "%'";
                dataGridViewdathang.DataSource = modify.table(query);
            }
        }

        private void Cbbtenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_HANGHOA = ((KeyValuePair<string, string>)Cbbtenhang.SelectedItem).Key;
            string sql = $"select * from HANGHOA where ID_HANGHOA = '{ID_HANGHOA}'";
            List<List<string>> hanghoa = modify.ReadData(sql);
            txtmahang.Text = hanghoa[0][0];
        }

        private void Cbbmanhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
