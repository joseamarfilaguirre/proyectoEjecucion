using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using Comun.Conexion;
using Ejecucion.Core.Datos;
using Comun.Exceptions;
namespace Ejecucion.Core.Logica
{
    class EmpresaConstructoraLogica: IDisposable
    {
        EmpresaConstructoraDato empresaDato = new EmpresaConstructoraDato();
        internal EmpresaConstructora TraerEmpresaConstructora(int empresaId)
        {
            if (empresaId <= 0)
                throw new NegocioException("El identificador de la empresa no es correcto. Verifique.");
            return empresaDato.TraerEmpresaConstructora(empresaId);
        }

        internal void QuitarEmpresaContructora(int empresaId)
        {
            EmpresaConstructora empresa = TraerEmpresaConstructora(empresaId);
            empresaDato.QuitarEmpresaConstructora(empresa);
        }

        internal void ActualizarEmpresaConstructora(EmpresaConstructora empresa)
        {
            if (empresa.IdEmpConstructora!= 0)
                throw new NegocioException("El identificador de la empresa que se desea modificar no es válido. Verifique.");
            if (string.IsNullOrEmpty(empresa.EmpConstructora))
                throw new NegocioException("Nombre es requerido.");
            empresaDato.ActualizarEmpresaConstructora(empresa);
        }

        internal void AgregarEmpresaConstructora(EmpresaConstructora empresa)
        {
            if (empresa.IdEmpConstructora != 0)
                throw new NegocioException("El identificador de empresa no es válido. Verifique.");
            if (string.IsNullOrEmpty(empresa.EmpConstructora))
                throw new NegocioException("el nombre de empresa debe ser ingresados.");
            empresaDato.AgregarEmpresaConstructora(empresa);
        }

        internal List<EmpresaConstructora> TraerEmpresasConstructoras(string buscar)
        {
            // throw new NotImplementedException();
            if (string.IsNullOrWhiteSpace(buscar))
                throw new NegocioException("No se ha ingresado ningún criterio de búsqueda. Intente de nuevo.");
            //return datos.TraerPersonas(buscar);
            var empresa = empresaDato.traerEmpresasConstructoras();
            if (empresa.Count > 0)
                return empresa;
            else
                throw new NegocioException("No se encontraron empresas para el criterio de búsqueda ingresado.");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
