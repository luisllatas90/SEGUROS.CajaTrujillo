using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.Entidades
{
    public class Seguro
    {
        private int codigo_seg;
        private string companiaAseguradora_seg;
        private string tipoSeguro_seg;
        private double factorImpuesto_seg;
        private double porcentajeComision_seg;
        private double montoPrima_seg;
        private string moneda_seg;
        private double edadMaxPermitida_seg;
        private DateTime fechaVigencia_seg;
        private string estado_seg;
        private double importeMensual_seg;
        private string cobertura_seg;

        public int Codigo_seg { get => codigo_seg; set => codigo_seg = value; }
        public string CompaniaAseguradora_seg { get => companiaAseguradora_seg; set => companiaAseguradora_seg = value; }
        public string TipoSeguro_seg { get => tipoSeguro_seg; set => tipoSeguro_seg = value; }
        public double FactorImpuesto_seg { get => factorImpuesto_seg; set => factorImpuesto_seg = value; }
        public double PorcentajeComision_seg { get => porcentajeComision_seg; set => porcentajeComision_seg = value; }
        public double MontoPrima_seg { get => montoPrima_seg; set => montoPrima_seg = value; }
        public string Moneda_seg { get => moneda_seg; set => moneda_seg = value; }
        public double EdadMaxPermitida_seg { get => edadMaxPermitida_seg; set => edadMaxPermitida_seg = value; }
        public DateTime FechaVigencia_seg { get => fechaVigencia_seg; set => fechaVigencia_seg = value; }
        public string Estado_seg { get => estado_seg; set => estado_seg = value; }
        public double ImporteMensual_seg { get => importeMensual_seg; set => importeMensual_seg = value; }
        public string Cobertura_seg { get => cobertura_seg; set => cobertura_seg = value; }
    }
}
