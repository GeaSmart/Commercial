using System;

namespace Entidades
{
	public class eCATEGORIA {

		private string _CAT_codigo = "";
		private string _CAT_nombre = "";
		private string _CAT_comentario = "";

		public string CAT_codigo {
			get {
				return _CAT_codigo;
			}
			set {
				_CAT_codigo = value;
			}
		}

		public string CAT_nombre {
			get {
				return _CAT_nombre;
			}
			set {
				_CAT_nombre = value;
			}
		}

		public string CAT_comentario {
			get {
				return _CAT_comentario;
			}
			set {
				_CAT_comentario = value;
			}
		}

		public eCATEGORIA(){
		}

		public eCATEGORIA(ref string CAT_codigo, string CAT_nombre, string CAT_comentario)
		{
			_CAT_codigo = CAT_codigo;
			_CAT_nombre = CAT_nombre;
			_CAT_comentario = CAT_comentario;
		}
	}
}
