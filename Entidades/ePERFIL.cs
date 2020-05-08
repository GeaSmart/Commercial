using System;

namespace Entidades
{
	public class ePERFIL {

		private string _PER_codigo = "";
		private string _PER_nombre = "";
		private string _PER_descripcion = "";
		private string _PER_is_admin = "";

		public string PER_codigo {
			get {
				return _PER_codigo;
			}
			set {
				_PER_codigo = value;
			}
		}

		public string PER_nombre {
			get {
				return _PER_nombre;
			}
			set {
				_PER_nombre = value;
			}
		}

		public string PER_descripcion {
			get {
				return _PER_descripcion;
			}
			set {
				_PER_descripcion = value;
			}
		}

		public string PER_is_admin {
			get {
				return _PER_is_admin;
			}
			set {
				_PER_is_admin = value;
			}
		}

		public ePERFIL(){
		}

		public ePERFIL(ref string PER_codigo, string PER_nombre, string PER_descripcion, string PER_is_admin)
		{
			_PER_codigo = PER_codigo;
			_PER_nombre = PER_nombre;
			_PER_descripcion = PER_descripcion;
			_PER_is_admin = PER_is_admin;
		}
	}
}
