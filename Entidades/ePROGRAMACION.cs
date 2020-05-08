using System;

namespace Entidades
{
	public class ePROGRAMACION {

		private DateTime _PRG_fecha = DateTime.Now;
		private string _PRG_comentario = "";
		private DateTime _PRG_ultima_mod = DateTime.Now;
		private string _PRG_estado = "";

		public DateTime PRG_fecha {
			get {
				return _PRG_fecha;
			}
			set {
				_PRG_fecha = value;
			}
		}

		public string PRG_comentario {
			get {
				return _PRG_comentario;
			}
			set {
				_PRG_comentario = value;
			}
		}

		public DateTime PRG_ultima_mod {
			get {
				return _PRG_ultima_mod;
			}
			set {
				_PRG_ultima_mod = value;
			}
		}

		public string PRG_estado {
			get {
				return _PRG_estado;
			}
			set {
				_PRG_estado = value;
			}
		}

		public ePROGRAMACION(){
		}

		public ePROGRAMACION(ref DateTime PRG_fecha, string PRG_comentario, DateTime PRG_ultima_mod, string PRG_estado)
		{
			_PRG_fecha = PRG_fecha;
			_PRG_comentario = PRG_comentario;
			_PRG_ultima_mod = PRG_ultima_mod;
			_PRG_estado = PRG_estado;
		}
	}
}
