using Microsoft.Data.SqlClient;
using SEGUROS.LIB.SERVICIOS.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.DATOS
{
    public class DARegistrarAfiliacion
    {
        String cadena = "Server=.;Database=BDSeguros;Trusted_Connection=True;TrustServerCertificate=True";
        public SEResRegistrarAfiliacion RegistrarAfiliacion(SEReqRegistrarAfiliacion afiliacion)
        {
          
            try
            {
                SEResRegistrarAfiliacion resultado;

                using (SqlConnection cnx = new SqlConnection(cadena))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("FIN_RegistrarAfiliacion", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_seg", afiliacion.CodigoSeguro);
                    cmd.Parameters.AddWithValue("@codigo_per", afiliacion.CodigoPersona);

                    using (var dr = cmd.ExecuteReader())
                    {
                        resultado = new SEResRegistrarAfiliacion();

                        while (dr.Read())
                        {                            
                            resultado.Rpta = Convert.ToString(dr["rpta"]);
                            resultado.CodigoAfiliacion = Convert.ToInt32(dr["codigo_afi"]);

                        }
                    }

                }

                return resultado;

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
