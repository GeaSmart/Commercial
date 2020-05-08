using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalNOTA_CREDITO
	{

		public bool insertarRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_NOTA_CREDITO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_FECHA_CONTABILIZACION", oeNOTA_CREDITO.NCR_fecha_contabilizacion)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeNOTA_CREDITO.TDO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SER_SERIE", oeNOTA_CREDITO.SER_serie)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_CORRELATIVO", oeNOTA_CREDITO.NCR_correlativo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeNOTA_CREDITO.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeNOTA_CREDITO.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@NCR_SOC_NOMBRE_RAZON", oeNOTA_CREDITO.NCR_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_SUBTOTAL", oeNOTA_CREDITO.NCR_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_IGV", oeNOTA_CREDITO.NCR_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_ISC", oeNOTA_CREDITO.NCR_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL", oeNOTA_CREDITO.NCR_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL_TEXTO", oeNOTA_CREDITO.NCR_monto_total_texto)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_COMENTARIO", (object)oeNOTA_CREDITO.NCR_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_ESTADO", oeNOTA_CREDITO.NCR_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", (object)oeNOTA_CREDITO.MDE_codigo ?? DBNull.Value)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_NOTA_CREDITO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_FECHA_CONTABILIZACION", oeNOTA_CREDITO.NCR_fecha_contabilizacion)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeNOTA_CREDITO.TDO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SER_SERIE", oeNOTA_CREDITO.SER_serie)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_CORRELATIVO", oeNOTA_CREDITO.NCR_correlativo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeNOTA_CREDITO.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeNOTA_CREDITO.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@NCR_SOC_NOMBRE_RAZON", oeNOTA_CREDITO.NCR_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_SUBTOTAL", oeNOTA_CREDITO.NCR_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_IGV", oeNOTA_CREDITO.NCR_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_ISC", oeNOTA_CREDITO.NCR_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL", oeNOTA_CREDITO.NCR_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL_TEXTO", oeNOTA_CREDITO.NCR_monto_total_texto)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_COMENTARIO", (object)oeNOTA_CREDITO.NCR_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NCR_ESTADO", oeNOTA_CREDITO.NCR_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", (object)oeNOTA_CREDITO.MDE_codigo ?? DBNull.Value)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_NOTA_CREDITO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_NOTA_CREDITO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_NOTA_CREDITO_poblar";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				dad.Fill(dt);
				return dt;
			}
		}

		public DataTable buscarRegistro(string cadena) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_NOTA_CREDITO_buscarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@Cadena", cadena));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable primerRegistro() {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_NOTA_CREDITO_primerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable ultimoRegistro() {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_NOTA_CREDITO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_NOTA_CREDITO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_NOTA_CREDITO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
