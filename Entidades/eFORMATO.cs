using System;

namespace Entidades
{
	public class eFORMATO {

		private string _FOR_codigo = "";
		private string _FOR_nombre = "";

		public string FOR_codigo {
			get {
				return _FOR_codigo;
			}
			set {
				_FOR_codigo = value;
			}
		}

		public string FOR_nombre {
			get {
				return _FOR_nombre;
			}
			set {
				_FOR_nombre = value;
			}
		}

		public eFORMATO(){
		}

		public eFORMATO(ref string FOR_codigo, string FOR_nombre)
		{
			_FOR_codigo = FOR_codigo;
			_FOR_nombre = FOR_nombre;
		}
	}
}
