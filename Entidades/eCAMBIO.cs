using System;

namespace Entidades
{
	public class eCAMBIO {

		private int _CAM_numero = 0;
		private int _SOC_codigo = 0;
		private string _SOC_nombre_razon = "";
		private int _MDE_codigo = 0;
		private int _VEN_codigo = 0;
		private string _CAM_nombre_vendedor = "";
		private double _CAM_monto_total = 0.0;

		public int CAM_numero {
			get {
				return _CAM_numero;
			}
			set {
				_CAM_numero = value;
			}
		}

		public int SOC_codigo {
			get {
				return _SOC_codigo;
			}
			set {
				_SOC_codigo = value;
			}
		}

		public string SOC_nombre_razon {
			get {
				return _SOC_nombre_razon;
			}
			set {
				_SOC_nombre_razon = value;
			}
		}

		public int MDE_codigo {
			get {
				return _MDE_codigo;
			}
			set {
				_MDE_codigo = value;
			}
		}

		public int VEN_codigo {
			get {
				return _VEN_codigo;
			}
			set {
				_VEN_codigo = value;
			}
		}

		public string CAM_nombre_vendedor {
			get {
				return _CAM_nombre_vendedor;
			}
			set {
				_CAM_nombre_vendedor = value;
			}
		}

		public double CAM_monto_total {
			get {
				return _CAM_monto_total;
			}
			set {
				_CAM_monto_total = value;
			}
		}

		public eCAMBIO(){
		}

		public eCAMBIO(ref int CAM_numero, int SOC_codigo, string SOC_nombre_razon, int MDE_codigo, int VEN_codigo, string CAM_nombre_vendedor, double CAM_monto_total)
		{
			_CAM_numero = CAM_numero;
			_SOC_codigo = SOC_codigo;
			_SOC_nombre_razon = SOC_nombre_razon;
			_MDE_codigo = MDE_codigo;
			_VEN_codigo = VEN_codigo;
			_CAM_nombre_vendedor = CAM_nombre_vendedor;
			_CAM_monto_total = CAM_monto_total;
		}
	}
}
