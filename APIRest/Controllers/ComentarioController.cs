using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Movies.Entidades;
using Movies.Logica;

namespace APIRest.Controllers
{
    public class ComentarioController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/comentario/crear")]
        public ResCrearComentario Crear(ReqCrearComentario req )
        {
            return new LogComentario().Crear(req);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/comentario/borrar")]
        public ResBorrarComentario Borrar(ReqBorrarComentario req)
        {
            return new LogComentario().Borrar(req);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/comentario/mostrar")]
        public ResMostrarComentarios Mostrar(ReqMostrarComentarios req)
        {
            return new LogComentario().Mostrar(req);
        }
    }
}