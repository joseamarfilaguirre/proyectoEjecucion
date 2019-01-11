using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using System.Data;
using Comun.Conexion;
using Comun.Exceptions;
using System.Data.SqlClient;

namespace Ejecucion.Core.Datos
{
    class EmpresaConstructoraDato : DatoBase, IDisposable
    {
        internal void QuitarEmpresaConstructora(EmpresaConstructora empresa)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_empresaConstructora", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = empresa.IdEmpConstructora;

                cmd.Parameters.Add("@xEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = empresa.EmpConstructora;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "B";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se elimino la Empresa Constructora. Verifique los datos.");
            }
        }

        internal void ActualizarEmpresaConstructora(EmpresaConstructora empresa)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_empresaConstructora", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = empresa.IdEmpConstructora;

                cmd.Parameters.Add("@xEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xEmpConstructora"].Value = empresa.EmpConstructora;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "M";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32( cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se modifico la Empresa Constructora. Verifique los datos.");
            }
        }

        internal object traerEmpresasConstructoras()
        {
            throw new NotImplementedException();
        }

        internal EmpresaConstructora TraerEmpresaConstructora(int empresaId)
        {
            throw new NotImplementedException();
        }

        internal void AgregarEmpresaConstructora(EmpresaConstructora empresa)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_empresaConstructora", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = empresa.IdEmpConstructora;

                cmd.Parameters.Add("@xEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xEmpConstructora"].Value = empresa.EmpConstructora;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "A";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego la Empresa Constructora. Verifique los datos.");
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        private static EmpresaConstructora ObtenerEmpresaMapping(SqlDataReader dr)
        {
            EmpresaConstructora empresa = new EmpresaConstructora();
            try
            {
                empresa.IdEmpConstructora = int.Parse(dr["IdEmpConstructora"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                empresa.EmpConstructora = dr["EmpConstructora"].ToString();
            }
            catch (Exception opd)
            {

            }
            return empresa;
        }
    }
}
