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
	public partial class balMOTIVO_DEVOLUCION:AbstractValidator<eMOTIVO_DEVOLUCION>
	{
		private static dalMOTIVO_DEVOLUCION _dalMOTIVO_DEVOLUCION = new dalMOTIVO_DEVOLUCION();
		private static balMOTIVO_DEVOLUCION _balMOTIVO_DEVOLUCION = new balMOTIVO_DEVOLUCION();

		public static bool insertarRegistro(eMOTIVO_DEVOLUCION oeMOTIVO_DEVOLUCION)
		{
			ValidationResult result = _balMOTIVO_DEVOLUCION.Validate(oeMOTIVO_DEVOLUCION);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalMOTIVO_DEVOLUCION.obtenerRegistro(oeMOTIVO_DEVOLUCION).Rows.Count == 0)
				{
					if (_dalMOTIVO_DEVOLUCION.insertarRegistro(oeMOTIVO_DEVOLUCION))
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

		public static bool actualizarRegistro(eMOTIVO_DEVOLUCION oeMOTIVO_DEVOLUCION)
		{
			ValidationResult result = _balMOTIVO_DEVOLUCION.Validate(oeMOTIVO_DEVOLUCION);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalMOTIVO_DEVOLUCION.obtenerRegistro(oeMOTIVO_DEVOLUCION).Rows.Count > 0)
				{
					if (_dalMOTIVO_DEVOLUCION.actualizarRegistro(oeMOTIVO_DEVOLUCION))
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

		public static bool eliminarRegistro(eMOTIVO_DEVOLUCION oeMOTIVO_DEVOLUCION)
		{
			bool flag = false;
			
			if ( _dalMOTIVO_DEVOLUCION.obtenerRegistro(oeMOTIVO_DEVOLUCION).Rows.Count > 0)
			{
				if (_dalMOTIVO_DEVOLUCION.eliminarRegistro(oeMOTIVO_DEVOLUCION))
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

		public static DataTable obtenerRegistro(eMOTIVO_DEVOLUCION oeMOTIVO_DEVOLUCION) {
			if ( _dalMOTIVO_DEVOLUCION.obtenerRegistro(oeMOTIVO_DEVOLUCION).Rows.Count > 0)
			{
				return _dalMOTIVO_DEVOLUCION.obtenerRegistro(oeMOTIVO_DEVOLUCION);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalMOTIVO_DEVOLUCION.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalMOTIVO_DEVOLUCION.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalMOTIVO_DEVOLUCION.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalMOTIVO_DEVOLUCION.poblar().Rows.Count > 0)
			{
				if(_dalMOTIVO_DEVOLUCION.primerRegistro().Rows.Count > 0)
				{
					return _dalMOTIVO_DEVOLUCION.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalMOTIVO_DEVOLUCION.poblar().Rows.Count > 0)
			{
				if(_dalMOTIVO_DEVOLUCION.ultimoRegistro().Rows.Count > 0)
				{
					return _dalMOTIVO_DEVOLUCION.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eMOTIVO_DEVOLUCION oeMOTIVO_DEVOLUCION) {
			if(_dalMOTIVO_DEVOLUCION.poblar().Rows.Count > 0)
			{
				if(_dalMOTIVO_DEVOLUCION.anteriorRegistro(oeMOTIVO_DEVOLUCION).Rows.Count > 0)
				{
					return _dalMOTIVO_DEVOLUCION.anteriorRegistro(oeMOTIVO_DEVOLUCION);
				}
				else
				{
					return _dalMOTIVO_DEVOLUCION.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eMOTIVO_DEVOLUCION oeMOTIVO_DEVOLUCION) {
			if(_dalMOTIVO_DEVOLUCION.poblar().Rows.Count > 0)
			{
				if(_dalMOTIVO_DEVOLUCION.siguienteRegistro(oeMOTIVO_DEVOLUCION).Rows.Count > 0)
				{
					return _dalMOTIVO_DEVOLUCION.siguienteRegistro(oeMOTIVO_DEVOLUCION);
				}
				else
				{
					return _dalMOTIVO_DEVOLUCION.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balMOTIVO_DEVOLUCION()
		{
			CascadeMode = CascadeMode.Continue;
			
			//MDE_descripcion (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.MDE_descripcion)
				.NotEmpty().WithMessage("El campo MDE_descripcion es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo MDE_descripcion no puede tener más de 50 caracteres.");
			//MDE_is_activo (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.MDE_is_activo)
				.NotEmpty().WithMessage("El campo MDE_is_activo es obligatorio.")
				.Length(1).WithMessage("El campo MDE_is_activo debe tener 1 caracteres.");
		}
	}
}
