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
	public partial class balLISTA_PRECIO:AbstractValidator<eLISTA_PRECIO>
	{
		private static dalLISTA_PRECIO _dalLISTA_PRECIO = new dalLISTA_PRECIO();
		private static balLISTA_PRECIO _balLISTA_PRECIO = new balLISTA_PRECIO();

		public static bool insertarRegistro(eLISTA_PRECIO oeLISTA_PRECIO)
		{
			ValidationResult result = _balLISTA_PRECIO.Validate(oeLISTA_PRECIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalLISTA_PRECIO.obtenerRegistro(oeLISTA_PRECIO).Rows.Count == 0)
				{
					if (_dalLISTA_PRECIO.insertarRegistro(oeLISTA_PRECIO))
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

		public static bool actualizarRegistro(eLISTA_PRECIO oeLISTA_PRECIO)
		{
			ValidationResult result = _balLISTA_PRECIO.Validate(oeLISTA_PRECIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalLISTA_PRECIO.obtenerRegistro(oeLISTA_PRECIO).Rows.Count > 0)
				{
					if (_dalLISTA_PRECIO.actualizarRegistro(oeLISTA_PRECIO))
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

		public static bool eliminarRegistro(eLISTA_PRECIO oeLISTA_PRECIO)
		{
			bool flag = false;
			
			if ( _dalLISTA_PRECIO.obtenerRegistro(oeLISTA_PRECIO).Rows.Count > 0)
			{
				if (_dalLISTA_PRECIO.eliminarRegistro(oeLISTA_PRECIO))
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

		public static DataTable obtenerRegistro(eLISTA_PRECIO oeLISTA_PRECIO) {
			if ( _dalLISTA_PRECIO.obtenerRegistro(oeLISTA_PRECIO).Rows.Count > 0)
			{
				return _dalLISTA_PRECIO.obtenerRegistro(oeLISTA_PRECIO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalLISTA_PRECIO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalLISTA_PRECIO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalLISTA_PRECIO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalLISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalLISTA_PRECIO.primerRegistro().Rows.Count > 0)
				{
					return _dalLISTA_PRECIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalLISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalLISTA_PRECIO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalLISTA_PRECIO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eLISTA_PRECIO oeLISTA_PRECIO) {
			if(_dalLISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalLISTA_PRECIO.anteriorRegistro(oeLISTA_PRECIO).Rows.Count > 0)
				{
					return _dalLISTA_PRECIO.anteriorRegistro(oeLISTA_PRECIO);
				}
				else
				{
					return _dalLISTA_PRECIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eLISTA_PRECIO oeLISTA_PRECIO) {
			if(_dalLISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalLISTA_PRECIO.siguienteRegistro(oeLISTA_PRECIO).Rows.Count > 0)
				{
					return _dalLISTA_PRECIO.siguienteRegistro(oeLISTA_PRECIO);
				}
				else
				{
					return _dalLISTA_PRECIO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balLISTA_PRECIO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//LPR_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.LPR_codigo)
				.NotEmpty().WithMessage("El campo LPR_codigo es obligatorio.")
				.Length(3).WithMessage("El campo LPR_codigo debe tener 3 caracteres.");
			//LPR_nombre (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.LPR_nombre)
				.NotEmpty().WithMessage("El campo LPR_nombre es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo LPR_nombre no puede tener más de 25 caracteres.");
			//LPR_is_activo (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.LPR_is_activo)
				.NotEmpty().WithMessage("El campo LPR_is_activo es obligatorio.")
				.Length(1).WithMessage("El campo LPR_is_activo debe tener 1 caracteres.");
			//LPR_anotaciones (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.LPR_anotaciones??"")
				.Must(x => x.Length <= 500).WithMessage("El campo LPR_anotaciones no puede tener más de 500 caracteres.");
		}
	}
}
