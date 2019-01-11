using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion.Core.Entidades
{
    public partial class RelacionSeguimeintoPersona
    {
        public int IdRelacionSeguimientoPersona { set; get; }
        public int IdRolSeguimiento { set; get; }
        public int IdSeguimiento { set; get; }
        public int idPersona { set; get; }
    }
}
