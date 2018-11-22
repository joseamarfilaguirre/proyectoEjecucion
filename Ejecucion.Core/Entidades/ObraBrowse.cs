using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion.Core.Entidades
{
    public class ObraBrowse
    {
        public int IdObra { get; set; }
        public string ExpMatriz { get; set; }
        public string Obra { get; set; }
        public string ACCU { get; set; }
        public int IdDptoProvincia { get; set; }
        public int IdPrograma { get; set; }
        public int IdEmpConstructora { get; set; }
        public int CantParaSorteo { get; set; }
        public float montoOriginal { get; set; }
        public string licitacionResolucion { get; set; }
        public int plazoOriginal { get; set; }
        public DateTime fechaFinalizacion { get; set; }
        public float MontoContratoPesos { get; set; }
        public float MontoContratoUVI { get; set; }
        public DateTime FechaOferta { get; set; }


    }
}
