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
	public partial class balTIPO_NEGOCIO:AbstractValidator<eTIPO_NEGOCIO>
	{
		private static dalTIPO_NEGOCIO _dalTIPO_NEGOCIO = new dalTIPO_NEGOCIO();
		private static balTIPO_NEGOCIO _balTIPO_NEGOCIO = new balTIPO_NEGOCIO();

		public static bool insertarRegistro(eTIPO_NEGOCIO oeTIPO_NEGOCIO)
		{
			ValidationResult result = _balTIPO_NEGOCIO.Validate(oeTIPO_NEGOCIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalTIPO_NEGOCIO.obtenerRegistro(oeTIPO_NEGOCIO).Rows.Count == 0)
				{
					if (_dalTIPO_NEGOCIO.insertarRegistro(oeTIPO_NEGOCIO))
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

		public static bool actualizarRegistro(eTIPO_NEGOCIO oeTIPO_NEGOCIO)
		{
			ValidationResult result = _balTIPO_NEGOCIO.Validate(oeTIPO_NEGOCIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalTIPO_NEGOCIO.obtenerRegistro(oeTIPO_NEGOCIO).Rows.Count > 0)
				{
					if (_dalTIPO_NEGOCIO.actualizarRegistro(oeTIPO_NEGOCIO))
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

		public static bool eliminarRegistro(eTIPO_NEGOCIO oeTIPO_NEGOCIO)
		{
			bool flag = false;
			
			if ( _dalTIPO_NEGOCIO.obtenerRegistro(oeTIPO_NEGOCIO).Rows.Count > 0)
			{
				if (_dalTIPO_NEGOCIO.eliminarRegistro(oeTIPO_NEGOCIO))
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

		public static DataTable obtenerRegistro(eTIPO_NEGOCIO oeTIPO_NEGOCIO) {
			if ( _dalTIPO_NEGOCIO.obtenerRegistro(oeTIPO_NEGOCIO).Rows.Count > 0)
			{
				return _dalTIPO_NEGOCIO.obtenerRegistro(oeTIPO_NEGOCIO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalTIPO_NEGOCIO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalTIPO_NEGOCIO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalTIPO_NEGOCIO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalTIPO_NEGOCIO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_NEGOCIO.primerRegistro().Rows.Count > 0)
				{
					return _dalTIPO_NEGOCIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalTIPO_NEGOCIO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_NEGOCIO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalTIPO_NEGOCIO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eTIPO_NEGOCIO oeTIPO_NEGOCIO) {
			if(_dalTIPO_NEGOCIO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_NEGOCIO.anteriorRegistro(oeTIPO_NEGOCIO).Rows.Count > 0)
				{
					return _dalTIPO_NEGOCIO.anteriorRegistro(oeTIPO_NEGOCIO);
				}
				else
				{
					return _dalTIPO_NEGOCIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eTIPO_NEGOCIO oeTIPO_NEGOCIO) {
			if(_dalTIPO_NEGOCIO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_NEGOCIO.siguienteRegistro(oeTIPO_NEGOCIO).Rows.Count > 0)
				{
					return _dalTIPO_NEGOCIO.siguienteRegistro(oeTIPO_NEGOCIO);
				}
				else
				{
					return _dalTIPO_NEGOCIO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balTIPO_NEGOCIO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//TNE_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TNE_codigo)
				.NotEmpty().WithMessage("El campo TNE_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TNE_codigo debe tener 3 caracteres.");
			//TNE_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.TNE_nombre)
				.NotEmpty().WithMessage("El campo TNE_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo TNE_nombre no puede tener más de 50 caracteres.");
		}
	}
}
