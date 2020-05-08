using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalCAMBIO_DETALLE
	{

		public bool insertarRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_DETALLE_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO_DETALLE.CAM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeCAMBIO_DETALLE.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCA_CANTIDAD", oeCAMBIO_DETALLE.DCA_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCA_CANTIDAD_SUBMULTIPLO", oeCAMBIO_DETALLE.DCA_cantidad_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCA_PRECIO_UNITARIO", oeCAMBIO_DETALLE.DCA_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_SUBTOTAL", oeCAMBIO_DETALLE.DCA_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_IGV", oeCAMBIO_DETALLE.DCA_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_ISC", oeCAMBIO_DETALLE.DCA_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_TOTAL", oeCAMBIO_DETALLE.DCA_monto_total)); //variable tipo:double
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_DETALLE_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO_DETALLE.CAM_numero)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeCAMBIO_DETALLE.PRO_codigo)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@DCA_CANTIDAD", oeCAMBIO_DETALLE.DCA_cantidad)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCA_CANTIDAD_SUBMULTIPLO", oeCAMBIO_DETALLE.DCA_cantidad_submultiplo)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@DCA_PRECIO_UNITARIO", oeCAMBIO_DETALLE.DCA_precio_unitario)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_SUBTOTAL", oeCAMBIO_DETALLE.DCA_monto_subtotal)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_IGV", oeCAMBIO_DETALLE.DCA_monto_igv)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_ISC", oeCAMBIO_DETALLE.DCA_monto_isc)); //variable tipo:double
				cmd.Parameters.Add(new SqlParameter("@DCA_MONTO_TOTAL", oeCAMBIO_DETALLE.DCA_monto_total)); //variable tipo:double
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_DETALLE_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO_DETALLE.CAM_numero));
				cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeCAMBIO_DETALLE.PRO_codigo));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_CAMBIO_DETALLE_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO_DETALLE.CAM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeCAMBIO_DETALLE.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_CAMBIO_DETALLE_poblar";
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
				string sp = "pa_crud_CAMBIO_DETALLE_buscarRegistro";
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
				string sp = "pa_list_CAMBIO_DETALLE_primerRegistro";
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
				string sp = "pa_list_CAMBIO_DETALLE_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_CAMBIO_DETALLE_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO_DETALLE.CAM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeCAMBIO_DETALLE.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_CAMBIO_DETALLE_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@CAM_NUMERO", oeCAMBIO_DETALLE.CAM_numero));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PRO_CODIGO", oeCAMBIO_DETALLE.PRO_codigo));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
