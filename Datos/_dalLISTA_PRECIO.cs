using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalLISTA_PRECIO
	{
        public DataTable mostrarListaPrecios(eLISTA_PRECIO oeLISTA_PRECIO, string filtro)//eLISTA_PRECIO oeLISTA_PRECIO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_LISTA_PRECIO_MostrarPrecios]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeLISTA_PRECIO.LPR_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@filtro", filtro));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
