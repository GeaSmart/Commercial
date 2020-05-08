using System;

namespace Entidades
{
	public class eNOTA_CREDITO {

		private string _NCR_serie_correlativo = "";
		private int _NCR_numero_registro = 0;
		private DateTime _NCR_fecha_contabilizacion = DateTime.Now;
		private string _TDO_codigo = "";
		private string _SER_serie = "";
		private int _NCR_correlativo = 0;
		private string _VTA_serie_correlativo = "";
		private int _SOC_codigo = 0;
		private string _NCR_soc_nombre_razon = "";
		private double _NCR_subtotal = 0.0;
		private double _NCR_monto_igv = 0.0;
		private double _NCR_monto_isc = 0.0;
		private double _NCR_monto_total = 0.0;
		private string _NCR_monto_total_texto = "";
		private string _NCR_comentario = "";
		private string _NCR_estado = "";
		private int? _MDE_codigo = 0;

		public string NCR_serie_correlativo {
			get {
				return _NCR_serie_correlativo;
			}
			set {
				_NCR_serie_correlativo = value;
			}
		}

		public int NCR_numero_registro {
			get {
				return _NCR_numero_registro;
			}
			set {
				_NCR_numero_registro = value;
			}
		}

		public DateTime NCR_fecha_contabilizacion {
			get {
				return _NCR_fecha_contabilizacion;
			}
			set {
				_NCR_fecha_contabilizacion = value;
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

		public int NCR_correlativo {
			get {
				return _NCR_correlativo;
			}
			set {
				_NCR_correlativo = value;
			}
		}

		public string VTA_serie_correlativo {
			get {
				return _VTA_serie_correlativo;
			}
			set {
				_VTA_serie_correlativo = value;
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

		public string NCR_soc_nombre_razon {
			get {
				return _NCR_soc_nombre_razon;
			}
			set {
				_NCR_soc_nombre_razon = value;
			}
		}

		public double NCR_subtotal {
			get {
				return _NCR_subtotal;
			}
			set {
				_NCR_subtotal = value;
			}
		}

		public double NCR_monto_igv {
			get {
				return _NCR_monto_igv;
			}
			set {
				_NCR_monto_igv = value;
			}
		}

		public double NCR_monto_isc {
			get {
				return _NCR_monto_isc;
			}
			set {
				_NCR_monto_isc = value;
			}
		}

		public double NCR_monto_total {
			get {
				return _NCR_monto_total;
			}
			set {
				_NCR_monto_total = value;
			}
		}

		public string NCR_monto_total_texto {
			get {
				return _NCR_monto_total_texto;
			}
			set {
				_NCR_monto_total_texto = value;
			}
		}

		public string NCR_comentario {
			get {
				return _NCR_comentario;
			}
			set {
				_NCR_comentario = value;
			}
		}

		public string NCR_estado {
			get {
				return _NCR_estado;
			}
			set {
				_NCR_estado = value;
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

		public eNOTA_CREDITO(){
		}

		public eNOTA_CREDITO(ref string NCR_serie_correlativo, int NCR_numero_registro, DateTime NCR_fecha_contabilizacion, string TDO_codigo, string SER_serie, int NCR_correlativo, string VTA_serie_correlativo, int SOC_codigo, string NCR_soc_nombre_razon, double NCR_subtotal, double NCR_monto_igv, double NCR_monto_isc, double NCR_monto_total, string NCR_monto_total_texto, string NCR_comentario, string NCR_estado, int MDE_codigo)
		{
			_NCR_serie_correlativo = NCR_serie_correlativo;
			_NCR_numero_registro = NCR_numero_registro;
			_NCR_fecha_contabilizacion = NCR_fecha_contabilizacion;
			_TDO_codigo = TDO_codigo;
			_SER_serie = SER_serie;
			_NCR_correlativo = NCR_correlativo;
			_VTA_serie_correlativo = VTA_serie_correlativo;
			_SOC_codigo = SOC_codigo;
			_NCR_soc_nombre_razon = NCR_soc_nombre_razon;
			_NCR_subtotal = NCR_subtotal;
			_NCR_monto_igv = NCR_monto_igv;
			_NCR_monto_isc = NCR_monto_isc;
			_NCR_monto_total = NCR_monto_total;
			_NCR_monto_total_texto = NCR_monto_total_texto;
			_NCR_comentario = NCR_comentario;
			_NCR_estado = NCR_estado;
			_MDE_codigo = MDE_codigo;
		}
	}
}
