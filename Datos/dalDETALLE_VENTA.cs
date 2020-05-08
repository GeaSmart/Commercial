using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_VENTA
	{

		public bool insertarRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_VENTA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeDETALLE_VENTA.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_VENTA.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_IS_BONIFICACION", oeDETALLE_VENTA.DVE_is_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_PRO_DESCRIPCION", oeDETALLE_VENTA.DVE_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_PRO_UME_MULTIPLO", oeDETALLE_VENTA.DVE_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DVE_CANTIDAD", oeDETALLE_VENTA.DVE_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DVE_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_VENTA.DVE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DVE_PRECIO_UNITARIO", oeDETALLE_VENTA.DVE_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_SUBTOTAL", oeDETALLE_VENTA.DVE_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_DESCUENTO", oeDETALLE_VENTA.DVE_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_DESCUENTO", oeDETALLE_VENTA.DVE_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_IGV", oeDETALLE_VENTA.DVE_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_ISC", oeDETALLE_VENTA.DVE_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_IGV", oeDETALLE_VENTA.DVE_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_ISC", oeDETALLE_VENTA.DVE_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_TOTAL_LINEA", oeDETALLE_VENTA.DVE_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MEMO", (object)oeDETALLE_VENTA.DVE_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_NUMERO_FILA", oeDETALLE_VENTA.DVE_numero_fila)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_VENTA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeDETALLE_VENTA.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_VENTA.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_IS_BONIFICACION", oeDETALLE_VENTA.DVE_is_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_PRO_DESCRIPCION", oeDETALLE_VENTA.DVE_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_PRO_UME_MULTIPLO", oeDETALLE_VENTA.DVE_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DVE_CANTIDAD", oeDETALLE_VENTA.DVE_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DVE_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_VENTA.DVE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DVE_PRECIO_UNITARIO", oeDETALLE_VENTA.DVE_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_SUBTOTAL", oeDETALLE_VENTA.DVE_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_DESCUENTO", oeDETALLE_VENTA.DVE_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_DESCUENTO", oeDETALLE_VENTA.DVE_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_IGV", oeDETALLE_VENTA.DVE_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_ISC", oeDETALLE_VENTA.DVE_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_IGV", oeDETALLE_VENTA.DVE_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_ISC", oeDETALLE_VENTA.DVE_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_TOTAL_LINEA", oeDETALLE_VENTA.DVE_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DVE_MEMO", (object)oeDETALLE_VENTA.DVE_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DVE_NUMERO_FILA", oeDETALLE_VENTA.DVE_numero_fila)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_VENTA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeDETALLE_VENTA.VTA_serie_correlativo));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_VENTA.PRO_codigo));
				cmd.Parameters.Add(new SqlParameter("@DVE_IS_BONIFICACION", oeDETALLE_VENTA.DVE_is_bonificacion));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_VENTA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeDETALLE_VENTA.VTA_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_VENTA.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DVE_IS_BONIFICACION", oeDETALLE_VENTA.DVE_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_DETALLE_VENTA_poblar";
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
				string sp = "pa_crud_DETALLE_VENTA_buscarRegistro";
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
				string sp = "pa_list_DETALLE_VENTA_primerRegistro";
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
				string sp = "pa_list_DETALLE_VENTA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_VENTA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeDETALLE_VENTA.VTA_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_VENTA.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DVE_IS_BONIFICACION", oeDETALLE_VENTA.DVE_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_VENTA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeDETALLE_VENTA.VTA_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_VENTA.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DVE_IS_BONIFICACION", oeDETALLE_VENTA.DVE_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
