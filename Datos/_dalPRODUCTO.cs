using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPRODUCTO
	{
        public DataTable obtenerRegistroComplejo(ePRODUCTO oePRODUCTO, eSOCIO oeSOCIO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_PRODUCTO_informacionDirigida]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oePRODUCTO.PRO_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeSOCIO.SOC_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable obtenerRegistroComplejoBonificacion(eCANAL oeCANAL)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_PRODUCTO_informacionDirigidaBonificacion]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeCANAL.CAN_codigo));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable buscarRegistroBonificacion(eCANAL oeCANAL, string cadena)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_PRODUCTO_informacionDirigidaBonificacion]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_codigo", oeCANAL.CAN_codigo));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@Cadena", cadena));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public DataTable poblarParaDescuentos()
        { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_PRODUCTO_poblarParaDescuentos]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dad.Fill(dt);
                return dt;
            }
        }

        public DataTable poblarPacks()
        { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_bf_PRODUCTO_poblarPacks";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dad.Fill(dt);
                return dt;
            }
        }
    }
}
