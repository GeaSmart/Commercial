using System;

namespace Entidades
{
	public class eAUDITORIA {

		private int _AuditID = 0;
		private string _Type = "";
		private string _TableName = "";
		private string _PrimaryKeyField = "";
		private string _PrimaryKeyValue = "";
		private string _FieldName = "";
		private string _OldValue = "";
		private string _NewValue = "";
		private DateTime _UpdateDate = DateTime.Now;
		private string _UsuarioApp = "";
		private string _Servidor = "";
		private string _UserName = "";
		private string _Estacion = "";

		public int AuditID {
			get {
				return _AuditID;
			}
			set {
				_AuditID = value;
			}
		}

		public string Type {
			get {
				return _Type;
			}
			set {
				_Type = value;
			}
		}

		public string TableName {
			get {
				return _TableName;
			}
			set {
				_TableName = value;
			}
		}

		public string PrimaryKeyField {
			get {
				return _PrimaryKeyField;
			}
			set {
				_PrimaryKeyField = value;
			}
		}

		public string PrimaryKeyValue {
			get {
				return _PrimaryKeyValue;
			}
			set {
				_PrimaryKeyValue = value;
			}
		}

		public string FieldName {
			get {
				return _FieldName;
			}
			set {
				_FieldName = value;
			}
		}

		public string OldValue {
			get {
				return _OldValue;
			}
			set {
				_OldValue = value;
			}
		}

		public string NewValue {
			get {
				return _NewValue;
			}
			set {
				_NewValue = value;
			}
		}

		public DateTime UpdateDate {
			get {
				return _UpdateDate;
			}
			set {
				_UpdateDate = value;
			}
		}

		public string UsuarioApp {
			get {
				return _UsuarioApp;
			}
			set {
				_UsuarioApp = value;
			}
		}

		public string Servidor {
			get {
				return _Servidor;
			}
			set {
				_Servidor = value;
			}
		}

		public string UserName {
			get {
				return _UserName;
			}
			set {
				_UserName = value;
			}
		}

		public string Estacion {
			get {
				return _Estacion;
			}
			set {
				_Estacion = value;
			}
		}

		public eAUDITORIA(){
		}

		public eAUDITORIA(ref int AuditID, string Type, string TableName, string PrimaryKeyField, string PrimaryKeyValue, string FieldName, string OldValue, string NewValue, DateTime UpdateDate, string UsuarioApp, string Servidor, string UserName, string Estacion)
		{
			_AuditID = AuditID;
			_Type = Type;
			_TableName = TableName;
			_PrimaryKeyField = PrimaryKeyField;
			_PrimaryKeyValue = PrimaryKeyValue;
			_FieldName = FieldName;
			_OldValue = OldValue;
			_NewValue = NewValue;
			_UpdateDate = UpdateDate;
			_UsuarioApp = UsuarioApp;
			_Servidor = Servidor;
			_UserName = UserName;
			_Estacion = Estacion;
		}
	}
}
