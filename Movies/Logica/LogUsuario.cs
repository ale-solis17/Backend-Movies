using System;
using System.Collections.Generic;
using System.Linq;
using Movies.AccesoDatos;
using Movies.Entidades;

namespace Movies.Logica
{
    public class LogUsuario
    {
        public ResCrearUsuario Crear(ReqCrearUsuario req)
        {
            ResCrearUsuario res = new ResCrearUsuario
            {
                errores = new List<string>()
            };

            try
            {
                if (req != null)
                {
                    if (String.IsNullOrEmpty(req.Usuario.name))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta nombre");
                    }
                    else if (String.IsNullOrEmpty(req.Usuario.lastName))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta apellido");
                    }
                    else if (String.IsNullOrEmpty(req.Usuario.mail))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el email");
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
                        string errorBd = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_CREAR_USUARIO(req.Usuario.name, req.Usuario.lastName, req.Usuario.mail,
                            req.Usuario.password, req.Usuario.nickname, ref idReturn, ref errorId, ref errorBd);

                        if (idReturn <= 0)
                        {
                            res.respuesta = false;
                            res.errores.Add(errorBd);
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

        public ResActualizarUsuario Actualizar(ReqActualizarUsuario req)
        {
            ResActualizarUsuario res = new ResActualizarUsuario
            {
                errores = new List<string>()
            };

            try
            {
                if (req != null)
                {
                    if (req.Usuario.id <= 0)
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el Id");
                    }
                    else if (String.IsNullOrEmpty(req.Usuario.name))
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
                    else if (String.IsNullOrEmpty(req.Usuario.mail))
                    {
                        res.respuesta = false;
                        res.errores.Add("Falta el email");
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
                        string errorBd = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_ACTUALIZAR_USUARIO(req.Usuario.id, req.Usuario.name, req.Usuario.lastName,
                            req.Usuario.password, req.Usuario.nickname, ref idReturn, ref errorId, ref errorBd);

                        if (idReturn <= 0)
                        {
                            res.respuesta = false;
                            res.errores.Add(errorBd);
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

        public ResMostrarUsuario Mostrar(ReqMostrarUsuario req)
        {
            ResMostrarUsuario res = new ResMostrarUsuario
            {
                errores = new List<string>(),
                Usuario = new Usuario()
            };

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
                        long? idReturn = 0;
                        string name = "";
                        string lastName = "";
                        string mail = "";
                        string nickname = "";
                        string userType = "";
                        string userStatus = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_TRAER_USUARIO(req.Usuario.id, ref idReturn, ref name, ref lastName, ref mail,
                            ref nickname, ref userType, ref userStatus);

                        if (idReturn != 0)
                        {
                            res.respuesta = true;
                            res.Usuario.id = (long)idReturn;
                            res.Usuario.name = name;
                            res.Usuario.lastName = lastName;
                            res.Usuario.mail = mail;
                            res.Usuario.nickname = nickname;
                            res.Usuario.userType = userType;
                            res.Usuario.userStatus = userStatus;
                        }
                        else
                        {
                            res.respuesta = false;
                            res.errores.Add("Error SP");
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

        public ResLogin Login(ReqLogin req)
        {
            ResLogin res = new ResLogin
            {
                errores = new List<string>(),
                Usuario = new Usuario()
            };

            if (req != null)
            {
                if (String.IsNullOrEmpty(req.Usuario.mail))
                {
                    res.respuesta = false;
                    res.errores.Add("Falta el email");
                }
                else if (String.IsNullOrEmpty(req.Usuario.mail))
                {
                    res.respuesta = false;
                    res.errores.Add("Falta el password");
                }
                else
                {
                    try
                    {
                        int? idReturn = 0;
                        int? errorId = 0;
                        String errorBd = "";
                        String nombre = "";
                        String apellidos = "";
                        String nickname = "";
                        String userType = "";
                        String userStatus = "";

                        ConexionDataContext conexion = new ConexionDataContext();
                        conexion.SP_LOGIN_USUARIO(req.Usuario.mail, req.Usuario.password, ref idReturn, ref errorId,
                            ref errorBd, ref nombre, ref apellidos, ref nickname, ref userType, ref userStatus);

                        if (errorId == 0)
                        {
                            res.respuesta = true;
                            res.errores.Add(errorBd);
                            res.Usuario.id = (long)idReturn;
                            res.Usuario.name = nombre;
                            res.Usuario.lastName = apellidos;
                            res.Usuario.mail = req.Usuario.mail;
                            res.Usuario.nickname = nickname;
                            res.Usuario.userType = userType;
                            res.Usuario.userStatus = userStatus;
                        }
                        else
                        {
                            res.respuesta = false;
                            res.errores.Add(errorBd);
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
    }
}