using System;

namespace Entidades
{
	public class eRUTA {

		private int _RUT_codigo = 0;
		private string _RUT_nombre = "";

		public int RUT_codigo {
			get {
				return _RUT_codigo;
			}
			set {
				_RUT_codigo = value;
			}
		}

		public string RUT_nombre {
			get {
				return _RUT_nombre;
			}
			set {
				_RUT_nombre = value;
			}
		}

		public eRUTA(){
		}

		public eRUTA(ref int RUT_codigo, string RUT_nombre)
		{
			_RUT_codigo = RUT_codigo;
			_RUT_nombre = RUT_nombre;
		}
	}
}
