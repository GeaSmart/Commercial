using System;

namespace Entidades
{
	public class eDETALLE_PROG {

		private DateTime _PRG_fecha = DateTime.Now;
		private int _CHO_codigo = 0;
		private int _DPR_numero_viaje = 0;
		private int _DPR_zona_desde = 0;
		private int _DPR_zona_hasta = 0;
		private double _DPR_peso = 0.0;
		private int _DPR_numero_documentos = 0;
		private double _DPR_cantidad_producto = 0.0;
		private string _VEH_placa = "";

		public DateTime PRG_fecha {
			get {
				return _PRG_fecha;
			}
			set {
				_PRG_fecha = value;
			}
		}

		public int CHO_codigo {
			get {
				return _CHO_codigo;
			}
			set {
				_CHO_codigo = value;
			}
		}

		public int DPR_numero_viaje {
			get {
				return _DPR_numero_viaje;
			}
			set {
				_DPR_numero_viaje = value;
			}
		}

		public int DPR_zona_desde {
			get {
				return _DPR_zona_desde;
			}
			set {
				_DPR_zona_desde = value;
			}
		}

		public int DPR_zona_hasta {
			get {
				return _DPR_zona_hasta;
			}
			set {
				_DPR_zona_hasta = value;
			}
		}

		public double DPR_peso {
			get {
				return _DPR_peso;
			}
			set {
				_DPR_peso = value;
			}
		}

		public int DPR_numero_documentos {
			get {
				return _DPR_numero_documentos;
			}
			set {
				_DPR_numero_documentos = value;
			}
		}

		public double DPR_cantidad_producto {
			get {
				return _DPR_cantidad_producto;
			}
			set {
				_DPR_cantidad_producto = value;
			}
		}

		public string VEH_placa {
			get {
				return _VEH_placa;
			}
			set {
				_VEH_placa = value;
			}
		}

		public eDETALLE_PROG(){
		}

		public eDETALLE_PROG(ref DateTime PRG_fecha, int CHO_codigo, int DPR_numero_viaje, int DPR_zona_desde, int DPR_zona_hasta, double DPR_peso, int DPR_numero_documentos, double DPR_cantidad_producto, string VEH_placa)
		{
			_PRG_fecha = PRG_fecha;
			_CHO_codigo = CHO_codigo;
			_DPR_numero_viaje = DPR_numero_viaje;
			_DPR_zona_desde = DPR_zona_desde;
			_DPR_zona_hasta = DPR_zona_hasta;
			_DPR_peso = DPR_peso;
			_DPR_numero_documentos = DPR_numero_documentos;
			_DPR_cantidad_producto = DPR_cantidad_producto;
			_VEH_placa = VEH_placa;
		}
	}
}
