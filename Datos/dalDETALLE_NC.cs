using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_NC
	{

		public bool insertarRegistro(eDETALLE_NC oeDETALLE_NC) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_NC_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeDETALLE_NC.NCR_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_NC.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DNC_PRO_DESCRIPCION", oeDETALLE_NC.DNC_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DNC_PRO_UME_MULTIPLO", oeDETALLE_NC.DNC_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD", oeDETALLE_NC.DNC_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_NC.DNC_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DNC_PRECIO_UNITARIO", oeDETALLE_NC.DNC_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_SUBTOTAL", oeDETALLE_NC.DNC_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_DESCUENTO", oeDETALLE_NC.DNC_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_DESCUENTO", oeDETALLE_NC.DNC_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_IGV", oeDETALLE_NC.DNC_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_ISC", oeDETALLE_NC.DNC_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_IGV", oeDETALLE_NC.DNC_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_ISC", oeDETALLE_NC.DNC_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_TOTAL_LINEA", oeDETALLE_NC.DNC_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MEMO", (object)oeDETALLE_NC.DNC_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DNC_NUMERO_FILA", oeDETALLE_NC.DNC_numero_fila)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eDETALLE_NC oeDETALLE_NC) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_NC_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeDETALLE_NC.NCR_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_NC.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DNC_PRO_DESCRIPCION", oeDETALLE_NC.DNC_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DNC_PRO_UME_MULTIPLO", oeDETALLE_NC.DNC_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD", oeDETALLE_NC.DNC_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_NC.DNC_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DNC_PRECIO_UNITARIO", oeDETALLE_NC.DNC_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_SUBTOTAL", oeDETALLE_NC.DNC_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_DESCUENTO", oeDETALLE_NC.DNC_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_DESCUENTO", oeDETALLE_NC.DNC_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_IGV", oeDETALLE_NC.DNC_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_ISC", oeDETALLE_NC.DNC_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_IGV", oeDETALLE_NC.DNC_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_ISC", oeDETALLE_NC.DNC_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_TOTAL_LINEA", oeDETALLE_NC.DNC_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DNC_MEMO", (object)oeDETALLE_NC.DNC_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DNC_NUMERO_FILA", oeDETALLE_NC.DNC_numero_fila)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eDETALLE_NC oeDETALLE_NC) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_NC_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeDETALLE_NC.NCR_serie_correlativo));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_NC.PRO_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eDETALLE_NC oeDETALLE_NC) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_NC_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeDETALLE_NC.NCR_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_NC.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_DETALLE_NC_poblar";
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
				string sp = "pa_crud_DETALLE_NC_buscarRegistro";
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
				string sp = "pa_list_DETALLE_NC_primerRegistro";
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
				string sp = "pa_list_DETALLE_NC_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eDETALLE_NC oeDETALLE_NC) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_NC_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeDETALLE_NC.NCR_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_NC.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eDETALLE_NC oeDETALLE_NC) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_NC_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeDETALLE_NC.NCR_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_NC.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
