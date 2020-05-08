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
	public partial class balUSUARIO:AbstractValidator<eUSUARIO>
	{
		private static dalUSUARIO _dalUSUARIO = new dalUSUARIO();
		private static balUSUARIO _balUSUARIO = new balUSUARIO();

		public static bool insertarRegistro(eUSUARIO oeUSUARIO)
		{
			ValidationResult result = _balUSUARIO.Validate(oeUSUARIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalUSUARIO.obtenerRegistro(oeUSUARIO).Rows.Count == 0)
				{
					if (_dalUSUARIO.insertarRegistro(oeUSUARIO))
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

		public static bool actualizarRegistro(eUSUARIO oeUSUARIO)
		{
			ValidationResult result = _balUSUARIO.Validate(oeUSUARIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalUSUARIO.obtenerRegistro(oeUSUARIO).Rows.Count > 0)
				{
					if (_dalUSUARIO.actualizarRegistro(oeUSUARIO))
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

		public static bool eliminarRegistro(eUSUARIO oeUSUARIO)
		{
			bool flag = false;
			
			if ( _dalUSUARIO.obtenerRegistro(oeUSUARIO).Rows.Count > 0)
			{
				if (_dalUSUARIO.eliminarRegistro(oeUSUARIO))
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

		public static DataTable obtenerRegistro(eUSUARIO oeUSUARIO) {
			if ( _dalUSUARIO.obtenerRegistro(oeUSUARIO).Rows.Count > 0)
			{
				return _dalUSUARIO.obtenerRegistro(oeUSUARIO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalUSUARIO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalUSUARIO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalUSUARIO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalUSUARIO.poblar().Rows.Count > 0)
			{
				if(_dalUSUARIO.primerRegistro().Rows.Count > 0)
				{
					return _dalUSUARIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalUSUARIO.poblar().Rows.Count > 0)
			{
				if(_dalUSUARIO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalUSUARIO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eUSUARIO oeUSUARIO) {
			if(_dalUSUARIO.poblar().Rows.Count > 0)
			{
				if(_dalUSUARIO.anteriorRegistro(oeUSUARIO).Rows.Count > 0)
				{
					return _dalUSUARIO.anteriorRegistro(oeUSUARIO);
				}
				else
				{
					return _dalUSUARIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eUSUARIO oeUSUARIO) {
			if(_dalUSUARIO.poblar().Rows.Count > 0)
			{
				if(_dalUSUARIO.siguienteRegistro(oeUSUARIO).Rows.Count > 0)
				{
					return _dalUSUARIO.siguienteRegistro(oeUSUARIO);
				}
				else
				{
					return _dalUSUARIO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balUSUARIO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//USU_usuario (Tipo C#: string, SQL:varchar(10))
			RuleFor(x => x.USU_usuario)
				.NotEmpty().WithMessage("El campo USU_usuario es obligatorio.")
				.Must(x => x.Length <= 10).WithMessage("El campo USU_usuario no puede tener más de 10 caracteres.");
			//USU_nombre_completo (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.USU_nombre_completo)
				.NotEmpty().WithMessage("El campo USU_nombre_completo es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo USU_nombre_completo no puede tener más de 150 caracteres.");
			//USU_dni (Tipo C#: string, SQL:char(8))
			RuleFor(x => x.USU_dni)
				.NotEmpty().WithMessage("El campo USU_dni es obligatorio.")
				.Length(8).WithMessage("El campo USU_dni debe tener 8 caracteres.");
			//USU_contrasena (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.USU_contrasena)
				.NotEmpty().WithMessage("El campo USU_contrasena es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo USU_contrasena no puede tener más de 15 caracteres.");
			//USU_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.USU_comentario??"")
				.Must(x => x.Length <= 150).WithMessage("El campo USU_comentario no puede tener más de 150 caracteres.");
			//PER_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.PER_codigo)
				.NotEmpty().WithMessage("El campo PER_codigo es obligatorio.")
				.Length(3).WithMessage("El campo PER_codigo debe tener 3 caracteres.");
		}
	}
}
