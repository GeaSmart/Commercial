using System;

namespace Entidades
{
	public class eVISITA {

		private int _ZON_codigo = 0;
		private int _VEN_codigo = 0;
		private string _VIS_dia_semana = "";
		private int _VIS_cantidad_clientes_activos = 0;
		private string _VIS_estado = "";

		public int ZON_codigo {
			get {
				return _ZON_codigo;
			}
			set {
				_ZON_codigo = value;
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

		public string VIS_dia_semana {
			get {
				return _VIS_dia_semana;
			}
			set {
				_VIS_dia_semana = value;
			}
		}

		public int VIS_cantidad_clientes_activos {
			get {
				return _VIS_cantidad_clientes_activos;
			}
			set {
				_VIS_cantidad_clientes_activos = value;
			}
		}

		public string VIS_estado {
			get {
				return _VIS_estado;
			}
			set {
				_VIS_estado = value;
			}
		}

		public eVISITA(){
		}

		public eVISITA(ref int ZON_codigo, int VEN_codigo, string VIS_dia_semana, int VIS_cantidad_clientes_activos, string VIS_estado)
		{
			_ZON_codigo = ZON_codigo;
			_VEN_codigo = VEN_codigo;
			_VIS_dia_semana = VIS_dia_semana;
			_VIS_cantidad_clientes_activos = VIS_cantidad_clientes_activos;
			_VIS_estado = VIS_estado;
		}
	}
}
