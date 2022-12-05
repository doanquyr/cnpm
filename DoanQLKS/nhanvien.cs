using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class nhanvien
    {
        private string id_nhanvien;
        private string id_chucvu;
        private string ten_nhanvien;
        private DateTime ngaysinh;
        private string cmnd;
        private string gioitinh;
        private string sdt;
        private string diachi;
        private string email;

        public nhanvien() { }
        public nhanvien(string id_nhanvien, string id_chucvu, string ten_nhanvien, DateTime ngaysinh, string cmnd, string gioitinh, string sdt, string diachi, string email)
        {
            this.Id_nhanvien = id_nhanvien;
            this.Id_chucvu = id_chucvu;
            this.Ten_nhanvien = ten_nhanvien;
            this.Ngaysinh = ngaysinh;
            this.Cmnd = cmnd;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Email = email;
        }

        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public string Id_chucvu { get => id_chucvu; set => id_chucvu = value; }
        public string Ten_nhanvien { get => ten_nhanvien; set => ten_nhanvien = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
    }
}
