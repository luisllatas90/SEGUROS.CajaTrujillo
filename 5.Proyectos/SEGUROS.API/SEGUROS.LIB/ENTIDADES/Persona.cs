using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.Entidades
{
    public class Persona
    {
        private int codigo_per;  
        private String nombres_per ;
        private String apellidoPaterno_per;
        private String apellidoMaterno_per;
        private String documentoIdentidad_per;

        public int Codigo_per { get => codigo_per; set => codigo_per = value; }
        public string Nombres_per { get => nombres_per; set => nombres_per = value; }
        public string ApellidoPaterno_per { get => apellidoPaterno_per; set => apellidoPaterno_per = value; }
        public string ApellidoMaterno_per { get => apellidoMaterno_per; set => apellidoMaterno_per = value; }
        public string DocumentoIdentidad_per { get => documentoIdentidad_per; set => documentoIdentidad_per = value; }
    }
}
