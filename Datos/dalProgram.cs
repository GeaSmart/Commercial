using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class dalProgram
    {
        public bool sincronizarDescuentosEspeciales()
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_sincronizarDescuentosEspeciales]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                //cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo));
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool sincronizarBonificacionesEspeciales()
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_sincronizarBonificacionesEspeciales]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                //cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo));
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
