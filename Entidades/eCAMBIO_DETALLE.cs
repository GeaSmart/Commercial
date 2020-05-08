using System;

namespace Entidades
{
	public class eCAMBIO_DETALLE {

		private int _CAM_numero = 0;
		private string _PRO_codigo = "";
		private int _DCA_cantidad = 0;
		private int _DCA_cantidad_submultiplo = 0;
		private double _DCA_precio_unitario = 0.0;
		private double _DCA_monto_subtotal = 0.0;
		private double _DCA_monto_igv = 0.0;
		private double _DCA_monto_isc = 0.0;
		private double _DCA_monto_total = 0.0;

		public int CAM_numero {
			get {
				return _CAM_numero;
			}
			set {
				_CAM_numero = value;
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

		public int DCA_cantidad {
			get {
				return _DCA_cantidad;
			}
			set {
				_DCA_cantidad = value;
			}
		}

		public int DCA_cantidad_submultiplo {
			get {
				return _DCA_cantidad_submultiplo;
			}
			set {
				_DCA_cantidad_submultiplo = value;
			}
		}

		public double DCA_precio_unitario {
			get {
				return _DCA_precio_unitario;
			}
			set {
				_DCA_precio_unitario = value;
			}
		}

		public double DCA_monto_subtotal {
			get {
				return _DCA_monto_subtotal;
			}
			set {
				_DCA_monto_subtotal = value;
			}
		}

		public double DCA_monto_igv {
			get {
				return _DCA_monto_igv;
			}
			set {
				_DCA_monto_igv = value;
			}
		}

		public double DCA_monto_isc {
			get {
				return _DCA_monto_isc;
			}
			set {
				_DCA_monto_isc = value;
			}
		}

		public double DCA_monto_total {
			get {
				return _DCA_monto_total;
			}
			set {
				_DCA_monto_total = value;
			}
		}

		public eCAMBIO_DETALLE(){
		}

		public eCAMBIO_DETALLE(ref int CAM_numero, string PRO_codigo, int DCA_cantidad, int DCA_cantidad_submultiplo, double DCA_precio_unitario, double DCA_monto_subtotal, double DCA_monto_igv, double DCA_monto_isc, double DCA_monto_total)
		{
			_CAM_numero = CAM_numero;
			_PRO_codigo = PRO_codigo;
			_DCA_cantidad = DCA_cantidad;
			_DCA_cantidad_submultiplo = DCA_cantidad_submultiplo;
			_DCA_precio_unitario = DCA_precio_unitario;
			_DCA_monto_subtotal = DCA_monto_subtotal;
			_DCA_monto_igv = DCA_monto_igv;
			_DCA_monto_isc = DCA_monto_isc;
			_DCA_monto_total = DCA_monto_total;
		}
	}
}
