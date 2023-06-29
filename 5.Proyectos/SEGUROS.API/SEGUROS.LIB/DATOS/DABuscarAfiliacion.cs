using Microsoft.Data.SqlClient;
using SEGUROS.LIB.SERVICIOS.Request;
using SegurosLIB.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.Datos
{
    public class DABuscarAfiliacion
    {
        String cadena = "Server=.;Database=BDSeguros;Trusted_Connection=True;TrustServerCertificate=True";
        public List<SEResBuscarAfiliacion> BuscarAfiliacion(String busquedaAfiliacion)
        {
            try
            {
                List<SEResBuscarAfiliacion> lstAfiliacion;

                using (SqlConnection cnx = new SqlConnection(cadena))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("FIN_Buscar_Afiliacion", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@busqueda", busquedaAfiliacion);

                    using (var dr = cmd.ExecuteReader())
                    {
                        lstAfiliacion = new List<SEResBuscarAfiliacion>();
                        SEResBuscarAfiliacion afiliacion;

                        while (dr.Read())
                        {
                            afiliacion = new SEResBuscarAfiliacion();
                            afiliacion.CodigoAfiliacion = Convert.ToInt32(dr["codigo_afi"]);
                            afiliacion.Cliente = Convert.ToString(dr["persona"]);
                            afiliacion.CodigoSeguro = Convert.ToInt32(dr["codigo_seg"]);
                            afiliacion.CompaniaAseguradora = Convert.ToString(dr["companiaAseguradora_seg"]);
                            afiliacion.TipoSeguro = Convert.ToString(dr["tipoSeguro_seg"]);
                            afiliacion.ImporteMensual = Convert.ToDouble(dr["importeMensual_seg"]);
                            afiliacion.Moneda = Convert.ToString(dr["moneda_seg"]);
                            afiliacion.MontoPrima = Convert.ToDouble(dr["montoPrima_seg"]);

                            lstAfiliacion.Add(afiliacion);
                        }
                    }

                }

                return lstAfiliacion;

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
