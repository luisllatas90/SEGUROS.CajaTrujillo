using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.Entidades
{
    public class Afiliacion
    {
        private int codigo_afi;
        private int codigo_seg;
        private int codigo_per;

        public int Codigo_afi { get => codigo_afi; set => codigo_afi = value; }
        public int Codigo_seg { get => codigo_seg; set => codigo_seg = value; }
        public int Codigo_per { get => codigo_per; set => codigo_per = value; }
    }
}
