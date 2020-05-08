using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_IMPUESTO
	{
        public DataTable obtenerDetallePorImpuesto(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_DETALLE_IMPUESTO_CargarPorImpuesto]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@IMP_CODIGO", oeDETALLE_IMPUESTO.IMP_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public bool actualizarFila(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_DETALLE_IMPUESTO_insertar_actualizar";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@IMP_CODIGO", oeDETALLE_IMPUESTO.IMP_codigo));
                cmd.Parameters.Add(new SqlParameter("@DIM_PORCENTAJE", oeDETALLE_IMPUESTO.DIM_porcentaje));

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool eliminarGrilla(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_DETALLE_IMPUESTO_eliminarGrilla";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@IMP_CODIGO", oeDETALLE_IMPUESTO.IMP_codigo));

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
