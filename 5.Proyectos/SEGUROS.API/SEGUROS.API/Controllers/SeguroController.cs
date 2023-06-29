using Microsoft.AspNetCore.Mvc;
using SEGUROS.LIB.SERVICIOS.Request;
using SegurosLIB.Datos;
using SegurosLIB.DATOS;
using SegurosLIB.Entidades;

namespace SEGUROS.API.Controllers
{

    [Route("api/seguro")]
    [ApiController]
    public class SeguroController: ControllerBase
    {
       [HttpGet]
       [Route("BuscarCliente")]
        public IActionResult BuscarCliente(SEReqBuscarCliente buscarCliente)
        {
            List<SEResBuscarCliente> lstCliente = new List<SEResBuscarCliente>();

            try
            {
                DABuscarCliente bc = new DABuscarCliente();
                lstCliente = bc.BuscarCliente(buscarCliente.BusquedaCliente);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = lstCliente });

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lstCliente });
            }

        }


        [HttpGet]
        [Route("BuscarSeguro")]
        public IActionResult BuscarSeguro(SEReqBuscarSeguro buscarSeguro)
        {
            List<SEResBuscarSeguro> lstSeguro = new List<SEResBuscarSeguro>();

            try
            {
                DABuscarSeguro bs = new DABuscarSeguro();
                Seguro seg = new Seguro();
                seg.Codigo_seg = buscarSeguro.CodigoSeguro;
                lstSeguro = bs.BuscarSeguro(seg);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = lstSeguro });

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lstSeguro });
            }

        }

        [HttpGet]
        [Route("BuscarAfiliacion")]
        public IActionResult BuscarAfiliacion(SEReqBuscarAfiliacion buscarAfiliacion)
        {
            List<SEResBuscarAfiliacion> lstAfiliacion = new List<SEResBuscarAfiliacion>();

            try
            {
                DABuscarAfiliacion ba = new DABuscarAfiliacion();
                lstAfiliacion = ba.BuscarAfiliacion(buscarAfiliacion.BusquedaAfiliacion);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = lstAfiliacion });

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lstAfiliacion });
            }

        }

        [HttpPost]
        [Route("RegistrarAfiliacion")]
        public IActionResult RegistraAfiliacion(SEReqRegistrarAfiliacion afiliacion)
        {
            SEResRegistrarAfiliacion resultado = new SEResRegistrarAfiliacion();

            try
            {
                DARegistrarAfiliacion ra = new DARegistrarAfiliacion();
                
                resultado = ra.RegistrarAfiliacion(afiliacion);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = resultado });

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = resultado });
            }

        }

        [HttpPost]
        [Route("RegistrarPago")]
        public IActionResult RegistrarPago(SEReqRegistrarPago pago)
        {
            SEResRegistrarPago resultado = new SEResRegistrarPago();

            try
            {
                DARegistrarPago rp = new DARegistrarPago();

                resultado = rp.RegistrarPago(pago);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = resultado });

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = resultado });
            }

        }

    }
}
