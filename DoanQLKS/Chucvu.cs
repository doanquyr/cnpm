using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Chucvu
    {
        private string id_chucvu;
        private string tencv;
        private int luong;
        private string vitri;

        public Chucvu() { }
        public Chucvu(string id_chucvu, string tencv, int luong, string vitri)
        {
            this.Id_chucvu = id_chucvu;
            this.Tencv = tencv;
            this.Luong = luong;
            this.Vitri = vitri;
        }

        public string Id_chucvu { get => id_chucvu; set => id_chucvu = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public int Luong { get => luong; set => luong = value; }
        public string Vitri { get => vitri; set => vitri = value; }
    }
}
