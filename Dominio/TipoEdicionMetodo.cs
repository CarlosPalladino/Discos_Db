using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoEdicionMetodo

    {

        public List<TiposEdicion> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<TiposEdicion> lista = new List<TiposEdicion>();
            try
            {
                datos.SetearConsulta("Select Id , Descripcion From  TiposEdicion");
                datos.GenerarLetura();

                while (datos.Lector.Read())
                {
                    TiposEdicion aux = new TiposEdicion();
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
        }


    }
}
