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
	public partial class balDETALLE_LISTA_PRECIO:AbstractValidator<eDETALLE_LISTA_PRECIO>
	{
		private static dalDETALLE_LISTA_PRECIO _dalDETALLE_LISTA_PRECIO = new dalDETALLE_LISTA_PRECIO();
		private static balDETALLE_LISTA_PRECIO _balDETALLE_LISTA_PRECIO = new balDETALLE_LISTA_PRECIO();

		public static bool insertarRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO)
		{
			ValidationResult result = _balDETALLE_LISTA_PRECIO.Validate(oeDETALLE_LISTA_PRECIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_LISTA_PRECIO.obtenerRegistro(oeDETALLE_LISTA_PRECIO).Rows.Count == 0)
				{
					if (_dalDETALLE_LISTA_PRECIO.insertarRegistro(oeDETALLE_LISTA_PRECIO))
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

		public static bool actualizarRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO)
		{
			ValidationResult result = _balDETALLE_LISTA_PRECIO.Validate(oeDETALLE_LISTA_PRECIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_LISTA_PRECIO.obtenerRegistro(oeDETALLE_LISTA_PRECIO).Rows.Count > 0)
				{
					if (_dalDETALLE_LISTA_PRECIO.actualizarRegistro(oeDETALLE_LISTA_PRECIO))
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

		public static bool eliminarRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO)
		{
			bool flag = false;
			
			if ( _dalDETALLE_LISTA_PRECIO.obtenerRegistro(oeDETALLE_LISTA_PRECIO).Rows.Count > 0)
			{
				if (_dalDETALLE_LISTA_PRECIO.eliminarRegistro(oeDETALLE_LISTA_PRECIO))
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

		public static DataTable obtenerRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			if ( _dalDETALLE_LISTA_PRECIO.obtenerRegistro(oeDETALLE_LISTA_PRECIO).Rows.Count > 0)
			{
				return _dalDETALLE_LISTA_PRECIO.obtenerRegistro(oeDETALLE_LISTA_PRECIO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDETALLE_LISTA_PRECIO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDETALLE_LISTA_PRECIO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDETALLE_LISTA_PRECIO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDETALLE_LISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_LISTA_PRECIO.primerRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_LISTA_PRECIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDETALLE_LISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_LISTA_PRECIO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_LISTA_PRECIO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			if(_dalDETALLE_LISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_LISTA_PRECIO.anteriorRegistro(oeDETALLE_LISTA_PRECIO).Rows.Count > 0)
				{
					return _dalDETALLE_LISTA_PRECIO.anteriorRegistro(oeDETALLE_LISTA_PRECIO);
				}
				else
				{
					return _dalDETALLE_LISTA_PRECIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO) {
			if(_dalDETALLE_LISTA_PRECIO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_LISTA_PRECIO.siguienteRegistro(oeDETALLE_LISTA_PRECIO).Rows.Count > 0)
				{
					return _dalDETALLE_LISTA_PRECIO.siguienteRegistro(oeDETALLE_LISTA_PRECIO);
				}
				else
				{
					return _dalDETALLE_LISTA_PRECIO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDETALLE_LISTA_PRECIO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//LPR_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.LPR_codigo)
				.NotEmpty().WithMessage("El campo LPR_codigo es obligatorio.")
				.Length(3).WithMessage("El campo LPR_codigo debe tener 3 caracteres.");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//DLP_precio (tipo: double)
			RuleFor(x => x.DLP_precio)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DLP_precio");
		}
	}
}
