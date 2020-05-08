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
	public partial class balTIPO_DOCUMENTO:AbstractValidator<eTIPO_DOCUMENTO>
	{
		private static dalTIPO_DOCUMENTO _dalTIPO_DOCUMENTO = new dalTIPO_DOCUMENTO();
		private static balTIPO_DOCUMENTO _balTIPO_DOCUMENTO = new balTIPO_DOCUMENTO();

		public static bool insertarRegistro(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO)
		{
			ValidationResult result = _balTIPO_DOCUMENTO.Validate(oeTIPO_DOCUMENTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalTIPO_DOCUMENTO.obtenerRegistro(oeTIPO_DOCUMENTO).Rows.Count == 0)
				{
					if (_dalTIPO_DOCUMENTO.insertarRegistro(oeTIPO_DOCUMENTO))
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

		public static bool actualizarRegistro(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO)
		{
			ValidationResult result = _balTIPO_DOCUMENTO.Validate(oeTIPO_DOCUMENTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalTIPO_DOCUMENTO.obtenerRegistro(oeTIPO_DOCUMENTO).Rows.Count > 0)
				{
					if (_dalTIPO_DOCUMENTO.actualizarRegistro(oeTIPO_DOCUMENTO))
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

		public static bool eliminarRegistro(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO)
		{
			bool flag = false;
			
			if ( _dalTIPO_DOCUMENTO.obtenerRegistro(oeTIPO_DOCUMENTO).Rows.Count > 0)
			{
				if (_dalTIPO_DOCUMENTO.eliminarRegistro(oeTIPO_DOCUMENTO))
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

		public static DataTable obtenerRegistro(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO) {
			if ( _dalTIPO_DOCUMENTO.obtenerRegistro(oeTIPO_DOCUMENTO).Rows.Count > 0)
			{
				return _dalTIPO_DOCUMENTO.obtenerRegistro(oeTIPO_DOCUMENTO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalTIPO_DOCUMENTO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalTIPO_DOCUMENTO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalTIPO_DOCUMENTO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalTIPO_DOCUMENTO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_DOCUMENTO.primerRegistro().Rows.Count > 0)
				{
					return _dalTIPO_DOCUMENTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalTIPO_DOCUMENTO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_DOCUMENTO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalTIPO_DOCUMENTO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO) {
			if(_dalTIPO_DOCUMENTO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_DOCUMENTO.anteriorRegistro(oeTIPO_DOCUMENTO).Rows.Count > 0)
				{
					return _dalTIPO_DOCUMENTO.anteriorRegistro(oeTIPO_DOCUMENTO);
				}
				else
				{
					return _dalTIPO_DOCUMENTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO) {
			if(_dalTIPO_DOCUMENTO.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_DOCUMENTO.siguienteRegistro(oeTIPO_DOCUMENTO).Rows.Count > 0)
				{
					return _dalTIPO_DOCUMENTO.siguienteRegistro(oeTIPO_DOCUMENTO);
				}
				else
				{
					return _dalTIPO_DOCUMENTO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balTIPO_DOCUMENTO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//TDO_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TDO_codigo)
				.NotEmpty().WithMessage("El campo TDO_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TDO_codigo debe tener 3 caracteres.");
			//TDO_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.TDO_nombre)
				.NotEmpty().WithMessage("El campo TDO_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo TDO_nombre no puede tener más de 50 caracteres.");
		}
	}
}
