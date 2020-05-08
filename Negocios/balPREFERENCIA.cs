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
	public partial class balPREFERENCIA:AbstractValidator<ePREFERENCIA>
	{
		private static dalPREFERENCIA _dalPREFERENCIA = new dalPREFERENCIA();
		private static balPREFERENCIA _balPREFERENCIA = new balPREFERENCIA();

		public static bool insertarRegistro(ePREFERENCIA oePREFERENCIA)
		{
			ValidationResult result = _balPREFERENCIA.Validate(oePREFERENCIA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPREFERENCIA.obtenerRegistro(oePREFERENCIA).Rows.Count == 0)
				{
					if (_dalPREFERENCIA.insertarRegistro(oePREFERENCIA))
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

		public static bool actualizarRegistro(ePREFERENCIA oePREFERENCIA)
		{
			ValidationResult result = _balPREFERENCIA.Validate(oePREFERENCIA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPREFERENCIA.obtenerRegistro(oePREFERENCIA).Rows.Count > 0)
				{
					if (_dalPREFERENCIA.actualizarRegistro(oePREFERENCIA))
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

		public static bool eliminarRegistro(ePREFERENCIA oePREFERENCIA)
		{
			bool flag = false;
			
			if ( _dalPREFERENCIA.obtenerRegistro(oePREFERENCIA).Rows.Count > 0)
			{
				if (_dalPREFERENCIA.eliminarRegistro(oePREFERENCIA))
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

		public static DataTable obtenerRegistro(ePREFERENCIA oePREFERENCIA) {
			if ( _dalPREFERENCIA.obtenerRegistro(oePREFERENCIA).Rows.Count > 0)
			{
				return _dalPREFERENCIA.obtenerRegistro(oePREFERENCIA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPREFERENCIA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPREFERENCIA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPREFERENCIA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPREFERENCIA.poblar().Rows.Count > 0)
			{
				if(_dalPREFERENCIA.primerRegistro().Rows.Count > 0)
				{
					return _dalPREFERENCIA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPREFERENCIA.poblar().Rows.Count > 0)
			{
				if(_dalPREFERENCIA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPREFERENCIA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePREFERENCIA oePREFERENCIA) {
			if(_dalPREFERENCIA.poblar().Rows.Count > 0)
			{
				if(_dalPREFERENCIA.anteriorRegistro(oePREFERENCIA).Rows.Count > 0)
				{
					return _dalPREFERENCIA.anteriorRegistro(oePREFERENCIA);
				}
				else
				{
					return _dalPREFERENCIA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePREFERENCIA oePREFERENCIA) {
			if(_dalPREFERENCIA.poblar().Rows.Count > 0)
			{
				if(_dalPREFERENCIA.siguienteRegistro(oePREFERENCIA).Rows.Count > 0)
				{
					return _dalPREFERENCIA.siguienteRegistro(oePREFERENCIA);
				}
				else
				{
					return _dalPREFERENCIA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPREFERENCIA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PRE_codigo (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.PRE_codigo)
				.NotEmpty().WithMessage("El campo PRE_codigo es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo PRE_codigo no puede tener más de 15 caracteres.");
			//PRE_descripcion (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.PRE_descripcion)
				.NotEmpty().WithMessage("El campo PRE_descripcion es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo PRE_descripcion no puede tener más de 50 caracteres.");
			//PRE_valor (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.PRE_valor)
				.NotEmpty().WithMessage("El campo PRE_valor es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo PRE_valor no puede tener más de 50 caracteres.");
		}
	}
}
