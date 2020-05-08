using System;

namespace Entidades
{
	public class eDETALLE_IMPUESTO {

		private string _IMP_codigo = "";
		private int _DIM_numero = 0;
		private double _DIM_porcentaje = 0.0;

		public string IMP_codigo {
			get {
				return _IMP_codigo;
			}
			set {
				_IMP_codigo = value;
			}
		}

		public int DIM_numero {
			get {
				return _DIM_numero;
			}
			set {
				_DIM_numero = value;
			}
		}

		public double DIM_porcentaje {
			get {
				return _DIM_porcentaje;
			}
			set {
				_DIM_porcentaje = value;
			}
		}

		public eDETALLE_IMPUESTO(){
		}

		public eDETALLE_IMPUESTO(ref string IMP_codigo, int DIM_numero, double DIM_porcentaje)
		{
			_IMP_codigo = IMP_codigo;
			_DIM_numero = DIM_numero;
			_DIM_porcentaje = DIM_porcentaje;
		}
	}
}
