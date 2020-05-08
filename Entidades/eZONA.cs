using System;

namespace Entidades
{
	public class eZONA {

		private int _ZON_codigo = 0;
		private string _ZON_nombre = "";
		private string _ZON_descripcion = "";
		private int? _RUT_codigo = 0;

		public int ZON_codigo {
			get {
				return _ZON_codigo;
			}
			set {
				_ZON_codigo = value;
			}
		}

		public string ZON_nombre {
			get {
				return _ZON_nombre;
			}
			set {
				_ZON_nombre = value;
			}
		}

		public string ZON_descripcion {
			get {
				return _ZON_descripcion;
			}
			set {
				_ZON_descripcion = value;
			}
		}

		public int? RUT_codigo {
			get {
				return _RUT_codigo;
			}
			set {
				_RUT_codigo = value;
			}
		}

		public eZONA(){
		}

		public eZONA(ref int ZON_codigo, string ZON_nombre, string ZON_descripcion, int RUT_codigo)
		{
			_ZON_codigo = ZON_codigo;
			_ZON_nombre = ZON_nombre;
			_ZON_descripcion = ZON_descripcion;
			_RUT_codigo = RUT_codigo;
		}
	}
}
