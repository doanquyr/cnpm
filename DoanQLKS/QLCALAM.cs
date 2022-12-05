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
    public partial class QLCALAM : Form
    {
        Modifycalam modify;
        public QLCALAM()
        {
            InitializeComponent();
            modify = new Modifycalam();
            string sql = "select * from NHANVIEN";
            List<List<string>> nhanvien = modify.ReadData(sql);
            Dictionary<string, string> combosource = new Dictionary<string, string>();
            for (int i = 0; i < nhanvien.Count; i++)
            {
                combosource.Add(nhanvien[i][0], nhanvien[i][2]);
                Cbbnhanvien.DataSource = new BindingSource(combosource, null);
                Cbbnhanvien.DisplayMember = "Key";
                Cbbnhanvien.ValueMember = "Key";
            }
        }
        Calam calam;
        private void QLCALAM_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewcalam.DataSource = modify.getAllCALAM();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemcalam_Click(object sender, EventArgs e)
        {
            string idcalam = this.txtmacalam.Text;
            string idnhanvien = ((KeyValuePair<string, string>)Cbbnhanvien.SelectedItem).Key;
            DateTime thoigianbatdau = this.dateTimePickergiobatdau.Value;
            DateTime thoigianketthuc = this.dateTimePickergioketthuc.Value;
            calam = new Calam(idcalam,idnhanvien,thoigianbatdau,thoigianketthuc);
            if (modify.insert(calam))
            {
                dataGridViewcalam.DataSource = modify.getAllCALAM();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuacalam_Click(object sender, EventArgs e)
        {
            string idcalam = this.txtmacalam.Text;
            string idnhanvien = this.Cbbnhanvien.SelectedItem.ToString();
            DateTime thoigianbatdau = this.dateTimePickergiobatdau.Value;
            DateTime thoigianketthuc = this.dateTimePickergioketthuc.Value;
            calam = new Calam(idcalam, idnhanvien, thoigianbatdau, thoigianketthuc);
            if (modify.update(calam))
            {
                dataGridViewcalam.DataSource = modify.getAllCALAM();
                MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbbnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_NHANVIEN = ((KeyValuePair<string, string>)Cbbnhanvien.SelectedItem).Key;
            string sql = $"select * from NHANVIEN where ID_NHANVIEN = '{ID_NHANVIEN}'";
            List<List<string>> nhanvien = modify.ReadData(sql);
            txttennhanvien.Text = nhanvien[0][2];
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string name = txtTK.Text.Trim();
            if (name == "")
            {
                QLCALAM_Load(sender, e);
            }
            else
            {
                string query = "Select * from CALAM Where IDCALAM like '%" + name + "%'";
                dataGridViewcalam.DataSource = modify.table(query);
            }
        }

        private void btnxoacalam_Click(object sender, EventArgs e)
        {
            string id = dataGridViewcalam.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewcalam.DataSource = modify.getAllCALAM();
                MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
