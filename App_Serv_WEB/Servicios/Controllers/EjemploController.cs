using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servicios.Controllers
{
    [RoutePrefix("api/Ejemplo")]
    public class EjemploController : Controller
    {
        [HttpGet]
        [Route("/ConsultarDatos")]
        public string consultarDatos()
        {
            return "Se hizo una consulta a la base de datos";
        }
        [HttpGet]
        [Route("Saludo")]
        public string saludar(string nombre)
        {
            return $"saludo a: {nombre}";
        }
    }
}