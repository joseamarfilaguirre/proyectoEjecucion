using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Ejecucion.Core.Entidades;
using Comun.Conexion;
using System.Data.Common,
namespace Ejecucion.Core.Datos
{
    class DptoProvinciaDato : DatoBase, IDisposable
    {
        internal object traerDptoProvincias(string buscar)
        {
            throw new NotImplementedException();
        }

        internal object traerDptoProvincia(int departamentoId)
        {
            DptoProvincia departamento = null;

            using (var cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, "XX_Tutorial_TraerPersona", CommandType.StoredProcedure);

                cmd.Parameters.Add(new SqlParameter("@Id", personaId));

                cnn.Open();

                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dr.HasRows)
                {
                    dr.Read();
                    departamento = ObtenerPersonaMapping(dr);
                }
            }

            return persona;

        }

        internal void AgregarDepartamentoProvincia(DptoProvincia departamento)
        {
            throw new NotImplementedException();
        }

        internal void ActualizarDepartamento(DptoProvincia departamento)
        {
            throw new NotImplementedException();
        }

        internal void QuitarDepartamento(DptoProvincia departamento)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        private DptoProvincia ObtenerDepartamentoMapping(SqlDataReader dr)
        {
            DptoProvincia departamento = new DptoProvincia();

            ///var map = new DataMapper().CrearDataMapper(dr);
    
            //departamento.IdDptoProv = map.GetString("IdDptoProv");
           // departamento.DptoProv = map.GetString("DptoProv");
            return departamento;


        }
    }
}
