using System;

namespace Entidades
{
	public class eBONIFICACION {

		private string _CAN_codigo = "";
		private string _PRO_codigo = "";
		private string _BON_is_especial = "";
		private int _BON_cantidad_req = 0;
		private int _BON_cantidad_req_submultiplo = 0;
		private int _BON_cantidad_boni = 0;
		private int _BON_cantidad_boni_submultiplo = 0;
		private int _BON_esp_cantidad_boni = 0;
		private int _BON_esp_cantidad_boni_submultiplo = 0;
		private string _BON_producto = "";
		private DateTime? _BON_fecha_vencimiento = DateTime.Now;

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

		public string BON_is_especial {
			get {
				return _BON_is_especial;
			}
			set {
				_BON_is_especial = value;
			}
		}

		public int BON_cantidad_req {
			get {
				return _BON_cantidad_req;
			}
			set {
				_BON_cantidad_req = value;
			}
		}

		public int BON_cantidad_req_submultiplo {
			get {
				return _BON_cantidad_req_submultiplo;
			}
			set {
				_BON_cantidad_req_submultiplo = value;
			}
		}

		public int BON_cantidad_boni {
			get {
				return _BON_cantidad_boni;
			}
			set {
				_BON_cantidad_boni = value;
			}
		}

		public int BON_cantidad_boni_submultiplo {
			get {
				return _BON_cantidad_boni_submultiplo;
			}
			set {
				_BON_cantidad_boni_submultiplo = value;
			}
		}

		public int BON_esp_cantidad_boni {
			get {
				return _BON_esp_cantidad_boni;
			}
			set {
				_BON_esp_cantidad_boni = value;
			}
		}

		public int BON_esp_cantidad_boni_submultiplo {
			get {
				return _BON_esp_cantidad_boni_submultiplo;
			}
			set {
				_BON_esp_cantidad_boni_submultiplo = value;
			}
		}

		public string BON_producto {
			get {
				return _BON_producto;
			}
			set {
				_BON_producto = value;
			}
		}

		public DateTime? BON_fecha_vencimiento {
			get {
				return _BON_fecha_vencimiento;
			}
			set {
				_BON_fecha_vencimiento = value;
			}
		}

		public eBONIFICACION(){
		}

		public eBONIFICACION(ref string CAN_codigo, string PRO_codigo, string BON_is_especial, int BON_cantidad_req, int BON_cantidad_req_submultiplo, int BON_cantidad_boni, int BON_cantidad_boni_submultiplo, int BON_esp_cantidad_boni, int BON_esp_cantidad_boni_submultiplo, string BON_producto, DateTime BON_fecha_vencimiento)
		{
			_CAN_codigo = CAN_codigo;
			_PRO_codigo = PRO_codigo;
			_BON_is_especial = BON_is_especial;
			_BON_cantidad_req = BON_cantidad_req;
			_BON_cantidad_req_submultiplo = BON_cantidad_req_submultiplo;
			_BON_cantidad_boni = BON_cantidad_boni;
			_BON_cantidad_boni_submultiplo = BON_cantidad_boni_submultiplo;
			_BON_esp_cantidad_boni = BON_esp_cantidad_boni;
			_BON_esp_cantidad_boni_submultiplo = BON_esp_cantidad_boni_submultiplo;
			_BON_producto = BON_producto;
			_BON_fecha_vencimiento = BON_fecha_vencimiento;
		}
	}
}
