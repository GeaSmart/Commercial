using System;

namespace Entidades
{
	public class eUSUARIO {

		private string _USU_usuario = "";
		private string _USU_nombre_completo = "";
		private string _USU_dni = "";
		private string _USU_contrasena = "";
		private string _USU_comentario = "";
		private string _PER_codigo = "";

		public string USU_usuario {
			get {
				return _USU_usuario;
			}
			set {
				_USU_usuario = value;
			}
		}

		public string USU_nombre_completo {
			get {
				return _USU_nombre_completo;
			}
			set {
				_USU_nombre_completo = value;
			}
		}

		public string USU_dni {
			get {
				return _USU_dni;
			}
			set {
				_USU_dni = value;
			}
		}

		public string USU_contrasena {
			get {
				return _USU_contrasena;
			}
			set {
				_USU_contrasena = value;
			}
		}

		public string USU_comentario {
			get {
				return _USU_comentario;
			}
			set {
				_USU_comentario = value;
			}
		}

		public string PER_codigo {
			get {
				return _PER_codigo;
			}
			set {
				_PER_codigo = value;
			}
		}

		public eUSUARIO(){
		}

		public eUSUARIO(ref string USU_usuario, string USU_nombre_completo, string USU_dni, string USU_contrasena, string USU_comentario, string PER_codigo)
		{
			_USU_usuario = USU_usuario;
			_USU_nombre_completo = USU_nombre_completo;
			_USU_dni = USU_dni;
			_USU_contrasena = USU_contrasena;
			_USU_comentario = USU_comentario;
			_PER_codigo = PER_codigo;
		}
	}
}
