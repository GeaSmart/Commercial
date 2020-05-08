using System;

namespace Entidades
{
	public class ePRODUCTO {

		private string _PRO_codigo = "";
		private string _PRO_descripcion = "";
		private string _FOR_codigo = "";
		private string _PRO_is_igv = "";
		private double _PRO_porcentaje_isc = 0.0;
		private double _PRO_peso_kgr = 0.0;
		private byte[] _PRO_imagen = null;
		private string _PRO_is_activo = "";
		private string _PRO_is_pack = "";
		private string _PRO_codigo_pack = "";
		private string _UME_codigo = "";
		private string _LIN_codigo = "";
		private string _MAR_codigo = "";

		public string PRO_codigo {
			get {
				return _PRO_codigo;
			}
			set {
				_PRO_codigo = value;
			}
		}

		public string PRO_descripcion {
			get {
				return _PRO_descripcion;
			}
			set {
				_PRO_descripcion = value;
			}
		}

		public string FOR_codigo {
			get {
				return _FOR_codigo;
			}
			set {
				_FOR_codigo = value;
			}
		}

		public string PRO_is_igv {
			get {
				return _PRO_is_igv;
			}
			set {
				_PRO_is_igv = value;
			}
		}

		public double PRO_porcentaje_isc {
			get {
				return _PRO_porcentaje_isc;
			}
			set {
				_PRO_porcentaje_isc = value;
			}
		}

		public double PRO_peso_kgr {
			get {
				return _PRO_peso_kgr;
			}
			set {
				_PRO_peso_kgr = value;
			}
		}

		public byte[] PRO_imagen {
			get {
				return _PRO_imagen;
			}
			set {
				_PRO_imagen = value;
			}
		}

		public string PRO_is_activo {
			get {
				return _PRO_is_activo;
			}
			set {
				_PRO_is_activo = value;
			}
		}

		public string PRO_is_pack {
			get {
				return _PRO_is_pack;
			}
			set {
				_PRO_is_pack = value;
			}
		}

		public string PRO_codigo_pack {
			get {
				return _PRO_codigo_pack;
			}
			set {
				_PRO_codigo_pack = value;
			}
		}

		public string UME_codigo {
			get {
				return _UME_codigo;
			}
			set {
				_UME_codigo = value;
			}
		}

		public string LIN_codigo {
			get {
				return _LIN_codigo;
			}
			set {
				_LIN_codigo = value;
			}
		}

		public string MAR_codigo {
			get {
				return _MAR_codigo;
			}
			set {
				_MAR_codigo = value;
			}
		}

		public ePRODUCTO(){
		}

		public ePRODUCTO(ref string PRO_codigo, string PRO_descripcion, string FOR_codigo, string PRO_is_igv, double PRO_porcentaje_isc, double PRO_peso_kgr, byte[] PRO_imagen, string PRO_is_activo, string PRO_is_pack, string PRO_codigo_pack, string UME_codigo, string LIN_codigo, string MAR_codigo)
		{
			_PRO_codigo = PRO_codigo;
			_PRO_descripcion = PRO_descripcion;
			_FOR_codigo = FOR_codigo;
			_PRO_is_igv = PRO_is_igv;
			_PRO_porcentaje_isc = PRO_porcentaje_isc;
			_PRO_peso_kgr = PRO_peso_kgr;
			_PRO_imagen = PRO_imagen;
			_PRO_is_activo = PRO_is_activo;
			_PRO_is_pack = PRO_is_pack;
			_PRO_codigo_pack = PRO_codigo_pack;
			_UME_codigo = UME_codigo;
			_LIN_codigo = LIN_codigo;
			_MAR_codigo = MAR_codigo;
		}
	}
}
