using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_LISTA_PRECIO
	{

		public bool insertarRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_LISTA_PRECIO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeDETALLE_LISTA_PRECIO.LPR_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_LISTA_PRECIO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DLP_PRECIO", oeDETALLE_LISTA_PRECIO.DLP_precio)); //variable tipo:double
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_LISTA_PRECIO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeDETALLE_LISTA_PRECIO.LPR_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_LISTA_PRECIO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DLP_PRECIO", oeDETALLE_LISTA_PRECIO.DLP_precio)); //variable tipo:double
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_LISTA_PRECIO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeDETALLE_LISTA_PRECIO.LPR_codigo));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_LISTA_PRECIO.PRO_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_LISTA_PRECIO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeDETALLE_LISTA_PRECIO.LPR_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_LISTA_PRECIO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_DETALLE_LISTA_PRECIO_poblar";
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
				string sp = "pa_crud_DETALLE_LISTA_PRECIO_buscarRegistro";
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
				string sp = "pa_list_DETALLE_LISTA_PRECIO_primerRegistro";
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
				string sp = "pa_list_DETALLE_LISTA_PRECIO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_LISTA_PRECIO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeDETALLE_LISTA_PRECIO.LPR_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_LISTA_PRECIO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_LISTA_PRECIO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@LPR_CODIGO", oeDETALLE_LISTA_PRECIO.LPR_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeDETALLE_LISTA_PRECIO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
