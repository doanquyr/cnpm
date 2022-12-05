using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Taikhoan
    {
        private string id_tk;
        private string tentk;
        private string id_nhanvien;
        private string matkhau;
        
        public Taikhoan() { }

        public Taikhoan(string id_tk, string tentk, string id_nhanvien, string matkhau)
        {
            this.Id_tk = id_tk;
            this.Tentk = tentk;
            this.Id_nhanvien = id_nhanvien;
            this.Matkhau = matkhau;
        }

        public string Id_tk { get => id_tk; set => id_tk = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
