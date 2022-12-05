using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Phong
    {
        private string id_phong;
        private string id_loaiphong;
        private int dongia;
        private string tang;
        private string trangthai;
        

        public Phong() { }
        public Phong(string id_phong,string id_loaiphong,int dongia,string tang,string trangthai)
        {
            this.Id_phong = id_phong;
            this.Id_loaiphong = id_loaiphong;
            this.Dongia = dongia;
            this.Tang = tang;
            this.Trangthai = trangthai;
        }

        public string Id_phong { get => id_phong; set => id_phong = value; }
        public string Id_loaiphong { get => id_loaiphong; set => id_loaiphong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Tang { get => tang; set => tang = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
