using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class EstiloMetodo
    {

        public List<Estilos> listar()
        {

            List<Estilos> list = new List<Estilos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select Id , Descripcion From  ESTILOS");
                datos.GenerarLetura();

                while (datos.Lector.Read())

                {
                    Estilos aux = new Estilos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    list.Add(aux);
                }

                return list;
            }

        
            catch (Exception ex)
            {

                throw ex;
            }


        }




    }
}
