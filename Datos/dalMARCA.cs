using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalMARCA
	{

		public bool insertarRegistro(eMARCA oeMARCA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_MARCA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@MAR_CODIGO", oeMARCA.MAR_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MAR_NOMBRE", oeMARCA.MAR_nombre)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eMARCA oeMARCA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_MARCA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@MAR_CODIGO", oeMARCA.MAR_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MAR_NOMBRE", oeMARCA.MAR_nombre)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eMARCA oeMARCA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_MARCA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@MAR_CODIGO", oeMARCA.MAR_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eMARCA oeMARCA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_MARCA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@MAR_CODIGO", oeMARCA.MAR_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_MARCA_poblar";
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
				string sp = "pa_crud_MARCA_buscarRegistro";
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
				string sp = "pa_list_MARCA_primerRegistro";
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
				string sp = "pa_list_MARCA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eMARCA oeMARCA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_MARCA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@MAR_CODIGO", oeMARCA.MAR_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eMARCA oeMARCA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_MARCA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@MAR_CODIGO", oeMARCA.MAR_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
