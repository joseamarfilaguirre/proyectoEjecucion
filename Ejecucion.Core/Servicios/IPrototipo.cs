using Ejecucion.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion.Core.Servicios
{
    interface IPrototipo
    {
        //Programa
        List<Prototipo> TraerPrototipos(string buscar);
        Prototipo TraerPrototipo(int prototipoId);
        void AgregarPrototipo(Prototipo prototipo);
        void ActualizarPrototipo(Prototipo prototipo);
        void QuitarPrototipo(int prototipoId);
    }
}
}
