using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Dichvu
    {
        private string id_dichvu;
        private string id_loaidichvu;
        private string tendichvu;
        private int dongia;
        private string donvitinh;
        public Dichvu() { }

        public Dichvu(string id_dichvu, string id_loaidichvu, string tendichvu, int dongia, string donvitinh)
        {
            this.Id_dichvu = id_dichvu;
            this.Id_loaidichvu = id_loaidichvu;
            this.Tendichvu = tendichvu;
            this.Dongia = dongia;
            this.Donvitinh = donvitinh;
        }

        public string Id_dichvu { get => id_dichvu; set => id_dichvu = value; }
        public string Id_loaidichvu { get => id_loaidichvu; set => id_loaidichvu = value; }
        public string Tendichvu { get => tendichvu; set => tendichvu = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
    }
}
