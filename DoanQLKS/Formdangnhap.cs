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
    public partial class Formdangnhap : Form
    {
        Modifydangnhap modify;
        public Formdangnhap()
        {
            modify = new Modifydangnhap();
            InitializeComponent();
            
        }
        
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tk = txttaikhoan.Text;
            string mk = txtmatkhau.Text;
            string sql = "SELECT TENTK,MATKHAU FROM TAIKHOAN";
            List<List<string>> dangnhap = modify.ReadData(sql);
            bool ketQua = false;
            for(int i = 0;i < dangnhap.Count;i++)
            {
                if(tk == dangnhap[i][0] && mk == dangnhap[i][1])
                {
                    string tentk = dangnhap[i][0];
                    switch(tentk){
                        case "LETAN": 
                            QUANLYDATPHONG quanlydatphong = new QUANLYDATPHONG();
                            quanlydatphong.Show();
                            break;
                        case "QLNHANSU":
                            QUANLYNHANSU quanly = new QUANLYNHANSU();
                            quanly.Show();
                            break;
                        case "KHO":
                            QUANLYKHO quanlykho = new QUANLYKHO();
                            quanlykho.Show();
                            break;
                        case "BAOVE":
                            BAOVE BV = new BAOVE();
                            BV.Show();
                            break;
                        case "QUANLY":
                            QUANLY ql = new QUANLY();
                            ql.Show();
                            break;
                        case "KETOAN":
                            QUANLYKETOAN  kt = new QUANLYKETOAN();
                            kt.Show(); 
                            break;

                    }
                    ketQua = true;
                    this.Hide();
                }
            }
            if (!ketQua)
                MessageBox.Show("đăng nhập thất bại", "thông báo", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("đăng nhập thất bại", "thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(tb == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
