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
	public partial class balCAMBIO_DETALLE:AbstractValidator<eCAMBIO_DETALLE>
	{
		private static dalCAMBIO_DETALLE _dalCAMBIO_DETALLE = new dalCAMBIO_DETALLE();
		private static balCAMBIO_DETALLE _balCAMBIO_DETALLE = new balCAMBIO_DETALLE();

		public static bool insertarRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE)
		{
			ValidationResult result = _balCAMBIO_DETALLE.Validate(oeCAMBIO_DETALLE);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCAMBIO_DETALLE.obtenerRegistro(oeCAMBIO_DETALLE).Rows.Count == 0)
				{
					if (_dalCAMBIO_DETALLE.insertarRegistro(oeCAMBIO_DETALLE))
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

		public static bool actualizarRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE)
		{
			ValidationResult result = _balCAMBIO_DETALLE.Validate(oeCAMBIO_DETALLE);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCAMBIO_DETALLE.obtenerRegistro(oeCAMBIO_DETALLE).Rows.Count > 0)
				{
					if (_dalCAMBIO_DETALLE.actualizarRegistro(oeCAMBIO_DETALLE))
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

		public static bool eliminarRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE)
		{
			bool flag = false;
			
			if ( _dalCAMBIO_DETALLE.obtenerRegistro(oeCAMBIO_DETALLE).Rows.Count > 0)
			{
				if (_dalCAMBIO_DETALLE.eliminarRegistro(oeCAMBIO_DETALLE))
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

		public static DataTable obtenerRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			if ( _dalCAMBIO_DETALLE.obtenerRegistro(oeCAMBIO_DETALLE).Rows.Count > 0)
			{
				return _dalCAMBIO_DETALLE.obtenerRegistro(oeCAMBIO_DETALLE);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalCAMBIO_DETALLE.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalCAMBIO_DETALLE.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalCAMBIO_DETALLE.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalCAMBIO_DETALLE.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO_DETALLE.primerRegistro().Rows.Count > 0)
				{
					return _dalCAMBIO_DETALLE.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalCAMBIO_DETALLE.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO_DETALLE.ultimoRegistro().Rows.Count > 0)
				{
					return _dalCAMBIO_DETALLE.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			if(_dalCAMBIO_DETALLE.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO_DETALLE.anteriorRegistro(oeCAMBIO_DETALLE).Rows.Count > 0)
				{
					return _dalCAMBIO_DETALLE.anteriorRegistro(oeCAMBIO_DETALLE);
				}
				else
				{
					return _dalCAMBIO_DETALLE.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eCAMBIO_DETALLE oeCAMBIO_DETALLE) {
			if(_dalCAMBIO_DETALLE.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO_DETALLE.siguienteRegistro(oeCAMBIO_DETALLE).Rows.Count > 0)
				{
					return _dalCAMBIO_DETALLE.siguienteRegistro(oeCAMBIO_DETALLE);
				}
				else
				{
					return _dalCAMBIO_DETALLE.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balCAMBIO_DETALLE()
		{
			CascadeMode = CascadeMode.Continue;
			
			//CAM_numero (tipo: int)
			RuleFor(x => x.CAM_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para CAM_numero");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//DCA_cantidad (tipo: int)
			RuleFor(x => x.DCA_cantidad)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCA_cantidad");
			//DCA_cantidad_submultiplo (tipo: int)
			RuleFor(x => x.DCA_cantidad_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCA_cantidad_submultiplo");
			//DCA_precio_unitario (tipo: double)
			RuleFor(x => x.DCA_precio_unitario)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCA_precio_unitario");
			//DCA_monto_subtotal (tipo: double)
			RuleFor(x => x.DCA_monto_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCA_monto_subtotal");
			//DCA_monto_igv (tipo: double)
			RuleFor(x => x.DCA_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCA_monto_igv");
			//DCA_monto_isc (tipo: double)
			RuleFor(x => x.DCA_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCA_monto_isc");
			//DCA_monto_total (tipo: double)
			RuleFor(x => x.DCA_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DCA_monto_total");
		}
	}
}
