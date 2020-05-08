using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPEDIDO
	{

		public bool insertarRegistro(ePEDIDO oePEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PEDIDO_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@PED_FECHA_ENTREGA", oePEDIDO.PED_fecha_entrega)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oePEDIDO.VEN_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_NOMBRE_VENDEDOR", oePEDIDO.PED_nombre_vendedor)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oePEDIDO.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_SOC_NOMBRE_RAZON", oePEDIDO.PED_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_SOC_DIRECCION", oePEDIDO.PED_soc_direccion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_SOC_ZONA", oePEDIDO.PED_soc_zona)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_SUBTOTAL", oePEDIDO.PED_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_PORCENTAJE_PERCEPCION", oePEDIDO.PED_porcentaje_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_IGV", oePEDIDO.PED_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_ISC", oePEDIDO.PED_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_PERCEPCION", oePEDIDO.PED_monto_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_TOTAL", oePEDIDO.PED_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_COMENTARIO", (object)oePEDIDO.PED_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_ESTADO", oePEDIDO.PED_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oePEDIDO.CPA_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_TDO_CODIGO", oePEDIDO.PED_tdo_codigo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(ePEDIDO oePEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PEDIDO_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@PED_FECHA_ENTREGA", oePEDIDO.PED_fecha_entrega)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oePEDIDO.VEN_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_NOMBRE_VENDEDOR", oePEDIDO.PED_nombre_vendedor)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oePEDIDO.SOC_codigo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_SOC_NOMBRE_RAZON", oePEDIDO.PED_soc_nombre_razon)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_SOC_DIRECCION", oePEDIDO.PED_soc_direccion)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_SOC_ZONA", oePEDIDO.PED_soc_zona)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PED_SUBTOTAL", oePEDIDO.PED_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_PORCENTAJE_PERCEPCION", oePEDIDO.PED_porcentaje_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_IGV", oePEDIDO.PED_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_ISC", oePEDIDO.PED_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_PERCEPCION", oePEDIDO.PED_monto_percepcion)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_MONTO_TOTAL", oePEDIDO.PED_monto_total)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@PED_COMENTARIO", (object)oePEDIDO.PED_comentario ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_ESTADO", oePEDIDO.PED_estado)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oePEDIDO.CPA_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PED_TDO_CODIGO", oePEDIDO.PED_tdo_codigo)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(ePEDIDO oePEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_PEDIDO_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(ePEDIDO oePEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_crud_PEDIDO_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_PEDIDO_poblar";
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
				string sp = "pa_crud_PEDIDO_buscarRegistro";
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
				string sp = "pa_op_list_PEDIDO_primerRegistro";
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
				string sp = "pa_op_list_PEDIDO_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(ePEDIDO oePEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_PEDIDO_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(ePEDIDO oePEDIDO) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_op_list_PEDIDO_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
