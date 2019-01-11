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
    class AvanceServicio : IAvance
    {
        private readonly AvanceLogica avanceLogica = new AvanceLogica();

        public void ActualizarAvance(Avance avance)
        {
            try
            {
                avanceLogica.ActualizarAvance(avance);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarAvance(Avance avance)
        {
            try
            {
                avanceLogica.AgregarAvance(avance);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void QuitarAvance(int idAvance)
        {
            try
            {
                avanceLogica.QuitarAvance(idAvance);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Avance TraerAvance(int avanceId)
        {
            try
            {
                return avanceLogica.TraerAvance(avanceId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Avance> TraerAvances(string buscar)
        {
            try
            {
                return avanceLogica.TraerAvances(buscar);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
