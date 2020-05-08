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
	public partial class balAUDITORIA:AbstractValidator<eAUDITORIA>
	{
		private static dalAUDITORIA _dalAUDITORIA = new dalAUDITORIA();
		private static balAUDITORIA _balAUDITORIA = new balAUDITORIA();

		public static bool insertarRegistro(eAUDITORIA oeAUDITORIA)
		{
			ValidationResult result = _balAUDITORIA.Validate(oeAUDITORIA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalAUDITORIA.obtenerRegistro(oeAUDITORIA).Rows.Count == 0)
				{
					if (_dalAUDITORIA.insertarRegistro(oeAUDITORIA))
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

		public static bool actualizarRegistro(eAUDITORIA oeAUDITORIA)
		{
			ValidationResult result = _balAUDITORIA.Validate(oeAUDITORIA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalAUDITORIA.obtenerRegistro(oeAUDITORIA).Rows.Count > 0)
				{
					if (_dalAUDITORIA.actualizarRegistro(oeAUDITORIA))
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

		public static bool eliminarRegistro(eAUDITORIA oeAUDITORIA)
		{
			bool flag = false;
			
			if ( _dalAUDITORIA.obtenerRegistro(oeAUDITORIA).Rows.Count > 0)
			{
				if (_dalAUDITORIA.eliminarRegistro(oeAUDITORIA))
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

		public static DataTable obtenerRegistro(eAUDITORIA oeAUDITORIA) {
			if ( _dalAUDITORIA.obtenerRegistro(oeAUDITORIA).Rows.Count > 0)
			{
				return _dalAUDITORIA.obtenerRegistro(oeAUDITORIA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalAUDITORIA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalAUDITORIA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalAUDITORIA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalAUDITORIA.poblar().Rows.Count > 0)
			{
				if(_dalAUDITORIA.primerRegistro().Rows.Count > 0)
				{
					return _dalAUDITORIA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalAUDITORIA.poblar().Rows.Count > 0)
			{
				if(_dalAUDITORIA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalAUDITORIA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eAUDITORIA oeAUDITORIA) {
			if(_dalAUDITORIA.poblar().Rows.Count > 0)
			{
				if(_dalAUDITORIA.anteriorRegistro(oeAUDITORIA).Rows.Count > 0)
				{
					return _dalAUDITORIA.anteriorRegistro(oeAUDITORIA);
				}
				else
				{
					return _dalAUDITORIA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eAUDITORIA oeAUDITORIA) {
			if(_dalAUDITORIA.poblar().Rows.Count > 0)
			{
				if(_dalAUDITORIA.siguienteRegistro(oeAUDITORIA).Rows.Count > 0)
				{
					return _dalAUDITORIA.siguienteRegistro(oeAUDITORIA);
				}
				else
				{
					return _dalAUDITORIA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balAUDITORIA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//Type (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.Type)
				.NotEmpty().WithMessage("El campo Type es obligatorio.")
				.Length(1).WithMessage("El campo Type debe tener 1 caracteres.");
			//TableName (Tipo C#: string, SQL:varchar(128))
			RuleFor(x => x.TableName)
				.NotEmpty().WithMessage("El campo TableName es obligatorio.")
				.Must(x => x.Length <= 128).WithMessage("El campo TableName no puede tener más de 128 caracteres.");
			//PrimaryKeyField (Tipo C#: string, SQL:varchar(1000))
			RuleFor(x => x.PrimaryKeyField)
				.NotEmpty().WithMessage("El campo PrimaryKeyField es obligatorio.")
				.Must(x => x.Length <= 1000).WithMessage("El campo PrimaryKeyField no puede tener más de 1000 caracteres.");
			//PrimaryKeyValue (Tipo C#: string, SQL:varchar(1000))
			RuleFor(x => x.PrimaryKeyValue)
				.NotEmpty().WithMessage("El campo PrimaryKeyValue es obligatorio.")
				.Must(x => x.Length <= 1000).WithMessage("El campo PrimaryKeyValue no puede tener más de 1000 caracteres.");
			//FieldName (Tipo C#: string, SQL:varchar(128))
			RuleFor(x => x.FieldName)
				.NotEmpty().WithMessage("El campo FieldName es obligatorio.")
				.Must(x => x.Length <= 128).WithMessage("El campo FieldName no puede tener más de 128 caracteres.");
			//OldValue (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.OldValue??"")
				.Must(x => x.Length <= 1000).WithMessage("El campo OldValue no puede tener más de 1000 caracteres.");
			//NewValue (Tipo C#: string, SQL:varchar(1000))
			RuleFor(x => x.NewValue)
				.NotEmpty().WithMessage("El campo NewValue es obligatorio.")
				.Must(x => x.Length <= 1000).WithMessage("El campo NewValue no puede tener más de 1000 caracteres.");
			//UpdateDate (tipo: DateTime)
			//Agregar aquí la validación para UpdateDate si se desea.
			
			//UsuarioApp (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.UsuarioApp)
				.NotEmpty().WithMessage("El campo UsuarioApp es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo UsuarioApp no puede tener más de 50 caracteres.");
			//Servidor (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.Servidor)
				.NotEmpty().WithMessage("El campo Servidor es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo Servidor no puede tener más de 50 caracteres.");
			//UserName (Tipo C#: string, SQL:varchar(128))
			RuleFor(x => x.UserName)
				.NotEmpty().WithMessage("El campo UserName es obligatorio.")
				.Must(x => x.Length <= 128).WithMessage("El campo UserName no puede tener más de 128 caracteres.");
			//Estacion (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.Estacion)
				.NotEmpty().WithMessage("El campo Estacion es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo Estacion no puede tener más de 50 caracteres.");
		}
	}
}
