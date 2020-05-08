using System;

namespace Entidades
{
	public class eTIPO_DOCUMENTO {

		private string _TDO_codigo = "";
		private string _TDO_nombre = "";

		public string TDO_codigo {
			get {
				return _TDO_codigo;
			}
			set {
				_TDO_codigo = value;
			}
		}

		public string TDO_nombre {
			get {
				return _TDO_nombre;
			}
			set {
				_TDO_nombre = value;
			}
		}

		public eTIPO_DOCUMENTO(){
		}

		public eTIPO_DOCUMENTO(ref string TDO_codigo, string TDO_nombre)
		{
			_TDO_codigo = TDO_codigo;
			_TDO_nombre = TDO_nombre;
		}
	}
}
