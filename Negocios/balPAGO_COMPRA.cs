using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Results;
using Entidades;
using Datos;

namespace Negocios
{
	public partial class balPAGO_COMPRA:AbstractValidator<ePAGO_COMPRA>
	{
		private static dalPAGO_COMPRA _dalPAGO_COMPRA = new dalPAGO_COMPRA();
		private static balPAGO_COMPRA _balPAGO_COMPRA = new balPAGO_COMPRA();

		public static bool insertarRegistro(ePAGO_COMPRA oePAGO_COMPRA)
		{
			ValidationResult result = _balPAGO_COMPRA.Validate(oePAGO_COMPRA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPAGO_COMPRA.obtenerRegistro(oePAGO_COMPRA).Rows.Count == 0)
				{
					if (_dalPAGO_COMPRA.insertarRegistro(oePAGO_COMPRA))
					{
						flag = true;
					}
					else
					{
						throw new CustomException("El registro no se pudo insertar.");
					}
				}
				else
				{
					throw new CustomException("El registro que desea insertar ya existe.");
				}
			}
			else
			{
				throw new CustomException(CustomException.getMensajeList(result));
			}
			return flag;
		}

		public static bool actualizarRegistro(ePAGO_COMPRA oePAGO_COMPRA)
		{
			ValidationResult result = _balPAGO_COMPRA.Validate(oePAGO_COMPRA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPAGO_COMPRA.obtenerRegistro(oePAGO_COMPRA).Rows.Count > 0)
				{
					if (_dalPAGO_COMPRA.actualizarRegistro(oePAGO_COMPRA))
					{
						flag = true;
					}
					else
					{
						throw new CustomException("El registro no se pudo actualizar.");
					}
				}
				else
				{
					throw new CustomException("El registro que desea actualizar no existe.");
				}
			}
			else
			{
				throw new CustomException(CustomException.getMensajeList(result));
			}
			return flag;
		}

		public static bool eliminarRegistro(ePAGO_COMPRA oePAGO_COMPRA)
		{
			bool flag = false;
			
			if ( _dalPAGO_COMPRA.obtenerRegistro(oePAGO_COMPRA).Rows.Count > 0)
			{
				if (_dalPAGO_COMPRA.eliminarRegistro(oePAGO_COMPRA))
				{
					flag = true;
				}
				else
				{
					throw new CustomException("El registro no se pudo eliminar.");
				}
			}
			else
			{
				throw new CustomException("El registro que desea eliminar no existe.");
			}
			return flag;
		}

		public static DataTable obtenerRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			if ( _dalPAGO_COMPRA.obtenerRegistro(oePAGO_COMPRA).Rows.Count > 0)
			{
				return _dalPAGO_COMPRA.obtenerRegistro(oePAGO_COMPRA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPAGO_COMPRA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPAGO_COMPRA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPAGO_COMPRA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPAGO_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalPAGO_COMPRA.primerRegistro().Rows.Count > 0)
				{
					return _dalPAGO_COMPRA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPAGO_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalPAGO_COMPRA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPAGO_COMPRA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			if(_dalPAGO_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalPAGO_COMPRA.anteriorRegistro(oePAGO_COMPRA).Rows.Count > 0)
				{
					return _dalPAGO_COMPRA.anteriorRegistro(oePAGO_COMPRA);
				}
				else
				{
					return _dalPAGO_COMPRA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePAGO_COMPRA oePAGO_COMPRA) {
			if(_dalPAGO_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalPAGO_COMPRA.siguienteRegistro(oePAGO_COMPRA).Rows.Count > 0)
				{
					return _dalPAGO_COMPRA.siguienteRegistro(oePAGO_COMPRA);
				}
				else
				{
					return _dalPAGO_COMPRA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPAGO_COMPRA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//COM_numero (tipo: int)
			RuleFor(x => x.COM_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_numero");
			//PCO_numero (tipo: int)
			RuleFor(x => x.PCO_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PCO_numero");
			//PCO_monto_total (tipo: double)
			RuleFor(x => x.PCO_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PCO_monto_total");
			//PCO_abono (tipo: double)
			RuleFor(x => x.PCO_abono)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PCO_abono");
			//PCO_referencia (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.PCO_referencia??"")
				.Must(x => x.Length <= 250).WithMessage("El campo PCO_referencia no puede tener más de 250 caracteres.");
		}
	}
}
