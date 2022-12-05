using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class quanlynhapkho
    {
        private string id_phieunk;
        private string id_kho;
        private string id_nhanvien;
        private string id_hanghoa;
        private DateTime ngaynk;
        private int slnhap;
        private int tongtien;
        private string tennguoigiao;
        private string ghichu;

        public quanlynhapkho(string id_phieunk, string id_kho, string id_nhanvien, string id_hanghoa, DateTime ngaynk, int slnhap, int tongtien, string tennguoigiao, string ghichu)
        {
            this.Id_phieunk = id_phieunk;
            this.Id_kho = id_kho;
            this.Id_nhanvien = id_nhanvien;
            this.Id_hanghoa = id_hanghoa;
            this.Ngaynk = ngaynk;
            this.Slnhap = slnhap;
            this.Tongtien = tongtien;
            this.Tennguoigiao = tennguoigiao;
            this.Ghichu = ghichu;
        }

        public string Id_phieunk { get => id_phieunk; set => id_phieunk = value; }
        public string Id_kho { get => id_kho; set => id_kho = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public string Id_hanghoa { get => id_hanghoa; set => id_hanghoa = value; }
        public DateTime Ngaynk { get => ngaynk; set => ngaynk = value; }
        public int Slnhap { get => slnhap; set => slnhap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Tennguoigiao { get => tennguoigiao; set => tennguoigiao = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
