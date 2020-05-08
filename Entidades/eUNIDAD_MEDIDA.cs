using System;

namespace Entidades
{
	public class eUNIDAD_MEDIDA {

		private string _UME_codigo = "";
		private string _UME_descripcion = "";
		private string _UME_descripcion_sunat = "";
		private int _UME_multiplo = 0;

		public string UME_codigo {
			get {
				return _UME_codigo;
			}
			set {
				_UME_codigo = value;
			}
		}

		public string UME_descripcion {
			get {
				return _UME_descripcion;
			}
			set {
				_UME_descripcion = value;
			}
		}

		public string UME_descripcion_sunat {
			get {
				return _UME_descripcion_sunat;
			}
			set {
				_UME_descripcion_sunat = value;
			}
		}

		public int UME_multiplo {
			get {
				return _UME_multiplo;
			}
			set {
				_UME_multiplo = value;
			}
		}

		public eUNIDAD_MEDIDA(){
		}

		public eUNIDAD_MEDIDA(ref string UME_codigo, string UME_descripcion, string UME_descripcion_sunat, int UME_multiplo)
		{
			_UME_codigo = UME_codigo;
			_UME_descripcion = UME_descripcion;
			_UME_descripcion_sunat = UME_descripcion_sunat;
			_UME_multiplo = UME_multiplo;
		}
	}
}
