using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_LISTA_PRECIO
	{
        public bool actualizarListaPrecios(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_DETALLE_LISTA_PRECIO_ActualizarPrecios]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeDETALLE_LISTA_PRECIO.LPR_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_LISTA_PRECIO.PRO_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@DLP_PRECIO", oeDETALLE_LISTA_PRECIO.DLP_precio)); //variable tipo:double

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
