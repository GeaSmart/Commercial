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
	public partial class balCONDICION_PAGO:AbstractValidator<eCONDICION_PAGO>
	{
		private static dalCONDICION_PAGO _dalCONDICION_PAGO = new dalCONDICION_PAGO();
		private static balCONDICION_PAGO _balCONDICION_PAGO = new balCONDICION_PAGO();

		public static bool insertarRegistro(eCONDICION_PAGO oeCONDICION_PAGO)
		{
			ValidationResult result = _balCONDICION_PAGO.Validate(oeCONDICION_PAGO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCONDICION_PAGO.obtenerRegistro(oeCONDICION_PAGO).Rows.Count == 0)
				{
					if (_dalCONDICION_PAGO.insertarRegistro(oeCONDICION_PAGO))
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

		public static bool actualizarRegistro(eCONDICION_PAGO oeCONDICION_PAGO)
		{
			ValidationResult result = _balCONDICION_PAGO.Validate(oeCONDICION_PAGO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCONDICION_PAGO.obtenerRegistro(oeCONDICION_PAGO).Rows.Count > 0)
				{
					if (_dalCONDICION_PAGO.actualizarRegistro(oeCONDICION_PAGO))
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

		public static bool eliminarRegistro(eCONDICION_PAGO oeCONDICION_PAGO)
		{
			bool flag = false;
			
			if ( _dalCONDICION_PAGO.obtenerRegistro(oeCONDICION_PAGO).Rows.Count > 0)
			{
				if (_dalCONDICION_PAGO.eliminarRegistro(oeCONDICION_PAGO))
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

		public static DataTable obtenerRegistro(eCONDICION_PAGO oeCONDICION_PAGO) {
			if ( _dalCONDICION_PAGO.obtenerRegistro(oeCONDICION_PAGO).Rows.Count > 0)
			{
				return _dalCONDICION_PAGO.obtenerRegistro(oeCONDICION_PAGO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalCONDICION_PAGO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalCONDICION_PAGO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalCONDICION_PAGO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalCONDICION_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalCONDICION_PAGO.primerRegistro().Rows.Count > 0)
				{
					return _dalCONDICION_PAGO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalCONDICION_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalCONDICION_PAGO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalCONDICION_PAGO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eCONDICION_PAGO oeCONDICION_PAGO) {
			if(_dalCONDICION_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalCONDICION_PAGO.anteriorRegistro(oeCONDICION_PAGO).Rows.Count > 0)
				{
					return _dalCONDICION_PAGO.anteriorRegistro(oeCONDICION_PAGO);
				}
				else
				{
					return _dalCONDICION_PAGO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eCONDICION_PAGO oeCONDICION_PAGO) {
			if(_dalCONDICION_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalCONDICION_PAGO.siguienteRegistro(oeCONDICION_PAGO).Rows.Count > 0)
				{
					return _dalCONDICION_PAGO.siguienteRegistro(oeCONDICION_PAGO);
				}
				else
				{
					return _dalCONDICION_PAGO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balCONDICION_PAGO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//CPA_codigo (Tipo C#: string, SQL:varchar(10))
			RuleFor(x => x.CPA_codigo)
				.NotEmpty().WithMessage("El campo CPA_codigo es obligatorio.")
				.Must(x => x.Length <= 10).WithMessage("El campo CPA_codigo no puede tener más de 10 caracteres.");
			//CPA_descripcion (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.CPA_descripcion)
				.NotEmpty().WithMessage("El campo CPA_descripcion es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo CPA_descripcion no puede tener más de 25 caracteres.");
			//CPA_dias_limite_pago (tipo: int)
			RuleFor(x => x.CPA_dias_limite_pago)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para CPA_dias_limite_pago");
		}
	}
}
