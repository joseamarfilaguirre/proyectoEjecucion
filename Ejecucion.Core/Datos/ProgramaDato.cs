﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using Comun.Conexion;
using System.Data.SqlClient;
using System.Data;
using Comun.Exceptions;

namespace Ejecucion.Core.Datos
{
    class ProgramaDato : DatoBase, IDisposable
    {
        internal void AgregarPrograma(Programa programa)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_programa", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPrograma", SqlDbType.Int);
                cmd.Parameters["@xIdPrograma"].Value = programa.IdPrograma;

                cmd.Parameters.Add("@xPrograma", SqlDbType.VarChar);
                cmd.Parameters["@xPrograma"].Value = programa.NombrePrograma;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "A";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego el Programa. Verifique los datos.");
            }
        }

        internal void ActualizarPrograma(Programa programa)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_programa", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPrograma", SqlDbType.Int);
                cmd.Parameters["@xIdPrograma"].Value = programa.IdPrograma;

                cmd.Parameters.Add("@xPrograma", SqlDbType.VarChar);
                cmd.Parameters["@xPrograma"].Value = programa.NombrePrograma;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "M";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se modifico el Programa. Verifique los datos.");
            }
        }

        internal void QuitarPrograma(Programa programa)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_programa", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPrograma", SqlDbType.Int);
                cmd.Parameters["@xIdPrograma"].Value = programa.IdPrograma;

                cmd.Parameters.Add("@xPrograma", SqlDbType.VarChar);
                cmd.Parameters["@xPrograma"].Value = programa.NombrePrograma;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "B";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se elimino el Programa. Verifique los datos.");
            }
        }

        internal Programa TraerPrograma(int programaId)
        {
            throw new NotImplementedException();
        }

        internal object traerProgramas(string buscar)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
