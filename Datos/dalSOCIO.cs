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

		public bool insertarRegistro(eSOCIO oeSOCIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_SOCIO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@SOC_TIPO_SOCIO", oeSOCIO.SOC_tipo_socio)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_NOMBRE_RAZON_SOCIAL", (object)oeSOCIO.SOC_nombre_razon_social ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_APELLIDO_PATERNO", (object)oeSOCIO.SOC_apellido_paterno ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_APELLIDO_MATERNO", (object)oeSOCIO.SOC_apellido_materno ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_NOMBRES", (object)oeSOCIO.SOC_nombres ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_NUMERO_DOCUMENTO", oeSOCIO.SOC_numero_documento)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_DIRECCION", oeSOCIO.SOC_direccion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_REFERENCIA_DIRECCION", (object)oeSOCIO.SOC_referencia_direccion ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_TELEFONO_FIJO", (object)oeSOCIO.SOC_telefono_fijo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_TELEFONO_MOVIL", (object)oeSOCIO.SOC_telefono_movil ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_EMAIL", (object)oeSOCIO.SOC_email ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_WEB", (object)oeSOCIO.SOC_web ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_AGENTE_RETENCION", oeSOCIO.SOC_is_agente_retencion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_AGENTE_PERCEPCION", oeSOCIO.SOC_is_agente_percepcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_PORCENTAJE_PERCEPCION", (object)oeSOCIO.SOC_porcentaje_percepcion ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_VALIDAR_BONIFICACION", oeSOCIO.SOC_is_validar_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_BONIFICACION_PERSONALIZADA", oeSOCIO.SOC_is_bonificacion_personalizada)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_DESCUENTO_PERSONALIZADO", oeSOCIO.SOC_is_descuento_personalizado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_KEY_ACCOUNT", oeSOCIO.SOC_is_key_account)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_DIAS_CREDITO", oeSOCIO.SOC_dias_credito)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@SOC_FECHA_REGISTRO", oeSOCIO.SOC_fecha_registro)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@SOC_LINEA_CREDITO", oeSOCIO.SOC_linea_credito)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@SOC_TIPO_PERSONA", oeSOCIO.SOC_tipo_persona)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_ACTIVO", oeSOCIO.SOC_is_activo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_COMENTARIO", (object)oeSOCIO.SOC_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_TIPO_DOCUMENTO_IDENTIDAD", oeSOCIO.SOC_tipo_documento_identidad)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_LATITUD", (object)oeSOCIO.SOC_latitud ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@SOC_LONGITUD", (object)oeSOCIO.SOC_longitud ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeSOCIO.LPR_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@TNE_CODIGO", oeSOCIO.TNE_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeSOCIO.CAN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@UBI_ID", oeSOCIO.UBI_id)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@ZON_CODIGO", oeSOCIO.ZON_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", (object)oeSOCIO.VEN_codigo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", (object)oeSOCIO.TDO_codigo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", (object)oeSOCIO.CPA_codigo ?? DBNull.Value)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eSOCIO oeSOCIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_SOCIO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeSOCIO.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@SOC_TIPO_SOCIO", oeSOCIO.SOC_tipo_socio)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_NOMBRE_RAZON_SOCIAL", (object)oeSOCIO.SOC_nombre_razon_social ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_APELLIDO_PATERNO", (object)oeSOCIO.SOC_apellido_paterno ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_APELLIDO_MATERNO", (object)oeSOCIO.SOC_apellido_materno ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_NOMBRES", (object)oeSOCIO.SOC_nombres ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_NUMERO_DOCUMENTO", oeSOCIO.SOC_numero_documento)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_DIRECCION", oeSOCIO.SOC_direccion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_REFERENCIA_DIRECCION", (object)oeSOCIO.SOC_referencia_direccion ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_TELEFONO_FIJO", (object)oeSOCIO.SOC_telefono_fijo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_TELEFONO_MOVIL", (object)oeSOCIO.SOC_telefono_movil ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_EMAIL", (object)oeSOCIO.SOC_email ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_WEB", (object)oeSOCIO.SOC_web ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_AGENTE_RETENCION", oeSOCIO.SOC_is_agente_retencion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_AGENTE_PERCEPCION", oeSOCIO.SOC_is_agente_percepcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_PORCENTAJE_PERCEPCION", (object)oeSOCIO.SOC_porcentaje_percepcion ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_VALIDAR_BONIFICACION", oeSOCIO.SOC_is_validar_bonificacion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_BONIFICACION_PERSONALIZADA", oeSOCIO.SOC_is_bonificacion_personalizada)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_DESCUENTO_PERSONALIZADO", oeSOCIO.SOC_is_descuento_personalizado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_KEY_ACCOUNT", oeSOCIO.SOC_is_key_account)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_DIAS_CREDITO", oeSOCIO.SOC_dias_credito)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@SOC_FECHA_REGISTRO", oeSOCIO.SOC_fecha_registro)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@SOC_LINEA_CREDITO", oeSOCIO.SOC_linea_credito)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@SOC_TIPO_PERSONA", oeSOCIO.SOC_tipo_persona)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_IS_ACTIVO", oeSOCIO.SOC_is_activo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_COMENTARIO", (object)oeSOCIO.SOC_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_TIPO_DOCUMENTO_IDENTIDAD", oeSOCIO.SOC_tipo_documento_identidad)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_LATITUD", (object)oeSOCIO.SOC_latitud ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@SOC_LONGITUD", (object)oeSOCIO.SOC_longitud ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeSOCIO.LPR_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@TNE_CODIGO", oeSOCIO.TNE_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeSOCIO.CAN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@UBI_ID", oeSOCIO.UBI_id)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@ZON_CODIGO", oeSOCIO.ZON_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", (object)oeSOCIO.VEN_codigo ?? DBNull.Value)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", (object)oeSOCIO.TDO_codigo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", (object)oeSOCIO.CPA_codigo ?? DBNull.Value)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eSOCIO oeSOCIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_SOCIO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeSOCIO.SOC_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eSOCIO oeSOCIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_SOCIO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeSOCIO.SOC_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_SOCIO_poblar";
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
				string sp = "pa_crud_SOCIO_buscarRegistro";
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
				string sp = "pa_list_SOCIO_primerRegistro";
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
				string sp = "pa_list_SOCIO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eSOCIO oeSOCIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_SOCIO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeSOCIO.SOC_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eSOCIO oeSOCIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_SOCIO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeSOCIO.SOC_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
