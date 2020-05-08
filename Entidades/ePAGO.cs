using System;

namespace Entidades
{
	public class ePAGO {

		private string _VTA_serie_correlativo = "";
		private int _PAG_numero = 0;
		private double _PAG_monto_total = 0.0;
		private double _PAG_abono = 0.0;
		private string _PAG_referencia = "";
		private string _MPA_codigo = "";

		public string VTA_serie_correlativo {
			get {
				return _VTA_serie_correlativo;
			}
			set {
				_VTA_serie_correlativo = value;
			}
		}

		public int PAG_numero {
			get {
				return _PAG_numero;
			}
			set {
				_PAG_numero = value;
			}
		}

		public double PAG_monto_total {
			get {
				return _PAG_monto_total;
			}
			set {
				_PAG_monto_total = value;
			}
		}

		public double PAG_abono {
			get {
				return _PAG_abono;
			}
			set {
				_PAG_abono = value;
			}
		}

		public string PAG_referencia {
			get {
				return _PAG_referencia;
			}
			set {
				_PAG_referencia = value;
			}
		}

		public string MPA_codigo {
			get {
				return _MPA_codigo;
			}
			set {
				_MPA_codigo = value;
			}
		}

		public ePAGO(){
		}

		public ePAGO(ref string VTA_serie_correlativo, int PAG_numero, double PAG_monto_total, double PAG_abono, string PAG_referencia, string MPA_codigo)
		{
			_VTA_serie_correlativo = VTA_serie_correlativo;
			_PAG_numero = PAG_numero;
			_PAG_monto_total = PAG_monto_total;
			_PAG_abono = PAG_abono;
			_PAG_referencia = PAG_referencia;
			_MPA_codigo = MPA_codigo;
		}
	}
}
