using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Lophoadon
    {
        private string id_hoadon;
        private string id_nhanvien;
        private string id_uudai;
        private string id_datphong;
        private int tienphong;
        private int tiendv;
        private int tongtien;

        public Lophoadon(string id_hoadon, string id_nhanvien, string id_uudai, string id_datphong, int tienphong, int tiendv, int tongtien)
        {
            this.Id_hoadon = id_hoadon;
            this.Id_nhanvien = id_nhanvien;
            this.Id_uudai = id_uudai;
            this.Id_datphong = id_datphong;
            this.Tienphong = tienphong;
            this.Tiendv = tiendv;
            this.Tongtien = tongtien;
        }

        public string Id_hoadon { get => id_hoadon; set => id_hoadon = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public string Id_uudai { get => id_uudai; set => id_uudai = value; }
        public string Id_datphong { get => id_datphong; set => id_datphong = value; }
        public int Tienphong { get => tienphong; set => tienphong = value; }
        public int Tiendv { get => tiendv; set => tiendv = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
