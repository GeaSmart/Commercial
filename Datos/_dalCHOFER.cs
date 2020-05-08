using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalCHOFER
	{
        public DataTable obtenerRegistroDetallado(eCHOFER oeCHOFER)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_bf_CHOFER_informacionDirigida_Programacion";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@CHO_CODIGO", oeCHOFER.CHO_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
