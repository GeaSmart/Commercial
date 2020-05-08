using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalAUDITORIA
	{

		public bool insertarRegistro(eAUDITORIA oeAUDITORIA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_AUDITORIA_insertarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@TYPE", oeAUDITORIA.Type)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@TABLENAME", oeAUDITORIA.TableName)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRIMARYKEYFIELD", oeAUDITORIA.PrimaryKeyField)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRIMARYKEYVALUE", oeAUDITORIA.PrimaryKeyValue)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@FIELDNAME", oeAUDITORIA.FieldName)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@OLDVALUE", (object)oeAUDITORIA.OldValue ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NEWVALUE", oeAUDITORIA.NewValue)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@UPDATEDATE", oeAUDITORIA.UpdateDate)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@USUARIOAPP", oeAUDITORIA.UsuarioApp)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SERVIDOR", oeAUDITORIA.Servidor)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@USERNAME", oeAUDITORIA.UserName)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@ESTACION", oeAUDITORIA.Estacion)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool actualizarRegistro(eAUDITORIA oeAUDITORIA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_AUDITORIA_actualizarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@AUDITID", oeAUDITORIA.AuditID)); //variable tipo:int
				cmd.Parameters.Add(new SqlParameter("@TYPE", oeAUDITORIA.Type)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@TABLENAME", oeAUDITORIA.TableName)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRIMARYKEYFIELD", oeAUDITORIA.PrimaryKeyField)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@PRIMARYKEYVALUE", oeAUDITORIA.PrimaryKeyValue)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@FIELDNAME", oeAUDITORIA.FieldName)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@OLDVALUE", (object)oeAUDITORIA.OldValue ?? DBNull.Value)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@NEWVALUE", oeAUDITORIA.NewValue)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@UPDATEDATE", oeAUDITORIA.UpdateDate)); //variable tipo:DateTime
				cmd.Parameters.Add(new SqlParameter("@USUARIOAPP", oeAUDITORIA.UsuarioApp)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@SERVIDOR", oeAUDITORIA.Servidor)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@USERNAME", oeAUDITORIA.UserName)); //variable tipo:string
				cmd.Parameters.Add(new SqlParameter("@ESTACION", oeAUDITORIA.Estacion)); //variable tipo:string
				
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public bool eliminarRegistro(eAUDITORIA oeAUDITORIA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_AUDITORIA_eliminarRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				cnn.Open();
				
				cmd.Parameters.Add(new SqlParameter("@AUDITID", oeAUDITORIA.AuditID));
			
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable obtenerRegistro(eAUDITORIA oeAUDITORIA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_crud_AUDITORIA_obtenerRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@AUDITID", oeAUDITORIA.AuditID));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		//Se recomienda sólo utilizar los métodos de poblado para tablas con 1 sola PK, porque este método está pensado en cargar tablas de Data maestra en comboboxes u otro control similar, no para tablas con abundante data resultado de las operaciones del sistema.
		public DataTable poblar() { //En caso se quiera poblar con condiciones (x ejm.Poblar solo activos) agregar entidad aquí como parámetro
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_pplt_AUDITORIA_poblar";
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
				string sp = "pa_crud_AUDITORIA_buscarRegistro";
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
				string sp = "pa_list_AUDITORIA_primerRegistro";
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
				string sp = "pa_list_AUDITORIA_ultimoRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable anteriorRegistro(eAUDITORIA oeAUDITORIA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_AUDITORIA_anteriorRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@AUDITID", oeAUDITORIA.AuditID));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

		public DataTable siguienteRegistro(eAUDITORIA oeAUDITORIA) {
			using ( SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
			{
				string sp = "pa_list_AUDITORIA_siguienteRegistro";
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				
				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@AUDITID", oeAUDITORIA.AuditID));
				
				DataTable dt = new DataTable();
				dad.Fill(dt);
				
				return dt;
			}
		}

	}
}
