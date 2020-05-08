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
	public partial class balDETALLE_VENTA:AbstractValidator<eDETALLE_VENTA>
	{
		private static dalDETALLE_VENTA _dalDETALLE_VENTA = new dalDETALLE_VENTA();
		private static balDETALLE_VENTA _balDETALLE_VENTA = new balDETALLE_VENTA();

		public static bool insertarRegistro(eDETALLE_VENTA oeDETALLE_VENTA)
		{
			ValidationResult result = _balDETALLE_VENTA.Validate(oeDETALLE_VENTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_VENTA.obtenerRegistro(oeDETALLE_VENTA).Rows.Count == 0)
				{
					if (_dalDETALLE_VENTA.insertarRegistro(oeDETALLE_VENTA))
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

		public static bool actualizarRegistro(eDETALLE_VENTA oeDETALLE_VENTA)
		{
			ValidationResult result = _balDETALLE_VENTA.Validate(oeDETALLE_VENTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_VENTA.obtenerRegistro(oeDETALLE_VENTA).Rows.Count > 0)
				{
					if (_dalDETALLE_VENTA.actualizarRegistro(oeDETALLE_VENTA))
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

		public static bool eliminarRegistro(eDETALLE_VENTA oeDETALLE_VENTA)
		{
			bool flag = false;
			
			if ( _dalDETALLE_VENTA.obtenerRegistro(oeDETALLE_VENTA).Rows.Count > 0)
			{
				if (_dalDETALLE_VENTA.eliminarRegistro(oeDETALLE_VENTA))
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

		public static DataTable obtenerRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			if ( _dalDETALLE_VENTA.obtenerRegistro(oeDETALLE_VENTA).Rows.Count > 0)
			{
				return _dalDETALLE_VENTA.obtenerRegistro(oeDETALLE_VENTA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDETALLE_VENTA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDETALLE_VENTA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDETALLE_VENTA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDETALLE_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_VENTA.primerRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_VENTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDETALLE_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_VENTA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_VENTA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			if(_dalDETALLE_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_VENTA.anteriorRegistro(oeDETALLE_VENTA).Rows.Count > 0)
				{
					return _dalDETALLE_VENTA.anteriorRegistro(oeDETALLE_VENTA);
				}
				else
				{
					return _dalDETALLE_VENTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDETALLE_VENTA oeDETALLE_VENTA) {
			if(_dalDETALLE_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_VENTA.siguienteRegistro(oeDETALLE_VENTA).Rows.Count > 0)
				{
					return _dalDETALLE_VENTA.siguienteRegistro(oeDETALLE_VENTA);
				}
				else
				{
					return _dalDETALLE_VENTA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDETALLE_VENTA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//VTA_serie_correlativo (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.VTA_serie_correlativo)
				.NotEmpty().WithMessage("El campo VTA_serie_correlativo es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo VTA_serie_correlativo no puede tener más de 50 caracteres.");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//DVE_is_bonificacion (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.DVE_is_bonificacion)
				.NotEmpty().WithMessage("El campo DVE_is_bonificacion es obligatorio.")
				.Length(1).WithMessage("El campo DVE_is_bonificacion debe tener 1 caracteres.");
			//DVE_pro_descripcion (Tipo C#: string, SQL:varchar(100))
			RuleFor(x => x.DVE_pro_descripcion)
				.NotEmpty().WithMessage("El campo DVE_pro_descripcion es obligatorio.")
				.Must(x => x.Length <= 100).WithMessage("El campo DVE_pro_descripcion no puede tener más de 100 caracteres.");
			//DVE_pro_ume_multiplo (tipo: int)
			RuleFor(x => x.DVE_pro_ume_multiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_pro_ume_multiplo");
			//DVE_cantidad (tipo: int)
			RuleFor(x => x.DVE_cantidad)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_cantidad");
			//DVE_cantidad_submultiplo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.DVE_cantidad_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_cantidad_submultiplo");
			//DVE_precio_unitario (tipo: double)
			RuleFor(x => x.DVE_precio_unitario)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_precio_unitario");
			//DVE_monto_subtotal (tipo: double)
			RuleFor(x => x.DVE_monto_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_monto_subtotal");
			//DVE_monto_descuento (tipo: double)
			RuleFor(x => x.DVE_monto_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_monto_descuento");
			//DVE_porcentaje_descuento (tipo: double)
			RuleFor(x => x.DVE_porcentaje_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_porcentaje_descuento");
			//DVE_monto_igv (tipo: double)
			RuleFor(x => x.DVE_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_monto_igv");
			//DVE_monto_isc (tipo: double)
			RuleFor(x => x.DVE_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_monto_isc");
			//DVE_porcentaje_igv (tipo: double)
			RuleFor(x => x.DVE_porcentaje_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_porcentaje_igv");
			//DVE_porcentaje_isc (tipo: double)
			RuleFor(x => x.DVE_porcentaje_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_porcentaje_isc");
			//DVE_monto_total_linea (tipo: double)
			RuleFor(x => x.DVE_monto_total_linea)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_monto_total_linea");
			//DVE_memo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.DVE_memo??"")
				.Must(x => x.Length <= 50).WithMessage("El campo DVE_memo no puede tener más de 50 caracteres.");
			//DVE_numero_fila (tipo: int)
			RuleFor(x => x.DVE_numero_fila)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DVE_numero_fila");
		}
	}
}
