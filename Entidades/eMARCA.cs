using System;

namespace Entidades
{
	public class eMARCA {

		private string _MAR_codigo = "";
		private string _MAR_nombre = "";

		public string MAR_codigo {
			get {
				return _MAR_codigo;
			}
			set {
				_MAR_codigo = value;
			}
		}

		public string MAR_nombre {
			get {
				return _MAR_nombre;
			}
			set {
				_MAR_nombre = value;
			}
		}

		public eMARCA(){
		}

		public eMARCA(ref string MAR_codigo, string MAR_nombre)
		{
			_MAR_codigo = MAR_codigo;
			_MAR_nombre = MAR_nombre;
		}
	}
}
