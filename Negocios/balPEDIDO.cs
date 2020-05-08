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
	public partial class balPEDIDO:AbstractValidator<ePEDIDO>
	{
		private static dalPEDIDO _dalPEDIDO = new dalPEDIDO();
		private static balPEDIDO _balPEDIDO = new balPEDIDO();

		public static bool insertarRegistro(ePEDIDO oePEDIDO)
		{
			ValidationResult result = _balPEDIDO.Validate(oePEDIDO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPEDIDO.obtenerRegistro(oePEDIDO).Rows.Count == 0)
				{
					if (_dalPEDIDO.insertarRegistro(oePEDIDO))
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

		public static bool actualizarRegistro(ePEDIDO oePEDIDO)
		{
			ValidationResult result = _balPEDIDO.Validate(oePEDIDO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPEDIDO.obtenerRegistro(oePEDIDO).Rows.Count > 0)
				{
					if (_dalPEDIDO.actualizarRegistro(oePEDIDO))
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

		public static bool eliminarRegistro(ePEDIDO oePEDIDO)
		{
			bool flag = false;
			
			if ( _dalPEDIDO.obtenerRegistro(oePEDIDO).Rows.Count > 0)
			{
				if (_dalPEDIDO.eliminarRegistro(oePEDIDO))
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

		public static DataTable obtenerRegistro(ePEDIDO oePEDIDO) {
			if ( _dalPEDIDO.obtenerRegistro(oePEDIDO).Rows.Count > 0)
			{
				return _dalPEDIDO.obtenerRegistro(oePEDIDO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPEDIDO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPEDIDO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPEDIDO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalPEDIDO.primerRegistro().Rows.Count > 0)
				{
					return _dalPEDIDO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalPEDIDO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPEDIDO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePEDIDO oePEDIDO) {
			if(_dalPEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalPEDIDO.anteriorRegistro(oePEDIDO).Rows.Count > 0)
				{
					return _dalPEDIDO.anteriorRegistro(oePEDIDO);
				}
				else
				{
					return _dalPEDIDO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePEDIDO oePEDIDO) {
			if(_dalPEDIDO.poblar().Rows.Count > 0)
			{
				if(_dalPEDIDO.siguienteRegistro(oePEDIDO).Rows.Count > 0)
				{
					return _dalPEDIDO.siguienteRegistro(oePEDIDO);
				}
				else
				{
					return _dalPEDIDO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPEDIDO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PED_numero (tipo: int)
			RuleFor(x => x.PED_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_numero");
			//PED_fecha (tipo: DateTime)
			//Agregar aquí la validación para PED_fecha si se desea.
			
			//PED_fecha_entrega (tipo: DateTime)
			//Agregar aquí la validación para PED_fecha_entrega si se desea.
			
			//VEN_codigo (tipo: int)
			RuleFor(x => x.VEN_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VEN_codigo");
			//PED_nombre_vendedor (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.PED_nombre_vendedor)
				.NotEmpty().WithMessage("El campo PED_nombre_vendedor es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo PED_nombre_vendedor no puede tener más de 150 caracteres.");
			//SOC_codigo (tipo: int)
			RuleFor(x => x.SOC_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_codigo");
			//PED_soc_nombre_razon (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.PED_soc_nombre_razon)
				.NotEmpty().WithMessage("El campo PED_soc_nombre_razon es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo PED_soc_nombre_razon no puede tener más de 150 caracteres.");
			//PED_soc_direccion (Tipo C#: string, SQL:varchar(250))
			RuleFor(x => x.PED_soc_direccion)
				.NotEmpty().WithMessage("El campo PED_soc_direccion es obligatorio.")
				.Must(x => x.Length <= 250).WithMessage("El campo PED_soc_direccion no puede tener más de 250 caracteres.");
			//PED_soc_zona (tipo: int)
			RuleFor(x => x.PED_soc_zona)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_soc_zona");
			//PED_subtotal (tipo: double)
			RuleFor(x => x.PED_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_subtotal");
			//PED_porcentaje_percepcion (tipo: double)
			RuleFor(x => x.PED_porcentaje_percepcion)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_porcentaje_percepcion");
			//PED_monto_igv (tipo: double)
			RuleFor(x => x.PED_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_monto_igv");
			//PED_monto_isc (tipo: double)
			RuleFor(x => x.PED_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_monto_isc");
			//PED_monto_percepcion (tipo: double)
			RuleFor(x => x.PED_monto_percepcion)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_monto_percepcion");
			//PED_monto_total (tipo: double)
			RuleFor(x => x.PED_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PED_monto_total");
			//PED_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.PED_comentario??"")
				.Must(x => x.Length <= 150).WithMessage("El campo PED_comentario no puede tener más de 150 caracteres.");
			//PED_estado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.PED_estado)
				.NotEmpty().WithMessage("El campo PED_estado es obligatorio.")
				.Length(1).WithMessage("El campo PED_estado debe tener 1 caracteres.");
			//CPA_codigo (Tipo C#: string, SQL:varchar(10))
			RuleFor(x => x.CPA_codigo)
				.NotEmpty().WithMessage("El campo CPA_codigo es obligatorio.")
				.Must(x => x.Length <= 10).WithMessage("El campo CPA_codigo no puede tener más de 10 caracteres.");
			//PED_tdo_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.PED_tdo_codigo)
				.NotEmpty().WithMessage("El campo PED_tdo_codigo es obligatorio.")
				.Length(3).WithMessage("El campo PED_tdo_codigo debe tener 3 caracteres.");
		}
	}
}
