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
    public partial class BAOVE : Form
    {
        public BAOVE()
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
        private void BAOVE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLPHIEUGIUXE());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenShowform(new QLTHEXE());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formdangnhap f = new Formdangnhap();
            this.Close();
        }
    }
}
