using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion.Core.Entidades
{
    public partial class RelacionObraPrototipo
    {
        public int IdRelacionObraPrototipo { set; get; }
        public int CantidadViviendas { set; get; }
        public int IdObra { set; get; }
        public int IdPrototipo { set; get; }
    }
}
