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
	public partial class balALMACEN:AbstractValidator<eALMACEN>
	{
		private static dalALMACEN _dalALMACEN = new dalALMACEN();
		private static balALMACEN _balALMACEN = new balALMACEN();

		public static bool insertarRegistro(eALMACEN oeALMACEN)
		{
			ValidationResult result = _balALMACEN.Validate(oeALMACEN);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalALMACEN.obtenerRegistro(oeALMACEN).Rows.Count == 0)
				{
					if (_dalALMACEN.insertarRegistro(oeALMACEN))
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

		public static bool actualizarRegistro(eALMACEN oeALMACEN)
		{
			ValidationResult result = _balALMACEN.Validate(oeALMACEN);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalALMACEN.obtenerRegistro(oeALMACEN).Rows.Count > 0)
				{
					if (_dalALMACEN.actualizarRegistro(oeALMACEN))
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

		public static bool eliminarRegistro(eALMACEN oeALMACEN)
		{
			bool flag = false;
			
			if ( _dalALMACEN.obtenerRegistro(oeALMACEN).Rows.Count > 0)
			{
				if (_dalALMACEN.eliminarRegistro(oeALMACEN))
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

		public static DataTable obtenerRegistro(eALMACEN oeALMACEN) {
			if ( _dalALMACEN.obtenerRegistro(oeALMACEN).Rows.Count > 0)
			{
				return _dalALMACEN.obtenerRegistro(oeALMACEN);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalALMACEN.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalALMACEN.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalALMACEN.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalALMACEN.poblar().Rows.Count > 0)
			{
				if(_dalALMACEN.primerRegistro().Rows.Count > 0)
				{
					return _dalALMACEN.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalALMACEN.poblar().Rows.Count > 0)
			{
				if(_dalALMACEN.ultimoRegistro().Rows.Count > 0)
				{
					return _dalALMACEN.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eALMACEN oeALMACEN) {
			if(_dalALMACEN.poblar().Rows.Count > 0)
			{
				if(_dalALMACEN.anteriorRegistro(oeALMACEN).Rows.Count > 0)
				{
					return _dalALMACEN.anteriorRegistro(oeALMACEN);
				}
				else
				{
					return _dalALMACEN.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eALMACEN oeALMACEN) {
			if(_dalALMACEN.poblar().Rows.Count > 0)
			{
				if(_dalALMACEN.siguienteRegistro(oeALMACEN).Rows.Count > 0)
				{
					return _dalALMACEN.siguienteRegistro(oeALMACEN);
				}
				else
				{
					return _dalALMACEN.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balALMACEN()
		{
			CascadeMode = CascadeMode.Continue;
			
			//ALM_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.ALM_codigo)
				.NotEmpty().WithMessage("El campo ALM_codigo es obligatorio.")
				.Length(3).WithMessage("El campo ALM_codigo debe tener 3 caracteres.");
			//ALM_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.ALM_nombre)
				.NotEmpty().WithMessage("El campo ALM_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo ALM_nombre no puede tener más de 50 caracteres.");
			//ALM_descripcion (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.ALM_descripcion??"")
				.Must(x => x.Length <= 150).WithMessage("El campo ALM_descripcion no puede tener más de 150 caracteres.");
		}
	}
}
