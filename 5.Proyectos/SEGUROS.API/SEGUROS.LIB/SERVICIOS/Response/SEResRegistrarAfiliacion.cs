using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUROS.LIB.SERVICIOS.Request
{
    public class SEResRegistrarAfiliacion
    {
        private String rpta;
        private int codigoAfiliacion;

        public string Rpta { get => rpta; set => rpta = value; }
        public int CodigoAfiliacion { get => codigoAfiliacion; set => codigoAfiliacion = value; }
    }
}
