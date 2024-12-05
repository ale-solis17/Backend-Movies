using System.Collections.Generic;
using Movies.Entidades.Modelos;

namespace Movies.Entidades
{
    public class ResMostrarComentarios : ResBase
    {
        public List<Comentario> Comentarios {  get; set; }
    }
}
