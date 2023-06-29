using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUROS.LIB.SERVICIOS.Request
{
    public class SEResBuscarSeguro
    {
        private int codigoSeguro;
        private string companiaAseguradora;
        private string tipoSeguro;
        private double montoPrima;
        private string moneda;
        private double edadMaximaPermitida;
        private DateTime fechaVigencia;
        private string estado;
        private double importeMensual;
        private string cobertura;

        public int CodigoSeguro { get => codigoSeguro; set => codigoSeguro = value; }
        public string CompaniaAseguradora { get => companiaAseguradora; set => companiaAseguradora = value; }
        public string TipoSeguro { get => tipoSeguro; set => tipoSeguro = value; }
        public double MontoPrima { get => montoPrima; set => montoPrima = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public double EdadMaximaPermitida { get => edadMaximaPermitida; set => edadMaximaPermitida = value; }
        public DateTime FechaVigencia { get => fechaVigencia; set => fechaVigencia = value; }
        public string Estado { get => estado; set => estado = value; }
        public double ImporteMensual { get => importeMensual; set => importeMensual = value; }
        public string Cobertura { get => cobertura; set => cobertura = value; }
    }
}
