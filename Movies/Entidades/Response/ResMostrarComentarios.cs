using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Entidades.Modelos;

namespace Movies.Entidades
{
    internal class ResMostrarComentarios : ResBase
    {
        public List<Comentario> Comentarios {  get; set; }
    }
}
