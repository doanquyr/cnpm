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
    public partial class QLDICHVU : Form
    {
        ModifyDichVu modify;
        public QLDICHVU()
        {
            InitializeComponent();
            modify = new ModifyDichVu();
            string sql = "select * from LOAIDV";
            List<List<string>> dichvu = modify.ReadData(sql);
            Dictionary<string, string> combosource = new Dictionary<string, string>();
            for (int i = 0; i < dichvu.Count; i++)
            {
                combosource.Add(dichvu[i][0], dichvu[i][1]);
                CbbLDV.DataSource = new BindingSource(combosource, null);
                CbbLDV.DisplayMember = "Value";
                CbbLDV.ValueMember = "Key";
            }
        }
        Dichvu dichvu;
        
        private void QLDICHVU_Load(object sender, EventArgs e)
        {
            
            try
            {
                dataGridViewDICHVU.DataSource = modify.getAllDICHVU();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnthemdichvu_Click(object sender, EventArgs e)
        {
            string iddichvu = this.txtiddichvu.Text;
            string idldv = this.txtMaLoaiDV.Text;
            string tendv = this.txttendichvu.Text;
            string dongia1 = this.txtDONGIA.Text;
            int dongia = Int32.Parse(dongia1);
            string donvitinh = this.txtDONVITINH.Text;
            dichvu = new Dichvu(iddichvu,idldv,tendv,dongia,donvitinh);
            if (modify.insert(dichvu))
            {
                dataGridViewDICHVU.DataSource = modify.getAllDICHVU();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoadichvu_Click(object sender, EventArgs e)
        {
            string id = dataGridViewDICHVU.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewDICHVU.DataSource = modify.getAllDICHVU();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuadichvu_Click(object sender, EventArgs e)
        {
            string iddichvu = this.txtiddichvu.Text;
            string idldv = this.txtMaLoaiDV.Text;
            string tendv = this.txttendichvu.Text;
            string dongia1 = this.txtDONGIA.Text;
            int dongia = Int32.Parse(dongia1);
            string donvitinh = this.txtDONVITINH.Text;
            dichvu = new Dichvu(iddichvu, idldv, tendv, dongia, donvitinh);
            if (modify.update(dichvu))
            {
                dataGridViewDICHVU.DataSource = modify.getAllDICHVU();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTIMKIEMDICHVU_TextChanged(object sender, EventArgs e)
        {
            string name = txtTIMKIEMDICHVU.Text.Trim();
            if (name == "")
            {
                QLDICHVU_Load(sender, e);
            }
            else
            {
                string query = "Select * from DICHVU Where TENDV like '%" + name + "%'";
                dataGridViewDICHVU.DataSource = modify.table(query);
            }
        }

        private void CbbLDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_LDV = ((KeyValuePair<string, string>)CbbLDV.SelectedItem).Key;
            string sql = $"select * from LOAIDV where ID_LDV = '{ID_LDV}'";
            List<List<string>> dichvu = modify.ReadData(sql);
            txtMaLoaiDV.Text = dichvu[0][0];
        }

        private void dataGridViewDICHVU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewDICHVU.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtiddichvu.Text = row.Cells[0].Value.ToString();
                txtMaLoaiDV.Text = row.Cells[1].Value.ToString();
                txttendichvu.Text = row.Cells[2].Value.ToString();
                txtDONGIA.Text = row.Cells[3].Value.ToString();
                txtDONVITINH.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
