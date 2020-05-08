using System;

namespace Entidades
{
	public class eCOMPRA {

		private int _COM_numero = 0;
		private DateTime _COM_fecha_documento_origen = DateTime.Now;
		private DateTime _COM_fecha_vencimiento = DateTime.Now;
		private string _COM_documento_origen = "";
		private string _COM_tipo_documento = "";
		private int _SOC_codigo = 0;
		private string _COM_soc_nombre_razon = "";
		private double _COM_subtotal = 0.0;
		private double _COM_porcentaje_percepcion = 0.0;
		private double _COM_monto_igv = 0.0;
		private double _COM_monto_isc = 0.0;
		private double _COM_monto_percepcion = 0.0;
		private double _COM_monto_total = 0.0;
		private string _COM_comentario = "";
		private string _COM_estado = "";

		public int COM_numero {
			get {
				return _COM_numero;
			}
			set {
				_COM_numero = value;
			}
		}

		public DateTime COM_fecha_documento_origen {
			get {
				return _COM_fecha_documento_origen;
			}
			set {
				_COM_fecha_documento_origen = value;
			}
		}

		public DateTime COM_fecha_vencimiento {
			get {
				return _COM_fecha_vencimiento;
			}
			set {
				_COM_fecha_vencimiento = value;
			}
		}

		public string COM_documento_origen {
			get {
				return _COM_documento_origen;
			}
			set {
				_COM_documento_origen = value;
			}
		}

		public string COM_tipo_documento {
			get {
				return _COM_tipo_documento;
			}
			set {
				_COM_tipo_documento = value;
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

		public string COM_soc_nombre_razon {
			get {
				return _COM_soc_nombre_razon;
			}
			set {
				_COM_soc_nombre_razon = value;
			}
		}

		public double COM_subtotal {
			get {
				return _COM_subtotal;
			}
			set {
				_COM_subtotal = value;
			}
		}

		public double COM_porcentaje_percepcion {
			get {
				return _COM_porcentaje_percepcion;
			}
			set {
				_COM_porcentaje_percepcion = value;
			}
		}

		public double COM_monto_igv {
			get {
				return _COM_monto_igv;
			}
			set {
				_COM_monto_igv = value;
			}
		}

		public double COM_monto_isc {
			get {
				return _COM_monto_isc;
			}
			set {
				_COM_monto_isc = value;
			}
		}

		public double COM_monto_percepcion {
			get {
				return _COM_monto_percepcion;
			}
			set {
				_COM_monto_percepcion = value;
			}
		}

		public double COM_monto_total {
			get {
				return _COM_monto_total;
			}
			set {
				_COM_monto_total = value;
			}
		}

		public string COM_comentario {
			get {
				return _COM_comentario;
			}
			set {
				_COM_comentario = value;
			}
		}

		public string COM_estado {
			get {
				return _COM_estado;
			}
			set {
				_COM_estado = value;
			}
		}

		public eCOMPRA(){
		}

		public eCOMPRA(ref int COM_numero, DateTime COM_fecha_documento_origen, DateTime COM_fecha_vencimiento, string COM_documento_origen, string COM_tipo_documento, int SOC_codigo, string COM_soc_nombre_razon, double COM_subtotal, double COM_porcentaje_percepcion, double COM_monto_igv, double COM_monto_isc, double COM_monto_percepcion, double COM_monto_total, string COM_comentario, string COM_estado)
		{
			_COM_numero = COM_numero;
			_COM_fecha_documento_origen = COM_fecha_documento_origen;
			_COM_fecha_vencimiento = COM_fecha_vencimiento;
			_COM_documento_origen = COM_documento_origen;
			_COM_tipo_documento = COM_tipo_documento;
			_SOC_codigo = SOC_codigo;
			_COM_soc_nombre_razon = COM_soc_nombre_razon;
			_COM_subtotal = COM_subtotal;
			_COM_porcentaje_percepcion = COM_porcentaje_percepcion;
			_COM_monto_igv = COM_monto_igv;
			_COM_monto_isc = COM_monto_isc;
			_COM_monto_percepcion = COM_monto_percepcion;
			_COM_monto_total = COM_monto_total;
			_COM_comentario = COM_comentario;
			_COM_estado = COM_estado;
		}
	}
}
