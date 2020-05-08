using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_COMPRA
	{

		public bool insertarRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_COMPRA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oeDETALLE_COMPRA.COM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_COMPRA.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", oeDETALLE_COMPRA.DCO_is_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_PRO_DESCRIPCION", oeDETALLE_COMPRA.DCO_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_PRO_UME_MULTIPLO", oeDETALLE_COMPRA.DCO_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD", oeDETALLE_COMPRA.DCO_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_COMPRA.DCO_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_PRECIO_UNITARIO", oeDETALLE_COMPRA.DCO_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_SUBTOTAL", oeDETALLE_COMPRA.DCO_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_DESCUENTO", oeDETALLE_COMPRA.DCO_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_DESCUENTO", oeDETALLE_COMPRA.DCO_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_IGV", oeDETALLE_COMPRA.DCO_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_ISC", oeDETALLE_COMPRA.DCO_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_IGV", oeDETALLE_COMPRA.DCO_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_ISC", oeDETALLE_COMPRA.DCO_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_TOTAL_LINEA", oeDETALLE_COMPRA.DCO_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MEMO", (object)oeDETALLE_COMPRA.DCO_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_NUMERO_FILA", oeDETALLE_COMPRA.DCO_numero_fila)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_PRODUCCION", oeDETALLE_COMPRA.DCO_fecha_produccion)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_VENCIMIENTO", oeDETALLE_COMPRA.DCO_fecha_vencimiento)); //variable tipo:DateTime
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_COMPRA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oeDETALLE_COMPRA.COM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_COMPRA.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", oeDETALLE_COMPRA.DCO_is_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_PRO_DESCRIPCION", oeDETALLE_COMPRA.DCO_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_PRO_UME_MULTIPLO", oeDETALLE_COMPRA.DCO_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD", oeDETALLE_COMPRA.DCO_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_COMPRA.DCO_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_PRECIO_UNITARIO", oeDETALLE_COMPRA.DCO_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_SUBTOTAL", oeDETALLE_COMPRA.DCO_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_DESCUENTO", oeDETALLE_COMPRA.DCO_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_DESCUENTO", oeDETALLE_COMPRA.DCO_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_IGV", oeDETALLE_COMPRA.DCO_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_ISC", oeDETALLE_COMPRA.DCO_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_IGV", oeDETALLE_COMPRA.DCO_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_ISC", oeDETALLE_COMPRA.DCO_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_TOTAL_LINEA", oeDETALLE_COMPRA.DCO_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCO_MEMO", (object)oeDETALLE_COMPRA.DCO_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCO_NUMERO_FILA", oeDETALLE_COMPRA.DCO_numero_fila)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_PRODUCCION", oeDETALLE_COMPRA.DCO_fecha_produccion)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_VENCIMIENTO", oeDETALLE_COMPRA.DCO_fecha_vencimiento)); //variable tipo:DateTime
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_COMPRA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oeDETALLE_COMPRA.COM_numero));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_COMPRA.PRO_codigo));
				cmd.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", oeDETALLE_COMPRA.DCO_is_bonificacion));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_COMPRA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oeDETALLE_COMPRA.COM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_COMPRA.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", oeDETALLE_COMPRA.DCO_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_DETALLE_COMPRA_poblar";
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
				string sp = "pa_crud_DETALLE_COMPRA_buscarRegistro";
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
				string sp = "pa_list_DETALLE_COMPRA_primerRegistro";
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
				string sp = "pa_list_DETALLE_COMPRA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_COMPRA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oeDETALLE_COMPRA.COM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_COMPRA.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", oeDETALLE_COMPRA.DCO_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_COMPRA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oeDETALLE_COMPRA.COM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_COMPRA.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", oeDETALLE_COMPRA.DCO_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
