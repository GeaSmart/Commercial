using System;

namespace Entidades
{
	public class eTIPO_NEGOCIO {

		private string _TNE_codigo = "";
		private string _TNE_nombre = "";

		public string TNE_codigo {
			get {
				return _TNE_codigo;
			}
			set {
				_TNE_codigo = value;
			}
		}

		public string TNE_nombre {
			get {
				return _TNE_nombre;
			}
			set {
				_TNE_nombre = value;
			}
		}

		public eTIPO_NEGOCIO(){
		}

		public eTIPO_NEGOCIO(ref string TNE_codigo, string TNE_nombre)
		{
			_TNE_codigo = TNE_codigo;
			_TNE_nombre = TNE_nombre;
		}
	}
}
