using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoanQLKS
{
    public partial class hoadon : Form
    {
        SqlDataAdapter dataAdapter;// truy xuất vào data của bảng
        public hoadon()
        {
            InitializeComponent();
        }
        ModifyHoadon modify;
        private void hoadon_Load(object sender, EventArgs e)
        {
            modify = new ModifyHoadon();
            try
            {
                dataGridView1.DataSource = modify.getAllHOADONTHANHTOAN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
