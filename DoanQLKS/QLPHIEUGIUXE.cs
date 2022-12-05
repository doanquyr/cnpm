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
    public partial class QLPHIEUGIUXE : Form
    {
        Modifyphieugiuxe modify;
        public QLPHIEUGIUXE()
        {
            InitializeComponent();
            modify = new Modifyphieugiuxe();

        }

        private void QLPHIEUGIUXE_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.getAllPHIEUGIUXE();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Phieugiuxe phieugiuxe;
        private void Themphieugiuxe_Click(object sender, EventArgs e)
        {
            string idphieugiuxe = this.txtmaphieugiuxe.Text;
            DateTime tgvao = this.dateTimePickertgvao.Value;
            DateTime tgra = this.dateTimePickertgra.Value;
            phieugiuxe = new Phieugiuxe(idphieugiuxe,tgvao,tgra);
            if (modify.insert(phieugiuxe))
            {
                dataGridView1.DataSource = modify.getAllPHIEUGIUXE();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suaphieugiuxe_Click(object sender, EventArgs e)
        {
            string idphieugiuxe = this.txtmaphieugiuxe.Text;
            DateTime tgvao = this.dateTimePickertgvao.Value;
            DateTime tgra = this.dateTimePickertgra.Value;
            phieugiuxe = new Phieugiuxe(idphieugiuxe, tgvao, tgra);
            if (modify.update(phieugiuxe))
            {
                dataGridView1.DataSource = modify.getAllPHIEUGIUXE();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QLPHIEUGIUXE_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không, thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xoaphieugiuxe_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridView1.DataSource = modify.getAllPHIEUGIUXE();
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
                QLPHIEUGIUXE_Load(sender, e);
            }
            else
            {
                string query = "Select * from PHIEUGX Where ID_PGX like '%" + name + "%'";
                dataGridView1.DataSource = modify.table(query);
            }
        }
    }
}
