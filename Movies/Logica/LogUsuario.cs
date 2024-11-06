using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.AccesoDatos;
using Movies.Entidades;

namespace Movies.Logica
{
    internal class LogUsuario
    {
        public ResCrearUsuario crear(ReqCrearUsuario req)
        {
            ResCrearUsuario res = new ResCrearUsuario();
            res.errores = new List<string>();

            try {
                if (req != null)
                {
                    if (String.IsNullOrEmpty(req.Usuario.name))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta nombre");
                    } else if(String.IsNullOrEmpty(req.Usuario.lastName))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta apellido");
                    } else if (String.IsNullOrEmpty(req.Usuario.mail))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el email");
                    } else if (String.IsNullOrEmpty(req.Usuario.password))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el password");
                    } else if (String.IsNullOrEmpty(req.Usuario.nickname))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el nickname");
                    } else
                    {
                        int? idReturn = 0;
                        int? errorId = 0;
                        string errorBD = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_CREAR_USUARIO(req.Usuario.name, req.Usuario.lastName, req.Usuario.mail, req.Usuario.password, req.Usuario.nickname, ref idReturn, ref errorId, ref errorBD);

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
                else {
                    res.respuesta = false;
                    res.errores.Add("Req null");
                }

            } catch (Exception ex) 
            {
                res.respuesta = false;
                res.errores.Add(ex.Message);
            }
            return res;
        }

        public ResActualizarUsuario actualizar(ReqActualizarUsuario req)
        {
            ResActualizarUsuario res = new ResActualizarUsuario();
            res.errores = new List<string>();

            try
            {
                if (req != null)
                {
                    if(req.Usuario.id <= 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el Id");
                    }else if (String.IsNullOrEmpty(req.Usuario.name))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta nombre");
                    }
                    else if (String.IsNullOrEmpty(req.Usuario.lastName))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta apellido");
                    }
                    else if (String.IsNullOrEmpty(req.Usuario.password))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el password");
                    }
                    else if (String.IsNullOrEmpty(req.Usuario.nickname))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el nickname");
                    }
                    else
                    {
                        int? idReturn = 0;
                        int? errorId = 0;
                        string errorBD = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_ACTUALIZAR_USUARIO(req.Usuario.id, req.Usuario.name, req.Usuario.lastName, req.Usuario.password, req.Usuario.nickname, ref idReturn, ref errorId, ref errorBD);

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

        public ResMostrarUsuario mostrar (ReqMostrarUsuario req)
        {
            ResMostrarUsuario res = new ResMostrarUsuario();
            res.errores = new List<string>();

            try
            {
                if (req != null)
                {
                    if (req.Usuario.id < 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta Id");
                    }
                    else
                    {
                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_TRAER_USUARIO(req.Usuario.id);
                        SP_TRAER_USUARIOResult result = new SP_TRAER_USUARIOResult();

                        res.respuesta = true;
                        res.Usuario.id = result.IdUser;
                        res.Usuario.name = result.Name;
                        res.Usuario.lastName = result.LastName;
                        res.Usuario.mail = result.Mail;
                        res.Usuario.nickname = result.Nickname;
                        
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
                res.errores.Add (ex.Message);
            }
            return res;
        }
    }
}
