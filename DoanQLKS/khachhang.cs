using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Khachhang
    {
        private string id_khachhang;
        private string ten_Khachhang;
        private DateTime ngaysinh;
        private string cmnd;
        private string gioitinh;
        private string sdt;
        private string diachi;
        private string email;

        public Khachhang() { }
        
        public Khachhang(string id_khachhang,string ten_Khachhang, DateTime ngaysinh, string cmnd, string gioitinh, string sdt, string diachi, string email)
        {
            this.id_khachhang = id_khachhang;
            this.Ten_Khachhang = ten_Khachhang;
            this.Ngaysinh = ngaysinh;
            this.Cmnd = cmnd;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Email = email;
        }
        public string Ten_Khachhang { get => ten_Khachhang; set => ten_Khachhang = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Id_khachhang { get => id_khachhang; set => id_khachhang = value; }
    }
}
