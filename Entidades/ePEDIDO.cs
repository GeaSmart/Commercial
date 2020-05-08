using System;

namespace Entidades
{
	public class ePEDIDO {

		private int _PED_numero = 0;
		private DateTime _PED_fecha = DateTime.Now;
		private DateTime _PED_fecha_entrega = DateTime.Now;
		private int _VEN_codigo = 0;
		private string _PED_nombre_vendedor = "";
		private int _SOC_codigo = 0;
		private string _PED_soc_nombre_razon = "";
		private string _PED_soc_direccion = "";
		private int _PED_soc_zona = 0;
		private double _PED_subtotal = 0.0;
		private double _PED_porcentaje_percepcion = 0.0;
		private double _PED_monto_igv = 0.0;
		private double _PED_monto_isc = 0.0;
		private double _PED_monto_percepcion = 0.0;
		private double _PED_monto_total = 0.0;
		private string _PED_comentario = "";
		private string _PED_estado = "";
		private string _CPA_codigo = "";
		private string _PED_tdo_codigo = "";

		public int PED_numero {
			get {
				return _PED_numero;
			}
			set {
				_PED_numero = value;
			}
		}

		public DateTime PED_fecha {
			get {
				return _PED_fecha;
			}
			set {
				_PED_fecha = value;
			}
		}

		public DateTime PED_fecha_entrega {
			get {
				return _PED_fecha_entrega;
			}
			set {
				_PED_fecha_entrega = value;
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

		public string PED_nombre_vendedor {
			get {
				return _PED_nombre_vendedor;
			}
			set {
				_PED_nombre_vendedor = value;
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

		public string PED_soc_nombre_razon {
			get {
				return _PED_soc_nombre_razon;
			}
			set {
				_PED_soc_nombre_razon = value;
			}
		}

		public string PED_soc_direccion {
			get {
				return _PED_soc_direccion;
			}
			set {
				_PED_soc_direccion = value;
			}
		}

		public int PED_soc_zona {
			get {
				return _PED_soc_zona;
			}
			set {
				_PED_soc_zona = value;
			}
		}

		public double PED_subtotal {
			get {
				return _PED_subtotal;
			}
			set {
				_PED_subtotal = value;
			}
		}

		public double PED_porcentaje_percepcion {
			get {
				return _PED_porcentaje_percepcion;
			}
			set {
				_PED_porcentaje_percepcion = value;
			}
		}

		public double PED_monto_igv {
			get {
				return _PED_monto_igv;
			}
			set {
				_PED_monto_igv = value;
			}
		}

		public double PED_monto_isc {
			get {
				return _PED_monto_isc;
			}
			set {
				_PED_monto_isc = value;
			}
		}

		public double PED_monto_percepcion {
			get {
				return _PED_monto_percepcion;
			}
			set {
				_PED_monto_percepcion = value;
			}
		}

		public double PED_monto_total {
			get {
				return _PED_monto_total;
			}
			set {
				_PED_monto_total = value;
			}
		}

		public string PED_comentario {
			get {
				return _PED_comentario;
			}
			set {
				_PED_comentario = value;
			}
		}

		public string PED_estado {
			get {
				return _PED_estado;
			}
			set {
				_PED_estado = value;
			}
		}

		public string CPA_codigo {
			get {
				return _CPA_codigo;
			}
			set {
				_CPA_codigo = value;
			}
		}

		public string PED_tdo_codigo {
			get {
				return _PED_tdo_codigo;
			}
			set {
				_PED_tdo_codigo = value;
			}
		}

		public ePEDIDO(){
		}

		public ePEDIDO(ref int PED_numero, DateTime PED_fecha, DateTime PED_fecha_entrega, int VEN_codigo, string PED_nombre_vendedor, int SOC_codigo, string PED_soc_nombre_razon, string PED_soc_direccion, int PED_soc_zona, double PED_subtotal, double PED_porcentaje_percepcion, double PED_monto_igv, double PED_monto_isc, double PED_monto_percepcion, double PED_monto_total, string PED_comentario, string PED_estado, string CPA_codigo, string PED_tdo_codigo)
		{
			_PED_numero = PED_numero;
			_PED_fecha = PED_fecha;
			_PED_fecha_entrega = PED_fecha_entrega;
			_VEN_codigo = VEN_codigo;
			_PED_nombre_vendedor = PED_nombre_vendedor;
			_SOC_codigo = SOC_codigo;
			_PED_soc_nombre_razon = PED_soc_nombre_razon;
			_PED_soc_direccion = PED_soc_direccion;
			_PED_soc_zona = PED_soc_zona;
			_PED_subtotal = PED_subtotal;
			_PED_porcentaje_percepcion = PED_porcentaje_percepcion;
			_PED_monto_igv = PED_monto_igv;
			_PED_monto_isc = PED_monto_isc;
			_PED_monto_percepcion = PED_monto_percepcion;
			_PED_monto_total = PED_monto_total;
			_PED_comentario = PED_comentario;
			_PED_estado = PED_estado;
			_CPA_codigo = CPA_codigo;
			_PED_tdo_codigo = PED_tdo_codigo;
		}
	}
}
