using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalVENTA
	{
        public DataTable obtenerSiguienteCorrelativo(eVENTA oeVENTA)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_VENTA_siguienteCorrelativo]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@TDO_codigo", oeVENTA.TDO_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@SER_serie", oeVENTA.SER_serie));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable obtenerSiguienteCorrelativo(eNOTA_CREDITO oeNOTA_CREDITO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_VENTA_siguienteCorrelativo]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@TDO_codigo", oeNOTA_CREDITO.TDO_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@SER_serie", oeNOTA_CREDITO.SER_serie));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public bool anularRegistro(eVENTA oeVENTA)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_VENTA_anularRegistro";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo));
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable obtenerCantidadDocumentosDia(eVENTA oeVENTA)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_VENTA_cantidadDocumentosDia";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_fecha_contabilizacion", oeVENTA.VTA_fecha_contabilizacion));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
