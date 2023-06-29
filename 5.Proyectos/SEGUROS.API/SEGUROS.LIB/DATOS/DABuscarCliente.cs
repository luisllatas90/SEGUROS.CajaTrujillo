using Microsoft.Data.SqlClient;
using SEGUROS.LIB.SERVICIOS.Request;
using SegurosLIB.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.DATOS
{
    public class DABuscarCliente
    {
        String cadena = "Server=.;Database=BDSeguros;Trusted_Connection=True;TrustServerCertificate=True";
        public List<SEResBuscarCliente> BuscarCliente(String busquedaCliente)
        {
            try
            {
                List<SEResBuscarCliente> lstCliente;

                using (SqlConnection cnx = new SqlConnection(cadena))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("FIN_Buscar_Cliente", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@busqueda", busquedaCliente);

                    using (var dr = cmd.ExecuteReader())
                    {
                        lstCliente = new List<SEResBuscarCliente>();
                        SEResBuscarCliente cliente;

                        while (dr.Read())
                        {
                            cliente = new SEResBuscarCliente();
                            cliente.Codigo_per = Convert.ToInt32(dr["codigo_per"]);
                            cliente.Persona = Convert.ToString(dr["persona"]);

                            lstCliente.Add(cliente);
                        }
                    }

                }

                return lstCliente;

            }
            catch (Exception ex)
            {

                throw;
            }

        }
       
    }
}
