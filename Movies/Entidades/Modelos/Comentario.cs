using System;

namespace Movies.Entidades.Modelos
{
    public class Comentario
    {
        public long Id { get; set; }
        public long idUsuario { get; set; }
        public string usuario { get; set; }
        public string nickname { get; set; }
        public long idPelicula { get; set; }
        public DateTime? creationDate { get; set; }
        public string comentario { get; set; }
        public decimal? rating { get; set; }
    }
}
