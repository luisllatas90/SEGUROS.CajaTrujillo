using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUROS.LIB.SERVICIOS.Request
{
    public class SEResBuscarAfiliacion
    {
        private int codigoAfiliacion;
        private string cliente;
        private int codigoSeguro;
        private string companiaAseguradora;
        private string tipoSeguro;
        private double importeMensual;
        private string moneda;
        private double montoPrima;

        public int CodigoAfiliacion { get => codigoAfiliacion; set => codigoAfiliacion = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int CodigoSeguro { get => codigoSeguro; set => codigoSeguro = value; }
        public string CompaniaAseguradora { get => companiaAseguradora; set => companiaAseguradora = value; }
        public string TipoSeguro { get => tipoSeguro; set => tipoSeguro = value; }
        public double ImporteMensual { get => importeMensual; set => importeMensual = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public double MontoPrima { get => montoPrima; set => montoPrima = value; }
    }
}
