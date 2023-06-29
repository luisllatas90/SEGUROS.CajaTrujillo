using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUROS.LIB.SERVICIOS.Request
{
    public class SEResBuscarCliente
    {
        private int codigo_per;
        private string persona;

        public int Codigo_per { get => codigo_per; set => codigo_per = value; }
        public string Persona { get => persona; set => persona = value; }
    }
}
