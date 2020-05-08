using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalBONIFICACION
	{
        //ADICIONALES DALBONIFICACION
        public DataTable mostrarBonificacionPorGrupo(eCANAL oeCANAL)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_BONIFICACION_mostrarBonisPorGrupo]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeCANAL.CAN_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public bool actualizarTabla(eBONIFICACION oeBONIFICACION)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_BONIFICACION_ActualizarTabla]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_REQ_SUBMULTIPLO", oeBONIFICACION.BON_cantidad_req_submultiplo)); //variable tipo:int
                cmd.Parameters.Add(new SqlParameter("@BON_PRODUCTO", oeBONIFICACION.BON_producto)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeBONIFICACION.PRO_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_REQ", oeBONIFICACION.BON_cantidad_req)); //variable tipo:int
                cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_BONI", oeBONIFICACION.BON_cantidad_boni)); //variable tipo:int
                cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_BONI_SUBMULTIPLO", oeBONIFICACION.BON_cantidad_boni_submultiplo)); //variable tipo:int
                cmd.Parameters.Add(new SqlParameter("@BON_ESP_CANTIDAD_BONI", oeBONIFICACION.BON_esp_cantidad_boni)); //variable tipo:int
                cmd.Parameters.Add(new SqlParameter("@BON_ESP_CANTIDAD_BONI_SUBMULTIPLO", oeBONIFICACION.BON_esp_cantidad_boni_submultiplo)); //variable tipo:int
                cmd.Parameters.Add(new SqlParameter("@BON_is_especial", oeBONIFICACION.BON_is_especial)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@BON_FECHA_VENCIMIENTO", (object)oeBONIFICACION.BON_fecha_vencimiento ?? DBNull.Value)); //variable tipo:DATETIME
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public void eliminarTabla(eBONIFICACION oeBONIFICACION)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_BONIFICACION_EliminarTabla]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo));
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable procesarReglas(eVENTA oeVENTA, eDETALLE_VENTA oeDETALLEVENTA)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_BONIFICACION_procesarReglas";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLEVENTA.PRO_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeVENTA.SOC_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@DVE_CANTIDAD", oeDETALLEVENTA.DVE_cantidad));

                //dad.SelectCommand.Parameters.Add(new SqlParameter("@DVE_CANTIDAD_SUBMULTIPLO", (object)oeDETALLEVENTA.DVE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:string

                dad.SelectCommand.Parameters.Add(new SqlParameter("@DVE_CANTIDAD_SUBMULTIPLO", oeDETALLEVENTA.DVE_cantidad_submultiplo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
