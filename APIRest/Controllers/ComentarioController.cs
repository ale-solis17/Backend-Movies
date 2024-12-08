using System.Web.Http;
using Movies.Entidades;
using Movies.Logica;

namespace APIRest.Controllers
{
    public class ComentarioController : ApiController
    {
        [HttpPost]
        [Route("api/comentario/crear")]
        public ResCrearComentario Crear(ReqCrearComentario req )
        {
            return new LogComentario().Crear(req);
        }

        [HttpPost]
        [Route("api/comentario/borrar")]
        public ResBorrarComentario Borrar(ReqBorrarComentario req)
        {
            return new LogComentario().Borrar(req);
        }

        [HttpGet]
        [Route("api/comentario/mostrar")]
        public ResMostrarComentarios Mostrar(ReqMostrarComentarios req)
        {
            return new LogComentario().Mostrar(req);
        }
    }
}