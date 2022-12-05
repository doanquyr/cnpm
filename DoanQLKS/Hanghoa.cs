using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Hanghoa
    {
        private string id_hanghoa;
        private string id_kho;
        private string tenhang;
        private int gia;
        private string donvitinh;
        private int soluong;

        public Hanghoa() { }
        public Hanghoa(string id_hanghoa, string id_kho, string tenhang, int gia, string donvitinh, int soluong)
        {
            this.Id_hanghoa = id_hanghoa;
            this.Id_kho = id_kho;
            this.Tenhang = tenhang;
            this.Gia = gia;
            this.Donvitinh = donvitinh;
            this.Soluong = soluong;
        }

        public string Id_hanghoa { get => id_hanghoa; set => id_hanghoa = value; }
        public string Id_kho { get => id_kho; set => id_kho = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
