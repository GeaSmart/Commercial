using System;

namespace Entidades
{
	public class eREGLA {

		private int _REG_codigo = 0;
		private string _REG_nombre = "";
		private string _REG_descripcion = "";
		private string _REG_tabla = "";

		public int REG_codigo {
			get {
				return _REG_codigo;
			}
			set {
				_REG_codigo = value;
			}
		}

		public string REG_nombre {
			get {
				return _REG_nombre;
			}
			set {
				_REG_nombre = value;
			}
		}

		public string REG_descripcion {
			get {
				return _REG_descripcion;
			}
			set {
				_REG_descripcion = value;
			}
		}

		public string REG_tabla {
			get {
				return _REG_tabla;
			}
			set {
				_REG_tabla = value;
			}
		}

		public eREGLA(){
		}

		public eREGLA(ref int REG_codigo, string REG_nombre, string REG_descripcion, string REG_tabla)
		{
			_REG_codigo = REG_codigo;
			_REG_nombre = REG_nombre;
			_REG_descripcion = REG_descripcion;
			_REG_tabla = REG_tabla;
		}
	}
}
