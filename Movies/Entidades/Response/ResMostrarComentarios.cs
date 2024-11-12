using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Entidades.Modelos;

namespace Movies.Entidades
{
    public class ResMostrarComentarios : ResBase
    {
        public List<Comentario> Comentarios {  get; set; }
    }
}
