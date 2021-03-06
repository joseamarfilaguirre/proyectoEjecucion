﻿using System;
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
            try
            {
                programaLogica.ActualizarPrograma(programa);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarPrograma(Programa programa)
        {
            try
            {
                programaLogica.AgregarPrograma(programa);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void QuitarPrograma(int programaId)
        {
            try
            {
                programaLogica.QuitarPrograma(programaId);
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
                return programaLogica.TraerPrograma(programaId);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Programa> TraerProgramas(string buscar)
        {
            try
            {
                return programaLogica.TraerProgramas(buscar);
            }
            catch (NegocioException ex) { throw (ex); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
