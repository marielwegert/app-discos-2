using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace negocio
{
    public class DiscoNegocio
    {
        //PONIENDO ASI EN GENERAL FUNCIONA BIEN PARECE,
        //en vez de llamar en cada metodo
        private AccesoDatos datos;
        //METODO
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion Estilo, T.Descripcion TipoEdicion, D.IdEstilo,D.IdTipoEdicion, D.Id From DISCOS D, ESTILOS E, TIPOSEDICION T Where E.Id = D.IdEstilo AND T.Id=D.IdTipoEdicion");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];

                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

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

        //METODO
        public void agregar(Disco nuevo)
        {
            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa)values(@titulo, @fechaLanzamiento, @cantidadCanciones, @idEstilo, @idTipoEdicion, @urlImagenTapa)");
                datos.setearParametro("@titulo", nuevo.Titulo);
                datos.setearParametro("@fechaLanzamiento", nuevo.FechaLanzamiento);
                datos.setearParametro("@cantidadCanciones", nuevo.CantidadCanciones);
                datos.setearParametro("@idEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@idTipoEdicion", nuevo.TipoEdicion.Id);
                datos.setearParametro("@urlImagenTapa", nuevo.UrlImagenTapa);

                datos.ejecutarAccion();
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

        //METODO
        public void modificar(Disco modificar)
        {
            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo=@titulo, FechaLanzamiento=@fechaLanzamiento, CantidadCanciones=@cantidadCanciones, UrlImagenTapa=@urlImagenTapa, IdEstilo=@IdEstilo, IdTipoEdicion=@idTipoEdicion where Id=@id");
                datos.setearParametro("@titulo", modificar.Titulo);
                datos.setearParametro("@fechaLanzamiento", modificar.FechaLanzamiento);
                datos.setearParametro("@cantidadCanciones", modificar.CantidadCanciones);
                datos.setearParametro("@urlImagenTapa", modificar.UrlImagenTapa);
                datos.setearParametro("@idEstilo", modificar.Estilo.Id);
                datos.setearParametro("@idTipoEdicion", modificar.TipoEdicion.Id);
                datos.setearParametro("@id", modificar.Id);

                datos.ejecutarAccion();
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

        //METODO
        public void eliminar(int id)
        {
            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from DISCOS where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
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

        //METODO
        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            datos = new AccesoDatos();
            try
            {
                string consulta = "select D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion Estilo, T.Descripcion TipoEdicion, D.IdEstilo,D.IdTipoEdicion, D.Id From DISCOS D, ESTILOS E, TIPOSEDICION T Where E.Id = D.IdEstilo AND T.Id = D.IdTipoEdicion AND ";

                switch (campo)
                {
                    case "Título":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "D.Titulo like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "D.Titulo like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "D.Titulo like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Fecha de lanzamiento":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "D.FechaLanzamiento > '" + filtro + "'";
                                break;
                            case "Menor a":
                                consulta += "D.FechaLanzamiento < '" + filtro + "'";
                                break;
                            default:
                                consulta += "D.FechaLanzamiento = '" + filtro + "'";
                                break;
                        }
                        break;

                    default:
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "D.CantidadCanciones > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "D.CantidadCanciones < " + filtro;
                                break;
                            default:
                                consulta += "D.CantidadCanciones = " + filtro;
                                break;
                        }
                        break;
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];

                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

                    //Guarda los objetos en la lista
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
