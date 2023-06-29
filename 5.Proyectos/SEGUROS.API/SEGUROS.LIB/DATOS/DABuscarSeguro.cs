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
    public class DABuscarSeguro
    {
        String cadena = "Server=.;Database=BDSeguros;Trusted_Connection=True;TrustServerCertificate=True";
        public List<SEResBuscarSeguro> BuscarSeguro(Seguro seguroParam)
        {
            try
            {
                List<SEResBuscarSeguro> lstSeguro;

                using (SqlConnection cnx = new SqlConnection(cadena))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("FIN_Buscar_Seguro", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_seg", seguroParam.Codigo_seg);

                    using (var dr = cmd.ExecuteReader())
                    {
                        lstSeguro = new List<SEResBuscarSeguro>();
                        SEResBuscarSeguro seguro;

                        while (dr.Read())
                        {
                            seguro = new SEResBuscarSeguro();
                            seguro.CodigoSeguro = Convert.ToInt32(dr["codigo_seg"]);
                            seguro.CompaniaAseguradora = Convert.ToString(dr["companiaAseguradora_seg"]);
                            seguro.TipoSeguro = Convert.ToString(dr["tipoSeguro_seg"]);
                            seguro.MontoPrima = Convert.ToDouble(dr["montoPrima_seg"]);
                            seguro.Moneda = Convert.ToString(dr["moneda_seg"]);
                            seguro.EdadMaximaPermitida = Convert.ToDouble(dr["edadMaxPermitida_seg"]);
                            seguro.FechaVigencia = Convert.ToDateTime(dr["fechaVigencia_seg"]);
                            seguro.Estado = Convert.ToString(dr["estado_seg"]);
                            seguro.ImporteMensual = Convert.ToDouble(dr["importeMensual_seg"]);
                            seguro.Cobertura = Convert.ToString(dr["cobertura_seg"]);

                            lstSeguro.Add(seguro);
                        }
                    }

                }

                return lstSeguro;

            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
