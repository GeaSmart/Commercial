using System;

namespace Entidades
{
	public class eCONDICION_PAGO {

		private string _CPA_codigo = "";
		private string _CPA_descripcion = "";
		private int _CPA_dias_limite_pago = 0;

		public string CPA_codigo {
			get {
				return _CPA_codigo;
			}
			set {
				_CPA_codigo = value;
			}
		}

		public string CPA_descripcion {
			get {
				return _CPA_descripcion;
			}
			set {
				_CPA_descripcion = value;
			}
		}

		public int CPA_dias_limite_pago {
			get {
				return _CPA_dias_limite_pago;
			}
			set {
				_CPA_dias_limite_pago = value;
			}
		}

		public eCONDICION_PAGO(){
		}

		public eCONDICION_PAGO(ref string CPA_codigo, string CPA_descripcion, int CPA_dias_limite_pago)
		{
			_CPA_codigo = CPA_codigo;
			_CPA_descripcion = CPA_descripcion;
			_CPA_dias_limite_pago = CPA_dias_limite_pago;
		}
	}
}
