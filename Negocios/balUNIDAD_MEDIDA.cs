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
	public partial class balUNIDAD_MEDIDA:AbstractValidator<eUNIDAD_MEDIDA>
	{
		private static dalUNIDAD_MEDIDA _dalUNIDAD_MEDIDA = new dalUNIDAD_MEDIDA();
		private static balUNIDAD_MEDIDA _balUNIDAD_MEDIDA = new balUNIDAD_MEDIDA();

		public static bool insertarRegistro(eUNIDAD_MEDIDA oeUNIDAD_MEDIDA)
		{
			ValidationResult result = _balUNIDAD_MEDIDA.Validate(oeUNIDAD_MEDIDA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalUNIDAD_MEDIDA.obtenerRegistro(oeUNIDAD_MEDIDA).Rows.Count == 0)
				{
					if (_dalUNIDAD_MEDIDA.insertarRegistro(oeUNIDAD_MEDIDA))
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

		public static bool actualizarRegistro(eUNIDAD_MEDIDA oeUNIDAD_MEDIDA)
		{
			ValidationResult result = _balUNIDAD_MEDIDA.Validate(oeUNIDAD_MEDIDA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalUNIDAD_MEDIDA.obtenerRegistro(oeUNIDAD_MEDIDA).Rows.Count > 0)
				{
					if (_dalUNIDAD_MEDIDA.actualizarRegistro(oeUNIDAD_MEDIDA))
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

		public static bool eliminarRegistro(eUNIDAD_MEDIDA oeUNIDAD_MEDIDA)
		{
			bool flag = false;
			
			if ( _dalUNIDAD_MEDIDA.obtenerRegistro(oeUNIDAD_MEDIDA).Rows.Count > 0)
			{
				if (_dalUNIDAD_MEDIDA.eliminarRegistro(oeUNIDAD_MEDIDA))
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

		public static DataTable obtenerRegistro(eUNIDAD_MEDIDA oeUNIDAD_MEDIDA) {
			if ( _dalUNIDAD_MEDIDA.obtenerRegistro(oeUNIDAD_MEDIDA).Rows.Count > 0)
			{
				return _dalUNIDAD_MEDIDA.obtenerRegistro(oeUNIDAD_MEDIDA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalUNIDAD_MEDIDA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalUNIDAD_MEDIDA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalUNIDAD_MEDIDA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalUNIDAD_MEDIDA.poblar().Rows.Count > 0)
			{
				if(_dalUNIDAD_MEDIDA.primerRegistro().Rows.Count > 0)
				{
					return _dalUNIDAD_MEDIDA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalUNIDAD_MEDIDA.poblar().Rows.Count > 0)
			{
				if(_dalUNIDAD_MEDIDA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalUNIDAD_MEDIDA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eUNIDAD_MEDIDA oeUNIDAD_MEDIDA) {
			if(_dalUNIDAD_MEDIDA.poblar().Rows.Count > 0)
			{
				if(_dalUNIDAD_MEDIDA.anteriorRegistro(oeUNIDAD_MEDIDA).Rows.Count > 0)
				{
					return _dalUNIDAD_MEDIDA.anteriorRegistro(oeUNIDAD_MEDIDA);
				}
				else
				{
					return _dalUNIDAD_MEDIDA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eUNIDAD_MEDIDA oeUNIDAD_MEDIDA) {
			if(_dalUNIDAD_MEDIDA.poblar().Rows.Count > 0)
			{
				if(_dalUNIDAD_MEDIDA.siguienteRegistro(oeUNIDAD_MEDIDA).Rows.Count > 0)
				{
					return _dalUNIDAD_MEDIDA.siguienteRegistro(oeUNIDAD_MEDIDA);
				}
				else
				{
					return _dalUNIDAD_MEDIDA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balUNIDAD_MEDIDA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//UME_codigo (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.UME_codigo)
				.NotEmpty().WithMessage("El campo UME_codigo es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo UME_codigo no puede tener más de 15 caracteres.");
			//UME_descripcion (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.UME_descripcion)
				.NotEmpty().WithMessage("El campo UME_descripcion es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo UME_descripcion no puede tener más de 25 caracteres.");
			//UME_descripcion_sunat (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.UME_descripcion_sunat??"")
				.Must(x => x.Length <= 50).WithMessage("El campo UME_descripcion_sunat no puede tener más de 50 caracteres.");
			//UME_multiplo (tipo: int)
			RuleFor(x => x.UME_multiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para UME_multiplo");
		}
	}
}
