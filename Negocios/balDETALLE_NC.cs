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
	public partial class balDETALLE_NC:AbstractValidator<eDETALLE_NC>
	{
		private static dalDETALLE_NC _dalDETALLE_NC = new dalDETALLE_NC();
		private static balDETALLE_NC _balDETALLE_NC = new balDETALLE_NC();

		public static bool insertarRegistro(eDETALLE_NC oeDETALLE_NC)
		{
			ValidationResult result = _balDETALLE_NC.Validate(oeDETALLE_NC);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_NC.obtenerRegistro(oeDETALLE_NC).Rows.Count == 0)
				{
					if (_dalDETALLE_NC.insertarRegistro(oeDETALLE_NC))
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

		public static bool actualizarRegistro(eDETALLE_NC oeDETALLE_NC)
		{
			ValidationResult result = _balDETALLE_NC.Validate(oeDETALLE_NC);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_NC.obtenerRegistro(oeDETALLE_NC).Rows.Count > 0)
				{
					if (_dalDETALLE_NC.actualizarRegistro(oeDETALLE_NC))
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

		public static bool eliminarRegistro(eDETALLE_NC oeDETALLE_NC)
		{
			bool flag = false;
			
			if ( _dalDETALLE_NC.obtenerRegistro(oeDETALLE_NC).Rows.Count > 0)
			{
				if (_dalDETALLE_NC.eliminarRegistro(oeDETALLE_NC))
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

		public static DataTable obtenerRegistro(eDETALLE_NC oeDETALLE_NC) {
			if ( _dalDETALLE_NC.obtenerRegistro(oeDETALLE_NC).Rows.Count > 0)
			{
				return _dalDETALLE_NC.obtenerRegistro(oeDETALLE_NC);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDETALLE_NC.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDETALLE_NC.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDETALLE_NC.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDETALLE_NC.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_NC.primerRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_NC.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDETALLE_NC.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_NC.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_NC.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDETALLE_NC oeDETALLE_NC) {
			if(_dalDETALLE_NC.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_NC.anteriorRegistro(oeDETALLE_NC).Rows.Count > 0)
				{
					return _dalDETALLE_NC.anteriorRegistro(oeDETALLE_NC);
				}
				else
				{
					return _dalDETALLE_NC.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDETALLE_NC oeDETALLE_NC) {
			if(_dalDETALLE_NC.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_NC.siguienteRegistro(oeDETALLE_NC).Rows.Count > 0)
				{
					return _dalDETALLE_NC.siguienteRegistro(oeDETALLE_NC);
				}
				else
				{
					return _dalDETALLE_NC.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDETALLE_NC()
		{
			CascadeMode = CascadeMode.Continue;
			
			//NCR_serie_correlativo (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.NCR_serie_correlativo)
				.NotEmpty().WithMessage("El campo NCR_serie_correlativo es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo NCR_serie_correlativo no puede tener más de 50 caracteres.");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//DNC_pro_descripcion (Tipo C#: string, SQL:varchar(100))
			RuleFor(x => x.DNC_pro_descripcion)
				.NotEmpty().WithMessage("El campo DNC_pro_descripcion es obligatorio.")
				.Must(x => x.Length <= 100).WithMessage("El campo DNC_pro_descripcion no puede tener más de 100 caracteres.");
			//DNC_pro_ume_multiplo (tipo: int)
			RuleFor(x => x.DNC_pro_ume_multiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_pro_ume_multiplo");
			//DNC_cantidad (tipo: int)
			RuleFor(x => x.DNC_cantidad)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_cantidad");
			//DNC_cantidad_submultiplo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.DNC_cantidad_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_cantidad_submultiplo");
			//DNC_precio_unitario (tipo: double)
			RuleFor(x => x.DNC_precio_unitario)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_precio_unitario");
			//DNC_monto_subtotal (tipo: double)
			RuleFor(x => x.DNC_monto_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_monto_subtotal");
			//DNC_monto_descuento (tipo: double)
			RuleFor(x => x.DNC_monto_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_monto_descuento");
			//DNC_porcentaje_descuento (tipo: double)
			RuleFor(x => x.DNC_porcentaje_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_porcentaje_descuento");
			//DNC_monto_igv (tipo: double)
			RuleFor(x => x.DNC_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_monto_igv");
			//DNC_monto_isc (tipo: double)
			RuleFor(x => x.DNC_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_monto_isc");
			//DNC_porcentaje_igv (tipo: double)
			RuleFor(x => x.DNC_porcentaje_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_porcentaje_igv");
			//DNC_porcentaje_isc (tipo: double)
			RuleFor(x => x.DNC_porcentaje_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_porcentaje_isc");
			//DNC_monto_total_linea (tipo: double)
			RuleFor(x => x.DNC_monto_total_linea)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_monto_total_linea");
			//DNC_memo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.DNC_memo??"")
				.Must(x => x.Length <= 50).WithMessage("El campo DNC_memo no puede tener más de 50 caracteres.");
			//DNC_numero_fila (tipo: int)
			RuleFor(x => x.DNC_numero_fila)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DNC_numero_fila");
		}
	}
}
