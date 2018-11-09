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
    public class ProgramaServicio : IPrograma
    {
        private readonly ProgramaLogica programaLogica = new ProgramaLogica();

        public void ActualizarPrograma(Programa programa)
        {
            throw new NotImplementedException();
        }

        public void AgregarPrograma(Programa programa)
        {
            throw new NotImplementedException();
        }

        public void QuitarPrograma(int programaId)
        {
            throw new NotImplementedException();
        }

        public void QuitarProgramas(int programaId)
        {
            try
            {
                programaLogica.QuitarProgramas(programaId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Programa TraerPrograma(int programaId)
        {
            try
            {
                return programaLogica.Traerprograma(programaId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Programa> Traerprogramas(string buscar)
        {
            try
            {
                return programaLogica.Traerprogramas(buscar);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
