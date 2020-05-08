using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalSOCIO
	{
        public DataTable buscarCliente(string cadena)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_crud_SOCIO_buscarCliente";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@Cadena", cadena));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable buscarProveedor(string cadena)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_crud_SOCIO_buscarProveedor";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@Cadena", cadena));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }
    }
}
