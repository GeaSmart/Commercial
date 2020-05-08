using System;

namespace Entidades
{
	public class eDETALLE_LISTA_PRECIO {

		private string _LPR_codigo = "";
		private string _PRO_codigo = "";
		private double _DLP_precio = 0.0;

		public string LPR_codigo {
			get {
				return _LPR_codigo;
			}
			set {
				_LPR_codigo = value;
			}
		}

		public string PRO_codigo {
			get {
				return _PRO_codigo;
			}
			set {
				_PRO_codigo = value;
			}
		}

		public double DLP_precio {
			get {
				return _DLP_precio;
			}
			set {
				_DLP_precio = value;
			}
		}

		public eDETALLE_LISTA_PRECIO(){
		}

		public eDETALLE_LISTA_PRECIO(ref string LPR_codigo, string PRO_codigo, double DLP_precio)
		{
			_LPR_codigo = LPR_codigo;
			_PRO_codigo = PRO_codigo;
			_DLP_precio = DLP_precio;
		}
	}
}
