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
    class DptoProvinciaLogica
    {
        DptoProvinciaDato datos = new DptoProvinciaDato();
        internal List<DptoProvincia> TraerDptoProvincias(string buscar)
        {
            // throw new NotImplementedException();
            if (string.IsNullOrWhiteSpace(buscar))
                throw new NegocioException("No se ha ingresado ningún criterio de búsqueda. Intente de nuevo.");
            //return datos.TraerPersonas(buscar);
            var provincias = datos.traerDptoProvincias(buscar);
            if (provincias.Count > 0)
                return provincias;
            else
                throw new NegocioException("No se encontraron personas para el criterio de búsqueda ingresado.");
        }

        internal DptoProvincia TraerDptoProvincia(int departamentoId)
        {
            // throw new NotImplementedException();
            if (string.IsNullOrWhiteSpace(departamentoId))
                throw new NegocioException("No se ha ingresado ningún criterio de búsqueda. Intente de nuevo.");
            //return datos.TraerPersonas(buscar);
            var provincia = datos.traerDptoProvincia(departamentoId);
            if (provincia.Count > 0)
                return provincia;
            else
                throw new NegocioException("No se encontraron personas para el criterio de búsqueda ingresado.");
        }

        internal void QuitarDptoprovincia(int departamentoId)
        {
            DptoProvincia departamento = TraerDptoProvincia(departamentoId);
            datos.QuitarDepartamento(departamento);

        }

        internal void ActualizarDptoprovincia(DptoProvincia departamento)
        {
            if (departamento.IdDptoProv <= 0)
                throw new NegocioException("El identificador del departamento que se desea modificar no es válido. Verifique.");
            if (string.IsNullOrEmpty(departamento.DptoProv))
                throw new NegocioException("El departamento es requeridos.");
                datos.ActualizarDepartamento(departamento);

        }

        internal void AgregarDptoprovincia(DptoProvincia departamento)
        {
            if (departamento.IdDptoProv != 0)
                throw new NegocioException("El identificador del departamento a no es válido. Verifique.");
            if (string.IsNullOrEmpty(departamento.DptoProv))
                throw new NegocioException("El nombre del departamento debe ser ingresados.");
               datos.AgregarDepartamentoProvincia(departamento);
        }
    }
}
