using Movies.Entidades;
using Movies.Logica;
using System.Web.Http;

namespace APIRest.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpPost]
        [Route("api/usuario/crear")]
        public ResCrearUsuario Crear(ReqCrearUsuario req)
        {
            return new LogUsuario().Crear(req);
        }


        [HttpPost]
        [Route("api/usuario/actualizar")]
        public ResActualizarUsuario Actualizar(ReqActualizarUsuario req)
        {
            return new LogUsuario().Actualizar(req);
        }

        [HttpGet]
        [Route("api/usuario/mostrar")]
        public ResMostrarUsuario Mostrar(ReqMostrarUsuario req)
        {
            return new LogUsuario().Mostrar(req);
        }

        [HttpPost]
        [Route("api/usuario/login")]
        public ResLogin Login(ReqLogin req)
        {
            return new LogUsuario().Login(req);
        }
    }

    
}