using Movies.Entidades;
using Movies.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APIRest.Controllers
{
    public class UsuarioController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/usuario/crear")]
        public ResCrearUsuario Crear(ReqCrearUsuario req)
        {
            return new LogUsuario().Crear(req);
        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/usuario/actualizar")]
        public ResActualizarUsuario Actualizar(ReqActualizarUsuario req)
        {
            return new LogUsuario().Actualizar(req);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/usuario/mostrar")]
        public ResMostrarUsuario Mostrar(ReqMostrarUsuario req)
        {
            return new LogUsuario().Mostrar(req);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/usuario/login")]
        public ResLogin Login(ReqLogin req)
        {
            return new LogUsuario().Login(req);
        }
    }

    
}