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
	public partial class balCANAL:AbstractValidator<eCANAL>
	{
		private static dalCANAL _dalCANAL = new dalCANAL();
		private static balCANAL _balCANAL = new balCANAL();

		public static bool insertarRegistro(eCANAL oeCANAL)
		{
			ValidationResult result = _balCANAL.Validate(oeCANAL);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCANAL.obtenerRegistro(oeCANAL).Rows.Count == 0)
				{
					if (_dalCANAL.insertarRegistro(oeCANAL))
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

		public static bool actualizarRegistro(eCANAL oeCANAL)
		{
			ValidationResult result = _balCANAL.Validate(oeCANAL);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCANAL.obtenerRegistro(oeCANAL).Rows.Count > 0)
				{
					if (_dalCANAL.actualizarRegistro(oeCANAL))
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

		public static bool eliminarRegistro(eCANAL oeCANAL)
		{
			bool flag = false;
			
			if ( _dalCANAL.obtenerRegistro(oeCANAL).Rows.Count > 0)
			{
				if (_dalCANAL.eliminarRegistro(oeCANAL))
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

		public static DataTable obtenerRegistro(eCANAL oeCANAL) {
			if ( _dalCANAL.obtenerRegistro(oeCANAL).Rows.Count > 0)
			{
				return _dalCANAL.obtenerRegistro(oeCANAL);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalCANAL.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalCANAL.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalCANAL.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalCANAL.poblar().Rows.Count > 0)
			{
				if(_dalCANAL.primerRegistro().Rows.Count > 0)
				{
					return _dalCANAL.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalCANAL.poblar().Rows.Count > 0)
			{
				if(_dalCANAL.ultimoRegistro().Rows.Count > 0)
				{
					return _dalCANAL.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eCANAL oeCANAL) {
			if(_dalCANAL.poblar().Rows.Count > 0)
			{
				if(_dalCANAL.anteriorRegistro(oeCANAL).Rows.Count > 0)
				{
					return _dalCANAL.anteriorRegistro(oeCANAL);
				}
				else
				{
					return _dalCANAL.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eCANAL oeCANAL) {
			if(_dalCANAL.poblar().Rows.Count > 0)
			{
				if(_dalCANAL.siguienteRegistro(oeCANAL).Rows.Count > 0)
				{
					return _dalCANAL.siguienteRegistro(oeCANAL);
				}
				else
				{
					return _dalCANAL.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balCANAL()
		{
			CascadeMode = CascadeMode.Continue;
			
			//CAN_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.CAN_codigo)
				.NotEmpty().WithMessage("El campo CAN_codigo es obligatorio.")
				.Length(3).WithMessage("El campo CAN_codigo debe tener 3 caracteres.");
			//CAN_nombre (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.CAN_nombre)
				.NotEmpty().WithMessage("El campo CAN_nombre es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo CAN_nombre no puede tener más de 25 caracteres.");
		}
	}
}
