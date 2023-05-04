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
                datos.SetearConsulta("select Id,Titulo,FechaLanzamiento, CantidadCanciones,UrlImagenTapa, IdEstilo,IdTipoEdicion from Discos D  ,Estilos E ,TipodEdicion T where E.Id= D.IdEstilo, and T.Id = D.TipoEdicion");
                datos.GenerarLetura();

                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();

                    aux.Id = (int)datos.Lector["id"];
                    aux.titulo = (string)datos.Lector["titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["fechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)datos.Lector["urlImagenTapa"];

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

    }
}
