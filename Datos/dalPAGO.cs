using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPAGO
	{

		public bool insertarRegistro(ePAGO oePAGO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oePAGO.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PAG_NUMERO", oePAGO.PAG_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PAG_MONTO_TOTAL", oePAGO.PAG_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PAG_ABONO", oePAGO.PAG_abono)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PAG_REFERENCIA", (object)oePAGO.PAG_referencia ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MPA_CODIGO", oePAGO.MPA_codigo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(ePAGO oePAGO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oePAGO.VTA_serie_correlativo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PAG_NUMERO", oePAGO.PAG_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PAG_MONTO_TOTAL", oePAGO.PAG_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PAG_ABONO", oePAGO.PAG_abono)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PAG_REFERENCIA", (object)oePAGO.PAG_referencia ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MPA_CODIGO", oePAGO.MPA_codigo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(ePAGO oePAGO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oePAGO.VTA_serie_correlativo));
				cmd.Parameters.Add(new SqlParameter("@PAG_NUMERO", oePAGO.PAG_numero));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(ePAGO oePAGO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oePAGO.VTA_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PAG_NUMERO", oePAGO.PAG_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_PAGO_poblar";
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
				string sp = "pa_crud_PAGO_buscarRegistro";
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
				string sp = "pa_list_PAGO_primerRegistro";
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
				string sp = "pa_list_PAGO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(ePAGO oePAGO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_PAGO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oePAGO.VTA_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PAG_NUMERO", oePAGO.PAG_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(ePAGO oePAGO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_PAGO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oePAGO.VTA_serie_correlativo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PAG_NUMERO", oePAGO.PAG_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
