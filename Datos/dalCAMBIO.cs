using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalCAMBIO
	{

		public bool insertarRegistro(eCAMBIO oeCAMBIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO.CAM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeCAMBIO.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@SOC_NOMBRE_RAZON", oeCAMBIO.SOC_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", oeCAMBIO.MDE_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oeCAMBIO.VEN_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@CAM_NOMBRE_VENDEDOR", oeCAMBIO.CAM_nombre_vendedor)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CAM_MONTO_TOTAL", oeCAMBIO.CAM_monto_total)); //variable tipo:double
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eCAMBIO oeCAMBIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO.CAM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeCAMBIO.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@SOC_NOMBRE_RAZON", oeCAMBIO.SOC_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", oeCAMBIO.MDE_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oeCAMBIO.VEN_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@CAM_NOMBRE_VENDEDOR", oeCAMBIO.CAM_nombre_vendedor)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CAM_MONTO_TOTAL", oeCAMBIO.CAM_monto_total)); //variable tipo:double
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eCAMBIO oeCAMBIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO.CAM_numero));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eCAMBIO oeCAMBIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO.CAM_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_CAMBIO_poblar";
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
				string sp = "pa_crud_CAMBIO_buscarRegistro";
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
				string sp = "pa_list_CAMBIO_primerRegistro";
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
				string sp = "pa_list_CAMBIO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eCAMBIO oeCAMBIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_CAMBIO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO.CAM_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eCAMBIO oeCAMBIO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_CAMBIO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO.CAM_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
