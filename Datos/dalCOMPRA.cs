using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalCOMPRA
	{

		public bool insertarRegistro(eCOMPRA oeCOMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_COMPRA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_FECHA_DOCUMENTO_ORIGEN", oeCOMPRA.COM_fecha_documento_origen)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@COM_FECHA_VENCIMIENTO", oeCOMPRA.COM_fecha_vencimiento)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@COM_DOCUMENTO_ORIGEN", oeCOMPRA.COM_documento_origen)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@COM_TIPO_DOCUMENTO", oeCOMPRA.COM_tipo_documento)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeCOMPRA.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@COM_SOC_NOMBRE_RAZON", oeCOMPRA.COM_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@COM_SUBTOTAL", oeCOMPRA.COM_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_PORCENTAJE_PERCEPCION", oeCOMPRA.COM_porcentaje_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_IGV", oeCOMPRA.COM_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_ISC", oeCOMPRA.COM_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_PERCEPCION", oeCOMPRA.COM_monto_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_TOTAL", oeCOMPRA.COM_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_COMENTARIO", (object)oeCOMPRA.COM_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@COM_ESTADO", oeCOMPRA.COM_estado)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eCOMPRA oeCOMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_COMPRA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oeCOMPRA.COM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@COM_FECHA_DOCUMENTO_ORIGEN", oeCOMPRA.COM_fecha_documento_origen)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@COM_FECHA_VENCIMIENTO", oeCOMPRA.COM_fecha_vencimiento)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@COM_DOCUMENTO_ORIGEN", oeCOMPRA.COM_documento_origen)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@COM_TIPO_DOCUMENTO", oeCOMPRA.COM_tipo_documento)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeCOMPRA.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@COM_SOC_NOMBRE_RAZON", oeCOMPRA.COM_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@COM_SUBTOTAL", oeCOMPRA.COM_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_PORCENTAJE_PERCEPCION", oeCOMPRA.COM_porcentaje_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_IGV", oeCOMPRA.COM_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_ISC", oeCOMPRA.COM_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_PERCEPCION", oeCOMPRA.COM_monto_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_MONTO_TOTAL", oeCOMPRA.COM_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@COM_COMENTARIO", (object)oeCOMPRA.COM_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@COM_ESTADO", oeCOMPRA.COM_estado)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eCOMPRA oeCOMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_COMPRA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oeCOMPRA.COM_numero));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eCOMPRA oeCOMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_COMPRA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oeCOMPRA.COM_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_COMPRA_poblar";
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
				string sp = "pa_crud_COMPRA_buscarRegistro";
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
				string sp = "pa_op_list_COMPRA_primerRegistro";
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
				string sp = "pa_op_list_COMPRA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eCOMPRA oeCOMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_COMPRA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oeCOMPRA.COM_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eCOMPRA oeCOMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_COMPRA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oeCOMPRA.COM_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
