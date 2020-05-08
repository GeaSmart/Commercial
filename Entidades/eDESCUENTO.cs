using System;

namespace Entidades
{
	public class eDESCUENTO {

		private string _CAN_codigo = "";
		private string _PRO_codigo = "";
		private string _DSC_is_especial = "";
		private double _DSC_porcentaje = 0.0;
		private double? _DSC_esp_porcentaje = 0.0;
		private DateTime? _DSC_fecha_vencimiento = DateTime.Now;

		public string CAN_codigo {
			get {
				return _CAN_codigo;
			}
			set {
				_CAN_codigo = value;
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

		public string DSC_is_especial {
			get {
				return _DSC_is_especial;
			}
			set {
				_DSC_is_especial = value;
			}
		}

		public double DSC_porcentaje {
			get {
				return _DSC_porcentaje;
			}
			set {
				_DSC_porcentaje = value;
			}
		}

		public double? DSC_esp_porcentaje {
			get {
				return _DSC_esp_porcentaje;
			}
			set {
				_DSC_esp_porcentaje = value;
			}
		}

		public DateTime? DSC_fecha_vencimiento {
			get {
				return _DSC_fecha_vencimiento;
			}
			set {
				_DSC_fecha_vencimiento = value;
			}
		}

		public eDESCUENTO(){
		}

		public eDESCUENTO(ref string CAN_codigo, string PRO_codigo, string DSC_is_especial, double DSC_porcentaje, double DSC_esp_porcentaje, DateTime DSC_fecha_vencimiento)
		{
			_CAN_codigo = CAN_codigo;
			_PRO_codigo = PRO_codigo;
			_DSC_is_especial = DSC_is_especial;
			_DSC_porcentaje = DSC_porcentaje;
			_DSC_esp_porcentaje = DSC_esp_porcentaje;
			_DSC_fecha_vencimiento = DSC_fecha_vencimiento;
		}
	}
}
