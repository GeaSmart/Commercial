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
	public partial class balSTOCK:AbstractValidator<eSTOCK>
	{
		private static dalSTOCK _dalSTOCK = new dalSTOCK();
		private static balSTOCK _balSTOCK = new balSTOCK();

		public static bool insertarRegistro(eSTOCK oeSTOCK)
		{
			ValidationResult result = _balSTOCK.Validate(oeSTOCK);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalSTOCK.obtenerRegistro(oeSTOCK).Rows.Count == 0)
				{
					if (_dalSTOCK.insertarRegistro(oeSTOCK))
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

		public static bool actualizarRegistro(eSTOCK oeSTOCK)
		{
			ValidationResult result = _balSTOCK.Validate(oeSTOCK);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalSTOCK.obtenerRegistro(oeSTOCK).Rows.Count > 0)
				{
					if (_dalSTOCK.actualizarRegistro(oeSTOCK))
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

		public static bool eliminarRegistro(eSTOCK oeSTOCK)
		{
			bool flag = false;
			
			if ( _dalSTOCK.obtenerRegistro(oeSTOCK).Rows.Count > 0)
			{
				if (_dalSTOCK.eliminarRegistro(oeSTOCK))
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

		public static DataTable obtenerRegistro(eSTOCK oeSTOCK) {
			if ( _dalSTOCK.obtenerRegistro(oeSTOCK).Rows.Count > 0)
			{
				return _dalSTOCK.obtenerRegistro(oeSTOCK);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalSTOCK.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalSTOCK.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalSTOCK.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalSTOCK.poblar().Rows.Count > 0)
			{
				if(_dalSTOCK.primerRegistro().Rows.Count > 0)
				{
					return _dalSTOCK.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalSTOCK.poblar().Rows.Count > 0)
			{
				if(_dalSTOCK.ultimoRegistro().Rows.Count > 0)
				{
					return _dalSTOCK.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eSTOCK oeSTOCK) {
			if(_dalSTOCK.poblar().Rows.Count > 0)
			{
				if(_dalSTOCK.anteriorRegistro(oeSTOCK).Rows.Count > 0)
				{
					return _dalSTOCK.anteriorRegistro(oeSTOCK);
				}
				else
				{
					return _dalSTOCK.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eSTOCK oeSTOCK) {
			if(_dalSTOCK.poblar().Rows.Count > 0)
			{
				if(_dalSTOCK.siguienteRegistro(oeSTOCK).Rows.Count > 0)
				{
					return _dalSTOCK.siguienteRegistro(oeSTOCK);
				}
				else
				{
					return _dalSTOCK.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balSTOCK()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//ALM_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.ALM_codigo)
				.NotEmpty().WithMessage("El campo ALM_codigo es obligatorio.")
				.Length(3).WithMessage("El campo ALM_codigo debe tener 3 caracteres.");
			//STO_stock (tipo: double)
			RuleFor(x => x.STO_stock)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para STO_stock");
		}
	}
}
