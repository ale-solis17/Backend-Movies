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
        public ResCrearPelicula Crear(ReqCrearPelicula req)
        {
            return new LogPeliculas().Crear(req);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/peliculas/mostrar")]
        public ResMostrarPeliculas Mostrar(ReqMostrarPeliculas req)
        {
            return new LogPeliculas().Mostrar(req);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/peliculas/especifica")]
        public ResPeliculaEsp Especifica(ReqPeliculaEsp req)
        {
            return new LogPeliculas().PeliculaEsp(req);
        }
    }
}