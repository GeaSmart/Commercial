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
	public partial class balBONIFICACION:AbstractValidator<eBONIFICACION>
	{
		private static dalBONIFICACION _dalBONIFICACION = new dalBONIFICACION();
		private static balBONIFICACION _balBONIFICACION = new balBONIFICACION();

		public static bool insertarRegistro(eBONIFICACION oeBONIFICACION)
		{
			ValidationResult result = _balBONIFICACION.Validate(oeBONIFICACION);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalBONIFICACION.obtenerRegistro(oeBONIFICACION).Rows.Count == 0)
				{
					if (_dalBONIFICACION.insertarRegistro(oeBONIFICACION))
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

		public static bool actualizarRegistro(eBONIFICACION oeBONIFICACION)
		{
			ValidationResult result = _balBONIFICACION.Validate(oeBONIFICACION);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalBONIFICACION.obtenerRegistro(oeBONIFICACION).Rows.Count > 0)
				{
					if (_dalBONIFICACION.actualizarRegistro(oeBONIFICACION))
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

		public static bool eliminarRegistro(eBONIFICACION oeBONIFICACION)
		{
			bool flag = false;
			
			if ( _dalBONIFICACION.obtenerRegistro(oeBONIFICACION).Rows.Count > 0)
			{
				if (_dalBONIFICACION.eliminarRegistro(oeBONIFICACION))
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

		public static DataTable obtenerRegistro(eBONIFICACION oeBONIFICACION) {
			if ( _dalBONIFICACION.obtenerRegistro(oeBONIFICACION).Rows.Count > 0)
			{
				return _dalBONIFICACION.obtenerRegistro(oeBONIFICACION);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalBONIFICACION.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalBONIFICACION.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalBONIFICACION.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalBONIFICACION.poblar().Rows.Count > 0)
			{
				if(_dalBONIFICACION.primerRegistro().Rows.Count > 0)
				{
					return _dalBONIFICACION.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalBONIFICACION.poblar().Rows.Count > 0)
			{
				if(_dalBONIFICACION.ultimoRegistro().Rows.Count > 0)
				{
					return _dalBONIFICACION.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eBONIFICACION oeBONIFICACION) {
			if(_dalBONIFICACION.poblar().Rows.Count > 0)
			{
				if(_dalBONIFICACION.anteriorRegistro(oeBONIFICACION).Rows.Count > 0)
				{
					return _dalBONIFICACION.anteriorRegistro(oeBONIFICACION);
				}
				else
				{
					return _dalBONIFICACION.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eBONIFICACION oeBONIFICACION) {
			if(_dalBONIFICACION.poblar().Rows.Count > 0)
			{
				if(_dalBONIFICACION.siguienteRegistro(oeBONIFICACION).Rows.Count > 0)
				{
					return _dalBONIFICACION.siguienteRegistro(oeBONIFICACION);
				}
				else
				{
					return _dalBONIFICACION.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balBONIFICACION()
		{
			CascadeMode = CascadeMode.Continue;
			
			//CAN_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.CAN_codigo)
				.NotEmpty().WithMessage("El campo CAN_codigo es obligatorio.")
				.Length(3).WithMessage("El campo CAN_codigo debe tener 3 caracteres.");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//BON_is_especial (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.BON_is_especial)
				.NotEmpty().WithMessage("El campo BON_is_especial es obligatorio.")
				.Length(1).WithMessage("El campo BON_is_especial debe tener 1 caracteres.");
			//BON_cantidad_req (tipo: int)
			RuleFor(x => x.BON_cantidad_req)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para BON_cantidad_req");
			//BON_cantidad_req_submultiplo (tipo: int)
			RuleFor(x => x.BON_cantidad_req_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para BON_cantidad_req_submultiplo");
			//BON_cantidad_boni (tipo: int)
			RuleFor(x => x.BON_cantidad_boni)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para BON_cantidad_boni");
			//BON_cantidad_boni_submultiplo (tipo: int)
			RuleFor(x => x.BON_cantidad_boni_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para BON_cantidad_boni_submultiplo");
			//BON_esp_cantidad_boni (tipo: int)
			RuleFor(x => x.BON_esp_cantidad_boni)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para BON_esp_cantidad_boni");
			//BON_esp_cantidad_boni_submultiplo (tipo: int)
			RuleFor(x => x.BON_esp_cantidad_boni_submultiplo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para BON_esp_cantidad_boni_submultiplo");
			//BON_producto (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.BON_producto)
				.NotEmpty().WithMessage("El campo BON_producto es obligatorio.")
				.Length(6).WithMessage("El campo BON_producto debe tener 6 caracteres.");
			//BON_fecha_vencimiento (tipo: DateTime, Acepta NULL en la BD)

		}
	}
}
