using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using Comun.Exceptions;
using Ejecucion.Core.Datos;

namespace Ejecucion.Core.Logica
{
    class ProgramaLogica
    {
        private readonly ProgramaDato programadato = new ProgramaDato();
        internal void ActualizarPrograma(Programa programa)
        {
            if (programa.IdPrograma != 0)
                throw new NegocioException("El identificador del programa que se desea modificar no es válido. Verifique.");
            if (string.IsNullOrEmpty(programa.NombrePrograma))
                throw new NegocioException("Nombre es requerido.");
            programadato.ActualizarPrograma(programa);
        }

        internal void AgregarPrograma(Programa programa)
        {
            if (programa.IdPrograma != 0)
                throw new NegocioException("El identificador de programa no es válido. Verifique.");
            if (string.IsNullOrEmpty(programa.NombrePrograma))
                throw new NegocioException("el nombre del programa debe ser ingresados.");
            programadato.AgregarPrograma(programa);
        }

        internal void QuitarPrograma(int programaId)
        {
            Programa programa = TraerPrograma(programaId);
            programadato.QuitarPrograma(programa);
        }

        internal Programa TraerPrograma(int programaId)
        {
            if (programaId <= 0)
                throw new NegocioException("El identificador del programa no es correcto. Verifique.");
            return programadato.TraerPrograma(programaId);
        }

        internal List<Programa> TraerProgramas(string buscar)
        {
            // throw new NotImplementedException();
            if (string.IsNullOrWhiteSpace(buscar))
                throw new NegocioException("No se ha ingresado ningún criterio de búsqueda. Intente de nuevo.");
            //return datos.TraerPersonas(buscar);
            var programas = programadato.traerProgramas(buscar);
            if (programas.Count > 0)
                return programas;
            else
                throw new NegocioException("No se encontraron programas para el criterio de búsqueda ingresado.");
        }
    }
}
