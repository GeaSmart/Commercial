using System;

namespace Entidades
{
	public class eIMPUESTO {

		private string _IMP_codigo = "";
		private string _IMP_nombre = "";
		private string _IMP_nombre_corto = "";

		public string IMP_codigo {
			get {
				return _IMP_codigo;
			}
			set {
				_IMP_codigo = value;
			}
		}

		public string IMP_nombre {
			get {
				return _IMP_nombre;
			}
			set {
				_IMP_nombre = value;
			}
		}

		public string IMP_nombre_corto {
			get {
				return _IMP_nombre_corto;
			}
			set {
				_IMP_nombre_corto = value;
			}
		}

		public eIMPUESTO(){
		}

		public eIMPUESTO(ref string IMP_codigo, string IMP_nombre, string IMP_nombre_corto)
		{
			_IMP_codigo = IMP_codigo;
			_IMP_nombre = IMP_nombre;
			_IMP_nombre_corto = IMP_nombre_corto;
		}
	}
}
