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
    public partial class QLTHEXE : Form
    {
        Modifythexe modify;
        public QLTHEXE()
        {
            InitializeComponent();
            modify = new Modifythexe();
            string sql = "select * from PHIEUGX";
            List<List<string>> phieugiuxe = modify.ReadData(sql);
            for (int i = 0; i < phieugiuxe.Count; i++)
            {
                Cbbphieugiuxe.Items.Add(phieugiuxe[i][0]);
            }
            modify = new Modifythexe();
            string sql1 = "select * from KHACHHANG";
            List<List<string>> khachhang = modify.ReadData(sql1);
            for (int i = 0; i < khachhang.Count; i++)
            {
                Cbbmakhachhang.Items.Add(khachhang[i][0]);
            }
        }

        private void QLTHEXE_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.getAllTHEXE();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Thexe thexe;

        private void btnthemthexe_Click(object sender, EventArgs e)
        {
            string mathexe = this.txtmathexe.Text;
            string idkhachhang = this.Cbbmakhachhang.SelectedItem.ToString();
            string idpgx = this.Cbbphieugiuxe.SelectedItem.ToString();
            string soxe = this.txtsoxe.Text;
            string loaixe = this.txtloaixe.Text;
            thexe = new Thexe(mathexe,idkhachhang,idpgx,soxe,loaixe);
            if (modify.insert(thexe))
            {
                dataGridView1.DataSource = modify.getAllTHEXE();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuathexe_Click(object sender, EventArgs e)
        {
            string mathexe = this.txtmathexe.Text;
            string idkhachhang = this.Cbbmakhachhang.SelectedItem.ToString();
            string idpgx = this.Cbbphieugiuxe.SelectedItem.ToString();
            string soxe = this.txtsoxe.Text;
            string loaixe = this.txtloaixe.Text;
            thexe = new Thexe(mathexe, idkhachhang, idpgx, soxe, loaixe);
            if (modify.update(thexe))
            {
                dataGridView1.DataSource = modify.getAllTHEXE();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoathexe_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridView1.DataSource = modify.getAllTHEXE();
                MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttiemkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txttiemkiem.Text.Trim();
            if (name == "")
            {
                QLTHEXE_Load(sender, e);
            }
            else
            {
                string query = "Select * from THEXE Where ID_THEXE like '%" + name + "%'";
                dataGridView1.DataSource = modify.table(query);
            }
        }
    }
}
