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
        public ResCrearUsuario crear(ReqCrearUsuario req)
        {
            return new LogUsuario().crear(req);
        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/usuario/actualizar")]
        public ResActualizarUsuario actualizar(ReqActualizarUsuario req)
        {
            return new LogUsuario().actualizar(req);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/usuario/mostrar")]
        public ResMostrarUsuario mostrar(ReqMostrarUsuario req)
        {
            return new LogUsuario().mostrar(req);
        }
    }

    
}