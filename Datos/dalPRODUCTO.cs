using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPRODUCTO
	{

		public bool insertarRegistro(ePRODUCTO oePRODUCTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PRODUCTO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oePRODUCTO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_DESCRIPCION", oePRODUCTO.PRO_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@FOR_CODIGO", (object)oePRODUCTO.FOR_codigo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_IS_IGV", oePRODUCTO.PRO_is_igv)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_PORCENTAJE_ISC", oePRODUCTO.PRO_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PRO_PESO_KGR", oePRODUCTO.PRO_peso_kgr)); //variable tipo:double
				cmd.Parameters.Add("@PRO_IMAGEN", SqlDbType.Image).Value = (object)oePRODUCTO.PRO_imagen ?? DBNull.Value;// variable tipo:byte[]
				cmd.Parameters.Add(new SqlParameter("@PRO_IS_ACTIVO", oePRODUCTO.PRO_is_activo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_IS_PACK", oePRODUCTO.PRO_is_pack)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO_PACK", (object)oePRODUCTO.PRO_codigo_pack ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@UME_CODIGO", oePRODUCTO.UME_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@LIN_CODIGO", oePRODUCTO.LIN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MAR_CODIGO", oePRODUCTO.MAR_codigo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(ePRODUCTO oePRODUCTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PRODUCTO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oePRODUCTO.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_DESCRIPCION", oePRODUCTO.PRO_descripcion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@FOR_CODIGO", (object)oePRODUCTO.FOR_codigo ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_IS_IGV", oePRODUCTO.PRO_is_igv)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_PORCENTAJE_ISC", oePRODUCTO.PRO_porcentaje_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PRO_PESO_KGR", oePRODUCTO.PRO_peso_kgr)); //variable tipo:double
				cmd.Parameters.Add("@PRO_IMAGEN", SqlDbType.Image).Value = (object)oePRODUCTO.PRO_imagen ?? DBNull.Value;// variable tipo:byte[]
				cmd.Parameters.Add(new SqlParameter("@PRO_IS_ACTIVO", oePRODUCTO.PRO_is_activo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_IS_PACK", oePRODUCTO.PRO_is_pack)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO_PACK", (object)oePRODUCTO.PRO_codigo_pack ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@UME_CODIGO", oePRODUCTO.UME_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@LIN_CODIGO", oePRODUCTO.LIN_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@MAR_CODIGO", oePRODUCTO.MAR_codigo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(ePRODUCTO oePRODUCTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PRODUCTO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oePRODUCTO.PRO_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(ePRODUCTO oePRODUCTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_PRODUCTO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oePRODUCTO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_PRODUCTO_poblar";
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
				string sp = "pa_op_crud_PRODUCTO_buscarRegistro";
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
				string sp = "pa_op_list_PRODUCTO_primerRegistro";
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
				string sp = "pa_op_list_PRODUCTO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(ePRODUCTO oePRODUCTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_PRODUCTO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oePRODUCTO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(ePRODUCTO oePRODUCTO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_PRODUCTO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oePRODUCTO.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
