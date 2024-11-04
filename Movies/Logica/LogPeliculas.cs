using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.AccesoDatos;
using Movies.Entidades;
using Movies.Entidades.Modelos;

namespace Movies.Logica
{
    internal class LogPeliculas
    {
        public ResMostrarPeliculas mostrar(ReqMostrarPeliculas req)
        {
            ResMostrarPeliculas res = new ResMostrarPeliculas();
            res.errores = new List<string>();
            res.Peliculas = new List<Peliculas>();

            try
            {
                ConexionDataContext conexion = new ConexionDataContext();
                List<SP_MOSTRAR_PELICULASResult> listaTipoComplejo = new List<SP_MOSTRAR_PELICULASResult>();
                listaTipoComplejo = conexion.SP_MOSTRAR_PELICULAS().ToList();

                foreach (SP_MOSTRAR_PELICULASResult unTipo in listaTipoComplejo)
                {
                    res.Peliculas.Add(this.factoriaPeliculas(unTipo));
                }
                res.respuesta = true;
            }
            catch (Exception ex)
            {
                res.respuesta = false;
                res.errores.Add((string)ex.Message);
            }

            return res;
        }

        private Peliculas factoriaPeliculas(SP_MOSTRAR_PELICULASResult unTipoComplejo)
        {
            Peliculas peliculasRetornar = new Peliculas();
            peliculasRetornar.id = unTipoComplejo.IdMovie;
            peliculasRetornar.name = unTipoComplejo.Name;
            peliculasRetornar.rating = unTipoComplejo.Rating;
            peliculasRetornar.director = unTipoComplejo.Director;
            peliculasRetornar.duracion = unTipoComplejo.MovieTime;
            peliculasRetornar.creacion = unTipoComplejo.CreatedAt;
            peliculasRetornar.fechaIngresado = unTipoComplejo.InsertDate;
            peliculasRetornar.synopsis = unTipoComplejo.Synopsis;
            peliculasRetornar.generos = unTipoComplejo.Genero;

            return peliculasRetornar;
        }
    }
}
