using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Entidades.Modelos
{
    public class Comentario
    {
        public long Id { get; set; }
        public long idUsuario { get; set; }
        public long idPelicula { get; set; }
        public System.DateTime creationDate { get; set; }
        public string comentario { get; set; }
    }
}
