using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUROS.LIB.SERVICIOS.Request
{
    public class SEReqRegistrarPago
    {
        private int codigoSeguro;
        private double montoPagar;
        private int mesPago;
        private int anioPago;

        public int CodigoSeguro { get => codigoSeguro; set => codigoSeguro = value; }
        public double MontoPagar { get => montoPagar; set => montoPagar = value; }
        public int MesPago { get => mesPago; set => mesPago = value; }
        public int AnioPago { get => anioPago; set => anioPago = value; }
    }
}
