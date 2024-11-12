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
    public class LogPeliculas
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

        public ResCrearPelicula crear(ReqCrearPelicula req)
        {
            ResCrearPelicula res = new ResCrearPelicula();
            res.errores = new List<string>();

            try
            {
                if (req != null)
                {
                    if (String.IsNullOrEmpty(req.Peliculas.name))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el nombre");
                    }
                    else if (req.Peliculas.rating <= 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el rating");
                    }
                    else if (String.IsNullOrEmpty(req.Peliculas.director))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el director");
                    }
                    else if (req.Peliculas.duracion <= 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta la duracion");
                    }
                    else if (String.IsNullOrEmpty(req.Peliculas.synopsis))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta la synopsis");
                    }
                    else if (String.IsNullOrEmpty(req.Peliculas.generos))
                    {
                        res.respuesta = false;
                        res.errores.Add("Faltan los generos");
                    }
                    else
                    {
                        long? idReturn = 0;
                        int? errorId = 0;
                        string errorBD = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_CREAR_PELICULA(req.Peliculas.name, req.Peliculas.rating, req.Peliculas.director, req.Peliculas.duracion, req.Peliculas.creacion, req.Peliculas.synopsis, req.Peliculas.generos, ref idReturn, ref errorId, ref errorBD);


                        if (idReturn <= 0)
                        {
                            res.respuesta = false;
                            res.errores.Add(errorBD);
                        }
                        else
                        {
                            res.respuesta = true;
                        }
                    }
                }
                else
                {
                    res.respuesta = false;
                    res.errores.Add("Req null");
                }
            }
            catch (Exception ex)
            {
                res.respuesta = false;
                res.errores.Add(ex.Message);
            }

            return res;
        }
    }
}
