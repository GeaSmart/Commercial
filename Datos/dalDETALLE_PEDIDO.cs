using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_PEDIDO
	{

		public bool insertarRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_DETALLE_PEDIDO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oeDETALLE_PEDIDO.PED_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_PEDIDO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", oeDETALLE_PEDIDO.DPE_is_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_PRO_DESCRIPCION", oeDETALLE_PEDIDO.DPE_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_PRO_UME_MULTIPLO", oeDETALLE_PEDIDO.DPE_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD", oeDETALLE_PEDIDO.DPE_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_PEDIDO.DPE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPE_PRECIO_UNITARIO", oeDETALLE_PEDIDO.DPE_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_SUBTOTAL", oeDETALLE_PEDIDO.DPE_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_DESCUENTO", oeDETALLE_PEDIDO.DPE_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_DESCUENTO", oeDETALLE_PEDIDO.DPE_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_IGV", oeDETALLE_PEDIDO.DPE_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_ISC", oeDETALLE_PEDIDO.DPE_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_IGV", oeDETALLE_PEDIDO.DPE_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_ISC", oeDETALLE_PEDIDO.DPE_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_TOTAL_LINEA", oeDETALLE_PEDIDO.DPE_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MEMO", (object)oeDETALLE_PEDIDO.DPE_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_NUMERO_FILA", oeDETALLE_PEDIDO.DPE_numero_fila)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_PEDIDO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oeDETALLE_PEDIDO.PED_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_PEDIDO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", oeDETALLE_PEDIDO.DPE_is_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_PRO_DESCRIPCION", oeDETALLE_PEDIDO.DPE_pro_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_PRO_UME_MULTIPLO", oeDETALLE_PEDIDO.DPE_pro_ume_multiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD", oeDETALLE_PEDIDO.DPE_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD_SUBMULTIPLO", (object)oeDETALLE_PEDIDO.DPE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPE_PRECIO_UNITARIO", oeDETALLE_PEDIDO.DPE_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_SUBTOTAL", oeDETALLE_PEDIDO.DPE_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_DESCUENTO", oeDETALLE_PEDIDO.DPE_monto_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_DESCUENTO", oeDETALLE_PEDIDO.DPE_porcentaje_descuento)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_IGV", oeDETALLE_PEDIDO.DPE_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_ISC", oeDETALLE_PEDIDO.DPE_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_IGV", oeDETALLE_PEDIDO.DPE_porcentaje_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_ISC", oeDETALLE_PEDIDO.DPE_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_TOTAL_LINEA", oeDETALLE_PEDIDO.DPE_monto_total_linea)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPE_MEMO", (object)oeDETALLE_PEDIDO.DPE_memo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DPE_NUMERO_FILA", oeDETALLE_PEDIDO.DPE_numero_fila)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_PEDIDO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oeDETALLE_PEDIDO.PED_numero));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_PEDIDO.PRO_codigo));
				cmd.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", oeDETALLE_PEDIDO.DPE_is_bonificacion));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_PEDIDO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_NUMERO", oeDETALLE_PEDIDO.PED_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_PEDIDO.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", oeDETALLE_PEDIDO.DPE_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_DETALLE_PEDIDO_poblar";
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
				string sp = "pa_crud_DETALLE_PEDIDO_buscarRegistro";
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
				string sp = "pa_list_DETALLE_PEDIDO_primerRegistro";
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
				string sp = "pa_list_DETALLE_PEDIDO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_PEDIDO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_NUMERO", oeDETALLE_PEDIDO.PED_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_PEDIDO.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", oeDETALLE_PEDIDO.DPE_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_PEDIDO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_NUMERO", oeDETALLE_PEDIDO.PED_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_PEDIDO.PRO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", oeDETALLE_PEDIDO.DPE_is_bonificacion));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
