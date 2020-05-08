using System;

namespace Entidades
{
	public class eCANAL {

		private string _CAN_codigo = "";
		private string _CAN_nombre = "";

		public string CAN_codigo {
			get {
				return _CAN_codigo;
			}
			set {
				_CAN_codigo = value;
			}
		}

		public string CAN_nombre {
			get {
				return _CAN_nombre;
			}
			set {
				_CAN_nombre = value;
			}
		}

		public eCANAL(){
		}

		public eCANAL(ref string CAN_codigo, string CAN_nombre)
		{
			_CAN_codigo = CAN_codigo;
			_CAN_nombre = CAN_nombre;
		}
	}
}
