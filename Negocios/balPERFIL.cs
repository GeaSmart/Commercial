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
	public partial class balPERFIL:AbstractValidator<ePERFIL>
	{
		private static dalPERFIL _dalPERFIL = new dalPERFIL();
		private static balPERFIL _balPERFIL = new balPERFIL();

		public static bool insertarRegistro(ePERFIL oePERFIL)
		{
			ValidationResult result = _balPERFIL.Validate(oePERFIL);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPERFIL.obtenerRegistro(oePERFIL).Rows.Count == 0)
				{
					if (_dalPERFIL.insertarRegistro(oePERFIL))
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

		public static bool actualizarRegistro(ePERFIL oePERFIL)
		{
			ValidationResult result = _balPERFIL.Validate(oePERFIL);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPERFIL.obtenerRegistro(oePERFIL).Rows.Count > 0)
				{
					if (_dalPERFIL.actualizarRegistro(oePERFIL))
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

		public static bool eliminarRegistro(ePERFIL oePERFIL)
		{
			bool flag = false;
			
			if ( _dalPERFIL.obtenerRegistro(oePERFIL).Rows.Count > 0)
			{
				if (_dalPERFIL.eliminarRegistro(oePERFIL))
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

		public static DataTable obtenerRegistro(ePERFIL oePERFIL) {
			if ( _dalPERFIL.obtenerRegistro(oePERFIL).Rows.Count > 0)
			{
				return _dalPERFIL.obtenerRegistro(oePERFIL);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPERFIL.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPERFIL.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPERFIL.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPERFIL.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL.primerRegistro().Rows.Count > 0)
				{
					return _dalPERFIL.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPERFIL.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPERFIL.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePERFIL oePERFIL) {
			if(_dalPERFIL.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL.anteriorRegistro(oePERFIL).Rows.Count > 0)
				{
					return _dalPERFIL.anteriorRegistro(oePERFIL);
				}
				else
				{
					return _dalPERFIL.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePERFIL oePERFIL) {
			if(_dalPERFIL.poblar().Rows.Count > 0)
			{
				if(_dalPERFIL.siguienteRegistro(oePERFIL).Rows.Count > 0)
				{
					return _dalPERFIL.siguienteRegistro(oePERFIL);
				}
				else
				{
					return _dalPERFIL.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPERFIL()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PER_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.PER_codigo)
				.NotEmpty().WithMessage("El campo PER_codigo es obligatorio.")
				.Length(3).WithMessage("El campo PER_codigo debe tener 3 caracteres.");
			//PER_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.PER_nombre)
				.NotEmpty().WithMessage("El campo PER_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo PER_nombre no puede tener más de 50 caracteres.");
			//PER_descripcion (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.PER_descripcion??"")
				.Must(x => x.Length <= 150).WithMessage("El campo PER_descripcion no puede tener más de 150 caracteres.");
			//PER_is_admin (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.PER_is_admin)
				.NotEmpty().WithMessage("El campo PER_is_admin es obligatorio.")
				.Length(1).WithMessage("El campo PER_is_admin debe tener 1 caracteres.");
		}
	}
}
