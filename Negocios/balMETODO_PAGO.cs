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
	public partial class balMETODO_PAGO:AbstractValidator<eMETODO_PAGO>
	{
		private static dalMETODO_PAGO _dalMETODO_PAGO = new dalMETODO_PAGO();
		private static balMETODO_PAGO _balMETODO_PAGO = new balMETODO_PAGO();

		public static bool insertarRegistro(eMETODO_PAGO oeMETODO_PAGO)
		{
			ValidationResult result = _balMETODO_PAGO.Validate(oeMETODO_PAGO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalMETODO_PAGO.obtenerRegistro(oeMETODO_PAGO).Rows.Count == 0)
				{
					if (_dalMETODO_PAGO.insertarRegistro(oeMETODO_PAGO))
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

		public static bool actualizarRegistro(eMETODO_PAGO oeMETODO_PAGO)
		{
			ValidationResult result = _balMETODO_PAGO.Validate(oeMETODO_PAGO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalMETODO_PAGO.obtenerRegistro(oeMETODO_PAGO).Rows.Count > 0)
				{
					if (_dalMETODO_PAGO.actualizarRegistro(oeMETODO_PAGO))
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

		public static bool eliminarRegistro(eMETODO_PAGO oeMETODO_PAGO)
		{
			bool flag = false;
			
			if ( _dalMETODO_PAGO.obtenerRegistro(oeMETODO_PAGO).Rows.Count > 0)
			{
				if (_dalMETODO_PAGO.eliminarRegistro(oeMETODO_PAGO))
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

		public static DataTable obtenerRegistro(eMETODO_PAGO oeMETODO_PAGO) {
			if ( _dalMETODO_PAGO.obtenerRegistro(oeMETODO_PAGO).Rows.Count > 0)
			{
				return _dalMETODO_PAGO.obtenerRegistro(oeMETODO_PAGO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalMETODO_PAGO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalMETODO_PAGO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalMETODO_PAGO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalMETODO_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalMETODO_PAGO.primerRegistro().Rows.Count > 0)
				{
					return _dalMETODO_PAGO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalMETODO_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalMETODO_PAGO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalMETODO_PAGO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eMETODO_PAGO oeMETODO_PAGO) {
			if(_dalMETODO_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalMETODO_PAGO.anteriorRegistro(oeMETODO_PAGO).Rows.Count > 0)
				{
					return _dalMETODO_PAGO.anteriorRegistro(oeMETODO_PAGO);
				}
				else
				{
					return _dalMETODO_PAGO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eMETODO_PAGO oeMETODO_PAGO) {
			if(_dalMETODO_PAGO.poblar().Rows.Count > 0)
			{
				if(_dalMETODO_PAGO.siguienteRegistro(oeMETODO_PAGO).Rows.Count > 0)
				{
					return _dalMETODO_PAGO.siguienteRegistro(oeMETODO_PAGO);
				}
				else
				{
					return _dalMETODO_PAGO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balMETODO_PAGO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//MPA_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.MPA_codigo)
				.NotEmpty().WithMessage("El campo MPA_codigo es obligatorio.")
				.Length(3).WithMessage("El campo MPA_codigo debe tener 3 caracteres.");
			//MPA_nombre (Tipo C#: string, SQL:varchar(75))
			RuleFor(x => x.MPA_nombre)
				.NotEmpty().WithMessage("El campo MPA_nombre es obligatorio.")
				.Must(x => x.Length <= 75).WithMessage("El campo MPA_nombre no puede tener más de 75 caracteres.");
			//MPA_is_activo (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.MPA_is_activo)
				.NotEmpty().WithMessage("El campo MPA_is_activo es obligatorio.")
				.Length(1).WithMessage("El campo MPA_is_activo debe tener 1 caracteres.");
		}
	}
}
