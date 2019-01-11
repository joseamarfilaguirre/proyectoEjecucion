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
    class AvanceDato : DatoBase, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal object traerAvances(string buscar)
        {
            var avances = new List<Avance>();

            using (var cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, "sp_TraerAvances", CommandType.StoredProcedure);
                cnn.Open();
                var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        avances.Add(ObtenerAvanceMapping(dr));
                    }
                }
            }

            return avances;

        }

        internal void ActualizarAvance(Avance avance)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_avance", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@IdxAvance", SqlDbType.Int);
                cmd.Parameters["@xIdAvance"].Value = avance.IdAvance;

                cmd.Parameters.Add("@xIdObra", SqlDbType.Int);
                cmd.Parameters["@xIdObra"].Value = avance.IdObra;

                cmd.Parameters.Add("@xPorcentajeAtraso", SqlDbType.Float);
                cmd.Parameters["@xPorcentajeAtraso"].Value = avance.PorcentajeAtraso;

                cmd.Parameters.Add("@xPorcentajePrevisto", SqlDbType.Float);
                cmd.Parameters["@xPorcentajePrevisto"].Value = avance.PorcentajePrevisto;

                cmd.Parameters.Add("@xPorcentajeReal", SqlDbType.Float);
                cmd.Parameters["@xPorcentajeReal"].Value = avance.PorcentajeReal;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "M";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se modifico el avance de obra. Verifique los datos.");
            }

        }

        internal void AgregarAvance(Avance avance)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_avance", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@IdxAvance", SqlDbType.Int);
                cmd.Parameters["@xIdAvance"].Value = avance.IdAvance;

                cmd.Parameters.Add("@xIdObra", SqlDbType.Int);
                cmd.Parameters["@xIdObra"].Value = avance.IdObra;

                cmd.Parameters.Add("@xPorcentajeAtraso", SqlDbType.Float);
                cmd.Parameters["@xPorcentajeAtraso"].Value = avance.PorcentajeAtraso;

                cmd.Parameters.Add("@xPorcentajePrevisto", SqlDbType.Float);
                cmd.Parameters["@xPorcentajePrevisto"].Value = avance.PorcentajePrevisto;

                cmd.Parameters.Add("@xPorcentajeReal", SqlDbType.Float);
                cmd.Parameters["@xPorcentajeReal"].Value = avance.PorcentajeReal;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "A";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego el avance de obra. Verifique los datos.");
            }

        }

        internal void QuitarAvance(Avance avance)
        {
            using (SqlConnection cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, " sp_ABM_avance", CommandType.StoredProcedure);
                int resultado = 0;
                cmd.Parameters.Add("@IdxAvance", SqlDbType.Int);
                cmd.Parameters["@xIdAvance"].Value = avance.IdAvance;

                cmd.Parameters.Add("@xIdObra", SqlDbType.Int);
                cmd.Parameters["@xIdObra"].Value = avance.IdObra;

                cmd.Parameters.Add("@xPorcentajeAtraso", SqlDbType.Float);
                cmd.Parameters["@xPorcentajeAtraso"].Value = avance.PorcentajeAtraso;

                cmd.Parameters.Add("@xPorcentajePrevisto", SqlDbType.Float);
                cmd.Parameters["@xPorcentajePrevisto"].Value = avance.PorcentajePrevisto;

                cmd.Parameters.Add("@xPorcentajeReal", SqlDbType.Float);
                cmd.Parameters["@xPorcentajeReal"].Value = avance.PorcentajeReal;

                cmd.Parameters.Add("@xAccion", SqlDbType.VarChar);
                cmd.Parameters["@xAccion"].Value = "B";

                cmd.Parameters.Add("@xresult", SqlDbType.Int);
                cmd.Parameters["@xresult"].Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteScalar();

                resultado = Convert.ToInt32(cmd.Parameters["@xresult"].Value);

                if (resultado == 1)
                    throw new NegocioException("No se agrego el avance de obra. Verifique los datos.");
            }

        }

        internal Avance TraerAvance(int avanceId)
        {
            Avance avance = null;

            using (var cnn = ObtenerConexion())
            {
                SqlCommand cmd = ObtenerComando(cnn, "sp_avance_traer", CommandType.StoredProcedure);

                cmd.Parameters.Add(new SqlParameter("@Id", avanceId));

                cnn.Open();

                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dr.HasRows)
                {
                    dr.Read();
                    avance = ObtenerAvanceMapping(dr);
                }
            }

            return avance;
        }
        private static Avance  ObtenerAvanceMapping(SqlDataReader dr)
        {
            Avance avance = new Avance();
            try
            {
                avance.IdAvance = int.Parse(dr["IdAvance"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                avance.IdObra = int.Parse(dr["IdObra"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                avance.Fechaavance = DateTime.Parse(dr["FechaAvance"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                avance.PorcentajeAtraso = float.Parse(dr["PorcentajeAtraso"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                avance.PorcentajePrevisto = float.Parse(dr["PorcentajePrevisto"].ToString());
            }
            catch (Exception opd)
            {

            }
            try
            {
                avance.PorcentajeReal = float.Parse(dr["PorcentajeReal"].ToString());
            }
            catch (Exception opd)
            {

            }
            return avance;
        }
    }
}
