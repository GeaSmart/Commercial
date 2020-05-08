using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalUSUARIO
	{
        public DataTable login(eUSUARIO oeUSUARIO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_USUARIO_login";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@USU_USUARIO", oeUSUARIO.USU_usuario));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@USU_PASSWORD", oeUSUARIO.USU_contrasena));
                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable refrescarReglas(string USU_usuario)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_USUARIO_refrescarReglas]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@USU_usuario", USU_usuario));
                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
