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
    class PrototipoLogica
    {
        private readonly PrototipoDato prototipoDato = new PrototipoDato();
        internal void AgregarPrototipo(Prototipo prototipo)
        {
            if (prototipo.IdPrototipo != 0)
                throw new NegocioException("El identificador de prototipo no es válido. Verifique.");
            if (string.IsNullOrEmpty(prototipo.DescripcionPrototipo))
                throw new NegocioException("el nombre del programa debe ser ingresados.");
            prototipoDato.AgregarPrototipo(prototipo);
        }

        internal void QuitarPrototipo(int prototipoId)
        {
            Prototipo prototipo = TraerPrototipo(prototipoId);
            prototipoDato.QuitarPrototipo(prototipo);
        }

        internal void ActualizarPrototipo(Prototipo prototipo)
        {
            if (prototipo.IdPrototipo != 0)
                throw new NegocioException("El identificador del prototipo que se desea modificar no es válido. Verifique.");
            if (string.IsNullOrEmpty(prototipo.DescripcionPrototipo))
                throw new NegocioException("Nombre es requerido.");
            prototipoDato.ActualizarPrototipo(prototipo);
        }

        internal Prototipo TraerPrototipo(int prototipoId)
        {
            if (prototipoId <= 0)
                throw new NegocioException("El identificador del prototipo no es correcto. Verifique.");
            return prototipoDato.TraerPrototipo(prototipoId);
        }

        internal List<Prototipo> TraerPrototipos(string buscar)
        {
            // throw new NotImplementedException();
            if (string.IsNullOrWhiteSpace(buscar))
                throw new NegocioException("No se ha ingresado ningún criterio de búsqueda. Intente de nuevo.");
            //return datos.TraerPersonas(buscar);
            var prototipos = prototipoDato.TraerPrototipos(buscar);
            if (prototipos.Count > 0)
                return prototipos;
            else
                throw new NegocioException("No se encontraron prototipos para el criterio de búsqueda ingresado.");
        }
    }
}
