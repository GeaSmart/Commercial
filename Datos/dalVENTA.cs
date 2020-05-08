using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalVENTA
	{

		public bool insertarRegistro(eVENTA oeVENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_VENTA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_FECHA_CONTABILIZACION", oeVENTA.VTA_fecha_contabilizacion)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@VTA_FECHA_VENCIMIENTO", oeVENTA.VTA_fecha_vencimiento)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeVENTA.TDO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SER_SERIE", oeVENTA.SER_serie)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_CORRELATIVO", oeVENTA.VTA_correlativo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", (object)oeVENTA.CHO_codigo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_CHO_NOMBRE_COMPLETO", (object)oeVENTA.VTA_cho_nombre_completo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", (object)oeVENTA.VEN_codigo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_NOMBRE_VENDEDOR", (object)oeVENTA.VTA_nombre_vendedor ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_IS_COMISIONABLE", oeVENTA.VTA_is_comisionable)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_IS_OFICINA", oeVENTA.VTA_is_oficina)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@TVE_CODIGO", oeVENTA.TVE_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeVENTA.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_SOC_NOMBRE_RAZON", oeVENTA.VTA_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_SOC_DIRECCION", oeVENTA.VTA_soc_direccion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_SOC_ZONA", (object)oeVENTA.VTA_soc_zona ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_SUBTOTAL", oeVENTA.VTA_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_PORCENTAJE_PERCEPCION", oeVENTA.VTA_porcentaje_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_IGV", oeVENTA.VTA_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_ISC", oeVENTA.VTA_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_PERCEPCION", oeVENTA.VTA_monto_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_TOTAL", oeVENTA.VTA_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_TOTAL_TEXTO", oeVENTA.VTA_monto_total_texto)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_COMENTARIO", (object)oeVENTA.VTA_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_ESTADO", oeVENTA.VTA_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oeVENTA.CPA_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", (object)oeVENTA.PED_numero ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", (object)oeVENTA.MDE_codigo ?? DBNull.Value)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eVENTA oeVENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_VENTA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_FECHA_CONTABILIZACION", oeVENTA.VTA_fecha_contabilizacion)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@VTA_FECHA_VENCIMIENTO", oeVENTA.VTA_fecha_vencimiento)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeVENTA.TDO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SER_SERIE", oeVENTA.SER_serie)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_CORRELATIVO", oeVENTA.VTA_correlativo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", (object)oeVENTA.CHO_codigo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_CHO_NOMBRE_COMPLETO", (object)oeVENTA.VTA_cho_nombre_completo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", (object)oeVENTA.VEN_codigo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_NOMBRE_VENDEDOR", (object)oeVENTA.VTA_nombre_vendedor ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_IS_COMISIONABLE", oeVENTA.VTA_is_comisionable)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_IS_OFICINA", oeVENTA.VTA_is_oficina)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@TVE_CODIGO", oeVENTA.TVE_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeVENTA.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_SOC_NOMBRE_RAZON", oeVENTA.VTA_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_SOC_DIRECCION", oeVENTA.VTA_soc_direccion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_SOC_ZONA", (object)oeVENTA.VTA_soc_zona ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VTA_SUBTOTAL", oeVENTA.VTA_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_PORCENTAJE_PERCEPCION", oeVENTA.VTA_porcentaje_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_IGV", oeVENTA.VTA_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_ISC", oeVENTA.VTA_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_PERCEPCION", oeVENTA.VTA_monto_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_TOTAL", oeVENTA.VTA_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_TOTAL_TEXTO", oeVENTA.VTA_monto_total_texto)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_COMENTARIO", (object)oeVENTA.VTA_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VTA_ESTADO", oeVENTA.VTA_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oeVENTA.CPA_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", (object)oeVENTA.PED_numero ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", (object)oeVENTA.MDE_codigo ?? DBNull.Value)); //variable tipo:int
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eVENTA oeVENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_VENTA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eVENTA oeVENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_VENTA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_VENTA_poblar";
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
				string sp = "pa_op_crud_VENTA_buscarRegistro";
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
				string sp = "pa_op_list_VENTA_primerRegistro";
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
				string sp = "pa_op_list_VENTA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eVENTA oeVENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_VENTA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eVENTA oeVENTA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_VENTA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
