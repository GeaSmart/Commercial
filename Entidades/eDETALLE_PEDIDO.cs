using System;

namespace Entidades
{
	public class eDETALLE_PEDIDO {

		private int _PED_numero = 0;
		private string _PRO_codigo = "";
		private string _DPE_is_bonificacion = "";
		private string _DPE_pro_descripcion = "";
		private int _DPE_pro_ume_multiplo = 0;
		private int _DPE_cantidad = 0;
		private int? _DPE_cantidad_submultiplo = 0;
		private double _DPE_precio_unitario = 0.0;
		private double _DPE_monto_subtotal = 0.0;
		private double _DPE_monto_descuento = 0.0;
		private double _DPE_porcentaje_descuento = 0.0;
		private double _DPE_monto_igv = 0.0;
		private double _DPE_monto_isc = 0.0;
		private double _DPE_porcentaje_igv = 0.0;
		private double _DPE_porcentaje_isc = 0.0;
		private double _DPE_monto_total_linea = 0.0;
		private string _DPE_memo = "";
		private int _DPE_numero_fila = 0;

		public int PED_numero {
			get {
				return _PED_numero;
			}
			set {
				_PED_numero = value;
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

		public string DPE_is_bonificacion {
			get {
				return _DPE_is_bonificacion;
			}
			set {
				_DPE_is_bonificacion = value;
			}
		}

		public string DPE_pro_descripcion {
			get {
				return _DPE_pro_descripcion;
			}
			set {
				_DPE_pro_descripcion = value;
			}
		}

		public int DPE_pro_ume_multiplo {
			get {
				return _DPE_pro_ume_multiplo;
			}
			set {
				_DPE_pro_ume_multiplo = value;
			}
		}

		public int DPE_cantidad {
			get {
				return _DPE_cantidad;
			}
			set {
				_DPE_cantidad = value;
			}
		}

		public int? DPE_cantidad_submultiplo {
			get {
				return _DPE_cantidad_submultiplo;
			}
			set {
				_DPE_cantidad_submultiplo = value;
			}
		}

		public double DPE_precio_unitario {
			get {
				return _DPE_precio_unitario;
			}
			set {
				_DPE_precio_unitario = value;
			}
		}

		public double DPE_monto_subtotal {
			get {
				return _DPE_monto_subtotal;
			}
			set {
				_DPE_monto_subtotal = value;
			}
		}

		public double DPE_monto_descuento {
			get {
				return _DPE_monto_descuento;
			}
			set {
				_DPE_monto_descuento = value;
			}
		}

		public double DPE_porcentaje_descuento {
			get {
				return _DPE_porcentaje_descuento;
			}
			set {
				_DPE_porcentaje_descuento = value;
			}
		}

		public double DPE_monto_igv {
			get {
				return _DPE_monto_igv;
			}
			set {
				_DPE_monto_igv = value;
			}
		}

		public double DPE_monto_isc {
			get {
				return _DPE_monto_isc;
			}
			set {
				_DPE_monto_isc = value;
			}
		}

		public double DPE_porcentaje_igv {
			get {
				return _DPE_porcentaje_igv;
			}
			set {
				_DPE_porcentaje_igv = value;
			}
		}

		public double DPE_porcentaje_isc {
			get {
				return _DPE_porcentaje_isc;
			}
			set {
				_DPE_porcentaje_isc = value;
			}
		}

		public double DPE_monto_total_linea {
			get {
				return _DPE_monto_total_linea;
			}
			set {
				_DPE_monto_total_linea = value;
			}
		}

		public string DPE_memo {
			get {
				return _DPE_memo;
			}
			set {
				_DPE_memo = value;
			}
		}

		public int DPE_numero_fila {
			get {
				return _DPE_numero_fila;
			}
			set {
				_DPE_numero_fila = value;
			}
		}

		public eDETALLE_PEDIDO(){
		}

		public eDETALLE_PEDIDO(ref int PED_numero, string PRO_codigo, string DPE_is_bonificacion, string DPE_pro_descripcion, int DPE_pro_ume_multiplo, int DPE_cantidad, int DPE_cantidad_submultiplo, double DPE_precio_unitario, double DPE_monto_subtotal, double DPE_monto_descuento, double DPE_porcentaje_descuento, double DPE_monto_igv, double DPE_monto_isc, double DPE_porcentaje_igv, double DPE_porcentaje_isc, double DPE_monto_total_linea, string DPE_memo, int DPE_numero_fila)
		{
			_PED_numero = PED_numero;
			_PRO_codigo = PRO_codigo;
			_DPE_is_bonificacion = DPE_is_bonificacion;
			_DPE_pro_descripcion = DPE_pro_descripcion;
			_DPE_pro_ume_multiplo = DPE_pro_ume_multiplo;
			_DPE_cantidad = DPE_cantidad;
			_DPE_cantidad_submultiplo = DPE_cantidad_submultiplo;
			_DPE_precio_unitario = DPE_precio_unitario;
			_DPE_monto_subtotal = DPE_monto_subtotal;
			_DPE_monto_descuento = DPE_monto_descuento;
			_DPE_porcentaje_descuento = DPE_porcentaje_descuento;
			_DPE_monto_igv = DPE_monto_igv;
			_DPE_monto_isc = DPE_monto_isc;
			_DPE_porcentaje_igv = DPE_porcentaje_igv;
			_DPE_porcentaje_isc = DPE_porcentaje_isc;
			_DPE_monto_total_linea = DPE_monto_total_linea;
			_DPE_memo = DPE_memo;
			_DPE_numero_fila = DPE_numero_fila;
		}
	}
}
