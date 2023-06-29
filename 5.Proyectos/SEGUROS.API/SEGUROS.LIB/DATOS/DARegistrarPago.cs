using Microsoft.Data.SqlClient;
using SEGUROS.LIB.SERVICIOS.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLIB.DATOS
{
    public class DARegistrarPago
    {
        String cadena = "Server=.;Database=BDSeguros;Trusted_Connection=True;TrustServerCertificate=True";
       public SEResRegistrarPago RegistrarPago(SEReqRegistrarPago pago)
        {

            try
            {
                SEResRegistrarPago resultado;

                using (SqlConnection cnx = new SqlConnection(cadena))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("FIN_RegistrarPago", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_seg", pago.CodigoSeguro);
                    cmd.Parameters.AddWithValue("@montoPagar", pago.MontoPagar);
                    cmd.Parameters.AddWithValue("@mesPago", pago.MesPago);
                    cmd.Parameters.AddWithValue("@anioPago", pago.AnioPago);

                    using (var dr = cmd.ExecuteReader())
                    {
                        resultado = new SEResRegistrarPago();

                        while (dr.Read())
                        {
                            resultado.Rpta = Convert.ToString(dr["rpta"]);
                            resultado.CodigoPago = Convert.ToInt32(dr["codigo_pag"]);

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
