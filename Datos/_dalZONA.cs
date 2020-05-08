using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalZONA
	{
        public DataTable buscarRegistroP(string cadena, ePROGRAMACION oePROGRAMACION)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_ZONA_buscarRegistroP";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@Cadena", cadena));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PRG_fecha", oePROGRAMACION.PRG_fecha));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable mostrarNoAsignadas(int RUT_codigo)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_bf_ZONA_MostrarZonasNoAsignadasListadoVisita";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                //dad.SelectCommand.Parameters.Add(new SqlParameter("@Cadena", cadena));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@RUT_codigo", RUT_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
