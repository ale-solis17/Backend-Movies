using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Movies.Entidades;
using Movies.Logica;

namespace APIRest.Controllers
{
    public class PeliculaController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/peliculas/crear")]
        public ResCrearPelicula crear(ReqCrearPelicula req)
        {
            return new LogPeliculas().crear(req);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/peliculas/mostrar")]
        public ResMostrarPeliculas mostrar(ReqMostrarPeliculas req)
        {
            return new LogPeliculas().mostrar(req);
        }
    }
}