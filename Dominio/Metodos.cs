using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Dominio
{
    public class Metodos
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select D.Titulo,D.FechaLanzamiento,D.CantidadCanciones,D.UrlImagenTapa,D.IdEstilo,D.IdTipoEdicion,D.Id,E.Descripcion Estilos ,T.Descripcion TiposEdicion From Discos D,Estilos E ,TiposEdicion T");
                datos.GenerarLetura();

                while (datos.Lector.Read())

                {
                    Discos aux = new Discos();

                    aux.Id = (int)datos.Lector["id"];
                    aux.titulo = (string)datos.Lector["titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["fechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)datos.Lector["urlImagenTapa"];
                    aux.IdEstilo = (int)datos.Lector["IdEstilo"];
                    aux.IdTipoEdicion = (int)datos.Lector["IdTipoEdicion"];

                    aux.Estilo = new Estilos();
                    aux.Estilo.Id = (int)datos.Lector["Id"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilos"];

                    aux.TiposEdicion = new TiposEdicion();
                    aux.TiposEdicion.Id = (int)datos.Lector["Id"];
                    aux.TiposEdicion.Descripcion = (string)datos.Lector["TiposEdicion"];

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
                datos.CerrarLectura();
            }


        }

        public void Nuevo(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Insert into Discos(titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)VALUES(@titulo,@fecha,@cantidad,@imagen,@estilo,@tapa)");
                datos.SetearParametro("@titulo",nuevo.titulo);
                datos.SetearParametro("@fecha",nuevo.FechaLanzamiento);
                datos.SetearParametro("@cantidad",nuevo.CantidadCanciones);
                datos.SetearParametro("@imagen",nuevo.UrlImagenTapa);
                datos.SetearParametro("@estilo",nuevo.Estilo.Id);
                datos.SetearParametro("@tapa",nuevo.TiposEdicion.Id);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }




    }
}
