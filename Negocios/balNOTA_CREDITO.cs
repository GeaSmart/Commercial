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
	public partial class balNOTA_CREDITO:AbstractValidator<eNOTA_CREDITO>
	{
		private static dalNOTA_CREDITO _dalNOTA_CREDITO = new dalNOTA_CREDITO();
		private static balNOTA_CREDITO _balNOTA_CREDITO = new balNOTA_CREDITO();

		public static bool insertarRegistro(eNOTA_CREDITO oeNOTA_CREDITO)
		{
			ValidationResult result = _balNOTA_CREDITO.Validate(oeNOTA_CREDITO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO).Rows.Count == 0)
				{
					if (_dalNOTA_CREDITO.insertarRegistro(oeNOTA_CREDITO))
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

		public static bool actualizarRegistro(eNOTA_CREDITO oeNOTA_CREDITO)
		{
			ValidationResult result = _balNOTA_CREDITO.Validate(oeNOTA_CREDITO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO).Rows.Count > 0)
				{
					if (_dalNOTA_CREDITO.actualizarRegistro(oeNOTA_CREDITO))
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

		public static bool eliminarRegistro(eNOTA_CREDITO oeNOTA_CREDITO)
		{
			bool flag = false;
			
			if ( _dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO).Rows.Count > 0)
			{
				if (_dalNOTA_CREDITO.eliminarRegistro(oeNOTA_CREDITO))
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

		public static DataTable obtenerRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			if ( _dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO).Rows.Count > 0)
			{
				return _dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalNOTA_CREDITO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalNOTA_CREDITO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalNOTA_CREDITO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalNOTA_CREDITO.poblar().Rows.Count > 0)
			{
				if(_dalNOTA_CREDITO.primerRegistro().Rows.Count > 0)
				{
					return _dalNOTA_CREDITO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalNOTA_CREDITO.poblar().Rows.Count > 0)
			{
				if(_dalNOTA_CREDITO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalNOTA_CREDITO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			if(_dalNOTA_CREDITO.poblar().Rows.Count > 0)
			{
				if(_dalNOTA_CREDITO.anteriorRegistro(oeNOTA_CREDITO).Rows.Count > 0)
				{
					return _dalNOTA_CREDITO.anteriorRegistro(oeNOTA_CREDITO);
				}
				else
				{
					return _dalNOTA_CREDITO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eNOTA_CREDITO oeNOTA_CREDITO) {
			if(_dalNOTA_CREDITO.poblar().Rows.Count > 0)
			{
				if(_dalNOTA_CREDITO.siguienteRegistro(oeNOTA_CREDITO).Rows.Count > 0)
				{
					return _dalNOTA_CREDITO.siguienteRegistro(oeNOTA_CREDITO);
				}
				else
				{
					return _dalNOTA_CREDITO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balNOTA_CREDITO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//NCR_serie_correlativo (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.NCR_serie_correlativo)
				.NotEmpty().WithMessage("El campo NCR_serie_correlativo es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo NCR_serie_correlativo no puede tener más de 50 caracteres.");
			//NCR_fecha_contabilizacion (tipo: DateTime)
			//Agregar aquí la validación para NCR_fecha_contabilizacion si se desea.
			
			//TDO_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TDO_codigo)
				.NotEmpty().WithMessage("El campo TDO_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TDO_codigo debe tener 3 caracteres.");
			//SER_serie (Tipo C#: string, SQL:varchar(7))
			RuleFor(x => x.SER_serie)
				.NotEmpty().WithMessage("El campo SER_serie es obligatorio.")
				.Must(x => x.Length <= 7).WithMessage("El campo SER_serie no puede tener más de 7 caracteres.");
			//NCR_correlativo (tipo: int)
			RuleFor(x => x.NCR_correlativo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para NCR_correlativo");
			//VTA_serie_correlativo (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.VTA_serie_correlativo)
				.NotEmpty().WithMessage("El campo VTA_serie_correlativo es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo VTA_serie_correlativo no puede tener más de 50 caracteres.");
			//SOC_codigo (tipo: int)
			RuleFor(x => x.SOC_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_codigo");
			//NCR_soc_nombre_razon (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.NCR_soc_nombre_razon)
				.NotEmpty().WithMessage("El campo NCR_soc_nombre_razon es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo NCR_soc_nombre_razon no puede tener más de 150 caracteres.");
			//NCR_subtotal (tipo: double)
			RuleFor(x => x.NCR_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para NCR_subtotal");
			//NCR_monto_igv (tipo: double)
			RuleFor(x => x.NCR_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para NCR_monto_igv");
			//NCR_monto_isc (tipo: double)
			RuleFor(x => x.NCR_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para NCR_monto_isc");
			//NCR_monto_total (tipo: double)
			RuleFor(x => x.NCR_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para NCR_monto_total");
			//NCR_monto_total_texto (Tipo C#: string, SQL:varchar(250))
			RuleFor(x => x.NCR_monto_total_texto)
				.NotEmpty().WithMessage("El campo NCR_monto_total_texto es obligatorio.")
				.Must(x => x.Length <= 250).WithMessage("El campo NCR_monto_total_texto no puede tener más de 250 caracteres.");
			//NCR_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.NCR_comentario??"")
				.Must(x => x.Length <= 250).WithMessage("El campo NCR_comentario no puede tener más de 250 caracteres.");
			//NCR_estado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.NCR_estado)
				.NotEmpty().WithMessage("El campo NCR_estado es obligatorio.")
				.Length(1).WithMessage("El campo NCR_estado debe tener 1 caracteres.");
			//MDE_codigo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.MDE_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para MDE_codigo");
		}
	}
}
