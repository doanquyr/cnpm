using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Datphong
    {
        private string id_datphong;
        private string id_khachhang;
        private string id_phong;
        private string id_nhanvien;
        private DateTime ngaydat;
        private DateTime ngaytra;
        private int tiencoc;
        private int tienphong;
        private string trangthai;

        public Datphong() { }

        public Datphong(string id_datphong, string id_khachhang, string id_phong, string id_nhanvien, DateTime ngaydat, DateTime ngaytra, int tiencoc, int tienphong, string trangthai)
        {
            this.id_datphong = id_datphong;
            this.id_khachhang = id_khachhang;
            this.id_phong = id_phong;
            this.id_nhanvien = id_nhanvien;
            this.ngaydat = ngaydat;
            this.ngaytra = ngaytra;
            this.tiencoc = tiencoc;
            this.tienphong = tienphong;
            this.trangthai = trangthai;
        }

        public string Id_datphong { get => id_datphong; set => id_datphong = value; }
        public string Id_khachhang { get => id_khachhang; set => id_khachhang = value; }
        public string Id_phong { get => id_phong; set => id_phong = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public DateTime Ngaydat { get => ngaydat; set => ngaydat = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }
        public int Tiencoc { get => tiencoc; set => tiencoc = value; }
        public int Tienphong { get => tienphong; set => tienphong = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
