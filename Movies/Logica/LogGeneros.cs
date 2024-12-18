using System;
using System.Collections.Generic;
using System.Linq;
using Movies.AccesoDatos;
using Movies.Entidades;
using Movies.Entidades.Modelos;

namespace Movies.Logica
{
    public class LogGeneros
    {
        public ResGeneros Generos(ReqGeneros req)
        {
            ResGeneros res = new ResGeneros
            {
                errores = new List<string>(),
                Generos = new List<Generos>()
            };

            if (req != null)
            {
                try
                {
                    ConexionDataContext conexion = new ConexionDataContext();
                    List<SP_GENEROSResult> listaComplejo = new List<SP_GENEROSResult>();
                    listaComplejo = conexion.SP_GENEROS().ToList();

                    foreach (SP_GENEROSResult unGenero in listaComplejo)
                    {
                        res.Generos.Add(this.FactoriaGeneros(unGenero));
                    }

                    res.respuesta = true;
                }
                catch (Exception e)
                {
                    res.respuesta = false;
                    res.errores.Add(e.Message);
                }
            }
            else
            {
                res.respuesta = false;
                res.errores.Add("No hay req");
            }

            return res;
        }

        private Generos FactoriaGeneros(SP_GENEROSResult unGenero)
        {
            Generos genero = new Generos
            {
                IdGenero = unGenero.IdMovieType,
                NombreGenero = unGenero.Name
            };
            return genero;
        }

        public ResFiltrarGenero Filtrar(ReqFiltrarGenero req)
        {
            ResFiltrarGenero res = new ResFiltrarGenero()
            {
                Peliculas = new List<Peliculas>(),
                errores = new List<string>(),
            };

            if (req != null)
            {
                try
                {
                    if (req.Generos.IdGenero != 0)
                    {
                        ConexionDataContext conexion = new ConexionDataContext();
                        List<SP_FILTRAR_GENEROResult> listaPel = new List<SP_FILTRAR_GENEROResult>();
                        listaPel = conexion.SP_FILTRAR_GENERO(req.Generos.IdGenero).ToList();

                        foreach (SP_FILTRAR_GENEROResult result in listaPel)
                        {
                            res.Peliculas.Add(this.FactoriaPeliculaGen(result));
                        }

                        if (res.Peliculas.Count == 0)
                        {
                            res.respuesta = false;
                            res.errores.Add("No hay peliculas con este genero");
                        }
                        else
                        {
                            res.respuesta = true;
                        }
                    }
                    else
                    {
                        res.respuesta = false;
                        res.errores.Add("No hay genero");
                    }
                }
                catch (Exception e)
                {
                    res.respuesta = false;
                    res.errores.Add("Error:" + e.Message);
                }
            }
            else
            {
                res.respuesta = false;
                res.errores.Add("No hay req");
            }

            return res;
        }

        private Peliculas FactoriaPeliculaGen(SP_FILTRAR_GENEROResult unaPel)
        {
            Peliculas pelicula = new Peliculas()
            {
                id = unaPel.IdMovie,
                name = unaPel.Name,
                rating = unaPel.Rating,
                director = unaPel.Director,
                creacion = unaPel.CreatedAt,
                synopsis = unaPel.Synopsis,
                generos = unaPel.MovieTypes,
                URL = unaPel.URL
            };
            return pelicula;
        }
    }
}