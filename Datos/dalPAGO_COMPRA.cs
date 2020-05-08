using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPAGO_COMPRA
	{

		public bool insertarRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_COMPRA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oePAGO_COMPRA.COM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PCO_NUMERO", oePAGO_COMPRA.PCO_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PCO_MONTO_TOTAL", oePAGO_COMPRA.PCO_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PCO_ABONO", oePAGO_COMPRA.PCO_abono)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PCO_REFERENCIA", (object)oePAGO_COMPRA.PCO_referencia ?? DBNull.Value)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_COMPRA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oePAGO_COMPRA.COM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PCO_NUMERO", oePAGO_COMPRA.PCO_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PCO_MONTO_TOTAL", oePAGO_COMPRA.PCO_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PCO_ABONO", oePAGO_COMPRA.PCO_abono)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PCO_REFERENCIA", (object)oePAGO_COMPRA.PCO_referencia ?? DBNull.Value)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_COMPRA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oePAGO_COMPRA.COM_numero));
				cmd.Parameters.Add(new SqlParameter("@PCO_NUMERO", oePAGO_COMPRA.PCO_numero));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PAGO_COMPRA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oePAGO_COMPRA.COM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PCO_NUMERO", oePAGO_COMPRA.PCO_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_PAGO_COMPRA_poblar";
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
				string sp = "pa_crud_PAGO_COMPRA_buscarRegistro";
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
				string sp = "pa_list_PAGO_COMPRA_primerRegistro";
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
				string sp = "pa_list_PAGO_COMPRA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_PAGO_COMPRA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oePAGO_COMPRA.COM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PCO_NUMERO", oePAGO_COMPRA.PCO_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_PAGO_COMPRA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@COM_NUMERO", oePAGO_COMPRA.COM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PCO_NUMERO", oePAGO_COMPRA.PCO_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
