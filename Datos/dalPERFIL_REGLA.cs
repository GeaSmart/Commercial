using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPERFIL_REGLA
	{

		public bool insertarRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PERFIL_REGLA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL_REGLA.PER_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@REG_CODIGO", oePERFIL_REGLA.REG_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRE_IS_ACTIVO", oePERFIL_REGLA.PRE_is_activo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PERFIL_REGLA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL_REGLA.PER_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@REG_CODIGO", oePERFIL_REGLA.REG_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRE_IS_ACTIVO", oePERFIL_REGLA.PRE_is_activo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PERFIL_REGLA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL_REGLA.PER_codigo));
				cmd.Parameters.Add(new SqlParameter("@REG_CODIGO", oePERFIL_REGLA.REG_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PERFIL_REGLA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL_REGLA.PER_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@REG_CODIGO", oePERFIL_REGLA.REG_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_PERFIL_REGLA_poblar";
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
				string sp = "pa_crud_PERFIL_REGLA_buscarRegistro";
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
				string sp = "pa_list_PERFIL_REGLA_primerRegistro";
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
				string sp = "pa_list_PERFIL_REGLA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_PERFIL_REGLA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL_REGLA.PER_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@REG_CODIGO", oePERFIL_REGLA.REG_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_PERFIL_REGLA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PER_CODIGO", oePERFIL_REGLA.PER_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@REG_CODIGO", oePERFIL_REGLA.REG_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
