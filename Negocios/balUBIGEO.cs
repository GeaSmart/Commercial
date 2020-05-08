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
	public partial class balUBIGEO:AbstractValidator<eUBIGEO>
	{
		private static dalUBIGEO _dalUBIGEO = new dalUBIGEO();
		private static balUBIGEO _balUBIGEO = new balUBIGEO();

		public static bool insertarRegistro(eUBIGEO oeUBIGEO)
		{
			ValidationResult result = _balUBIGEO.Validate(oeUBIGEO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalUBIGEO.obtenerRegistro(oeUBIGEO).Rows.Count == 0)
				{
					if (_dalUBIGEO.insertarRegistro(oeUBIGEO))
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

		public static bool actualizarRegistro(eUBIGEO oeUBIGEO)
		{
			ValidationResult result = _balUBIGEO.Validate(oeUBIGEO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalUBIGEO.obtenerRegistro(oeUBIGEO).Rows.Count > 0)
				{
					if (_dalUBIGEO.actualizarRegistro(oeUBIGEO))
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

		public static bool eliminarRegistro(eUBIGEO oeUBIGEO)
		{
			bool flag = false;
			
			if ( _dalUBIGEO.obtenerRegistro(oeUBIGEO).Rows.Count > 0)
			{
				if (_dalUBIGEO.eliminarRegistro(oeUBIGEO))
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

		public static DataTable obtenerRegistro(eUBIGEO oeUBIGEO) {
			if ( _dalUBIGEO.obtenerRegistro(oeUBIGEO).Rows.Count > 0)
			{
				return _dalUBIGEO.obtenerRegistro(oeUBIGEO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalUBIGEO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalUBIGEO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalUBIGEO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalUBIGEO.poblar().Rows.Count > 0)
			{
				if(_dalUBIGEO.primerRegistro().Rows.Count > 0)
				{
					return _dalUBIGEO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalUBIGEO.poblar().Rows.Count > 0)
			{
				if(_dalUBIGEO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalUBIGEO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eUBIGEO oeUBIGEO) {
			if(_dalUBIGEO.poblar().Rows.Count > 0)
			{
				if(_dalUBIGEO.anteriorRegistro(oeUBIGEO).Rows.Count > 0)
				{
					return _dalUBIGEO.anteriorRegistro(oeUBIGEO);
				}
				else
				{
					return _dalUBIGEO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eUBIGEO oeUBIGEO) {
			if(_dalUBIGEO.poblar().Rows.Count > 0)
			{
				if(_dalUBIGEO.siguienteRegistro(oeUBIGEO).Rows.Count > 0)
				{
					return _dalUBIGEO.siguienteRegistro(oeUBIGEO);
				}
				else
				{
					return _dalUBIGEO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balUBIGEO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//UBI_id (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.UBI_id)
				.NotEmpty().WithMessage("El campo UBI_id es obligatorio.")
				.Length(6).WithMessage("El campo UBI_id debe tener 6 caracteres.");
			//UBI_departamento (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.UBI_departamento)
				.NotEmpty().WithMessage("El campo UBI_departamento es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo UBI_departamento no puede tener más de 50 caracteres.");
			//UBI_provincia (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.UBI_provincia)
				.NotEmpty().WithMessage("El campo UBI_provincia es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo UBI_provincia no puede tener más de 50 caracteres.");
			//UBI_distrito (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.UBI_distrito)
				.NotEmpty().WithMessage("El campo UBI_distrito es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo UBI_distrito no puede tener más de 50 caracteres.");
		}
	}
}
