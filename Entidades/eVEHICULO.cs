using System;

namespace Entidades
{
	public class eVEHICULO {

		private string _VEH_placa = "";
		private string _VEH_nombre = "";
		private double _VEH_tonelaje = 0.0;

		public string VEH_placa {
			get {
				return _VEH_placa;
			}
			set {
				_VEH_placa = value;
			}
		}

		public string VEH_nombre {
			get {
				return _VEH_nombre;
			}
			set {
				_VEH_nombre = value;
			}
		}

		public double VEH_tonelaje {
			get {
				return _VEH_tonelaje;
			}
			set {
				_VEH_tonelaje = value;
			}
		}

		public eVEHICULO(){
		}

		public eVEHICULO(ref string VEH_placa, string VEH_nombre, double VEH_tonelaje)
		{
			_VEH_placa = VEH_placa;
			_VEH_nombre = VEH_nombre;
			_VEH_tonelaje = VEH_tonelaje;
		}
	}
}
