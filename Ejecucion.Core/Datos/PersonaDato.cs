using Comun.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using System.Data.SqlClient;
using System.Data;
using Comun.Exceptions;

namespace Ejecucion.Core.Datos
{
    class PersonaDato : DatoBase, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void AgregarPersona(Persona persona)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_persona", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPersona", SqlDbType.Int);
                cmd.Parameters["@xIdPersona"].Value = persona.IdPersona;

                cmd.Parameters.Add("@xApellidoNombre", SqlDbType.VarChar);
                cmd.Parameters["@xApellidoNombre"].Value = persona.ApellidoNombre;

                cmd.Parameters.Add("@xDocumento", SqlDbType.VarChar);
                cmd.Parameters["@xDocumento"].Value = persona.Documento;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "A";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego la Persona. Verifique los datos.");
            }
        }

        internal void ActualizarPersona(Persona persona)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_persona", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPersona", SqlDbType.Int);
                cmd.Parameters["@xIdPersona"].Value = persona.IdPersona;

                cmd.Parameters.Add("@xApellidoNombre", SqlDbType.VarChar);
                cmd.Parameters["@xApellidoNombre"].Value = persona.ApellidoNombre;

                cmd.Parameters.Add("@xDocumento", SqlDbType.VarChar);
                cmd.Parameters["@xDocumento"].Value = persona.Documento;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "M";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego la Empresa Constructora. Verifique los datos.");
            }
        }

        internal void QuitarPersona(Persona persona)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_persona", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPersona", SqlDbType.Int);
                cmd.Parameters["@xIdPersona"].Value = persona.IdPersona;

                cmd.Parameters.Add("@xApellidoNombre", SqlDbType.VarChar);
                cmd.Parameters["@xApellidoNombre"].Value = persona.ApellidoNombre;

                cmd.Parameters.Add("@xDocumento", SqlDbType.VarChar);
                cmd.Parameters["@xDocumento"].Value = persona.Documento;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "B";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego la Empresa Constructora. Verifique los datos.");
            }
        }

        internal Persona TraerPersona(int personaId)
        {
            throw new NotImplementedException();
        }

        internal object traerPersonas(string buscar)
        {
            throw new NotImplementedException();
        }
    }
}
