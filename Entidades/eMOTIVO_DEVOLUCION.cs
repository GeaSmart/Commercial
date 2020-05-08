using System;

namespace Entidades
{
	public class eMOTIVO_DEVOLUCION {

		private int _MDE_codigo = 0;
		private string _MDE_descripcion = "";
		private string _MDE_is_activo = "";

		public int MDE_codigo {
			get {
				return _MDE_codigo;
			}
			set {
				_MDE_codigo = value;
			}
		}

		public string MDE_descripcion {
			get {
				return _MDE_descripcion;
			}
			set {
				_MDE_descripcion = value;
			}
		}

		public string MDE_is_activo {
			get {
				return _MDE_is_activo;
			}
			set {
				_MDE_is_activo = value;
			}
		}

		public eMOTIVO_DEVOLUCION(){
		}

		public eMOTIVO_DEVOLUCION(ref int MDE_codigo, string MDE_descripcion, string MDE_is_activo)
		{
			_MDE_codigo = MDE_codigo;
			_MDE_descripcion = MDE_descripcion;
			_MDE_is_activo = MDE_is_activo;
		}
	}
}
