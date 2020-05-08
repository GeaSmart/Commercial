using System;

namespace Entidades
{
	public class eSTOCK {

		private string _PRO_codigo = "";
		private string _ALM_codigo = "";
		private double _STO_stock = 0.0;

		public string PRO_codigo {
			get {
				return _PRO_codigo;
			}
			set {
				_PRO_codigo = value;
			}
		}

		public string ALM_codigo {
			get {
				return _ALM_codigo;
			}
			set {
				_ALM_codigo = value;
			}
		}

		public double STO_stock {
			get {
				return _STO_stock;
			}
			set {
				_STO_stock = value;
			}
		}

		public eSTOCK(){
		}

		public eSTOCK(ref string PRO_codigo, string ALM_codigo, double STO_stock)
		{
			_PRO_codigo = PRO_codigo;
			_ALM_codigo = ALM_codigo;
			_STO_stock = STO_stock;
		}
	}
}
