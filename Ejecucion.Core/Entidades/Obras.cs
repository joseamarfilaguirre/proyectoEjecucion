using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion.Core.Entidades
{
    public partial class Obras
    {
        public int IdObra { set; get; }
        public string ExpMatriz { set; get; }
        public string ObraNombre { set; get; }
        public string ACCU { set; get; }
        public int IdDptoProv { set; get; }
        public int IdPrograma { set; get; }
        public int CantViviendas { set; get; }
        public int IdEmpConstructora { set; get; }
        public int? CantParaSorteo { set; get; }
        public float MontoOriginal { set; get; }
        public string LicitacionResolucion { set; get; }
        public int PlazoOriginal { set; get; }
        public DateTime FechaFinalizacion { set; get; }
        public int IdAvance { set; get; }
        public float MontoContratoPesos { set; get; }
        public float MontoContratoUVI { set; get; }
        public DateTime FechaOferta { set; get; }
    }
}
