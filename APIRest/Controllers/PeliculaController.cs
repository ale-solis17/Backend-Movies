using System.Web.Http;
using Movies.Entidades;
using Movies.Logica;

namespace APIRest.Controllers
{
    public class PeliculaController : ApiController
    {
        [HttpPost]
        [Route("api/peliculas/crear")]
        public ResCrearPelicula Crear(ReqCrearPelicula req)
        {
            return new LogPeliculas().Crear(req);
        }

        [HttpGet]
        [Route("api/peliculas/mostrar")]
        public ResMostrarPeliculas Mostrar(ReqMostrarPeliculas req)
        {
            return new LogPeliculas().Mostrar(req);
        }

        [HttpGet]
        [Route("api/peliculas/especifica")]
        public ResPeliculaEsp Especifica(ReqPeliculaEsp req)
        {
            return new LogPeliculas().PeliculaEsp(req);
        }
        
        [HttpGet]
        [Route("api/peliculas/inicio")]
        public ResPeliculaInicio Inicio(ReqPeliculaInicio req)
        {
            return new LogPeliculas().PeliculaInicio(req);
        }
    }
}