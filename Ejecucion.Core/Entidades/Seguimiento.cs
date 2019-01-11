using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion.Core.Entidades
{
    public partial class Seguimiento
    {
        public int IdSeguimiento { set; get; }
        public DateTime FechaSeguimeinto { set; get; }
        public int IdObra { set; get; }
        public int idEstadoObra { set; get; }
    }
}
