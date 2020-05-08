using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPAGO
	{
        public DataTable mostrarListadoPagos(DateTime desde, DateTime hasta, eVENTA oeVENTA, DataTable series, DataTable condicionesPago, string isSoloAbiertos)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_PAG_MostrarListadoPagos";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@FechaDesde", desde));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@FechaHasta", hasta));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@TVE_codigo", oeVENTA.TVE_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@CHO_codigo", oeVENTA.CHO_codigo));

                dad.SelectCommand.Parameters.Add(new SqlParameter("@TablaSeries", series));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@TablaCondicionesPago", condicionesPago));

                dad.SelectCommand.Parameters.Add(new SqlParameter("@isSoloAbiertos", isSoloAbiertos));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public bool pagarDocumento(ePAGO oePAGO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_PAGO_PagarDocumento]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@VTA_serie_correlativo", oePAGO.VTA_serie_correlativo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@PAG_abono", oePAGO.PAG_abono)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@PAG_referencia", (object)oePAGO.PAG_referencia ?? DBNull.Value)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@MPA_codigo", oePAGO.MPA_codigo)); //variable tipo:string

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
