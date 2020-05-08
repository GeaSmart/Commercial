using System;

namespace Entidades
{
	public class ePERFIL_REGLA {

		private string _PER_codigo = "";
		private int _REG_codigo = 0;
		private string _PRE_is_activo = "";

		public string PER_codigo {
			get {
				return _PER_codigo;
			}
			set {
				_PER_codigo = value;
			}
		}

		public int REG_codigo {
			get {
				return _REG_codigo;
			}
			set {
				_REG_codigo = value;
			}
		}

		public string PRE_is_activo {
			get {
				return _PRE_is_activo;
			}
			set {
				_PRE_is_activo = value;
			}
		}

		public ePERFIL_REGLA(){
		}

		public ePERFIL_REGLA(ref string PER_codigo, int REG_codigo, string PRE_is_activo)
		{
			_PER_codigo = PER_codigo;
			_REG_codigo = REG_codigo;
			_PRE_is_activo = PRE_is_activo;
		}
	}
}
