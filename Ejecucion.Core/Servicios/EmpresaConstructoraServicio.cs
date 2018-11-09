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
    public class EmpresaConstructoraServicio : IEmpresaConstructora
    {
        private readonly EmpresaConstructoraLogica empresaLogica = new EmpresaConstructoraLogica();
        public void ActualizarEmpresaConstructora(EmpresaConstructora empresa)
        {
            try
            {
                empresaLogica.ActualizarEmpresaConstructora(empresa);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AgregarEmpresaConstructora(EmpresaConstructora empresa)
        {
            try
            {
                empresaLogica.AgregarEmpresaConstructora(empresa);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }   
        }
        public void QuitarEmpresaConstructora(int empresaId)
        {
            try
            {
                empresaLogica.QuitarEmpresaContructora(empresaId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmpresaConstructora TraerEmpresaConstructora(int empresaId)
        {
            try
            {
                return empresaLogica.TraerEmpresaConstructora(empresaId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EmpresaConstructora> TraerEmpresasConstructoras(string buscar)
        {
            try
            {
                return empresaLogica.TraerEmpresasConstructoras(buscar);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
