using Ejecucion.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion.Core.Servicios
{
    interface IPersonaServicio
    {
        //Deprtamento Provincia
        List<Persona> TraerPersonas(string buscar);
        Persona traerPersona(int personaId);
        void AgreagarPersona(Persona persona);
        void ActualizarPersona(Persona persona);
        void QuitarPersona(int personaId);
    }
}
