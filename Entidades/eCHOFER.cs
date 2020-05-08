using System;

namespace Entidades
{
	public class eCHOFER {

		private int _CHO_codigo = 0;
		private string _CHO_nombre_completo = "";
		private string _CHO_dni = "";
		private string _VEH_placa = "";
		private string _CHO_licencia_conducir = "";

		public int CHO_codigo {
			get {
				return _CHO_codigo;
			}
			set {
				_CHO_codigo = value;
			}
		}

		public string CHO_nombre_completo {
			get {
				return _CHO_nombre_completo;
			}
			set {
				_CHO_nombre_completo = value;
			}
		}

		public string CHO_dni {
			get {
				return _CHO_dni;
			}
			set {
				_CHO_dni = value;
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

		public string CHO_licencia_conducir {
			get {
				return _CHO_licencia_conducir;
			}
			set {
				_CHO_licencia_conducir = value;
			}
		}

		public eCHOFER(){
		}

		public eCHOFER(ref int CHO_codigo, string CHO_nombre_completo, string CHO_dni, string VEH_placa, string CHO_licencia_conducir)
		{
			_CHO_codigo = CHO_codigo;
			_CHO_nombre_completo = CHO_nombre_completo;
			_CHO_dni = CHO_dni;
			_VEH_placa = VEH_placa;
			_CHO_licencia_conducir = CHO_licencia_conducir;
		}
	}
}
