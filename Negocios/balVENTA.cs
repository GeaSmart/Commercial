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
	public partial class balVENTA:AbstractValidator<eVENTA>
	{
		private static dalVENTA _dalVENTA = new dalVENTA();
		private static balVENTA _balVENTA = new balVENTA();

		public static bool insertarRegistro(eVENTA oeVENTA)
		{
			ValidationResult result = _balVENTA.Validate(oeVENTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVENTA.obtenerRegistro(oeVENTA).Rows.Count == 0)
				{
					if (_dalVENTA.insertarRegistro(oeVENTA))
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

		public static bool actualizarRegistro(eVENTA oeVENTA)
		{
			ValidationResult result = _balVENTA.Validate(oeVENTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVENTA.obtenerRegistro(oeVENTA).Rows.Count > 0)
				{
					if (_dalVENTA.actualizarRegistro(oeVENTA))
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

		public static bool eliminarRegistro(eVENTA oeVENTA)
		{
			bool flag = false;
			
			if ( _dalVENTA.obtenerRegistro(oeVENTA).Rows.Count > 0)
			{
				if (_dalVENTA.eliminarRegistro(oeVENTA))
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

		public static DataTable obtenerRegistro(eVENTA oeVENTA) {
			if ( _dalVENTA.obtenerRegistro(oeVENTA).Rows.Count > 0)
			{
				return _dalVENTA.obtenerRegistro(oeVENTA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalVENTA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalVENTA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalVENTA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalVENTA.poblar().Rows.Count > 0)
			{
				if(_dalVENTA.primerRegistro().Rows.Count > 0)
				{
					return _dalVENTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalVENTA.poblar().Rows.Count > 0)
			{
				if(_dalVENTA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalVENTA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eVENTA oeVENTA) {
			if(_dalVENTA.poblar().Rows.Count > 0)
			{
				if(_dalVENTA.anteriorRegistro(oeVENTA).Rows.Count > 0)
				{
					return _dalVENTA.anteriorRegistro(oeVENTA);
				}
				else
				{
					return _dalVENTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eVENTA oeVENTA) {
			if(_dalVENTA.poblar().Rows.Count > 0)
			{
				if(_dalVENTA.siguienteRegistro(oeVENTA).Rows.Count > 0)
				{
					return _dalVENTA.siguienteRegistro(oeVENTA);
				}
				else
				{
					return _dalVENTA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balVENTA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//VTA_serie_correlativo (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.VTA_serie_correlativo)
				.NotEmpty().WithMessage("El campo VTA_serie_correlativo es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo VTA_serie_correlativo no puede tener más de 50 caracteres.");
			//VTA_fecha_contabilizacion (tipo: DateTime)
			//Agregar aquí la validación para VTA_fecha_contabilizacion si se desea.
			
			//VTA_fecha_vencimiento (tipo: DateTime)
			//Agregar aquí la validación para VTA_fecha_vencimiento si se desea.
			
			//TDO_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TDO_codigo)
				.NotEmpty().WithMessage("El campo TDO_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TDO_codigo debe tener 3 caracteres.");
			//SER_serie (Tipo C#: string, SQL:varchar(7))
			RuleFor(x => x.SER_serie)
				.NotEmpty().WithMessage("El campo SER_serie es obligatorio.")
				.Must(x => x.Length <= 7).WithMessage("El campo SER_serie no puede tener más de 7 caracteres.");
			//VTA_correlativo (tipo: int)
			RuleFor(x => x.VTA_correlativo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_correlativo");
			//CHO_codigo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.CHO_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para CHO_codigo");
			//VTA_cho_nombre_completo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.VTA_cho_nombre_completo??"")
				.Must(x => x.Length <= 150).WithMessage("El campo VTA_cho_nombre_completo no puede tener más de 150 caracteres.");
			//VEN_codigo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.VEN_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VEN_codigo");
			//VTA_nombre_vendedor (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.VTA_nombre_vendedor??"")
				.Must(x => x.Length <= 150).WithMessage("El campo VTA_nombre_vendedor no puede tener más de 150 caracteres.");
			//VTA_is_comisionable (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.VTA_is_comisionable)
				.NotEmpty().WithMessage("El campo VTA_is_comisionable es obligatorio.")
				.Length(1).WithMessage("El campo VTA_is_comisionable debe tener 1 caracteres.");
			//VTA_is_oficina (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.VTA_is_oficina)
				.NotEmpty().WithMessage("El campo VTA_is_oficina es obligatorio.")
				.Length(1).WithMessage("El campo VTA_is_oficina debe tener 1 caracteres.");
			//TVE_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TVE_codigo)
				.NotEmpty().WithMessage("El campo TVE_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TVE_codigo debe tener 3 caracteres.");
			//SOC_codigo (tipo: int)
			RuleFor(x => x.SOC_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_codigo");
			//VTA_soc_nombre_razon (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.VTA_soc_nombre_razon)
				.NotEmpty().WithMessage("El campo VTA_soc_nombre_razon es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo VTA_soc_nombre_razon no puede tener más de 150 caracteres.");
			//VTA_soc_direccion (Tipo C#: string, SQL:varchar(250))
			RuleFor(x => x.VTA_soc_direccion)
				.NotEmpty().WithMessage("El campo VTA_soc_direccion es obligatorio.")
				.Must(x => x.Length <= 250).WithMessage("El campo VTA_soc_direccion no puede tener más de 250 caracteres.");
			//VTA_soc_zona (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.VTA_soc_zona)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_soc_zona");
			//VTA_subtotal (tipo: double)
			RuleFor(x => x.VTA_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_subtotal");
			//VTA_porcentaje_percepcion (tipo: double)
			RuleFor(x => x.VTA_porcentaje_percepcion)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_porcentaje_percepcion");
			//VTA_monto_igv (tipo: double)
			RuleFor(x => x.VTA_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_monto_igv");
			//VTA_monto_isc (tipo: double)
			RuleFor(x => x.VTA_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_monto_isc");
			//VTA_monto_percepcion (tipo: double)
			RuleFor(x => x.VTA_monto_percepcion)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_monto_percepcion");
			//VTA_monto_total (tipo: double)
			RuleFor(x => x.VTA_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VTA_monto_total");
			//VTA_monto_total_texto (Tipo C#: string, SQL:varchar(250))
			RuleFor(x => x.VTA_monto_total_texto)
				.NotEmpty().WithMessage("El campo VTA_monto_total_texto es obligatorio.")
				.Must(x => x.Length <= 250).WithMessage("El campo VTA_monto_total_texto no puede tener más de 250 caracteres.");
			//VTA_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.VTA_comentario??"")
				.Must(x => x.Length <= 250).WithMessage("El campo VTA_comentario no puede tener más de 250 caracteres.");
			//VTA_estado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.VTA_estado)
				.NotEmpty().WithMessage("El campo VTA_estado es obligatorio.")
				.Length(1).WithMessage("El campo VTA_estado debe tener 1 caracteres.");
			//CPA_codigo (Tipo C#: string, SQL:varchar(10))
			RuleFor(x => x.CPA_codigo)
				.NotEmpty().WithMessage("El campo CPA_codigo es obligatorio.")
				.Must(x => x.Length <= 10).WithMessage("El campo CPA_codigo no puede tener más de 10 caracteres.");
			//PED_numero (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.PED_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_numero");
			//MDE_codigo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.MDE_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para MDE_codigo");
		}
	}
}
