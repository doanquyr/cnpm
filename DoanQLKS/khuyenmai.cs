using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Khuyenmai
    {
        private string id_uudai;
        private int donvi;
        

        public Khuyenmai() { }

        public Khuyenmai(string id_uudai, int donvi)
        {
            this.Id_uudai = id_uudai;
            this.Donvi = donvi;
        }

        public string Id_uudai { get => id_uudai; set => id_uudai = value; }
        public int Donvi { get => donvi; set => donvi = value; }
    }
}
