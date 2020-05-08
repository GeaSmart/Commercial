using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_PROG
	{

		public bool insertarRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_PROG_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", oeDETALLE_PROG.PRG_fecha)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", oeDETALLE_PROG.CHO_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", oeDETALLE_PROG.DPR_numero_viaje)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_DESDE", oeDETALLE_PROG.DPR_zona_desde)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_HASTA", oeDETALLE_PROG.DPR_zona_hasta)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_PESO", oeDETALLE_PROG.DPR_peso)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_DOCUMENTOS", oeDETALLE_PROG.DPR_numero_documentos)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_CANTIDAD_PRODUCTO", oeDETALLE_PROG.DPR_cantidad_producto)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VEH_PLACA", (object)oeDETALLE_PROG.VEH_placa ?? DBNull.Value)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_PROG_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", oeDETALLE_PROG.PRG_fecha)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", oeDETALLE_PROG.CHO_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", oeDETALLE_PROG.DPR_numero_viaje)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_DESDE", oeDETALLE_PROG.DPR_zona_desde)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_HASTA", oeDETALLE_PROG.DPR_zona_hasta)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_PESO", oeDETALLE_PROG.DPR_peso)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_DOCUMENTOS", oeDETALLE_PROG.DPR_numero_documentos)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DPR_CANTIDAD_PRODUCTO", oeDETALLE_PROG.DPR_cantidad_producto)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@VEH_PLACA", (object)oeDETALLE_PROG.VEH_placa ?? DBNull.Value)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_PROG_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", oeDETALLE_PROG.PRG_fecha));
				cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", oeDETALLE_PROG.CHO_codigo));
				cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", oeDETALLE_PROG.DPR_numero_viaje));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_DETALLE_PROG_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRG_FECHA", oeDETALLE_PROG.PRG_fecha));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CHO_CODIGO", oeDETALLE_PROG.CHO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", oeDETALLE_PROG.DPR_numero_viaje));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_DETALLE_PROG_poblar";
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
				string sp = "pa_crud_DETALLE_PROG_buscarRegistro";
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
				string sp = "pa_list_DETALLE_PROG_primerRegistro";
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
				string sp = "pa_list_DETALLE_PROG_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_PROG_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRG_FECHA", oeDETALLE_PROG.PRG_fecha));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CHO_CODIGO", oeDETALLE_PROG.CHO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", oeDETALLE_PROG.DPR_numero_viaje));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_DETALLE_PROG_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRG_FECHA", oeDETALLE_PROG.PRG_fecha));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CHO_CODIGO", oeDETALLE_PROG.CHO_codigo));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", oeDETALLE_PROG.DPR_numero_viaje));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
