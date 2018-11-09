using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;

namespace Ejecucion.Core.Servicios
{
    interface IPrograma
    {
        //Programa
        List<Programa> Traerprogramas(string buscar);
        Programa TraerPrograma(int programaId);
        void AgregarPrograma(Programa programa);
        void ActualizarPrograma(Programa programa);
        void QuitarProgramas(int programaId);
    }
}
