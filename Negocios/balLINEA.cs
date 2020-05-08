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
	public partial class balLINEA:AbstractValidator<eLINEA>
	{
		private static dalLINEA _dalLINEA = new dalLINEA();
		private static balLINEA _balLINEA = new balLINEA();

		public static bool insertarRegistro(eLINEA oeLINEA)
		{
			ValidationResult result = _balLINEA.Validate(oeLINEA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalLINEA.obtenerRegistro(oeLINEA).Rows.Count == 0)
				{
					if (_dalLINEA.insertarRegistro(oeLINEA))
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

		public static bool actualizarRegistro(eLINEA oeLINEA)
		{
			ValidationResult result = _balLINEA.Validate(oeLINEA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalLINEA.obtenerRegistro(oeLINEA).Rows.Count > 0)
				{
					if (_dalLINEA.actualizarRegistro(oeLINEA))
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

		public static bool eliminarRegistro(eLINEA oeLINEA)
		{
			bool flag = false;
			
			if ( _dalLINEA.obtenerRegistro(oeLINEA).Rows.Count > 0)
			{
				if (_dalLINEA.eliminarRegistro(oeLINEA))
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

		public static DataTable obtenerRegistro(eLINEA oeLINEA) {
			if ( _dalLINEA.obtenerRegistro(oeLINEA).Rows.Count > 0)
			{
				return _dalLINEA.obtenerRegistro(oeLINEA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalLINEA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalLINEA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalLINEA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalLINEA.poblar().Rows.Count > 0)
			{
				if(_dalLINEA.primerRegistro().Rows.Count > 0)
				{
					return _dalLINEA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalLINEA.poblar().Rows.Count > 0)
			{
				if(_dalLINEA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalLINEA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eLINEA oeLINEA) {
			if(_dalLINEA.poblar().Rows.Count > 0)
			{
				if(_dalLINEA.anteriorRegistro(oeLINEA).Rows.Count > 0)
				{
					return _dalLINEA.anteriorRegistro(oeLINEA);
				}
				else
				{
					return _dalLINEA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eLINEA oeLINEA) {
			if(_dalLINEA.poblar().Rows.Count > 0)
			{
				if(_dalLINEA.siguienteRegistro(oeLINEA).Rows.Count > 0)
				{
					return _dalLINEA.siguienteRegistro(oeLINEA);
				}
				else
				{
					return _dalLINEA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balLINEA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//LIN_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.LIN_codigo)
				.NotEmpty().WithMessage("El campo LIN_codigo es obligatorio.")
				.Length(3).WithMessage("El campo LIN_codigo debe tener 3 caracteres.");
			//LIN_nombre (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.LIN_nombre)
				.NotEmpty().WithMessage("El campo LIN_nombre es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo LIN_nombre no puede tener más de 25 caracteres.");
			//CAT_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.CAT_codigo)
				.NotEmpty().WithMessage("El campo CAT_codigo es obligatorio.")
				.Length(3).WithMessage("El campo CAT_codigo debe tener 3 caracteres.");
		}
	}
}
