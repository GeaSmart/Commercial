using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalVENDEDOR
	{

		public bool insertarRegistro(eVENDEDOR oeVENDEDOR) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_VENDEDOR_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VEN_NOMBRE_COMPLETO", oeVENDEDOR.VEN_nombre_completo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_DNI", oeVENDEDOR.VEN_dni)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_TELEFONO", (object)oeVENDEDOR.VEN_telefono ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_ESTADO", oeVENDEDOR.VEN_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_COMENTARIO", (object)oeVENDEDOR.VEN_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add("@VEN_IMAGEN", SqlDbType.Image).Value = (object)oeVENDEDOR.VEN_imagen ?? DBNull.Value;// variable tipo:byte[]
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eVENDEDOR oeVENDEDOR) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_VENDEDOR_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oeVENDEDOR.VEN_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VEN_NOMBRE_COMPLETO", oeVENDEDOR.VEN_nombre_completo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_DNI", oeVENDEDOR.VEN_dni)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_TELEFONO", (object)oeVENDEDOR.VEN_telefono ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_ESTADO", oeVENDEDOR.VEN_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@VEN_COMENTARIO", (object)oeVENDEDOR.VEN_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add("@VEN_IMAGEN", SqlDbType.Image).Value = (object)oeVENDEDOR.VEN_imagen ?? DBNull.Value;// variable tipo:byte[]
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eVENDEDOR oeVENDEDOR) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_VENDEDOR_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oeVENDEDOR.VEN_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eVENDEDOR oeVENDEDOR) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_VENDEDOR_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VEN_CODIGO", oeVENDEDOR.VEN_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_VENDEDOR_poblar";
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
				string sp = "pa_crud_VENDEDOR_buscarRegistro";
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
				string sp = "pa_list_VENDEDOR_primerRegistro";
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
				string sp = "pa_list_VENDEDOR_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eVENDEDOR oeVENDEDOR) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_VENDEDOR_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VEN_CODIGO", oeVENDEDOR.VEN_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eVENDEDOR oeVENDEDOR) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_VENDEDOR_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@VEN_CODIGO", oeVENDEDOR.VEN_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
