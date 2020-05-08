using System;

namespace Entidades
{
	public class eMETODO_PAGO {

		private string _MPA_codigo = "";
		private string _MPA_nombre = "";
		private string _MPA_is_activo = "";

		public string MPA_codigo {
			get {
				return _MPA_codigo;
			}
			set {
				_MPA_codigo = value;
			}
		}

		public string MPA_nombre {
			get {
				return _MPA_nombre;
			}
			set {
				_MPA_nombre = value;
			}
		}

		public string MPA_is_activo {
			get {
				return _MPA_is_activo;
			}
			set {
				_MPA_is_activo = value;
			}
		}

		public eMETODO_PAGO(){
		}

		public eMETODO_PAGO(ref string MPA_codigo, string MPA_nombre, string MPA_is_activo)
		{
			_MPA_codigo = MPA_codigo;
			_MPA_nombre = MPA_nombre;
			_MPA_is_activo = MPA_is_activo;
		}
	}
}
