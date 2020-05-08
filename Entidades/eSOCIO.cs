using System;

namespace Entidades
{
	public class eSOCIO {

		private int _SOC_codigo = 0;
		private string _SOC_tipo_socio = "";
		private string _SOC_nombre_razon_social = "";
		private string _SOC_apellido_paterno = "";
		private string _SOC_apellido_materno = "";
		private string _SOC_nombres = "";
		private string _SOC_numero_documento = "";
		private string _SOC_direccion = "";
		private string _SOC_referencia_direccion = "";
		private string _SOC_telefono_fijo = "";
		private string _SOC_telefono_movil = "";
		private string _SOC_email = "";
		private string _SOC_web = "";
		private string _SOC_is_agente_retencion = "";
		private string _SOC_is_agente_percepcion = "";
		private double? _SOC_porcentaje_percepcion = 0.0;
		private string _SOC_is_validar_bonificacion = "";
		private string _SOC_is_bonificacion_personalizada = "";
		private string _SOC_is_descuento_personalizado = "";
		private string _SOC_is_key_account = "";
		private int _SOC_dias_credito = 0;
		private DateTime _SOC_fecha_registro = DateTime.Now;
		private double _SOC_linea_credito = 0.0;
		private string _SOC_tipo_persona = "";
		private string _SOC_is_activo = "";
		private string _SOC_comentario = "";
		private string _SOC_tipo_documento_identidad = "";
		private double? _SOC_latitud = 0.0;
		private double? _SOC_longitud = 0.0;
		private string _LPR_codigo = "";
		private string _TNE_codigo = "";
		private string _CAN_codigo = "";
		private string _UBI_id = "";
		private int _ZON_codigo = 0;
		private int? _VEN_codigo = 0;
		private string _TDO_codigo = "";
		private string _CPA_codigo = "";

		public int SOC_codigo {
			get {
				return _SOC_codigo;
			}
			set {
				_SOC_codigo = value;
			}
		}

		public string SOC_tipo_socio {
			get {
				return _SOC_tipo_socio;
			}
			set {
				_SOC_tipo_socio = value;
			}
		}

		public string SOC_nombre_razon_social {
			get {
				return _SOC_nombre_razon_social;
			}
			set {
				_SOC_nombre_razon_social = value;
			}
		}

		public string SOC_apellido_paterno {
			get {
				return _SOC_apellido_paterno;
			}
			set {
				_SOC_apellido_paterno = value;
			}
		}

		public string SOC_apellido_materno {
			get {
				return _SOC_apellido_materno;
			}
			set {
				_SOC_apellido_materno = value;
			}
		}

		public string SOC_nombres {
			get {
				return _SOC_nombres;
			}
			set {
				_SOC_nombres = value;
			}
		}

		public string SOC_numero_documento {
			get {
				return _SOC_numero_documento;
			}
			set {
				_SOC_numero_documento = value;
			}
		}

		public string SOC_direccion {
			get {
				return _SOC_direccion;
			}
			set {
				_SOC_direccion = value;
			}
		}

		public string SOC_referencia_direccion {
			get {
				return _SOC_referencia_direccion;
			}
			set {
				_SOC_referencia_direccion = value;
			}
		}

		public string SOC_telefono_fijo {
			get {
				return _SOC_telefono_fijo;
			}
			set {
				_SOC_telefono_fijo = value;
			}
		}

		public string SOC_telefono_movil {
			get {
				return _SOC_telefono_movil;
			}
			set {
				_SOC_telefono_movil = value;
			}
		}

		public string SOC_email {
			get {
				return _SOC_email;
			}
			set {
				_SOC_email = value;
			}
		}

		public string SOC_web {
			get {
				return _SOC_web;
			}
			set {
				_SOC_web = value;
			}
		}

		public string SOC_is_agente_retencion {
			get {
				return _SOC_is_agente_retencion;
			}
			set {
				_SOC_is_agente_retencion = value;
			}
		}

		public string SOC_is_agente_percepcion {
			get {
				return _SOC_is_agente_percepcion;
			}
			set {
				_SOC_is_agente_percepcion = value;
			}
		}

		public double? SOC_porcentaje_percepcion {
			get {
				return _SOC_porcentaje_percepcion;
			}
			set {
				_SOC_porcentaje_percepcion = value;
			}
		}

		public string SOC_is_validar_bonificacion {
			get {
				return _SOC_is_validar_bonificacion;
			}
			set {
				_SOC_is_validar_bonificacion = value;
			}
		}

		public string SOC_is_bonificacion_personalizada {
			get {
				return _SOC_is_bonificacion_personalizada;
			}
			set {
				_SOC_is_bonificacion_personalizada = value;
			}
		}

		public string SOC_is_descuento_personalizado {
			get {
				return _SOC_is_descuento_personalizado;
			}
			set {
				_SOC_is_descuento_personalizado = value;
			}
		}

		public string SOC_is_key_account {
			get {
				return _SOC_is_key_account;
			}
			set {
				_SOC_is_key_account = value;
			}
		}

		public int SOC_dias_credito {
			get {
				return _SOC_dias_credito;
			}
			set {
				_SOC_dias_credito = value;
			}
		}

		public DateTime SOC_fecha_registro {
			get {
				return _SOC_fecha_registro;
			}
			set {
				_SOC_fecha_registro = value;
			}
		}

		public double SOC_linea_credito {
			get {
				return _SOC_linea_credito;
			}
			set {
				_SOC_linea_credito = value;
			}
		}

		public string SOC_tipo_persona {
			get {
				return _SOC_tipo_persona;
			}
			set {
				_SOC_tipo_persona = value;
			}
		}

		public string SOC_is_activo {
			get {
				return _SOC_is_activo;
			}
			set {
				_SOC_is_activo = value;
			}
		}

		public string SOC_comentario {
			get {
				return _SOC_comentario;
			}
			set {
				_SOC_comentario = value;
			}
		}

		public string SOC_tipo_documento_identidad {
			get {
				return _SOC_tipo_documento_identidad;
			}
			set {
				_SOC_tipo_documento_identidad = value;
			}
		}

		public double? SOC_latitud {
			get {
				return _SOC_latitud;
			}
			set {
				_SOC_latitud = value;
			}
		}

		public double? SOC_longitud {
			get {
				return _SOC_longitud;
			}
			set {
				_SOC_longitud = value;
			}
		}

		public string LPR_codigo {
			get {
				return _LPR_codigo;
			}
			set {
				_LPR_codigo = value;
			}
		}

		public string TNE_codigo {
			get {
				return _TNE_codigo;
			}
			set {
				_TNE_codigo = value;
			}
		}

		public string CAN_codigo {
			get {
				return _CAN_codigo;
			}
			set {
				_CAN_codigo = value;
			}
		}

		public string UBI_id {
			get {
				return _UBI_id;
			}
			set {
				_UBI_id = value;
			}
		}

		public int ZON_codigo {
			get {
				return _ZON_codigo;
			}
			set {
				_ZON_codigo = value;
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

		public string TDO_codigo {
			get {
				return _TDO_codigo;
			}
			set {
				_TDO_codigo = value;
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

		public eSOCIO(){
		}

		public eSOCIO(ref int SOC_codigo, string SOC_tipo_socio, string SOC_nombre_razon_social, string SOC_apellido_paterno, string SOC_apellido_materno, string SOC_nombres, string SOC_numero_documento, string SOC_direccion, string SOC_referencia_direccion, string SOC_telefono_fijo, string SOC_telefono_movil, string SOC_email, string SOC_web, string SOC_is_agente_retencion, string SOC_is_agente_percepcion, double SOC_porcentaje_percepcion, string SOC_is_validar_bonificacion, string SOC_is_bonificacion_personalizada, string SOC_is_descuento_personalizado, string SOC_is_key_account, int SOC_dias_credito, DateTime SOC_fecha_registro, double SOC_linea_credito, string SOC_tipo_persona, string SOC_is_activo, string SOC_comentario, string SOC_tipo_documento_identidad, double SOC_latitud, double SOC_longitud, string LPR_codigo, string TNE_codigo, string CAN_codigo, string UBI_id, int ZON_codigo, int VEN_codigo, string TDO_codigo, string CPA_codigo)
		{
			_SOC_codigo = SOC_codigo;
			_SOC_tipo_socio = SOC_tipo_socio;
			_SOC_nombre_razon_social = SOC_nombre_razon_social;
			_SOC_apellido_paterno = SOC_apellido_paterno;
			_SOC_apellido_materno = SOC_apellido_materno;
			_SOC_nombres = SOC_nombres;
			_SOC_numero_documento = SOC_numero_documento;
			_SOC_direccion = SOC_direccion;
			_SOC_referencia_direccion = SOC_referencia_direccion;
			_SOC_telefono_fijo = SOC_telefono_fijo;
			_SOC_telefono_movil = SOC_telefono_movil;
			_SOC_email = SOC_email;
			_SOC_web = SOC_web;
			_SOC_is_agente_retencion = SOC_is_agente_retencion;
			_SOC_is_agente_percepcion = SOC_is_agente_percepcion;
			_SOC_porcentaje_percepcion = SOC_porcentaje_percepcion;
			_SOC_is_validar_bonificacion = SOC_is_validar_bonificacion;
			_SOC_is_bonificacion_personalizada = SOC_is_bonificacion_personalizada;
			_SOC_is_descuento_personalizado = SOC_is_descuento_personalizado;
			_SOC_is_key_account = SOC_is_key_account;
			_SOC_dias_credito = SOC_dias_credito;
			_SOC_fecha_registro = SOC_fecha_registro;
			_SOC_linea_credito = SOC_linea_credito;
			_SOC_tipo_persona = SOC_tipo_persona;
			_SOC_is_activo = SOC_is_activo;
			_SOC_comentario = SOC_comentario;
			_SOC_tipo_documento_identidad = SOC_tipo_documento_identidad;
			_SOC_latitud = SOC_latitud;
			_SOC_longitud = SOC_longitud;
			_LPR_codigo = LPR_codigo;
			_TNE_codigo = TNE_codigo;
			_CAN_codigo = CAN_codigo;
			_UBI_id = UBI_id;
			_ZON_codigo = ZON_codigo;
			_VEN_codigo = VEN_codigo;
			_TDO_codigo = TDO_codigo;
			_CPA_codigo = CPA_codigo;
		}
	}
}
