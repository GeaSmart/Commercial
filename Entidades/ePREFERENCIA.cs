using System;

namespace Entidades
{
	public class ePREFERENCIA {

		private string _PRE_codigo = "";
		private string _PRE_descripcion = "";
		private string _PRE_valor = "";

		public string PRE_codigo {
			get {
				return _PRE_codigo;
			}
			set {
				_PRE_codigo = value;
			}
		}

		public string PRE_descripcion {
			get {
				return _PRE_descripcion;
			}
			set {
				_PRE_descripcion = value;
			}
		}

		public string PRE_valor {
			get {
				return _PRE_valor;
			}
			set {
				_PRE_valor = value;
			}
		}

		public ePREFERENCIA(){
		}

		public ePREFERENCIA(ref string PRE_codigo, string PRE_descripcion, string PRE_valor)
		{
			_PRE_codigo = PRE_codigo;
			_PRE_descripcion = PRE_descripcion;
			_PRE_valor = PRE_valor;
		}
	}
}
