using System;

namespace Entidades
{
	public class eDESCUENTO_P {

		private int _SOC_codigo = 0;
		private string _PRO_codigo = "";
		private double _DSC_porcentaje = 0.0;

		public int SOC_codigo {
			get {
				return _SOC_codigo;
			}
			set {
				_SOC_codigo = value;
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

		public double DSC_porcentaje {
			get {
				return _DSC_porcentaje;
			}
			set {
				_DSC_porcentaje = value;
			}
		}

		public eDESCUENTO_P(){
		}

		public eDESCUENTO_P(ref int SOC_codigo, string PRO_codigo, double DSC_porcentaje)
		{
			_SOC_codigo = SOC_codigo;
			_PRO_codigo = PRO_codigo;
			_DSC_porcentaje = DSC_porcentaje;
		}
	}
}
