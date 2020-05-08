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
	public partial class balPAGO:AbstractValidator<ePAGO>
	{
		private static dalPAGO _dalPAGO = new dalPAGO();
		private static balPAGO _balPAGO = new balPAGO();

		public static bool insertarRegistro(ePAGO oePAGO)
		{
			ValidationResult result = _balPAGO.Validate(oePAGO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPAGO.obtenerRegistro(oePAGO).Rows.Count == 0)
				{
					if (_dalPAGO.insertarRegistro(oePAGO))
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

		public static bool actualizarRegistro(ePAGO oePAGO)
		{
			ValidationResult result = _balPAGO.Validate(oePAGO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPAGO.obtenerRegistro(oePAGO).Rows.Count > 0)
				{
					if (_dalPAGO.actualizarRegistro(oePAGO))
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

		public static bool eliminarRegistro(ePAGO oePAGO)
		{
			bool flag = false;
			
			if ( _dalPAGO.obtenerRegistro(oePAGO).Rows.Count > 0)
			{
				if (_dalPAGO.eliminarRegistro(oePAGO))
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

		public static DataTable obtenerRegistro(ePAGO oePAGO) {
			if ( _dalPAGO.obtenerRegistro(oePAGO).Rows.Count > 0)
			{
				return _dalPAGO.obtenerRegistro(oePAGO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPAGO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPAGO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPAGO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPAGO.poblar().Rows.Count > 0)
			{
				if(_dalPAGO.primerRegistro().Rows.Count > 0)
				{
					return _dalPAGO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPAGO.poblar().Rows.Count > 0)
			{
				if(_dalPAGO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPAGO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePAGO oePAGO) {
			if(_dalPAGO.poblar().Rows.Count > 0)
			{
				if(_dalPAGO.anteriorRegistro(oePAGO).Rows.Count > 0)
				{
					return _dalPAGO.anteriorRegistro(oePAGO);
				}
				else
				{
					return _dalPAGO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePAGO oePAGO) {
			if(_dalPAGO.poblar().Rows.Count > 0)
			{
				if(_dalPAGO.siguienteRegistro(oePAGO).Rows.Count > 0)
				{
					return _dalPAGO.siguienteRegistro(oePAGO);
				}
				else
				{
					return _dalPAGO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPAGO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//VTA_serie_correlativo (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.VTA_serie_correlativo)
				.NotEmpty().WithMessage("El campo VTA_serie_correlativo es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo VTA_serie_correlativo no puede tener más de 50 caracteres.");
			//PAG_numero (tipo: int)
			RuleFor(x => x.PAG_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PAG_numero");
			//PAG_monto_total (tipo: double)
			RuleFor(x => x.PAG_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PAG_monto_total");
			//PAG_abono (tipo: double)
			RuleFor(x => x.PAG_abono)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PAG_abono");
			//PAG_referencia (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.PAG_referencia??"")
				.Must(x => x.Length <= 250).WithMessage("El campo PAG_referencia no puede tener más de 250 caracteres.");
			//MPA_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.MPA_codigo)
				.NotEmpty().WithMessage("El campo MPA_codigo es obligatorio.")
				.Length(3).WithMessage("El campo MPA_codigo debe tener 3 caracteres.");
		}
	}
}
