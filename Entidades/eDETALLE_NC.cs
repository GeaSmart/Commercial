using System;

namespace Entidades
{
	public class eDETALLE_NC {

		private string _NCR_serie_correlativo = "";
		private string _PRO_codigo = "";
		private string _DNC_pro_descripcion = "";
		private int _DNC_pro_ume_multiplo = 0;
		private int _DNC_cantidad = 0;
		private int? _DNC_cantidad_submultiplo = 0;
		private double _DNC_precio_unitario = 0.0;
		private double _DNC_monto_subtotal = 0.0;
		private double _DNC_monto_descuento = 0.0;
		private double _DNC_porcentaje_descuento = 0.0;
		private double _DNC_monto_igv = 0.0;
		private double _DNC_monto_isc = 0.0;
		private double _DNC_porcentaje_igv = 0.0;
		private double _DNC_porcentaje_isc = 0.0;
		private double _DNC_monto_total_linea = 0.0;
		private string _DNC_memo = "";
		private int _DNC_numero_fila = 0;

		public string NCR_serie_correlativo {
			get {
				return _NCR_serie_correlativo;
			}
			set {
				_NCR_serie_correlativo = value;
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

		public string DNC_pro_descripcion {
			get {
				return _DNC_pro_descripcion;
			}
			set {
				_DNC_pro_descripcion = value;
			}
		}

		public int DNC_pro_ume_multiplo {
			get {
				return _DNC_pro_ume_multiplo;
			}
			set {
				_DNC_pro_ume_multiplo = value;
			}
		}

		public int DNC_cantidad {
			get {
				return _DNC_cantidad;
			}
			set {
				_DNC_cantidad = value;
			}
		}

		public int? DNC_cantidad_submultiplo {
			get {
				return _DNC_cantidad_submultiplo;
			}
			set {
				_DNC_cantidad_submultiplo = value;
			}
		}

		public double DNC_precio_unitario {
			get {
				return _DNC_precio_unitario;
			}
			set {
				_DNC_precio_unitario = value;
			}
		}

		public double DNC_monto_subtotal {
			get {
				return _DNC_monto_subtotal;
			}
			set {
				_DNC_monto_subtotal = value;
			}
		}

		public double DNC_monto_descuento {
			get {
				return _DNC_monto_descuento;
			}
			set {
				_DNC_monto_descuento = value;
			}
		}

		public double DNC_porcentaje_descuento {
			get {
				return _DNC_porcentaje_descuento;
			}
			set {
				_DNC_porcentaje_descuento = value;
			}
		}

		public double DNC_monto_igv {
			get {
				return _DNC_monto_igv;
			}
			set {
				_DNC_monto_igv = value;
			}
		}

		public double DNC_monto_isc {
			get {
				return _DNC_monto_isc;
			}
			set {
				_DNC_monto_isc = value;
			}
		}

		public double DNC_porcentaje_igv {
			get {
				return _DNC_porcentaje_igv;
			}
			set {
				_DNC_porcentaje_igv = value;
			}
		}

		public double DNC_porcentaje_isc {
			get {
				return _DNC_porcentaje_isc;
			}
			set {
				_DNC_porcentaje_isc = value;
			}
		}

		public double DNC_monto_total_linea {
			get {
				return _DNC_monto_total_linea;
			}
			set {
				_DNC_monto_total_linea = value;
			}
		}

		public string DNC_memo {
			get {
				return _DNC_memo;
			}
			set {
				_DNC_memo = value;
			}
		}

		public int DNC_numero_fila {
			get {
				return _DNC_numero_fila;
			}
			set {
				_DNC_numero_fila = value;
			}
		}

		public eDETALLE_NC(){
		}

		public eDETALLE_NC(ref string NCR_serie_correlativo, string PRO_codigo, string DNC_pro_descripcion, int DNC_pro_ume_multiplo, int DNC_cantidad, int DNC_cantidad_submultiplo, double DNC_precio_unitario, double DNC_monto_subtotal, double DNC_monto_descuento, double DNC_porcentaje_descuento, double DNC_monto_igv, double DNC_monto_isc, double DNC_porcentaje_igv, double DNC_porcentaje_isc, double DNC_monto_total_linea, string DNC_memo, int DNC_numero_fila)
		{
			_NCR_serie_correlativo = NCR_serie_correlativo;
			_PRO_codigo = PRO_codigo;
			_DNC_pro_descripcion = DNC_pro_descripcion;
			_DNC_pro_ume_multiplo = DNC_pro_ume_multiplo;
			_DNC_cantidad = DNC_cantidad;
			_DNC_cantidad_submultiplo = DNC_cantidad_submultiplo;
			_DNC_precio_unitario = DNC_precio_unitario;
			_DNC_monto_subtotal = DNC_monto_subtotal;
			_DNC_monto_descuento = DNC_monto_descuento;
			_DNC_porcentaje_descuento = DNC_porcentaje_descuento;
			_DNC_monto_igv = DNC_monto_igv;
			_DNC_monto_isc = DNC_monto_isc;
			_DNC_porcentaje_igv = DNC_porcentaje_igv;
			_DNC_porcentaje_isc = DNC_porcentaje_isc;
			_DNC_monto_total_linea = DNC_monto_total_linea;
			_DNC_memo = DNC_memo;
			_DNC_numero_fila = DNC_numero_fila;
		}
	}
}
