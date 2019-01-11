using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using Ejecucion.Core.Datos;
using Comun.Exceptions;
using Comun.Conexion;

namespace Ejecucion.Core.Logica
{
    class AvanceLogica : IDisposable
    {
        AvanceDato avanceDatos = new AvanceDato();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void ActualizarAvance(Avance avance)
        {
            if (avance.IdAvance != 0)
                throw new NegocioException("El identificador de avance que se desea modificar no es válido. Verifique.");
            if (string.IsNullOrEmpty(avance.Fechaavance.ToString()))
                throw new NegocioException("Fecha es requerida.");
            avanceDatos.ActualizarAvance(avance);

        }
        internal void AgregarAvance(Avance avance)
        {
            if (avance.IdAvance != 0)
                throw new NegocioException("El identificador de avance no es válido. Verifique.");
            if (string.IsNullOrEmpty(avance.Fechaavance.ToString()))
                throw new NegocioException("La fecha de avance debe ser ingresados.");
            //datos 
                avanceDatos.AgregarAvance(avance);
        }

        internal void QuitarAvance(int idAvance)
        {
            Avance avance = TraerAvance(idAvance);
             avanceDatos.QuitarAvance(avance);

        }

        internal Avance TraerAvance(int avanceId)
        {
            if (avanceId <= 0)
                throw new NegocioException("El identificador del avance no es correcto. Verifique.");
            return avanceDatos.TraerAvance(avanceId);
        }

        internal List<Avance> TraerAvances(string buscar)
        {
            // throw new NotImplementedException();
            if (string.IsNullOrWhiteSpace(buscar))
                throw new NegocioException("No se ha ingresado ningún criterio de búsqueda. Intente de nuevo.");
            //return datos.TraerPersonas(buscar);
            var avances = avanceDatos.traerAvances(buscar);
            if (avances.Count > 0)
                return avances;
            else
                throw new NegocioException("No se encontraron personas para el criterio de búsqueda ingresado.");
        }

    }
}
