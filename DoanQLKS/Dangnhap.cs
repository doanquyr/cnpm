using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Dangnhap
    {
        private string id_tk;
        private string tentk;
        private string matkhau;
        private string id_nhanvien;

        public Dangnhap(string id_tk, string tentk, string matkhau, string id_nhanvien)
        {
            this.Id_tk = id_tk;
            this.Tentk = tentk;
            this.Matkhau = matkhau;
            this.Id_nhanvien = id_nhanvien;
        }

        public string Id_tk { get => id_tk; set => id_tk = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
    }
}
