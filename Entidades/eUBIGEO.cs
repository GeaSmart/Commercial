using System;

namespace Entidades
{
	public class eUBIGEO {

		private string _UBI_id = "";
		private string _UBI_departamento = "";
		private string _UBI_provincia = "";
		private string _UBI_distrito = "";

		public string UBI_id {
			get {
				return _UBI_id;
			}
			set {
				_UBI_id = value;
			}
		}

		public string UBI_departamento {
			get {
				return _UBI_departamento;
			}
			set {
				_UBI_departamento = value;
			}
		}

		public string UBI_provincia {
			get {
				return _UBI_provincia;
			}
			set {
				_UBI_provincia = value;
			}
		}

		public string UBI_distrito {
			get {
				return _UBI_distrito;
			}
			set {
				_UBI_distrito = value;
			}
		}

		public eUBIGEO(){
		}

		public eUBIGEO(ref string UBI_id, string UBI_departamento, string UBI_provincia, string UBI_distrito)
		{
			_UBI_id = UBI_id;
			_UBI_departamento = UBI_departamento;
			_UBI_provincia = UBI_provincia;
			_UBI_distrito = UBI_distrito;
		}
	}
}
