using System;

namespace Entidades
{
	public class eVENDEDOR {

		private int _VEN_codigo = 0;
		private string _VEN_nombre_completo = "";
		private string _VEN_dni = "";
		private string _VEN_telefono = "";
		private string _VEN_estado = "";
		private string _VEN_comentario = "";
		private byte[] _VEN_imagen = null;

		public int VEN_codigo {
			get {
				return _VEN_codigo;
			}
			set {
				_VEN_codigo = value;
			}
		}

		public string VEN_nombre_completo {
			get {
				return _VEN_nombre_completo;
			}
			set {
				_VEN_nombre_completo = value;
			}
		}

		public string VEN_dni {
			get {
				return _VEN_dni;
			}
			set {
				_VEN_dni = value;
			}
		}

		public string VEN_telefono {
			get {
				return _VEN_telefono;
			}
			set {
				_VEN_telefono = value;
			}
		}

		public string VEN_estado {
			get {
				return _VEN_estado;
			}
			set {
				_VEN_estado = value;
			}
		}

		public string VEN_comentario {
			get {
				return _VEN_comentario;
			}
			set {
				_VEN_comentario = value;
			}
		}

		public byte[] VEN_imagen {
			get {
				return _VEN_imagen;
			}
			set {
				_VEN_imagen = value;
			}
		}

		public eVENDEDOR(){
		}

		public eVENDEDOR(ref int VEN_codigo, string VEN_nombre_completo, string VEN_dni, string VEN_telefono, string VEN_estado, string VEN_comentario, byte[] VEN_imagen)
		{
			_VEN_codigo = VEN_codigo;
			_VEN_nombre_completo = VEN_nombre_completo;
			_VEN_dni = VEN_dni;
			_VEN_telefono = VEN_telefono;
			_VEN_estado = VEN_estado;
			_VEN_comentario = VEN_comentario;
			_VEN_imagen = VEN_imagen;
		}
	}
}
