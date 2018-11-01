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
        private readonly ObraLogica Logica = new ObraLogica(); 
        public void actualizarObra(Obras obra)
        {
            throw new NotImplementedException();
        }

        public void agregarObra(Obras obra)
        {
            throw new NotImplementedException();
        }

        public void eliminarObra(int obraId)
        {
            throw new NotImplementedException();
        }

        public List<DptoProvincia> TraerDptos(string Buscar)
        {
            throw new NotImplementedException();
        }

        public List<EmpresaConstructora> TraerEmpresaConstructora(string Buscar)
        {
            throw new NotImplementedException();
        }

        public Obras traerObra(int obraId)
        {
            throw new NotImplementedException();
        }

        public List<Obras> TraerObra(string Buscar)
        {
            try
            {
                return Logica.TraerObra(Buscar);
            }
            catch(NegocioException ex) { throw (ex); }
            catch(Exception ex){throw (ex);}
        }

        public List<Programa> TraerObras(string Buscar)
        {
            throw new NotImplementedException();
        }
    }
}
