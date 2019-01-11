using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejecucion.Core.Entidades;
using System.Data.SqlClient;
using Comun.Conexion;
using System.Data;
using Comun.Exceptions;

namespace Ejecucion.Core.Datos
{
    class ObraDato : DatoBase, IDisposable
    {
        internal Obras TraerObra(int obraId)
        {
            Obras obra = null;

            using (var cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, "sp_obra_traer", CommandType.StoredProcedure);

                cmd.Parameters.Add(new SqlParameter("@IdObra", obraId));

                cnn.Open();

                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dr.HasRows)
                {
                    dr.Read();
                    obra = ObtenerObraMapping(dr);
                }
            }

            return obra;
        }

        internal void AgregarObra(Obras obra)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_obra", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdObra", SqlDbType.Int);
                cmd.Parameters["@xIdObra"].Value = obra.IdObra;

                cmd.Parameters.Add("@xexpMatriz", SqlDbType.VarChar);
                cmd.Parameters["@xexpMatriz"].Value = obra.ExpMatriz;

                cmd.Parameters.Add("@xObra", SqlDbType.VarChar);
                cmd.Parameters["@xObra"].Value = obra.ObraNombre;

                cmd.Parameters.Add("@xACCU", SqlDbType.VarChar);
                cmd.Parameters["@xACCU"].Value = obra.ACCU;

                cmd.Parameters.Add("@xIdDptoProvincia", SqlDbType.Int);
                cmd.Parameters["@xIdDptoProvincia"].Value = obra.IdDptoProvincia;

                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = obra.IdEmpConstructora;

                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = obra.IdEmpConstructora;

                cmd.Parameters.Add("@xCantParaSorteo", SqlDbType.Int);
                cmd.Parameters["@xCantParaSorteo"].Value = obra.CantParaSorteo;

                cmd.Parameters.Add("@xMontoOriginal", SqlDbType.Float);
                cmd.Parameters["@xMontoOriginal"].Value = obra.MontoOriginal;

                cmd.Parameters.Add("@xLicitacionResolucion", SqlDbType.VarChar);
                cmd.Parameters["@xLicitacionResolucion"].Value = obra.LicitacionResolucion;

                cmd.Parameters.Add("@xPlazoOriginal", SqlDbType.Int);
                cmd.Parameters["@xPlazoOriginal"].Value = obra.PlazoOriginal;

                cmd.Parameters.Add("@xFechaFinalizacion", SqlDbType.Int);
                cmd.Parameters["@xFechaFinalizacion"].Value = obra.FechaFinalizacion;

                cmd.Parameters.Add("@xMontoContratoPesos", SqlDbType.Int);
                cmd.Parameters["@xMontoContratoPesos"].Value = obra.MontoContratoPesos;

                cmd.Parameters.Add("@xMontoContratoUVI", SqlDbType.Int);
                cmd.Parameters["@xMontoContratoUVI"].Value = obra.MontoContratoUVI;

                cmd.Parameters.Add("@xFechaOferta", SqlDbType.Int);
                cmd.Parameters["@xFechaOferta"].Value = obra.FechaOferta;

                cmd.Parameters.Add("@xFechaInicio", SqlDbType.Int);
                cmd.Parameters["@xFechaInicio"].Value = obra.FechaInicio;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "A";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego la obra. Verifique los datos.");
            }
        }

        internal void ActualizarObra(Obras obra)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_obra", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdObra", SqlDbType.Int);
                cmd.Parameters["@xIdObra"].Value = obra.IdObra;

                cmd.Parameters.Add("@xexpMatriz", SqlDbType.VarChar);
                cmd.Parameters["@xexpMatriz"].Value = obra.ExpMatriz;

                cmd.Parameters.Add("@xObra", SqlDbType.VarChar);
                cmd.Parameters["@xObra"].Value = obra.ObraNombre;

                cmd.Parameters.Add("@xACCU", SqlDbType.VarChar);
                cmd.Parameters["@xACCU"].Value = obra.ACCU;

                cmd.Parameters.Add("@xIdDptoProvincia", SqlDbType.Int);
                cmd.Parameters["@xIdDptoProvincia"].Value = obra.IdDptoProvincia;

                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = obra.IdEmpConstructora;

                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = obra.IdEmpConstructora;

                cmd.Parameters.Add("@xCantParaSorteo", SqlDbType.Int);
                cmd.Parameters["@xCantParaSorteo"].Value = obra.CantParaSorteo;

                cmd.Parameters.Add("@xMontoOriginal", SqlDbType.Float);
                cmd.Parameters["@xMontoOriginal"].Value = obra.MontoOriginal;

                cmd.Parameters.Add("@xLicitacionResolucion", SqlDbType.VarChar);
                cmd.Parameters["@xLicitacionResolucion"].Value = obra.LicitacionResolucion;

                cmd.Parameters.Add("@xPlazoOriginal", SqlDbType.Int);
                cmd.Parameters["@xPlazoOriginal"].Value = obra.PlazoOriginal;

                cmd.Parameters.Add("@xFechaFinalizacion", SqlDbType.Int);
                cmd.Parameters["@xFechaFinalizacion"].Value = obra.FechaFinalizacion;

                cmd.Parameters.Add("@xMontoContratoPesos", SqlDbType.Int);
                cmd.Parameters["@xMontoContratoPesos"].Value = obra.MontoContratoPesos;

                cmd.Parameters.Add("@xMontoContratoUVI", SqlDbType.Int);
                cmd.Parameters["@xMontoContratoUVI"].Value = obra.MontoContratoUVI;

                cmd.Parameters.Add("@xFechaOferta", SqlDbType.Int);
                cmd.Parameters["@xFechaOferta"].Value = obra.FechaOferta;

                cmd.Parameters.Add("@xFechaInicio", SqlDbType.Int);
                cmd.Parameters["@xFechaInicio"].Value = obra.FechaInicio;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "M";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego la obra. Verifique los datos.");
            }
        }

        internal void EliminarObra(Obras obra)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_obra", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@xIdObra", SqlDbType.Int);
                cmd.Parameters["@xIdObra"].Value = obra.IdObra;

                cmd.Parameters.Add("@xexpMatriz", SqlDbType.VarChar);
                cmd.Parameters["@xexpMatriz"].Value = obra.ExpMatriz;

                cmd.Parameters.Add("@xObra", SqlDbType.VarChar);
                cmd.Parameters["@xObra"].Value = obra.ObraNombre;

                cmd.Parameters.Add("@xACCU", SqlDbType.VarChar);
                cmd.Parameters["@xACCU"].Value = obra.ACCU;

                cmd.Parameters.Add("@xIdDptoProvincia", SqlDbType.Int);
                cmd.Parameters["@xIdDptoProvincia"].Value = obra.IdDptoProvincia;

                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = obra.IdEmpConstructora;

                cmd.Parameters.Add("@xIdEmpConstructora", SqlDbType.Int);
                cmd.Parameters["@xIdEmpConstructora"].Value = obra.IdEmpConstructora;

                cmd.Parameters.Add("@xCantParaSorteo", SqlDbType.Int);
                cmd.Parameters["@xCantParaSorteo"].Value = obra.CantParaSorteo;

                cmd.Parameters.Add("@xMontoOriginal", SqlDbType.Float);
                cmd.Parameters["@xMontoOriginal"].Value = obra.MontoOriginal;

                cmd.Parameters.Add("@xLicitacionResolucion", SqlDbType.VarChar);
                cmd.Parameters["@xLicitacionResolucion"].Value = obra.LicitacionResolucion;

                cmd.Parameters.Add("@xPlazoOriginal", SqlDbType.Int);
                cmd.Parameters["@xPlazoOriginal"].Value = obra.PlazoOriginal;

                cmd.Parameters.Add("@xFechaFinalizacion", SqlDbType.Int);
                cmd.Parameters["@xFechaFinalizacion"].Value = obra.FechaFinalizacion;

                cmd.Parameters.Add("@xMontoContratoPesos", SqlDbType.Int);
                cmd.Parameters["@xMontoContratoPesos"].Value = obra.MontoContratoPesos;

                cmd.Parameters.Add("@xMontoContratoUVI", SqlDbType.Int);
                cmd.Parameters["@xMontoContratoUVI"].Value = obra.MontoContratoUVI;

                cmd.Parameters.Add("@xFechaOferta", SqlDbType.Int);
                cmd.Parameters["@xFechaOferta"].Value = obra.FechaOferta;

                cmd.Parameters.Add("@xFechaInicio", SqlDbType.Int);
                cmd.Parameters["@xFechaInicio"].Value = obra.FechaInicio;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "B";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego la obra. Verifique los datos.");
            }
        }

        internal List<Obras> TraerObras(String buscar)
        {
            List<Obras> obras= new List<Obras>();

            using (var cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, "sp_TraerObras", CommandType.StoredProcedure);
                cnn.Open();
                var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        obras.Add(ObtenerObraMapping(dr));
                    }
                }
            }

            return obras;
        }

        internal List<DptoProvincia> TraerDptoProvincia()
        {
            throw new NotImplementedException();
        }

        internal List<EmpresaConstructora> TraerEmpConstructora()
        {
            throw new NotImplementedException();
        }

        internal List<Programa> TraerPrograma()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        private static Obras ObtenerObraMapping(SqlDataReader dr)
        {
            Obras obra = new Obras();
            try
            {
                obra.IdObra = int.Parse(dr["IdObra"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.ExpMatriz = dr["ExpMatriz"].ToString();
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.ObraNombre = dr["Obra"].ToString();
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.ACCU = dr["ACCU"].ToString();
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.IdDptoProvincia = int.Parse(dr["IdDptoProvincia"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.IdPrograma = int.Parse(dr["IdPrograma"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.IdPrograma = int.Parse(dr["IdPrograma"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.IdEmpConstructora = int.Parse(dr["IdEmpConstructora"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.CantParaSorteo = int.Parse(dr["CantParaSorteo"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.MontoOriginal = int.Parse(dr["MontoOriginal"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.LicitacionResolucion = dr["LicitacionResolucion"].ToString();
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.PlazoOriginal = int.Parse( dr["PlazoOriginal"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.FechaFinalizacion = DateTime.Parse(dr["FechaFinalizacion"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.MontoContratoPesos = float.Parse(dr["MontoContratoPesos"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.MontoContratoUVI = float.Parse(dr["MontoContratoUVI"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.FechaOferta = DateTime.Parse(dr["FechaOferta"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                obra.FechaInicio = DateTime.Parse(dr["FechaInicio"].ToString());
            }
            catch (Exception opd)
            {

            }
            return obra;
   
        }
    }
}
