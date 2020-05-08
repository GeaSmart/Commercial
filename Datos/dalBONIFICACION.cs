using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalBONIFICACION
	{

		public bool insertarRegistro(eBONIFICACION oeBONIFICACION) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_BONIFICACION_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeBONIFICACION.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@BON_IS_ESPECIAL", oeBONIFICACION.BON_is_especial)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_REQ", oeBONIFICACION.BON_cantidad_req)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_REQ_SUBMULTIPLO", oeBONIFICACION.BON_cantidad_req_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_BONI", oeBONIFICACION.BON_cantidad_boni)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_BONI_SUBMULTIPLO", oeBONIFICACION.BON_cantidad_boni_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_ESP_CANTIDAD_BONI", oeBONIFICACION.BON_esp_cantidad_boni)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_ESP_CANTIDAD_BONI_SUBMULTIPLO", oeBONIFICACION.BON_esp_cantidad_boni_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_PRODUCTO", oeBONIFICACION.BON_producto)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@BON_FECHA_VENCIMIENTO", (object)oeBONIFICACION.BON_fecha_vencimiento ?? DBNull.Value)); //variable tipo:DateTime
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eBONIFICACION oeBONIFICACION) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_BONIFICACION_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeBONIFICACION.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@BON_IS_ESPECIAL", oeBONIFICACION.BON_is_especial)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_REQ", oeBONIFICACION.BON_cantidad_req)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_REQ_SUBMULTIPLO", oeBONIFICACION.BON_cantidad_req_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_BONI", oeBONIFICACION.BON_cantidad_boni)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_CANTIDAD_BONI_SUBMULTIPLO", oeBONIFICACION.BON_cantidad_boni_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_ESP_CANTIDAD_BONI", oeBONIFICACION.BON_esp_cantidad_boni)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_ESP_CANTIDAD_BONI_SUBMULTIPLO", oeBONIFICACION.BON_esp_cantidad_boni_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@BON_PRODUCTO", oeBONIFICACION.BON_producto)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@BON_FECHA_VENCIMIENTO", (object)oeBONIFICACION.BON_fecha_vencimiento ?? DBNull.Value)); //variable tipo:DateTime
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eBONIFICACION oeBONIFICACION) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_BONIFICACION_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeBONIFICACION.PRO_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eBONIFICACION oeBONIFICACION) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_BONIFICACION_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeBONIFICACION.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_BONIFICACION_poblar";
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
				string sp = "pa_crud_BONIFICACION_buscarRegistro";
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
				string sp = "pa_list_BONIFICACION_primerRegistro";
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
				string sp = "pa_list_BONIFICACION_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eBONIFICACION oeBONIFICACION) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_BONIFICACION_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeBONIFICACION.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eBONIFICACION oeBONIFICACION) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_BONIFICACION_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeBONIFICACION.CAN_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeBONIFICACION.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
