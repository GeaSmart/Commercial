using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalSERIE
	{
        public DataTable CargarSeries(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_SERIE_CargarSeriesPorTipoDocumento]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@TDO_codigo", oeTIPO_DOCUMENTO.TDO_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable obtenerSeriesPorTipoDocumento(eSERIE oeSERIE, ePEDIDO oePEDIDO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_SERIE_ObtenerSeriesPorTipoDocumento]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeSERIE.TDO_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
