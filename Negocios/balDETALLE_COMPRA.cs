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
	public partial class balDETALLE_COMPRA:AbstractValidator<eDETALLE_COMPRA>
	{
		private static dalDETALLE_COMPRA _dalDETALLE_COMPRA = new dalDETALLE_COMPRA();
		private static balDETALLE_COMPRA _balDETALLE_COMPRA = new balDETALLE_COMPRA();

		public static bool insertarRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA)
		{
			ValidationResult result = _balDETALLE_COMPRA.Validate(oeDETALLE_COMPRA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_COMPRA.obtenerRegistro(oeDETALLE_COMPRA).Rows.Count == 0)
				{
					if (_dalDETALLE_COMPRA.insertarRegistro(oeDETALLE_COMPRA))
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

		public static bool actualizarRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA)
		{
			ValidationResult result = _balDETALLE_COMPRA.Validate(oeDETALLE_COMPRA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_COMPRA.obtenerRegistro(oeDETALLE_COMPRA).Rows.Count > 0)
				{
					if (_dalDETALLE_COMPRA.actualizarRegistro(oeDETALLE_COMPRA))
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

		public static bool eliminarRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA)
		{
			bool flag = false;
			
			if ( _dalDETALLE_COMPRA.obtenerRegistro(oeDETALLE_COMPRA).Rows.Count > 0)
			{
				if (_dalDETALLE_COMPRA.eliminarRegistro(oeDETALLE_COMPRA))
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

		public static DataTable obtenerRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			if ( _dalDETALLE_COMPRA.obtenerRegistro(oeDETALLE_COMPRA).Rows.Count > 0)
			{
				return _dalDETALLE_COMPRA.obtenerRegistro(oeDETALLE_COMPRA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDETALLE_COMPRA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDETALLE_COMPRA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDETALLE_COMPRA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDETALLE_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_COMPRA.primerRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_COMPRA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDETALLE_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_COMPRA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_COMPRA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			if(_dalDETALLE_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_COMPRA.anteriorRegistro(oeDETALLE_COMPRA).Rows.Count > 0)
				{
					return _dalDETALLE_COMPRA.anteriorRegistro(oeDETALLE_COMPRA);
				}
				else
				{
					return _dalDETALLE_COMPRA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDETALLE_COMPRA oeDETALLE_COMPRA) {
			if(_dalDETALLE_COMPRA.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_COMPRA.siguienteRegistro(oeDETALLE_COMPRA).Rows.Count > 0)
				{
					return _dalDETALLE_COMPRA.siguienteRegistro(oeDETALLE_COMPRA);
				}
				else
				{
					return _dalDETALLE_COMPRA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDETALLE_COMPRA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//COM_numero (tipo: int)
			RuleFor(x => x.COM_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_numero");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//DCO_is_bonificacion (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.DCO_is_bonificacion)
				.NotEmpty().WithMessage("El campo DCO_is_bonificacion es obligatorio.")
				.Length(1).WithMessage("El campo DCO_is_bonificacion debe tener 1 caracteres.");
			//DCO_pro_descripcion (Tipo C#: string, SQL:varchar(100))
			RuleFor(x => x.DCO_pro_descripcion)
				.NotEmpty().WithMessage("El campo DCO_pro_descripcion es obligatorio.")
				.Must(x => x.Length <= 100).WithMessage("El campo DCO_pro_descripcion no puede tener más de 100 caracteres.");
			//DCO_pro_ume_multiplo (tipo: int)
			RuleFor(x => x.DCO_pro_ume_multiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_pro_ume_multiplo");
			//DCO_cantidad (tipo: int)
			RuleFor(x => x.DCO_cantidad)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_cantidad");
			//DCO_cantidad_submultiplo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.DCO_cantidad_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_cantidad_submultiplo");
			//DCO_precio_unitario (tipo: double)
			RuleFor(x => x.DCO_precio_unitario)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_precio_unitario");
			//DCO_monto_subtotal (tipo: double)
			RuleFor(x => x.DCO_monto_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_monto_subtotal");
			//DCO_monto_descuento (tipo: double)
			RuleFor(x => x.DCO_monto_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_monto_descuento");
			//DCO_porcentaje_descuento (tipo: double)
			RuleFor(x => x.DCO_porcentaje_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_porcentaje_descuento");
			//DCO_monto_igv (tipo: double)
			RuleFor(x => x.DCO_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_monto_igv");
			//DCO_monto_isc (tipo: double)
			RuleFor(x => x.DCO_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_monto_isc");
			//DCO_porcentaje_igv (tipo: double)
			RuleFor(x => x.DCO_porcentaje_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_porcentaje_igv");
			//DCO_porcentaje_isc (tipo: double)
			RuleFor(x => x.DCO_porcentaje_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_porcentaje_isc");
			//DCO_monto_total_linea (tipo: double)
			RuleFor(x => x.DCO_monto_total_linea)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_monto_total_linea");
			//DCO_memo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.DCO_memo??"")
				.Must(x => x.Length <= 50).WithMessage("El campo DCO_memo no puede tener más de 50 caracteres.");
			//DCO_numero_fila (tipo: int)
			RuleFor(x => x.DCO_numero_fila)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCO_numero_fila");
			//DCO_fecha_produccion (tipo: DateTime)
			//Agregar aquí la validación para DCO_fecha_produccion si se desea.
			
			//DCO_fecha_vencimiento (tipo: DateTime)
			//Agregar aquí la validación para DCO_fecha_vencimiento si se desea.
			
		}
	}
}
