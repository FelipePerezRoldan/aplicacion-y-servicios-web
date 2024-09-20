using Servicios.Models;
using System.Web.Http;

namespace Servicios.Controllers
{
    [RoutePrefix("api/Clientes")]
    public class ClientesController : ApiController
    {
        [Route("ConsultarDocumento")]
        public CLIEnte ConsultarDocumento(string documento)
        {
            clsCliente cliente = new clsCliente();
            return cliente.Consultar(documento);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] CLIEnte Cliente)
        {
            //Se crea una instancia del objeto cliente y se pasan los datos de entrada y se imboca el metodo
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = Cliente;

            return _cliente.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] CLIEnte Cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = Cliente;

            return _cliente.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] CLIEnte Cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = Cliente;

            return _cliente.Eliminar();
        }
    }
}
