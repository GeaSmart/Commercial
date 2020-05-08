using System;

namespace Entidades
{
	public class eLISTA_PRECIO {

		private string _LPR_codigo = "";
		private string _LPR_nombre = "";
		private string _LPR_is_activo = "";
		private string _LPR_anotaciones = "";

		public string LPR_codigo {
			get {
				return _LPR_codigo;
			}
			set {
				_LPR_codigo = value;
			}
		}

		public string LPR_nombre {
			get {
				return _LPR_nombre;
			}
			set {
				_LPR_nombre = value;
			}
		}

		public string LPR_is_activo {
			get {
				return _LPR_is_activo;
			}
			set {
				_LPR_is_activo = value;
			}
		}

		public string LPR_anotaciones {
			get {
				return _LPR_anotaciones;
			}
			set {
				_LPR_anotaciones = value;
			}
		}

		public eLISTA_PRECIO(){
		}

		public eLISTA_PRECIO(ref string LPR_codigo, string LPR_nombre, string LPR_is_activo, string LPR_anotaciones)
		{
			_LPR_codigo = LPR_codigo;
			_LPR_nombre = LPR_nombre;
			_LPR_is_activo = LPR_is_activo;
			_LPR_anotaciones = LPR_anotaciones;
		}
	}
}
