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
	public partial class balPERFIL_REGLA:AbstractValidator<ePERFIL_REGLA>
	{
		private static dalPERFIL_REGLA _dalPERFIL_REGLA = new dalPERFIL_REGLA();
		private static balPERFIL_REGLA _balPERFIL_REGLA = new balPERFIL_REGLA();

		public static bool insertarRegistro(ePERFIL_REGLA oePERFIL_REGLA)
		{
			ValidationResult result = _balPERFIL_REGLA.Validate(oePERFIL_REGLA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPERFIL_REGLA.obtenerRegistro(oePERFIL_REGLA).Rows.Count == 0)
				{
					if (_dalPERFIL_REGLA.insertarRegistro(oePERFIL_REGLA))
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

		public static bool actualizarRegistro(ePERFIL_REGLA oePERFIL_REGLA)
		{
			ValidationResult result = _balPERFIL_REGLA.Validate(oePERFIL_REGLA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPERFIL_REGLA.obtenerRegistro(oePERFIL_REGLA).Rows.Count > 0)
				{
					if (_dalPERFIL_REGLA.actualizarRegistro(oePERFIL_REGLA))
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

		public static bool eliminarRegistro(ePERFIL_REGLA oePERFIL_REGLA)
		{
			bool flag = false;
			
			if ( _dalPERFIL_REGLA.obtenerRegistro(oePERFIL_REGLA).Rows.Count > 0)
			{
				if (_dalPERFIL_REGLA.eliminarRegistro(oePERFIL_REGLA))
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

		public static DataTable obtenerRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			if ( _dalPERFIL_REGLA.obtenerRegistro(oePERFIL_REGLA).Rows.Count > 0)
			{
				return _dalPERFIL_REGLA.obtenerRegistro(oePERFIL_REGLA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPERFIL_REGLA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPERFIL_REGLA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPERFIL_REGLA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPERFIL_REGLA.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL_REGLA.primerRegistro().Rows.Count > 0)
				{
					return _dalPERFIL_REGLA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPERFIL_REGLA.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL_REGLA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPERFIL_REGLA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			if(_dalPERFIL_REGLA.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL_REGLA.anteriorRegistro(oePERFIL_REGLA).Rows.Count > 0)
				{
					return _dalPERFIL_REGLA.anteriorRegistro(oePERFIL_REGLA);
				}
				else
				{
					return _dalPERFIL_REGLA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePERFIL_REGLA oePERFIL_REGLA) {
			if(_dalPERFIL_REGLA.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL_REGLA.siguienteRegistro(oePERFIL_REGLA).Rows.Count > 0)
				{
					return _dalPERFIL_REGLA.siguienteRegistro(oePERFIL_REGLA);
				}
				else
				{
					return _dalPERFIL_REGLA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPERFIL_REGLA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PER_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.PER_codigo)
				.NotEmpty().WithMessage("El campo PER_codigo es obligatorio.")
				.Length(3).WithMessage("El campo PER_codigo debe tener 3 caracteres.");
			//REG_codigo (tipo: int)
			RuleFor(x => x.REG_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para REG_codigo");
			//PRE_is_activo (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.PRE_is_activo)
				.NotEmpty().WithMessage("El campo PRE_is_activo es obligatorio.")
				.Length(1).WithMessage("El campo PRE_is_activo debe tener 1 caracteres.");
		}
	}
}
