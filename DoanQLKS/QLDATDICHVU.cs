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
    public partial class QLDATDICHVU : Form
    {
        Modifydatdichvu modify;
        public QLDATDICHVU()
        {
            InitializeComponent();
            modify = new Modifydatdichvu();
            string sql = "select * from DICHVU";
            List<List<string>> dichvu = modify.ReadData(sql);
            Dictionary<string, string> combosource = new Dictionary<string, string>();
            for (int i = 0; i < dichvu.Count; i++)
            {
                combosource.Add(dichvu[i][0],dichvu[i][1]);
                Cbbmadichvu.DataSource = new BindingSource(combosource, null);
                Cbbmadichvu.ValueMember = "Value";
                Cbbmadichvu.DisplayMember = "Key";
            }
            string sql1 = "select * from PDATPHONG where TRANGTHAI LIKE N'Đang Đặt Phòng'";
            List<List<string>> datphong = modify.ReadData(sql1);
            for(int i = 0;i < datphong.Count; i++)
            {
                Cbbphieudatphong.Items.Add(datphong[i][0]);
            }
        }
        Datdichvu datdichvu;
        private void QLDATDICHVU_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewdatdichvu.DataSource = modify.getAllDATDICHVU();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemdichvu_Click(object sender, EventArgs e)
        {
            string iddatphong = this.Cbbphieudatphong.SelectedItem.ToString();
            string iddichvu = ((KeyValuePair<string, string>)Cbbmadichvu.SelectedItem).Key;
            string sl = this.txtsoluong.Text;
            int soluong = Int32.Parse(sl);
            string dg = this.txtdongia.Text;
            int dongia = Int32.Parse(dg);
            string donvitinh = this.txtdongia.Text;
            datdichvu = new Datdichvu(iddatphong,iddichvu,soluong,dongia,donvitinh);
            if (modify.insert(datdichvu))
            {
                dataGridViewdatdichvu.DataSource = modify.getAllDATDICHVU();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuadichvu_Click(object sender, EventArgs e)
        {
            string iddatphong = this.Cbbphieudatphong.SelectedItem.ToString();
            string iddichvu = this.Cbbmadichvu.SelectedItem.ToString();
            string sl = this.txtsoluong.Text;
            int soluong = Int32.Parse(sl);
            string dg = this.txtdongia.Text;
            int dongia = Int32.Parse(dg);
            string donvitinh = this.txtdongia.Text;
            datdichvu = new Datdichvu(iddatphong, iddichvu, soluong, dongia, donvitinh);
            if (modify.update(datdichvu))
            {
                dataGridViewdatdichvu.DataSource = modify.getAllDATDICHVU();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoadichvu_Click(object sender, EventArgs e)
        {
            string id = dataGridViewdatdichvu.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridViewdatdichvu.DataSource = modify.getAllDATDICHVU();
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
                QLDATDICHVU_Load(sender, e);
            }
            else
            {
                string query = "Select * from PDATDV Where ID_DATPHONG like '%" + name + "%'";
                dataGridViewdatdichvu.DataSource = modify.table(query);
            }
        }

        private void Cbbphieudatphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbbmadichvu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string ID_DICHVU = ((KeyValuePair<string, string>)Cbbmadichvu.SelectedItem).Key;
            string sql = $"select * from DICHVU where ID_DICHVU = '{ID_DICHVU}'";
            List<List<string>> dichvu = modify.ReadData(sql);
            txttendichvu.Text = dichvu[0][2];
            txtdongia.Text = dichvu[0][3];
            txtdonvitinh.Text = dichvu[0][4];
        }
    }
}
