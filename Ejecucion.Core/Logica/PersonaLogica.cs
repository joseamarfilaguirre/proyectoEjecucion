using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using Ejecucion.Core.Datos;
using Comun.Exceptions;

namespace Ejecucion.Core.Logica
{
    class PersonaLogica
    {
        PersonaDato personaDato = new PersonaDato();

        internal void AgregarPersona(Persona persona)
        {
            if (persona.IdPersona != 0)
                throw new NegocioException("El identificador de la persona no es válido. Verifique.");
            if (string.IsNullOrEmpty(persona.ApellidoNombre))
                throw new NegocioException("el nombre de la persona debe ser ingresados.");
            personaDato.AgregarPersona(persona);
        }

        internal void QuitarPersona(int personaId)
        {
            Persona persona = TraerPersona(personaId);
            personaDato.QuitarPersona(persona);
        }

        internal void ActualizarPersona(Persona persona)
        {
            if (persona.IdPersona != 0)
                throw new NegocioException("El identificador de la persona que se desea modificar no es válido. Verifique.");
            if (string.IsNullOrEmpty(persona.ApellidoNombre))
                throw new NegocioException("Nombre y apellido es requerido.");
            personaDato.ActualizarPersona(persona);
        }

        internal Persona TraerPersona(int personaId)
        {
            if (personaId <= 0)
                throw new NegocioException("El identificador de la persona no es correcto. Verifique.");
            return personaDato.TraerPersona(personaId);
        }

        internal List<Persona> TraerPersonas(string buscar)
        {
            // throw new NotImplementedException();
            if (string.IsNullOrWhiteSpace(buscar))
                throw new NegocioException("No se ha ingresado ningún criterio de búsqueda. Intente de nuevo.");
            //return datos.TraerPersonas(buscar);
            var personas = personaDato.traerPersonas(buscar);
            if (personas.Count > 0)
                return personas;
            else
                throw new NegocioException("No se encontraron personas para el criterio de búsqueda ingresado.");
        }
    }
}
