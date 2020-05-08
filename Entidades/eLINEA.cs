using System;

namespace Entidades
{
	public class eLINEA {

		private string _LIN_codigo = "";
		private string _LIN_nombre = "";
		private string _CAT_codigo = "";

		public string LIN_codigo {
			get {
				return _LIN_codigo;
			}
			set {
				_LIN_codigo = value;
			}
		}

		public string LIN_nombre {
			get {
				return _LIN_nombre;
			}
			set {
				_LIN_nombre = value;
			}
		}

		public string CAT_codigo {
			get {
				return _CAT_codigo;
			}
			set {
				_CAT_codigo = value;
			}
		}

		public eLINEA(){
		}

		public eLINEA(ref string LIN_codigo, string LIN_nombre, string CAT_codigo)
		{
			_LIN_codigo = LIN_codigo;
			_LIN_nombre = LIN_nombre;
			_CAT_codigo = CAT_codigo;
		}
	}
}
