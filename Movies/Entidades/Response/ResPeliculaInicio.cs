using System.Collections.Generic;
using Movies.Entidades.Modelos;

namespace Movies.Entidades
{
    public class ResPeliculaInicio : ResBase
    {
        public Peliculas Peliculas = new Peliculas();
        public List<Comentario> Comentario = new List<Comentario>();
    }
}