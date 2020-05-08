using System;

namespace Entidades
{
	public class eSERIE {

		private string _SER_serie = "";
		private string _TDO_codigo = "";
		private int _SER_correlativo_actual = 0;
		private int _SER_correlativo_desde = 0;
		private int _SER_correlativo_hasta = 0;

		public string SER_serie {
			get {
				return _SER_serie;
			}
			set {
				_SER_serie = value;
			}
		}

		public string TDO_codigo {
			get {
				return _TDO_codigo;
			}
			set {
				_TDO_codigo = value;
			}
		}

		public int SER_correlativo_actual {
			get {
				return _SER_correlativo_actual;
			}
			set {
				_SER_correlativo_actual = value;
			}
		}

		public int SER_correlativo_desde {
			get {
				return _SER_correlativo_desde;
			}
			set {
				_SER_correlativo_desde = value;
			}
		}

		public int SER_correlativo_hasta {
			get {
				return _SER_correlativo_hasta;
			}
			set {
				_SER_correlativo_hasta = value;
			}
		}

		public eSERIE(){
		}

		public eSERIE(ref string SER_serie, string TDO_codigo, int SER_correlativo_actual, int SER_correlativo_desde, int SER_correlativo_hasta)
		{
			_SER_serie = SER_serie;
			_TDO_codigo = TDO_codigo;
			_SER_correlativo_actual = SER_correlativo_actual;
			_SER_correlativo_desde = SER_correlativo_desde;
			_SER_correlativo_hasta = SER_correlativo_hasta;
		}
	}
}
