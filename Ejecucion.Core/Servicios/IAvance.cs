using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;

namespace Ejecucion.Core.Servicios
{
    interface IAvance
    {
            List<Avance> TraerAvances(string buscar);
            Avance TraerAvance(int avanceId);
            void AgregarAvance(Avance avance);
            void ActualizarAvance(Avance avance);
            void QuitarAvance(int idAvance);
    }
}
