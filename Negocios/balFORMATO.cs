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
	public partial class balFORMATO:AbstractValidator<eFORMATO>
	{
		private static dalFORMATO _dalFORMATO = new dalFORMATO();
		private static balFORMATO _balFORMATO = new balFORMATO();

		public static bool insertarRegistro(eFORMATO oeFORMATO)
		{
			ValidationResult result = _balFORMATO.Validate(oeFORMATO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalFORMATO.obtenerRegistro(oeFORMATO).Rows.Count == 0)
				{
					if (_dalFORMATO.insertarRegistro(oeFORMATO))
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

		public static bool actualizarRegistro(eFORMATO oeFORMATO)
		{
			ValidationResult result = _balFORMATO.Validate(oeFORMATO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalFORMATO.obtenerRegistro(oeFORMATO).Rows.Count > 0)
				{
					if (_dalFORMATO.actualizarRegistro(oeFORMATO))
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

		public static bool eliminarRegistro(eFORMATO oeFORMATO)
		{
			bool flag = false;
			
			if ( _dalFORMATO.obtenerRegistro(oeFORMATO).Rows.Count > 0)
			{
				if (_dalFORMATO.eliminarRegistro(oeFORMATO))
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

		public static DataTable obtenerRegistro(eFORMATO oeFORMATO) {
			if ( _dalFORMATO.obtenerRegistro(oeFORMATO).Rows.Count > 0)
			{
				return _dalFORMATO.obtenerRegistro(oeFORMATO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalFORMATO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalFORMATO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalFORMATO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalFORMATO.poblar().Rows.Count > 0)
			{
				if(_dalFORMATO.primerRegistro().Rows.Count > 0)
				{
					return _dalFORMATO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalFORMATO.poblar().Rows.Count > 0)
			{
				if(_dalFORMATO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalFORMATO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eFORMATO oeFORMATO) {
			if(_dalFORMATO.poblar().Rows.Count > 0)
			{
				if(_dalFORMATO.anteriorRegistro(oeFORMATO).Rows.Count > 0)
				{
					return _dalFORMATO.anteriorRegistro(oeFORMATO);
				}
				else
				{
					return _dalFORMATO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eFORMATO oeFORMATO) {
			if(_dalFORMATO.poblar().Rows.Count > 0)
			{
				if(_dalFORMATO.siguienteRegistro(oeFORMATO).Rows.Count > 0)
				{
					return _dalFORMATO.siguienteRegistro(oeFORMATO);
				}
				else
				{
					return _dalFORMATO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balFORMATO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//FOR_codigo (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.FOR_codigo)
				.NotEmpty().WithMessage("El campo FOR_codigo es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo FOR_codigo no puede tener más de 15 caracteres.");
			//FOR_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.FOR_nombre)
				.NotEmpty().WithMessage("El campo FOR_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo FOR_nombre no puede tener más de 50 caracteres.");
		}
	}
}
