using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Calam
    {
        private string id_calam;
        private string id_nhanvien;
        private DateTime thoigianbd;
        private DateTime thoigiankt;

        public Calam(string id_calam, string id_nhanvien, DateTime thoigianbd, DateTime thoigiankt)
        {
            this.Id_calam = id_calam;
            this.Id_nhanvien = id_nhanvien;
            this.Thoigianbd = thoigianbd;
            this.Thoigiankt = thoigiankt;
        }

        public string Id_calam { get => id_calam; set => id_calam = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public DateTime Thoigianbd { get => thoigianbd; set => thoigianbd = value; }
        public DateTime Thoigiankt { get => thoigiankt; set => thoigiankt = value; }
    }
}
