using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Thexe
    {
        private string id_thexe;
        private string id_khachhang;
        private string id_pgx;
        private string soxe;
        private string loaixe;

        public Thexe(string id_thexe, string id_khachhang, string id_pgx, string soxe, string loaixe)
        {
            this.Id_thexe = id_thexe;
            this.Id_khachhang = id_khachhang;
            this.Id_pgx = id_pgx;
            this.Soxe = soxe;
            this.Loaixe = loaixe;
        }

        public string Id_thexe { get => id_thexe; set => id_thexe = value; }
        public string Id_khachhang { get => id_khachhang; set => id_khachhang = value; }
        public string Id_pgx { get => id_pgx; set => id_pgx = value; }
        public string Soxe { get => soxe; set => soxe = value; }
        public string Loaixe { get => loaixe; set => loaixe = value; }
    }
}
