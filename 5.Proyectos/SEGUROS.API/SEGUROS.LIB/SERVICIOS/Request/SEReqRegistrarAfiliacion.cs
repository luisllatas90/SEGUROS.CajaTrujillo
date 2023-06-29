using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUROS.LIB.SERVICIOS.Request
{
    public class SEReqRegistrarAfiliacion
    {
        private int codigoSeguro;
        private int codigoPersona;

        public int CodigoSeguro { get => codigoSeguro; set => codigoSeguro = value; }
        public int CodigoPersona { get => codigoPersona; set => codigoPersona = value; }
    }
}
