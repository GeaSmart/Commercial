using System;

namespace Entidades
{
	public class ePAGO_COMPRA {

		private int _COM_numero = 0;
		private int _PCO_numero = 0;
		private double _PCO_monto_total = 0.0;
		private double _PCO_abono = 0.0;
		private string _PCO_referencia = "";

		public int COM_numero {
			get {
				return _COM_numero;
			}
			set {
				_COM_numero = value;
			}
		}

		public int PCO_numero {
			get {
				return _PCO_numero;
			}
			set {
				_PCO_numero = value;
			}
		}

		public double PCO_monto_total {
			get {
				return _PCO_monto_total;
			}
			set {
				_PCO_monto_total = value;
			}
		}

		public double PCO_abono {
			get {
				return _PCO_abono;
			}
			set {
				_PCO_abono = value;
			}
		}

		public string PCO_referencia {
			get {
				return _PCO_referencia;
			}
			set {
				_PCO_referencia = value;
			}
		}

		public ePAGO_COMPRA(){
		}

		public ePAGO_COMPRA(ref int COM_numero, int PCO_numero, double PCO_monto_total, double PCO_abono, string PCO_referencia)
		{
			_COM_numero = COM_numero;
			_PCO_numero = PCO_numero;
			_PCO_monto_total = PCO_monto_total;
			_PCO_abono = PCO_abono;
			_PCO_referencia = PCO_referencia;
		}
	}
}
