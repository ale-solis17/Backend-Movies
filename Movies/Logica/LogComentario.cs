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
    public class LogComentario
    {
        public ResCrearComentario Crear(ReqCrearComentario req)
        {
            ResCrearComentario res = new ResCrearComentario
            {
                errores = new List<string>()
            };

            try
            {
                if (req != null)
                {
                    if (req.Comentario.idUsuario < 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el IdUsuario");
                    }
                    else if (req.Comentario.idPelicula < 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el IdPelicula");
                    }
                    else if (String.IsNullOrEmpty(req.Comentario.comentario))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el comentario");
                    }
                    else
                    {
                        long? idReturn = 0;
                        int? errorId = 0;
                        string errorBD = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_CREAR_COMENTARIO(req.Comentario.idUsuario, req.Comentario.idPelicula,
                            req.Comentario.comentario, req.Comentario.rating, ref idReturn, ref errorId, ref errorBD);

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
                    res.errores.Add("Falta el req");
                }
            }
            catch (Exception ex)
            {
                res.respuesta = false;
                res.errores.Add(ex.Message);
            }

            return res;
        }

        public ResBorrarComentario Borrar(ReqBorrarComentario req)
        {
            ResBorrarComentario res = new ResBorrarComentario
            {
                errores = new List<string>()
            };

            try
            {
                if (req != null)
                {
                    if (req.Comentario.idUsuario <= 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el idUsuario");
                    }
                    else if (req.Comentario.Id <= 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el idComentario");
                    }
                    else
                    {
                        long? idReturn = 0;
                        int? errorId = 0;
                        string errorBD = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_BORRAR_COMENTARIO(req.Comentario.idUsuario, req.Comentario.Id, ref idReturn,
                            ref errorId, ref errorBD);

                        if (errorId > 0)
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
                    res.errores.Add("Falta el req");
                }
            }
            catch (Exception ex)
            {
                res.respuesta = false;
                res.errores.Add(ex.Message);
            }

            return res;
        }

        public ResMostrarComentarios Mostrar(ReqMostrarComentarios req)
        {
            ResMostrarComentarios res = new ResMostrarComentarios
            {
                errores = new List<string>(),
                Comentarios = new List<Comentario>()
            };

            try
            {
                if (req.Comentario.idPelicula <= 0)
                {
                    res.respuesta = false;
                    res.errores.Add("Falta el idPelicula");
                }
                else
                {
                    int? idReturn = 0;
                    int? errorId = 0;
                    string errorBD = "";

                    ConexionDataContext conexion = new ConexionDataContext();
                    List<SP_MOSTRAR_COMENTARIOSResult> listaTipoComplejo = new List<SP_MOSTRAR_COMENTARIOSResult>();
                    listaTipoComplejo = conexion
                        .SP_MOSTRAR_COMENTARIOS(req.Comentario.idPelicula, ref idReturn, ref errorId, ref errorBD)
                        .ToList();

                    foreach (SP_MOSTRAR_COMENTARIOSResult unTipo in listaTipoComplejo)
                    {
                        res.Comentarios.Add(this.FactoriaComentarios(unTipo));
                    }

                    res.respuesta = true;
                }
            }
            catch (Exception ex)
            {
                res.respuesta = false;
                res.errores.Add(ex.Message);
            }

            return res;
        }

        private Comentario FactoriaComentarios(SP_MOSTRAR_COMENTARIOSResult unTipoComplejo)
        {
            Comentario comentarioRetornar = new Comentario();
            comentarioRetornar.Id = unTipoComplejo.IdComments;
            comentarioRetornar.idUsuario = unTipoComplejo.FkIdUser;
            comentarioRetornar.idPelicula = unTipoComplejo.FkIdMovie;
            comentarioRetornar.creationDate = unTipoComplejo.InsertDate;
            comentarioRetornar.comentario = unTipoComplejo.Comment;
            comentarioRetornar.rating = unTipoComplejo.CommentRating;

            return comentarioRetornar;
        }
    }
}