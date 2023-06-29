using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.Entidades
{
    public class pago
    {
       private int codigo_pag;
       private int codigo_seg;
       private double montoPagar_pag;
       private int mesPago_pag;
       private int anioPago_pag;

        public int Codigo_pag { get => codigo_pag; set => codigo_pag = value; }

        public int Codigo_seg { get => codigo_seg; set => codigo_seg = value; }
        
        public double MontoPagar_pag { get => montoPagar_pag; set => montoPagar_pag = value; }
        
        public int MesPago_pag { get => mesPago_pag; set => mesPago_pag = value; }
        
        public int AnioPago_pag { get => anioPago_pag; set => anioPago_pag = value; }
    }
}
