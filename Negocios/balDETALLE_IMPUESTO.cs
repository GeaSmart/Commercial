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
	public partial class balDETALLE_IMPUESTO:AbstractValidator<eDETALLE_IMPUESTO>
	{
		private static dalDETALLE_IMPUESTO _dalDETALLE_IMPUESTO = new dalDETALLE_IMPUESTO();
		private static balDETALLE_IMPUESTO _balDETALLE_IMPUESTO = new balDETALLE_IMPUESTO();

		public static bool insertarRegistro(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
		{
			ValidationResult result = _balDETALLE_IMPUESTO.Validate(oeDETALLE_IMPUESTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_IMPUESTO.obtenerRegistro(oeDETALLE_IMPUESTO).Rows.Count == 0)
				{
					if (_dalDETALLE_IMPUESTO.insertarRegistro(oeDETALLE_IMPUESTO))
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

		public static bool actualizarRegistro(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
		{
			ValidationResult result = _balDETALLE_IMPUESTO.Validate(oeDETALLE_IMPUESTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_IMPUESTO.obtenerRegistro(oeDETALLE_IMPUESTO).Rows.Count > 0)
				{
					if (_dalDETALLE_IMPUESTO.actualizarRegistro(oeDETALLE_IMPUESTO))
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

		public static bool eliminarRegistro(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
		{
			bool flag = false;
			
			if ( _dalDETALLE_IMPUESTO.obtenerRegistro(oeDETALLE_IMPUESTO).Rows.Count > 0)
			{
				if (_dalDETALLE_IMPUESTO.eliminarRegistro(oeDETALLE_IMPUESTO))
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

		public static DataTable obtenerRegistro(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO) {
			if ( _dalDETALLE_IMPUESTO.obtenerRegistro(oeDETALLE_IMPUESTO).Rows.Count > 0)
			{
				return _dalDETALLE_IMPUESTO.obtenerRegistro(oeDETALLE_IMPUESTO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDETALLE_IMPUESTO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDETALLE_IMPUESTO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDETALLE_IMPUESTO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDETALLE_IMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_IMPUESTO.primerRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_IMPUESTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDETALLE_IMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_IMPUESTO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_IMPUESTO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO) {
			if(_dalDETALLE_IMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_IMPUESTO.anteriorRegistro(oeDETALLE_IMPUESTO).Rows.Count > 0)
				{
					return _dalDETALLE_IMPUESTO.anteriorRegistro(oeDETALLE_IMPUESTO);
				}
				else
				{
					return _dalDETALLE_IMPUESTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO) {
			if(_dalDETALLE_IMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_IMPUESTO.siguienteRegistro(oeDETALLE_IMPUESTO).Rows.Count > 0)
				{
					return _dalDETALLE_IMPUESTO.siguienteRegistro(oeDETALLE_IMPUESTO);
				}
				else
				{
					return _dalDETALLE_IMPUESTO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDETALLE_IMPUESTO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//IMP_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.IMP_codigo)
				.NotEmpty().WithMessage("El campo IMP_codigo es obligatorio.")
				.Length(3).WithMessage("El campo IMP_codigo debe tener 3 caracteres.");
			//DIM_numero (tipo: int)
			RuleFor(x => x.DIM_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DIM_numero");
			//DIM_porcentaje (tipo: double)
			RuleFor(x => x.DIM_porcentaje)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DIM_porcentaje");
		}
	}
}
