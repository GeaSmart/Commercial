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
	public partial class balDETALLE_PEDIDO:AbstractValidator<eDETALLE_PEDIDO>
	{
		private static dalDETALLE_PEDIDO _dalDETALLE_PEDIDO = new dalDETALLE_PEDIDO();
		private static balDETALLE_PEDIDO _balDETALLE_PEDIDO = new balDETALLE_PEDIDO();

		public static bool insertarRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO)
		{
			ValidationResult result = _balDETALLE_PEDIDO.Validate(oeDETALLE_PEDIDO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_PEDIDO.obtenerRegistro(oeDETALLE_PEDIDO).Rows.Count == 0)
				{
					if (_dalDETALLE_PEDIDO.insertarRegistro(oeDETALLE_PEDIDO))
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

		public static bool actualizarRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO)
		{
			ValidationResult result = _balDETALLE_PEDIDO.Validate(oeDETALLE_PEDIDO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_PEDIDO.obtenerRegistro(oeDETALLE_PEDIDO).Rows.Count > 0)
				{
					if (_dalDETALLE_PEDIDO.actualizarRegistro(oeDETALLE_PEDIDO))
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

		public static bool eliminarRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO)
		{
			bool flag = false;
			
			if ( _dalDETALLE_PEDIDO.obtenerRegistro(oeDETALLE_PEDIDO).Rows.Count > 0)
			{
				if (_dalDETALLE_PEDIDO.eliminarRegistro(oeDETALLE_PEDIDO))
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

		public static DataTable obtenerRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			if ( _dalDETALLE_PEDIDO.obtenerRegistro(oeDETALLE_PEDIDO).Rows.Count > 0)
			{
				return _dalDETALLE_PEDIDO.obtenerRegistro(oeDETALLE_PEDIDO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDETALLE_PEDIDO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDETALLE_PEDIDO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDETALLE_PEDIDO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDETALLE_PEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PEDIDO.primerRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_PEDIDO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDETALLE_PEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PEDIDO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_PEDIDO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			if(_dalDETALLE_PEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PEDIDO.anteriorRegistro(oeDETALLE_PEDIDO).Rows.Count > 0)
				{
					return _dalDETALLE_PEDIDO.anteriorRegistro(oeDETALLE_PEDIDO);
				}
				else
				{
					return _dalDETALLE_PEDIDO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDETALLE_PEDIDO oeDETALLE_PEDIDO) {
			if(_dalDETALLE_PEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PEDIDO.siguienteRegistro(oeDETALLE_PEDIDO).Rows.Count > 0)
				{
					return _dalDETALLE_PEDIDO.siguienteRegistro(oeDETALLE_PEDIDO);
				}
				else
				{
					return _dalDETALLE_PEDIDO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDETALLE_PEDIDO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PED_numero (tipo: int)
			RuleFor(x => x.PED_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_numero");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//DPE_is_bonificacion (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.DPE_is_bonificacion)
				.NotEmpty().WithMessage("El campo DPE_is_bonificacion es obligatorio.")
				.Length(1).WithMessage("El campo DPE_is_bonificacion debe tener 1 caracteres.");
			//DPE_pro_descripcion (Tipo C#: string, SQL:varchar(100))
			RuleFor(x => x.DPE_pro_descripcion)
				.NotEmpty().WithMessage("El campo DPE_pro_descripcion es obligatorio.")
				.Must(x => x.Length <= 100).WithMessage("El campo DPE_pro_descripcion no puede tener más de 100 caracteres.");
			//DPE_pro_ume_multiplo (tipo: int)
			RuleFor(x => x.DPE_pro_ume_multiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_pro_ume_multiplo");
			//DPE_cantidad (tipo: int)
			RuleFor(x => x.DPE_cantidad)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_cantidad");
			//DPE_cantidad_submultiplo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.DPE_cantidad_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_cantidad_submultiplo");
			//DPE_precio_unitario (tipo: double)
			RuleFor(x => x.DPE_precio_unitario)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_precio_unitario");
			//DPE_monto_subtotal (tipo: double)
			RuleFor(x => x.DPE_monto_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_monto_subtotal");
			//DPE_monto_descuento (tipo: double)
			RuleFor(x => x.DPE_monto_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_monto_descuento");
			//DPE_porcentaje_descuento (tipo: double)
			RuleFor(x => x.DPE_porcentaje_descuento)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_porcentaje_descuento");
			//DPE_monto_igv (tipo: double)
			RuleFor(x => x.DPE_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_monto_igv");
			//DPE_monto_isc (tipo: double)
			RuleFor(x => x.DPE_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_monto_isc");
			//DPE_porcentaje_igv (tipo: double)
			RuleFor(x => x.DPE_porcentaje_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_porcentaje_igv");
			//DPE_porcentaje_isc (tipo: double)
			RuleFor(x => x.DPE_porcentaje_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_porcentaje_isc");
			//DPE_monto_total_linea (tipo: double)
			RuleFor(x => x.DPE_monto_total_linea)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_monto_total_linea");
			//DPE_memo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.DPE_memo??"")
				.Must(x => x.Length <= 50).WithMessage("El campo DPE_memo no puede tener más de 50 caracteres.");
			//DPE_numero_fila (tipo: int)
			RuleFor(x => x.DPE_numero_fila)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPE_numero_fila");
		}
	}
}
