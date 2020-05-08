using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDESCUENTO
	{
        //ADICIONALES DAL DESCUENTO
        public DataTable mostrarDescuentosPorProducto(eDESCUENTO oeDESCUENTO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_DESCUENTO_MostrarDescuentosPorProducto";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public bool actualizarDescuento(eDESCUENTO oeDESCUENTO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_DESCUENTO_ActualizarDescuento]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@DSC_is_especial", oeDESCUENTO.DSC_is_especial)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@DSC_PORCENTAJE", oeDESCUENTO.DSC_porcentaje)); //variable tipo:double
                cmd.Parameters.Add(new SqlParameter("@DSC_ESP_PORCENTAJE", oeDESCUENTO.DSC_esp_porcentaje)); //variable tipo:double
                cmd.Parameters.Add(new SqlParameter("@DSC_FECHA_VENCIMIENTO", (object)oeDESCUENTO.DSC_fecha_vencimiento ?? DBNull.Value)); //variable tipo:DATETIME

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
