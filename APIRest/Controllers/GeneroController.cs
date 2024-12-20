﻿using System.Web.Http;
using Movies.Entidades;
using Movies.Logica;

namespace APIRest.Controllers
{
    public class GeneroController : ApiController
    {
        [HttpGet]
        [Route("api/generos")]
        public ResGeneros Generos()
        {
            return new LogGeneros().Generos();
        }

        [HttpPost]
        [Route("api/generos/filtrar")]
        public ResFiltrarGenero Filtrar(ReqFiltrarGenero req)
        {
            return new LogGeneros().Filtrar(req);
        }
    }
}