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
    public class PrototipoServicio : IPrototipo
    {
        private readonly PrototipoLogica prototipoLogica = new PrototipoLogica();

        public void ActualizarPrototipo(Prototipo prototipo)
        {
            try
            {
                prototipoLogica.ActualizarPrototipo(prototipo);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarPrototipo(Prototipo prototipo)
        {
            try
            {
                prototipoLogica.AgregarPrototipo(prototipo);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void QuitarPrototipo(int prototipoId)
        {
            try
            {
                prototipoLogica.QuitarPrototipo(prototipoId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Prototipo TraerPrototipo(int prototipoId)
        {
            try
            {
                return prototipoLogica.TraerPrototipo(prototipoId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Prototipo> TraerPrototipos(string buscar)
        {
            try
            {
                return prototipoLogica.TraerPrototipos(buscar);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
