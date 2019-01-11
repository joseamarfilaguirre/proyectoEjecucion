using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using Comun.Conexion;
using System.Data;
using System.Data.SqlClient;
using Comun.Exceptions;

namespace Ejecucion.Core.Datos
{
    class PrototipoDato : DatoBase, IDisposable
    {
        internal void AgregarPrototipo(Prototipo prototipo)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_prototipo", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPrototipo", SqlDbType.Int);
                cmd.Parameters["@xIdPrototipo"].Value = prototipo.IdPrototipo;

                cmd.Parameters.Add("@xPrototipo", SqlDbType.VarChar);
                cmd.Parameters["@xPrototipo"].Value = prototipo.DescripcionPrototipo;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "A";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego el Prototipo. Verifique los datos.");
            }
        }

        internal void ActualizarPrototipo(Prototipo prototipo)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_prototipo", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPrototipo", SqlDbType.Int);
                cmd.Parameters["@xIdPrototipo"].Value = prototipo.IdPrototipo;

                cmd.Parameters.Add("@xPrototipo", SqlDbType.VarChar);
                cmd.Parameters["@xPrototipo"].Value = prototipo.DescripcionPrototipo;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "M";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se modifico el Prototipo. Verifique los datos.");
            }
        }

        internal void QuitarPrototipo(Prototipo prototipo)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_prototipo", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdPrototipo", SqlDbType.Int);
                cmd.Parameters["@xIdPrototipo"].Value = prototipo.IdPrototipo;

                cmd.Parameters.Add("@xPrototipo", SqlDbType.VarChar);
                cmd.Parameters["@xPrototipo"].Value = prototipo.DescripcionPrototipo;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "B";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se elimino el Prototipo. Verifique los datos.");
            }
        }

        internal Prototipo TraerPrototipo(int prototipoId)
        {
            throw new NotImplementedException();
        }

        internal object TraerPrototipos(string buscar)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
