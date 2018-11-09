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
    public class DptoprovinciaServicio : IDptoProvincia
    {
        private readonly DptoProvinciaLogica departamentoLogica = new DptoProvinciaLogica();

        public void ActualizarDptoprovincia(DptoProvincia departamento)
        {
            try
            {
                departamentoLogica.ActualizarDptoprovincia(departamento);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarDptoprovincia(DptoProvincia departamento)
        {
            try
            {
                departamentoLogica.AgregarDptoprovincia(departamento);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void QuitarDptoprovincia(int departamentoId)
        {
            try
            {
                departamentoLogica.QuitarDptoprovincia(departamentoId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DptoProvincia TraerDptoProvincia(int departamentoId)
        {
            try
            {
                return departamentoLogica.TraerDptoProvincia(departamentoId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DptoProvincia> TraerDptoProvincias(string buscar)
        {
            try
            {
                  return  departamento.TraerDptoProvincias(buscar);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
