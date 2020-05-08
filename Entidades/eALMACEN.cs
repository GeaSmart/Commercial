using System;

namespace Entidades
{
	public class eALMACEN {

		private string _ALM_codigo = "";
		private string _ALM_nombre = "";
		private string _ALM_descripcion = "";

		public string ALM_codigo {
			get {
				return _ALM_codigo;
			}
			set {
				_ALM_codigo = value;
			}
		}

		public string ALM_nombre {
			get {
				return _ALM_nombre;
			}
			set {
				_ALM_nombre = value;
			}
		}

		public string ALM_descripcion {
			get {
				return _ALM_descripcion;
			}
			set {
				_ALM_descripcion = value;
			}
		}

		public eALMACEN(){
		}

		public eALMACEN(ref string ALM_codigo, string ALM_nombre, string ALM_descripcion)
		{
			_ALM_codigo = ALM_codigo;
			_ALM_nombre = ALM_nombre;
			_ALM_descripcion = ALM_descripcion;
		}
	}
}
