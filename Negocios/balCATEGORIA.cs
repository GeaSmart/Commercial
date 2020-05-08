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
	public partial class balCATEGORIA:AbstractValidator<eCATEGORIA>
	{
		private static dalCATEGORIA _dalCATEGORIA = new dalCATEGORIA();
		private static balCATEGORIA _balCATEGORIA = new balCATEGORIA();

		public static bool insertarRegistro(eCATEGORIA oeCATEGORIA)
		{
			ValidationResult result = _balCATEGORIA.Validate(oeCATEGORIA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCATEGORIA.obtenerRegistro(oeCATEGORIA).Rows.Count == 0)
				{
					if (_dalCATEGORIA.insertarRegistro(oeCATEGORIA))
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

		public static bool actualizarRegistro(eCATEGORIA oeCATEGORIA)
		{
			ValidationResult result = _balCATEGORIA.Validate(oeCATEGORIA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCATEGORIA.obtenerRegistro(oeCATEGORIA).Rows.Count > 0)
				{
					if (_dalCATEGORIA.actualizarRegistro(oeCATEGORIA))
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

		public static bool eliminarRegistro(eCATEGORIA oeCATEGORIA)
		{
			bool flag = false;
			
			if ( _dalCATEGORIA.obtenerRegistro(oeCATEGORIA).Rows.Count > 0)
			{
				if (_dalCATEGORIA.eliminarRegistro(oeCATEGORIA))
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

		public static DataTable obtenerRegistro(eCATEGORIA oeCATEGORIA) {
			if ( _dalCATEGORIA.obtenerRegistro(oeCATEGORIA).Rows.Count > 0)
			{
				return _dalCATEGORIA.obtenerRegistro(oeCATEGORIA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalCATEGORIA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalCATEGORIA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalCATEGORIA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalCATEGORIA.poblar().Rows.Count > 0)
			{
				if(_dalCATEGORIA.primerRegistro().Rows.Count > 0)
				{
					return _dalCATEGORIA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalCATEGORIA.poblar().Rows.Count > 0)
			{
				if(_dalCATEGORIA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalCATEGORIA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eCATEGORIA oeCATEGORIA) {
			if(_dalCATEGORIA.poblar().Rows.Count > 0)
			{
				if(_dalCATEGORIA.anteriorRegistro(oeCATEGORIA).Rows.Count > 0)
				{
					return _dalCATEGORIA.anteriorRegistro(oeCATEGORIA);
				}
				else
				{
					return _dalCATEGORIA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eCATEGORIA oeCATEGORIA) {
			if(_dalCATEGORIA.poblar().Rows.Count > 0)
			{
				if(_dalCATEGORIA.siguienteRegistro(oeCATEGORIA).Rows.Count > 0)
				{
					return _dalCATEGORIA.siguienteRegistro(oeCATEGORIA);
				}
				else
				{
					return _dalCATEGORIA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balCATEGORIA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//CAT_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.CAT_codigo)
				.NotEmpty().WithMessage("El campo CAT_codigo es obligatorio.")
				.Length(3).WithMessage("El campo CAT_codigo debe tener 3 caracteres.");
			//CAT_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.CAT_nombre)
				.NotEmpty().WithMessage("El campo CAT_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo CAT_nombre no puede tener más de 50 caracteres.");
			//CAT_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.CAT_comentario??"")
				.Must(x => x.Length <= 75).WithMessage("El campo CAT_comentario no puede tener más de 75 caracteres.");
		}
	}
}
