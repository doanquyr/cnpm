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
    public partial class QUANLYNHANSU : Form
    {
        public QUANLYNHANSU()
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
        private void QUANLYNHANSU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLNHANVIEN());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLCALAM());
        }

        private void btnchucvu_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLCHUCVU());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formdangnhap f = new Formdangnhap();
            this.Close();
        }
    }
}
