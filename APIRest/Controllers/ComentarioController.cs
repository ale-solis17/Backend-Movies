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
        public ResCrearComentario crear(ReqCrearComentario req )
        {
            return new LogComentario().crear(req);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/comentario/borrar")]
        public ResBorrarComentario borrar(ReqBorrarComentario req)
        {
            return new LogComentario().borrar(req);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/comentario/mostrar")]
        public ResMostrarComentarios mostrar(ReqMostrarComentarios req)
        {
            return new LogComentario().mostrar(req);
        }
    }
}