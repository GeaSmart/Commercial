using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public partial class dalPERFIL_REGLA
    {
        public DataTable mostrarReglas(ePERFIL oePERFIL, string filtro)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_PERFIL_REGLA_MostrarReglas]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL.PER_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@filtro", filtro));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
        public bool actualizarRegla(ePERFIL_REGLA oePERFIL_REGLA)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_PERFIL_REGLA_ActualizarRegla]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL_REGLA.PER_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@REG_CODIGO", oePERFIL_REGLA.REG_codigo)); //variable tipo:string
                cmd.Parameters.Add(new SqlParameter("@PRE_IS_ACTIVO", oePERFIL_REGLA.PRE_is_activo)); //variable tipo:double

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
