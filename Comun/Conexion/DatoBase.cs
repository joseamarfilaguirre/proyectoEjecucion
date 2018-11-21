using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Comun.Conexion
{
    public class DatoBase
    {
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["db_IPV_Ejecucion"].ConnectionString);
        }
        public SqlCommand ObtenerComando(SqlConnection cnn, string instruccion, CommandType tipoComando)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = instruccion;
            cmd.Connection = cnn;
            cmd.CommandType = tipoComando;
            return cmd;
        }

    }
}
