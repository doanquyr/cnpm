using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanQLKS
{
    internal class Phieugiuxe
    {
        private string id_pgx;
        private DateTime tgvao;
        private DateTime tgra;

        public Phieugiuxe(string id_pgx, DateTime tgvao, DateTime tgra)
        {
            this.Id_pgx = id_pgx;
            this.Tgvao = tgvao;
            this.Tgra = tgra;
        }

        public string Id_pgx { get => id_pgx; set => id_pgx = value; }
        public DateTime Tgvao { get => tgvao; set => tgvao = value; }
        public DateTime Tgra { get => tgra; set => tgra = value; }
    }
}
