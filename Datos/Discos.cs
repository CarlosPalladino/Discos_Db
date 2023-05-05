using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Discos
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public int IdEstilo { get; set; }
        public int IdTipoEdicion { get; set; }

        public Estilos Estilo { get; set; }

        public TiposEdicion TiposEdicion { get; set; }
    }
}
