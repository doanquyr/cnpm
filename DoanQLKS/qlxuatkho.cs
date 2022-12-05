using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class qlxuatkho
    {
        private string id_pxk;
        private string id_kho;
        private string id_nhanvien;
        private string id_hanghoa;
        private DateTime ngayxk;
        private int tongslxk;
        private int tongtien;
        private string lydoxk;

        public qlxuatkho() { }
        public qlxuatkho(string id_pxk, string id_kho, string id_nhanvien, string id_hanghoa, DateTime ngayxk, int tongslxk, int tongtien, string lydoxk)
        {
            this.Id_pxk = id_pxk;
            this.Id_kho = id_kho;
            this.Id_nhanvien = id_nhanvien;
            this.Id_hanghoa = id_hanghoa;
            this.Ngayxk = ngayxk;
            this.Tongslxk = tongslxk;
            this.Tongtien = tongtien;
            this.Lydoxk = lydoxk;
        }

        public string Id_pxk { get => id_pxk; set => id_pxk = value; }
        public string Id_kho { get => id_kho; set => id_kho = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public string Id_hanghoa { get => id_hanghoa; set => id_hanghoa = value; }
        public DateTime Ngayxk { get => ngayxk; set => ngayxk = value; }
        public int Tongslxk { get => tongslxk; set => tongslxk = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Lydoxk { get => lydoxk; set => lydoxk = value; }
    }
}
