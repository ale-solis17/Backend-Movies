using System;
using System.Collections.Generic;
using System.Linq;
using Movies.AccesoDatos;
using Movies.Entidades;
using Movies.Entidades.Modelos;

namespace Movies.Logica
{
    public class LogPeliculas
    {
        public ResMostrarPeliculas Mostrar(ReqMostrarPeliculas req)
        {
            ResMostrarPeliculas res = new ResMostrarPeliculas
            {
                errores = new List<string>(),
                Peliculas = new List<Peliculas>()
            };

            try
            {
                ConexionDataContext conexion = new ConexionDataContext();
                List<SP_MOSTRAR_PELICULASResult> listaTipoComplejo = new List<SP_MOSTRAR_PELICULASResult>();
                listaTipoComplejo = conexion.SP_MOSTRAR_PELICULAS().ToList();

                foreach (SP_MOSTRAR_PELICULASResult unTipo in listaTipoComplejo)
                {
                    res.Peliculas.Add(this.FactoriaPeliculas(unTipo));
                }

                res.respuesta = true;
            }
            catch (Exception ex)
            {
                res.respuesta = false;
                res.errores.Add(ex.Message);
            }

            return res;
        }

        private Peliculas FactoriaPeliculas(SP_MOSTRAR_PELICULASResult unTipoComplejo)
        {
            Peliculas peliculasRetornar = new Peliculas
            {
                id = unTipoComplejo.IdMovie,
                name = unTipoComplejo.Name,
                rating = unTipoComplejo.Rating ?? 0,
                director = unTipoComplejo.Director,
                duracion = unTipoComplejo.MovieTime,
                creacion = unTipoComplejo.InsertDate,
                synopsis = unTipoComplejo.Synopsis,
                generos = unTipoComplejo.Generos
            };

            return peliculasRetornar;
        }

        public ResCrearPelicula Crear(ReqCrearPelicula req)
        {
            ResCrearPelicula res = new ResCrearPelicula
            {
                errores = new List<string>()
            };

            try
            {
                if (req != null)
                {
                    if (String.IsNullOrEmpty(req.Peliculas.name))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el nombre");
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
                        conexion.SP_CREAR_PELICULA(req.Peliculas.name, req.Peliculas.director,
                            req.Peliculas.duracion, req.Peliculas.creacion, req.Peliculas.synopsis,
                            req.Peliculas.generos, req.Peliculas.URL, ref idReturn, ref errorId, ref errorBD);

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

        public ResPeliculaEsp PeliculaEsp(ReqPeliculaEsp req)
        {
            ResPeliculaEsp res = new ResPeliculaEsp
            {
                errores = new List<string>(),
                Peliculas = new Peliculas()
            };

            if (req != null)
            {
                if (req.Peliculas.id <= 0)
                {
                    res.respuesta = false;
                    res.errores.Add("Falta el Id");
                }
                else
                {
                    try
                    {
                        string name = "";
                        decimal? rating = 0;
                        string director = "";
                        int? duracion = 0;
                        DateTime? creacion = null;
                        string synopsis = "";
                        string generos = "";
                        string url = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_Mostrar_Pelicula_Especifica(req.Peliculas.id, ref name, ref rating, ref director,
                            ref duracion, ref creacion, ref synopsis, ref generos, ref url);

                        if (!string.IsNullOrEmpty(name))
                        {
                            res.respuesta = true;
                            res.Peliculas.id = req.Peliculas.id;
                            res.Peliculas.name = name;
                            res.Peliculas.rating = (decimal)rating;
                            res.Peliculas.director = director;
                            res.Peliculas.duracion = (int)duracion;
                            res.Peliculas.creacion = (DateTime)creacion;
                            res.Peliculas.synopsis = synopsis;
                            res.Peliculas.generos = generos;
                            res.Peliculas.URL = url;
                        }
                        else
                        {
                            res.respuesta = false;
                            res.errores.Add("Error SP");
                        }
                    }
                    catch (Exception e)
                    {
                        res.respuesta = false;
                        res.errores.Add(e.Message);
                    }
                }
            }
            else
            {
                res.respuesta = false;
                res.errores.Add("Falta el Request");
            }

            return res;
        }

        public ResPeliculaInicio PeliculaInicio(ReqPeliculaInicio req)
        {
            ResPeliculaInicio res = new ResPeliculaInicio()
            {
                errores = new List<string>(),
                Peliculas = new Peliculas
                {
                    id = 0,
                    name = null,
                    rating = 0,
                    director = null,
                    duracion = 0,
                    creacion = default,
                    synopsis = null,
                    generos = null,
                    URL = null
                },
               Comentario = new List<Comentario>()
            };

            if (req != null)
            {
                try
                {
                    long? idReturn = 0;
                    string name = "";
                    string director = "";
                    int? duracion = 0;
                    DateTime? creacion = null;
                    string synopsis = "";
                    string generos = "";
                    string url = "";
                    ConexionDataContext conexion = new ConexionDataContext();
                    List<SP_PELICULA_INICIOResult> listaTipoComplejo = new List<SP_PELICULA_INICIOResult>();
                    listaTipoComplejo = conexion.SP_PELICULA_INICIO(ref idReturn, ref name, ref director, ref duracion,
                        ref creacion, ref synopsis, ref generos, ref url).ToList();
                    if (idReturn != 0)
                    {
                        res.respuesta = true;
                        res.Peliculas.id = (long)idReturn;
                        res.Peliculas.name = name;
                        res.Peliculas.director = director;
                        res.Peliculas.duracion = (int)duracion;
                        res.Peliculas.creacion = (DateTime)creacion;
                        res.Peliculas.synopsis = synopsis;
                        res.Peliculas.generos = generos;
                        res.Peliculas.URL = url;
                        
                        foreach (SP_PELICULA_INICIOResult unTipo in listaTipoComplejo)
                        {
                            res.Comentario.Add(this.FactoriaComentarios(unTipo));
                        }
                    }
                    else
                    {
                        res.respuesta = false;
                        res.errores.Add("Error SP");
                    }
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
                res.errores.Add("Falta el Request");
            }

            return res;
        }
        
        private Comentario FactoriaComentarios(SP_PELICULA_INICIOResult unTipoComplejo)
        {
            Comentario comentarioRetornar = new Comentario();
            comentarioRetornar.Id = unTipoComplejo.IdComments;
            comentarioRetornar.usuario = unTipoComplejo.Nickname;
            comentarioRetornar.idPelicula = unTipoComplejo.FkIdMovie;
            comentarioRetornar.creationDate = unTipoComplejo.InsertDate;
            comentarioRetornar.comentario = unTipoComplejo.Comment;
            comentarioRetornar.rating = unTipoComplejo.CommentRating;

            return comentarioRetornar;
        }
    }
}