using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUROS.LIB.SERVICIOS.Request
{
    public class SEResRegistrarPago
    {
        private String rpta;
        private int codigoPago;

        public string Rpta { get => rpta; set => rpta = value; }
        public int CodigoPago { get => codigoPago; set => codigoPago = value; }
    }
}
