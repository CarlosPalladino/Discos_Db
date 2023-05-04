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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("")

            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
