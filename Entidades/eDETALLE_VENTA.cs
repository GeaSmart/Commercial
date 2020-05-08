using System;

namespace Entidades
{
	public class eDETALLE_VENTA {

		private string _VTA_serie_correlativo = "";
		private string _PRO_codigo = "";
		private string _DVE_is_bonificacion = "";
		private string _DVE_pro_descripcion = "";
		private int _DVE_pro_ume_multiplo = 0;
		private int _DVE_cantidad = 0;
		private int? _DVE_cantidad_submultiplo = 0;
		private double _DVE_precio_unitario = 0.0;
		private double _DVE_monto_subtotal = 0.0;
		private double _DVE_monto_descuento = 0.0;
		private double _DVE_porcentaje_descuento = 0.0;
		private double _DVE_monto_igv = 0.0;
		private double _DVE_monto_isc = 0.0;
		private double _DVE_porcentaje_igv = 0.0;
		private double _DVE_porcentaje_isc = 0.0;
		private double _DVE_monto_total_linea = 0.0;
		private string _DVE_memo = "";
		private int _DVE_numero_fila = 0;

		public string VTA_serie_correlativo {
			get {
				return _VTA_serie_correlativo;
			}
			set {
				_VTA_serie_correlativo = value;
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

		public string DVE_is_bonificacion {
			get {
				return _DVE_is_bonificacion;
			}
			set {
				_DVE_is_bonificacion = value;
			}
		}

		public string DVE_pro_descripcion {
			get {
				return _DVE_pro_descripcion;
			}
			set {
				_DVE_pro_descripcion = value;
			}
		}

		public int DVE_pro_ume_multiplo {
			get {
				return _DVE_pro_ume_multiplo;
			}
			set {
				_DVE_pro_ume_multiplo = value;
			}
		}

		public int DVE_cantidad {
			get {
				return _DVE_cantidad;
			}
			set {
				_DVE_cantidad = value;
			}
		}

		public int? DVE_cantidad_submultiplo {
			get {
				return _DVE_cantidad_submultiplo;
			}
			set {
				_DVE_cantidad_submultiplo = value;
			}
		}

		public double DVE_precio_unitario {
			get {
				return _DVE_precio_unitario;
			}
			set {
				_DVE_precio_unitario = value;
			}
		}

		public double DVE_monto_subtotal {
			get {
				return _DVE_monto_subtotal;
			}
			set {
				_DVE_monto_subtotal = value;
			}
		}

		public double DVE_monto_descuento {
			get {
				return _DVE_monto_descuento;
			}
			set {
				_DVE_monto_descuento = value;
			}
		}

		public double DVE_porcentaje_descuento {
			get {
				return _DVE_porcentaje_descuento;
			}
			set {
				_DVE_porcentaje_descuento = value;
			}
		}

		public double DVE_monto_igv {
			get {
				return _DVE_monto_igv;
			}
			set {
				_DVE_monto_igv = value;
			}
		}

		public double DVE_monto_isc {
			get {
				return _DVE_monto_isc;
			}
			set {
				_DVE_monto_isc = value;
			}
		}

		public double DVE_porcentaje_igv {
			get {
				return _DVE_porcentaje_igv;
			}
			set {
				_DVE_porcentaje_igv = value;
			}
		}

		public double DVE_porcentaje_isc {
			get {
				return _DVE_porcentaje_isc;
			}
			set {
				_DVE_porcentaje_isc = value;
			}
		}

		public double DVE_monto_total_linea {
			get {
				return _DVE_monto_total_linea;
			}
			set {
				_DVE_monto_total_linea = value;
			}
		}

		public string DVE_memo {
			get {
				return _DVE_memo;
			}
			set {
				_DVE_memo = value;
			}
		}

		public int DVE_numero_fila {
			get {
				return _DVE_numero_fila;
			}
			set {
				_DVE_numero_fila = value;
			}
		}

		public eDETALLE_VENTA(){
		}

		public eDETALLE_VENTA(ref string VTA_serie_correlativo, string PRO_codigo, string DVE_is_bonificacion, string DVE_pro_descripcion, int DVE_pro_ume_multiplo, int DVE_cantidad, int DVE_cantidad_submultiplo, double DVE_precio_unitario, double DVE_monto_subtotal, double DVE_monto_descuento, double DVE_porcentaje_descuento, double DVE_monto_igv, double DVE_monto_isc, double DVE_porcentaje_igv, double DVE_porcentaje_isc, double DVE_monto_total_linea, string DVE_memo, int DVE_numero_fila)
		{
			_VTA_serie_correlativo = VTA_serie_correlativo;
			_PRO_codigo = PRO_codigo;
			_DVE_is_bonificacion = DVE_is_bonificacion;
			_DVE_pro_descripcion = DVE_pro_descripcion;
			_DVE_pro_ume_multiplo = DVE_pro_ume_multiplo;
			_DVE_cantidad = DVE_cantidad;
			_DVE_cantidad_submultiplo = DVE_cantidad_submultiplo;
			_DVE_precio_unitario = DVE_precio_unitario;
			_DVE_monto_subtotal = DVE_monto_subtotal;
			_DVE_monto_descuento = DVE_monto_descuento;
			_DVE_porcentaje_descuento = DVE_porcentaje_descuento;
			_DVE_monto_igv = DVE_monto_igv;
			_DVE_monto_isc = DVE_monto_isc;
			_DVE_porcentaje_igv = DVE_porcentaje_igv;
			_DVE_porcentaje_isc = DVE_porcentaje_isc;
			_DVE_monto_total_linea = DVE_monto_total_linea;
			_DVE_memo = DVE_memo;
			_DVE_numero_fila = DVE_numero_fila;
		}
	}
}
