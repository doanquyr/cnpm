using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Dathang
    {
        private string id_phieudh;
        private string id_nhanvien;
        private string id_hanghoa;
        private int tongsl;
        private int tongtien;
        private string tenncc;

        public Dathang() { }

        public Dathang(string id_phieudh, string id_nhanvien, string id_hanghoa, int tongsl, int tongtien, string tenncc)
        {
            this.Id_phieudh = id_phieudh;
            this.Id_nhanvien = id_nhanvien;
            this.Id_hanghoa = id_hanghoa;
            this.Tongsl = tongsl;
            this.Tongtien = tongtien;
            this.Tenncc = tenncc;
        }

        public string Id_phieudh { get => id_phieudh; set => id_phieudh = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public string Id_hanghoa { get => id_hanghoa; set => id_hanghoa = value; }
        public int Tongsl { get => tongsl; set => tongsl = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
    }
}
