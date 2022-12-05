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
    public partial class QUANLY : Form
    {
        public QUANLY()
        {
            InitializeComponent();
        }
        
        private Form activeform = null;
        private void OpenShowform(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLKHACHHANG());
        }

        private void BtnDichVu_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLDICHVU());  
        }

        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLTAIKHOAN());
        }

        private void BtnPhong_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLPHONG());   
        }

        private void BtnUuDai_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLKHUYENMAI());
        }

        private void QUANLY_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formdangnhap f = new Formdangnhap();
            this.Close();
        }
    }
}
