using System;

namespace Entidades
{
	public class eTIPO_VENTA {

		private string _TVE_codigo = "";
		private string _TVE_descripcion = "";

		public string TVE_codigo {
			get {
				return _TVE_codigo;
			}
			set {
				_TVE_codigo = value;
			}
		}

		public string TVE_descripcion {
			get {
				return _TVE_descripcion;
			}
			set {
				_TVE_descripcion = value;
			}
		}

		public eTIPO_VENTA(){
		}

		public eTIPO_VENTA(ref string TVE_codigo, string TVE_descripcion)
		{
			_TVE_codigo = TVE_codigo;
			_TVE_descripcion = TVE_descripcion;
		}
	}
}
