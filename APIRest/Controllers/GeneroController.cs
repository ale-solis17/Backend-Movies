using System.Web.Http;
using Movies.Entidades;
using Movies.Logica;

namespace APIRest.Controllers
{
    public class GeneroController : ApiController
    {
        [HttpGet]
        [Route("api/generos")]
        public ResGeneros Generos(ReqGeneros req)
        {
            return new LogGeneros().Generos(req);
        }
    }
}