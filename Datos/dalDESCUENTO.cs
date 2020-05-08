using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDESCUENTO
	{

		public bool insertarRegistro(eDESCUENTO oeDESCUENTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DESCUENTO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DSC_IS_ESPECIAL", oeDESCUENTO.DSC_is_especial)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DSC_PORCENTAJE", oeDESCUENTO.DSC_porcentaje)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DSC_ESP_PORCENTAJE", (object)oeDESCUENTO.DSC_esp_porcentaje ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DSC_FECHA_VENCIMIENTO", (object)oeDESCUENTO.DSC_fecha_vencimiento ?? DBNull.Value)); //variable tipo:DateTime
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eDESCUENTO oeDESCUENTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DESCUENTO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DSC_IS_ESPECIAL", oeDESCUENTO.DSC_is_especial)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DSC_PORCENTAJE", oeDESCUENTO.DSC_porcentaje)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DSC_ESP_PORCENTAJE", (object)oeDESCUENTO.DSC_esp_porcentaje ?? DBNull.Value)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DSC_FECHA_VENCIMIENTO", (object)oeDESCUENTO.DSC_fecha_vencimiento ?? DBNull.Value)); //variable tipo:DateTime
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eDESCUENTO oeDESCUENTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DESCUENTO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eDESCUENTO oeDESCUENTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DESCUENTO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_DESCUENTO_poblar";
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
				string sp = "pa_crud_DESCUENTO_buscarRegistro";
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
				string sp = "pa_list_DESCUENTO_primerRegistro";
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
				string sp = "pa_list_DESCUENTO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eDESCUENTO oeDESCUENTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DESCUENTO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eDESCUENTO oeDESCUENTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DESCUENTO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAN_CODIGO", oeDESCUENTO.CAN_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDESCUENTO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
