using System;

namespace Entidades
{
	public class eVENTA {

		private string _VTA_serie_correlativo = "";
		private int _VTA_numero_registro = 0;
		private DateTime _VTA_fecha_contabilizacion = DateTime.Now;
		private DateTime _VTA_fecha_vencimiento = DateTime.Now;
		private string _TDO_codigo = "";
		private string _SER_serie = "";
		private int _VTA_correlativo = 0;
		private int? _CHO_codigo = 0;
		private string _VTA_cho_nombre_completo = "";
		private int? _VEN_codigo = 0;
		private string _VTA_nombre_vendedor = "";
		private string _VTA_is_comisionable = "";
		private string _VTA_is_oficina = "";
		private string _TVE_codigo = "";
		private int _SOC_codigo = 0;
		private string _VTA_soc_nombre_razon = "";
		private string _VTA_soc_direccion = "";
		private int? _VTA_soc_zona = 0;
		private double _VTA_subtotal = 0.0;
		private double _VTA_porcentaje_percepcion = 0.0;
		private double _VTA_monto_igv = 0.0;
		private double _VTA_monto_isc = 0.0;
		private double _VTA_monto_percepcion = 0.0;
		private double _VTA_monto_total = 0.0;
		private string _VTA_monto_total_texto = "";
		private string _VTA_comentario = "";
		private string _VTA_estado = "";
		private string _CPA_codigo = "";
		private int? _PED_numero = 0;
		private int? _MDE_codigo = 0;

		public string VTA_serie_correlativo {
			get {
				return _VTA_serie_correlativo;
			}
			set {
				_VTA_serie_correlativo = value;
			}
		}

		public int VTA_numero_registro {
			get {
				return _VTA_numero_registro;
			}
			set {
				_VTA_numero_registro = value;
			}
		}

		public DateTime VTA_fecha_contabilizacion {
			get {
				return _VTA_fecha_contabilizacion;
			}
			set {
				_VTA_fecha_contabilizacion = value;
			}
		}

		public DateTime VTA_fecha_vencimiento {
			get {
				return _VTA_fecha_vencimiento;
			}
			set {
				_VTA_fecha_vencimiento = value;
			}
		}

		public string TDO_codigo {
			get {
				return _TDO_codigo;
			}
			set {
				_TDO_codigo = value;
			}
		}

		public string SER_serie {
			get {
				return _SER_serie;
			}
			set {
				_SER_serie = value;
			}
		}

		public int VTA_correlativo {
			get {
				return _VTA_correlativo;
			}
			set {
				_VTA_correlativo = value;
			}
		}

		public int? CHO_codigo {
			get {
				return _CHO_codigo;
			}
			set {
				_CHO_codigo = value;
			}
		}

		public string VTA_cho_nombre_completo {
			get {
				return _VTA_cho_nombre_completo;
			}
			set {
				_VTA_cho_nombre_completo = value;
			}
		}

		public int? VEN_codigo {
			get {
				return _VEN_codigo;
			}
			set {
				_VEN_codigo = value;
			}
		}

		public string VTA_nombre_vendedor {
			get {
				return _VTA_nombre_vendedor;
			}
			set {
				_VTA_nombre_vendedor = value;
			}
		}

		public string VTA_is_comisionable {
			get {
				return _VTA_is_comisionable;
			}
			set {
				_VTA_is_comisionable = value;
			}
		}

		public string VTA_is_oficina {
			get {
				return _VTA_is_oficina;
			}
			set {
				_VTA_is_oficina = value;
			}
		}

		public string TVE_codigo {
			get {
				return _TVE_codigo;
			}
			set {
				_TVE_codigo = value;
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

		public string VTA_soc_nombre_razon {
			get {
				return _VTA_soc_nombre_razon;
			}
			set {
				_VTA_soc_nombre_razon = value;
			}
		}

		public string VTA_soc_direccion {
			get {
				return _VTA_soc_direccion;
			}
			set {
				_VTA_soc_direccion = value;
			}
		}

		public int? VTA_soc_zona {
			get {
				return _VTA_soc_zona;
			}
			set {
				_VTA_soc_zona = value;
			}
		}

		public double VTA_subtotal {
			get {
				return _VTA_subtotal;
			}
			set {
				_VTA_subtotal = value;
			}
		}

		public double VTA_porcentaje_percepcion {
			get {
				return _VTA_porcentaje_percepcion;
			}
			set {
				_VTA_porcentaje_percepcion = value;
			}
		}

		public double VTA_monto_igv {
			get {
				return _VTA_monto_igv;
			}
			set {
				_VTA_monto_igv = value;
			}
		}

		public double VTA_monto_isc {
			get {
				return _VTA_monto_isc;
			}
			set {
				_VTA_monto_isc = value;
			}
		}

		public double VTA_monto_percepcion {
			get {
				return _VTA_monto_percepcion;
			}
			set {
				_VTA_monto_percepcion = value;
			}
		}

		public double VTA_monto_total {
			get {
				return _VTA_monto_total;
			}
			set {
				_VTA_monto_total = value;
			}
		}

		public string VTA_monto_total_texto {
			get {
				return _VTA_monto_total_texto;
			}
			set {
				_VTA_monto_total_texto = value;
			}
		}

		public string VTA_comentario {
			get {
				return _VTA_comentario;
			}
			set {
				_VTA_comentario = value;
			}
		}

		public string VTA_estado {
			get {
				return _VTA_estado;
			}
			set {
				_VTA_estado = value;
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

		public int? PED_numero {
			get {
				return _PED_numero;
			}
			set {
				_PED_numero = value;
			}
		}

		public int? MDE_codigo {
			get {
				return _MDE_codigo;
			}
			set {
				_MDE_codigo = value;
			}
		}

		public eVENTA(){
		}

		public eVENTA(ref string VTA_serie_correlativo, int VTA_numero_registro, DateTime VTA_fecha_contabilizacion, DateTime VTA_fecha_vencimiento, string TDO_codigo, string SER_serie, int VTA_correlativo, int CHO_codigo, string VTA_cho_nombre_completo, int VEN_codigo, string VTA_nombre_vendedor, string VTA_is_comisionable, string VTA_is_oficina, string TVE_codigo, int SOC_codigo, string VTA_soc_nombre_razon, string VTA_soc_direccion, int VTA_soc_zona, double VTA_subtotal, double VTA_porcentaje_percepcion, double VTA_monto_igv, double VTA_monto_isc, double VTA_monto_percepcion, double VTA_monto_total, string VTA_monto_total_texto, string VTA_comentario, string VTA_estado, string CPA_codigo, int PED_numero, int MDE_codigo)
		{
			_VTA_serie_correlativo = VTA_serie_correlativo;
			_VTA_numero_registro = VTA_numero_registro;
			_VTA_fecha_contabilizacion = VTA_fecha_contabilizacion;
			_VTA_fecha_vencimiento = VTA_fecha_vencimiento;
			_TDO_codigo = TDO_codigo;
			_SER_serie = SER_serie;
			_VTA_correlativo = VTA_correlativo;
			_CHO_codigo = CHO_codigo;
			_VTA_cho_nombre_completo = VTA_cho_nombre_completo;
			_VEN_codigo = VEN_codigo;
			_VTA_nombre_vendedor = VTA_nombre_vendedor;
			_VTA_is_comisionable = VTA_is_comisionable;
			_VTA_is_oficina = VTA_is_oficina;
			_TVE_codigo = TVE_codigo;
			_SOC_codigo = SOC_codigo;
			_VTA_soc_nombre_razon = VTA_soc_nombre_razon;
			_VTA_soc_direccion = VTA_soc_direccion;
			_VTA_soc_zona = VTA_soc_zona;
			_VTA_subtotal = VTA_subtotal;
			_VTA_porcentaje_percepcion = VTA_porcentaje_percepcion;
			_VTA_monto_igv = VTA_monto_igv;
			_VTA_monto_isc = VTA_monto_isc;
			_VTA_monto_percepcion = VTA_monto_percepcion;
			_VTA_monto_total = VTA_monto_total;
			_VTA_monto_total_texto = VTA_monto_total_texto;
			_VTA_comentario = VTA_comentario;
			_VTA_estado = VTA_estado;
			_CPA_codigo = CPA_codigo;
			_PED_numero = PED_numero;
			_MDE_codigo = MDE_codigo;
		}
	}
}
