using System;

namespace Entidades
{
	public class eDETALLE_COMPRA {

		private int _COM_numero = 0;
		private string _PRO_codigo = "";
		private string _DCO_is_bonificacion = "";
		private string _DCO_pro_descripcion = "";
		private int _DCO_pro_ume_multiplo = 0;
		private int _DCO_cantidad = 0;
		private int? _DCO_cantidad_submultiplo = 0;
		private double _DCO_precio_unitario = 0.0;
		private double _DCO_monto_subtotal = 0.0;
		private double _DCO_monto_descuento = 0.0;
		private double _DCO_porcentaje_descuento = 0.0;
		private double _DCO_monto_igv = 0.0;
		private double _DCO_monto_isc = 0.0;
		private double _DCO_porcentaje_igv = 0.0;
		private double _DCO_porcentaje_isc = 0.0;
		private double _DCO_monto_total_linea = 0.0;
		private string _DCO_memo = "";
		private int _DCO_numero_fila = 0;
		private DateTime _DCO_fecha_produccion = DateTime.Now;
		private DateTime _DCO_fecha_vencimiento = DateTime.Now;

		public int COM_numero {
			get {
				return _COM_numero;
			}
			set {
				_COM_numero = value;
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

		public string DCO_is_bonificacion {
			get {
				return _DCO_is_bonificacion;
			}
			set {
				_DCO_is_bonificacion = value;
			}
		}

		public string DCO_pro_descripcion {
			get {
				return _DCO_pro_descripcion;
			}
			set {
				_DCO_pro_descripcion = value;
			}
		}

		public int DCO_pro_ume_multiplo {
			get {
				return _DCO_pro_ume_multiplo;
			}
			set {
				_DCO_pro_ume_multiplo = value;
			}
		}

		public int DCO_cantidad {
			get {
				return _DCO_cantidad;
			}
			set {
				_DCO_cantidad = value;
			}
		}

		public int? DCO_cantidad_submultiplo {
			get {
				return _DCO_cantidad_submultiplo;
			}
			set {
				_DCO_cantidad_submultiplo = value;
			}
		}

		public double DCO_precio_unitario {
			get {
				return _DCO_precio_unitario;
			}
			set {
				_DCO_precio_unitario = value;
			}
		}

		public double DCO_monto_subtotal {
			get {
				return _DCO_monto_subtotal;
			}
			set {
				_DCO_monto_subtotal = value;
			}
		}

		public double DCO_monto_descuento {
			get {
				return _DCO_monto_descuento;
			}
			set {
				_DCO_monto_descuento = value;
			}
		}

		public double DCO_porcentaje_descuento {
			get {
				return _DCO_porcentaje_descuento;
			}
			set {
				_DCO_porcentaje_descuento = value;
			}
		}

		public double DCO_monto_igv {
			get {
				return _DCO_monto_igv;
			}
			set {
				_DCO_monto_igv = value;
			}
		}

		public double DCO_monto_isc {
			get {
				return _DCO_monto_isc;
			}
			set {
				_DCO_monto_isc = value;
			}
		}

		public double DCO_porcentaje_igv {
			get {
				return _DCO_porcentaje_igv;
			}
			set {
				_DCO_porcentaje_igv = value;
			}
		}

		public double DCO_porcentaje_isc {
			get {
				return _DCO_porcentaje_isc;
			}
			set {
				_DCO_porcentaje_isc = value;
			}
		}

		public double DCO_monto_total_linea {
			get {
				return _DCO_monto_total_linea;
			}
			set {
				_DCO_monto_total_linea = value;
			}
		}

		public string DCO_memo {
			get {
				return _DCO_memo;
			}
			set {
				_DCO_memo = value;
			}
		}

		public int DCO_numero_fila {
			get {
				return _DCO_numero_fila;
			}
			set {
				_DCO_numero_fila = value;
			}
		}

		public DateTime DCO_fecha_produccion {
			get {
				return _DCO_fecha_produccion;
			}
			set {
				_DCO_fecha_produccion = value;
			}
		}

		public DateTime DCO_fecha_vencimiento {
			get {
				return _DCO_fecha_vencimiento;
			}
			set {
				_DCO_fecha_vencimiento = value;
			}
		}

		public eDETALLE_COMPRA(){
		}

		public eDETALLE_COMPRA(ref int COM_numero, string PRO_codigo, string DCO_is_bonificacion, string DCO_pro_descripcion, int DCO_pro_ume_multiplo, int DCO_cantidad, int DCO_cantidad_submultiplo, double DCO_precio_unitario, double DCO_monto_subtotal, double DCO_monto_descuento, double DCO_porcentaje_descuento, double DCO_monto_igv, double DCO_monto_isc, double DCO_porcentaje_igv, double DCO_porcentaje_isc, double DCO_monto_total_linea, string DCO_memo, int DCO_numero_fila, DateTime DCO_fecha_produccion, DateTime DCO_fecha_vencimiento)
		{
			_COM_numero = COM_numero;
			_PRO_codigo = PRO_codigo;
			_DCO_is_bonificacion = DCO_is_bonificacion;
			_DCO_pro_descripcion = DCO_pro_descripcion;
			_DCO_pro_ume_multiplo = DCO_pro_ume_multiplo;
			_DCO_cantidad = DCO_cantidad;
			_DCO_cantidad_submultiplo = DCO_cantidad_submultiplo;
			_DCO_precio_unitario = DCO_precio_unitario;
			_DCO_monto_subtotal = DCO_monto_subtotal;
			_DCO_monto_descuento = DCO_monto_descuento;
			_DCO_porcentaje_descuento = DCO_porcentaje_descuento;
			_DCO_monto_igv = DCO_monto_igv;
			_DCO_monto_isc = DCO_monto_isc;
			_DCO_porcentaje_igv = DCO_porcentaje_igv;
			_DCO_porcentaje_isc = DCO_porcentaje_isc;
			_DCO_monto_total_linea = DCO_monto_total_linea;
			_DCO_memo = DCO_memo;
			_DCO_numero_fila = DCO_numero_fila;
			_DCO_fecha_produccion = DCO_fecha_produccion;
			_DCO_fecha_vencimiento = DCO_fecha_vencimiento;
		}
	}
}
