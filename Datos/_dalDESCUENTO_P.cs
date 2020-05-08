using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDESCUENTO_P
	{
        //ADICIONALES DAL DESCUENTO P
        public DataTable mostrarDescuentosPPorProducto(eDESCUENTO_P oeDESCUENTOP)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_DESCUENTO_MostrarDescuentosPPorProducto";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeDESCUENTOP.SOC_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTOP.PRO_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public bool actualizarDescuentoP(eDESCUENTO_P oeDESCUENTOP)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_DESCUENTO_ActualizarDescuentoP]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeDESCUENTOP.SOC_codigo));
                cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTOP.PRO_codigo));
                cmd.Parameters.Add(new SqlParameter("@DSC_PORCENTAJE", oeDESCUENTOP.DSC_porcentaje)); //variable tipo:double

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
