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
    }
}