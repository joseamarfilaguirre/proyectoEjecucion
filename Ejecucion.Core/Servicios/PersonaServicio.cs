using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using Ejecucion.Core.Logica;
using Comun.Exceptions;

namespace Ejecucion.Core.Servicios
{
    class PersonaServicio : IPersonaServicio
    {
        private readonly PersonaLogica personaLogica = new PersonaLogica();
        public void ActualizarPersona(Persona persona)
        {
            try
            {
                personaLogica.ActualizarPersona(persona);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgreagarPersona(Persona persona)
        {
            try
            {
                personaLogica.AgregarPersona(persona);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void QuitarPersona(int personaId)
        {
            try
            {
                personaLogica.QuitarPersona(personaId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Persona traerPersona(int personaId)
        {
            try
            {
                return personaLogica.TraerPersona(personaId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Persona> TraerPersonas(string buscar)
        {
            try
            {
                return personaLogica.TraerPersonas(buscar);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
