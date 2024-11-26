﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TipoEdicionNegocio
    {
        //METODO que se usa en la clase "frmAltaDisco"
        public List<TipoEdicion> listar()
        {
            List<TipoEdicion> lista = new List<TipoEdicion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from TIPOSEDICION");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
