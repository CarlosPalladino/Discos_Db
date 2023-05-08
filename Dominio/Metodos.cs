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
        AccesoDatos datos = new AccesoDatos();
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select  Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,D.IdEstilo,D.IdTipoEdicion,D.Id,E.Descripcion Estilos,T.Descripcion TiposEdicion From Discos D,Estilos E ,TiposEdicion T WHERE E.Id = D.IdEstilo And T.Id = D.IdTipoEdicion");
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
            try
            {
                datos.SetearConsulta("Insert into Discos(titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)VALUES(@titulo,@fecha,@cantidad,@imagen,@estilo,@tapa)");
                datos.SetearParametro("@titulo", nuevo.titulo);
                datos.SetearParametro("@fecha", nuevo.FechaLanzamiento);
                datos.SetearParametro("@cantidad", nuevo.CantidadCanciones);
                datos.SetearParametro("@imagen", nuevo.UrlImagenTapa);
                datos.SetearParametro("@estilo", nuevo.Estilo.Id);
                datos.SetearParametro("@tapa", nuevo.TiposEdicion.Id);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
        public void Modificar(Discos disco)
        {

            try
            {
                datos.SetearConsulta("Update Discos set  titulo=@titulo,FechaLanzamiento =@fecha,CantidadCanciones=@canciones,UrlImagenTapa=@imagen,IdEstilo=@estilo,IdTipoEdicion=@tipo Where Id=@id ");
                datos.SetearParametro("@titulo", disco.titulo);
                datos.SetearParametro("@fecha", disco.FechaLanzamiento);
                datos.SetearParametro("@canciones", disco.CantidadCanciones);
                datos.SetearParametro("@imagen", disco.UrlImagenTapa);
                datos.SetearParametro("@estilo", disco.Estilo.Id);
                datos.SetearParametro("@tipo", disco.TiposEdicion.Id);
                datos.SetearParametro("@Id", disco.Id);


                datos.GenerarLetura();

            }
            catch (Exception ex)
            {

                throw ex;
            }









        }
        public void Eliminar(int Id)
        {


            try
            {
                datos.SetearConsulta("Delete from Discos Where Id =@id");
                datos.SetearParametro("@id", Id);
                datos.GenerarLetura();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void filtrar(string campo, string criterio, string filtro)
        {
            try
            {
                string consulta = "Select  Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,D.IdEstilo,D.IdTipoEdicion,D.Id,E.Descripcion Estilos,T.Descripcion TiposEdicion From Discos D,Estilos E ,TiposEdicion T WHERE E.Id = D.IdEstilo And T.Id = D.IdTipoEdicion and ";
                if (campo == "Estilo")
                {
                    switch (criterio)
                    {
                        case "Rock":
                            consulta += " Estilo  '%" + filtro + "+' ";
                            break;
                        case "Pop":
                            consulta += "Estilo  '%" + filtro + " +' ";
                            break;
                        default:
                            consulta += " Estilo   '%" + filtro + " + '";
                            break;


                    }
                }
                else if (campo == "Tapa")
                {
                    switch (campo == "TipoEdicion")
                    {

                    }
                }
                else
                {
                    switch (campo == "CantitdadCanciones")
                    {

                    }

                }


            }
            catch (Exception)
            {

                throw;
            }


            try
            {


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
