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
    public class ObraServicio : IObraServicio
    {
        private readonly ObraLogica logica = new ObraLogica(); 
        public void actualizarObra(Obras obra)
        {
            try
            {
                logica.ActualizarObra(obra);
            }
            catch (NegocioException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        public void agregarObra(Obras obra)
        {
            try
            {
                logica.AgregarObra(obra);
            }
            catch (NegocioException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        public void eliminarObra(int obraId)
        {
            try
            {
                logica.EliminarObra(obraId);
            }
            catch (NegocioException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        public List<DptoProvincia> TraerDptos(string Buscar)
        {
            try
            {
                return logica.TraerDptos();
            }
            catch (NegocioException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        public List<EmpresaConstructora> TraerEmpresaConstructora(string Buscar)
        {
            try
            {
                return logica.TraerEmpresaConstructora();
            }
            catch (NegocioException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        public Obras traerObra(int obraId)
        {
            try
            {
                return logica.TraerObra(obraId);
            }
            catch(NegocioException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            
        }

        public List<ObraBrowse> TraerObra(int obraId)
        {
            try
            {
                return logica.TraerObras(obraId);
            }
            catch(NegocioException ex) { throw (ex); }
            catch(Exception ex){throw (ex);}
        }

        public List<Programa> TraerObras(string Buscar)
        {
            try
            {
                return logica.TraerObras();
            }
            catch (NegocioException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }
    }
}
