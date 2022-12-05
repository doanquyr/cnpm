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
    public partial class QUANLYDATPHONG : Form
    {
        public QUANLYDATPHONG()
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
        private void QUANLYDATPHONG_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLDATPHONG()); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLDATDICHVU());
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            OpenShowform(new Thanhtoan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLXACNHANPHONG());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenShowform(new hoadon());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formdangnhap f = new Formdangnhap();
            this.Close();
        }
    }
}
