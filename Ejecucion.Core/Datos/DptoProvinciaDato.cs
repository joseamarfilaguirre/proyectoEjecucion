using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Ejecucion.Core.Entidades;
using Comun.Conexion;
using System.Collections.Generic;
using Comun.Exceptions;

namespace Ejecucion.Core.Datos
{
    class DptoProvinciaDato : DatoBase, IDisposable
    {
        internal object traerDptoProvincias(string buscar)
        {
            var departamentos = new List<DptoProvincia>();

            using (var cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, "sp_TraerDepartamentos", CommandType.StoredProcedure);
                cnn.Open();
                var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        departamentos.Add(ObtenerDepartamentoMapping(dr));
                    }
                }
            }

            return departamentos;
        }

        internal DptoProvincia traerDptoProvincia(int departamentoId)
        {
            DptoProvincia departamento = null;

            using (var cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, "sp_dptopciatraer", CommandType.StoredProcedure);

                cmd.Parameters.Add(new SqlParameter("@Id", departamentoId));

                cnn.Open();

                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dr.HasRows)
                {
                    dr.Read();
                    departamento =  ObtenerDepartamentoMapping(dr);
                }
            }

            return departamento;

        }
        internal void AgregarDepartamentoProvincia(DptoProvincia departamento)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_dptoProvincia", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdDptoProvincia", SqlDbType.Int);
                cmd.Parameters["@xIdDptoProvincia"].Value = departamento.IdDptoProvincia;

                cmd.Parameters.Add("@xDptoProvincia", SqlDbType.VarChar);
                cmd.Parameters["@xDptoProvincia"].Value = departamento.DptoProv;

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

        internal void ActualizarDepartamento(DptoProvincia departamento)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_dptoProvincia", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdDptoProvincia", SqlDbType.Int);
                cmd.Parameters["@xIdDptoProvincia"].Value = departamento.IdDptoProvincia;

                cmd.Parameters.Add("@xDptoProvincia", SqlDbType.VarChar);
                cmd.Parameters["@xDptoProvincia"].Value = departamento.DptoProv;

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

        internal void QuitarDepartamento(DptoProvincia departamento)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_dptoProvincia", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdDptoProvincia", SqlDbType.Int);
                cmd.Parameters["@xIdDptoProvincia"].Value = departamento.IdDptoProvincia;

                cmd.Parameters.Add("@xDptoProvincia", SqlDbType.VarChar);
                cmd.Parameters["@xDptoProvincia"].Value = departamento.DptoProv;

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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        private static DptoProvincia ObtenerDepartamentoMapping(SqlDataReader dr)
        {
            DptoProvincia departamento = new DptoProvincia();
            try
            {
                departamento.IdDptoProvincia = int.Parse(dr["IdDptoProv"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                departamento.DptoProv = dr["DptoProv"].ToString();
            }
            catch (Exception opd)
            {

            }
            return departamento;
        }

    }
}
