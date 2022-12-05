using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Datdichvu
    {
        private string id_datphong;
        private string id_dichvu;
        private int soluong;
        private int dongia;
        private string donvitinh;

        public Datdichvu(string id_datphong, string id_dichvu, int soluong, int dongia, string donvitinh)
        {
            this.Id_datphong = id_datphong;
            this.Id_dichvu = id_dichvu;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Donvitinh = donvitinh;
        }

        public string Id_datphong { get => id_datphong; set => id_datphong = value; }
        public string Id_dichvu { get => id_dichvu; set => id_dichvu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
    }
}
