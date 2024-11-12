using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Entidades.Modelos;

namespace Movies.Entidades
{
    public class ResMostrarPeliculas : ResBase
    {
        public List<Peliculas> Peliculas { get; set; }
    }
}
