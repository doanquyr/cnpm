using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Xacnhanphong
    {
        private string id_huyphong;
        private string id_datphong;
        private string id_nhanvien;
        private DateTime ngayhuy;
        private string lydohuy;

        public Xacnhanphong(string id_huyphong, string id_datphong, string id_nhanvien, DateTime ngayhuy, string lydohuy)
        {
            this.Id_huyphong = id_huyphong;
            this.Id_datphong = id_datphong;
            this.Id_nhanvien = id_nhanvien;
            this.Ngayhuy = ngayhuy;
            this.Lydohuy = lydohuy;
        }

        public string Id_huyphong { get => id_huyphong; set => id_huyphong = value; }
        public string Id_datphong { get => id_datphong; set => id_datphong = value; }
        public string Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public DateTime Ngayhuy { get => ngayhuy; set => ngayhuy = value; }
        public string Lydohuy { get => lydohuy; set => lydohuy = value; }
    }
}
