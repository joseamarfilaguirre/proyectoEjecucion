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
    class ObraLogica
    {
        ObraDato datos = new ObraDato();

        internal Obras TraerObra(int obraId)
        {
            if (obraId<=0)
                throw new NotImplementedException("El Identificador de la Obra no es correcto. Verifique.");
            return datos.TraerObra(obraId);
        }

        internal List<Obras> TraerObras(String buscar)
        {
            if (string.IsNullOrWhiteSpace(buscar))
                throw new NotImplementedException("No se ha ningún criterio de busqueda. Intente de nuevo.");
            List<Obras> obras = datos.TraerObras(buscar);
            if (obras.Count > 0)
                return obras;
            else
                throw new NotImplementedException("No se ha ningún criterio de busqueda. Intente de nuevo.");
        }

        internal void ActualizarObra(Obras obra)
        {
            if (obra.IdObra<=0)
                throw new NegocioException("El Identificador de la Obra que se desea modificar no es válido. Verifique");
            if (string.IsNullOrWhiteSpace(obra.ObraNombre) || string.IsNullOrWhiteSpace(obra.ACCU))
                throw new NegocioException("La Obra y el ACCU deben ser requeridos.");
            datos.ActualizarObra(obra);
        }

        internal void AgregarObra(Obras obra)
        {
            if (obra.IdObra != 0)
                throw new NegocioException("El Identificador de la Obra no es válido. Verifique");
            if (string.IsNullOrWhiteSpace(obra.ObraNombre)|| string.IsNullOrWhiteSpace(obra.ACCU))
                throw new NegocioException("La Obra y el ACCU deben ser ingresados.");
            datos.AgregarObra(obra);
            
        }

        internal void EliminarObra(int obraId)
        {
            Obras obra = TraerObra(obraId);
            datos.EliminarObra(obra);
            
        }

        internal List<DptoProvincia> TraerDptos()
        {
            List<DptoProvincia> dptos = datos.TraerDptoProvincia();
            if (dptos.Count > 0)
                return dptos;
            throw new NegocioException("No se encontró Dpto. Verifique");
        }

        internal List<EmpresaConstructora> TraerEmpresaConstructora()
        {
            List<EmpresaConstructora> empConstructora = datos.TraerEmpConstructora();
            if (empConstructora.Count > 0)
                return empConstructora;
            throw new NegocioException("No se encontró Empresa Constructora. Verifique");
        }

        //internal List<Programa> TraerPrograma()
        //{
        //    List<Programa> programa = datos.TraerPrograma();
        //    if (programa.Count > 0)
        //        return programa;
        //    throw new NegocioException("No se encontró Programa. Verifique");
        //}
    }
}
