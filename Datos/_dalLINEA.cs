using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalLINEA
	{
        public DataTable mostrarPorCategoria(string CAT_codigo)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_bf_LINEA_mostrarPotCategoria";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@CAT_CODIGO", CAT_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
