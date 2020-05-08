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
	public partial class balCOMPRA:AbstractValidator<eCOMPRA>
	{
		private static dalCOMPRA _dalCOMPRA = new dalCOMPRA();
		private static balCOMPRA _balCOMPRA = new balCOMPRA();

		public static bool insertarRegistro(eCOMPRA oeCOMPRA)
		{
			ValidationResult result = _balCOMPRA.Validate(oeCOMPRA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCOMPRA.obtenerRegistro(oeCOMPRA).Rows.Count == 0)
				{
					if (_dalCOMPRA.insertarRegistro(oeCOMPRA))
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

		public static bool actualizarRegistro(eCOMPRA oeCOMPRA)
		{
			ValidationResult result = _balCOMPRA.Validate(oeCOMPRA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCOMPRA.obtenerRegistro(oeCOMPRA).Rows.Count > 0)
				{
					if (_dalCOMPRA.actualizarRegistro(oeCOMPRA))
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

		public static bool eliminarRegistro(eCOMPRA oeCOMPRA)
		{
			bool flag = false;
			
			if ( _dalCOMPRA.obtenerRegistro(oeCOMPRA).Rows.Count > 0)
			{
				if (_dalCOMPRA.eliminarRegistro(oeCOMPRA))
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

		public static DataTable obtenerRegistro(eCOMPRA oeCOMPRA) {
			if ( _dalCOMPRA.obtenerRegistro(oeCOMPRA).Rows.Count > 0)
			{
				return _dalCOMPRA.obtenerRegistro(oeCOMPRA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalCOMPRA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalCOMPRA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalCOMPRA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalCOMPRA.poblar().Rows.Count > 0)
			{
				if(_dalCOMPRA.primerRegistro().Rows.Count > 0)
				{
					return _dalCOMPRA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalCOMPRA.poblar().Rows.Count > 0)
			{
				if(_dalCOMPRA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalCOMPRA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eCOMPRA oeCOMPRA) {
			if(_dalCOMPRA.poblar().Rows.Count > 0)
			{
				if(_dalCOMPRA.anteriorRegistro(oeCOMPRA).Rows.Count > 0)
				{
					return _dalCOMPRA.anteriorRegistro(oeCOMPRA);
				}
				else
				{
					return _dalCOMPRA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eCOMPRA oeCOMPRA) {
			if(_dalCOMPRA.poblar().Rows.Count > 0)
			{
				if(_dalCOMPRA.siguienteRegistro(oeCOMPRA).Rows.Count > 0)
				{
					return _dalCOMPRA.siguienteRegistro(oeCOMPRA);
				}
				else
				{
					return _dalCOMPRA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balCOMPRA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//COM_fecha_documento_origen (tipo: DateTime)
			//Agregar aquí la validación para COM_fecha_documento_origen si se desea.
			
			//COM_fecha_vencimiento (tipo: DateTime)
			//Agregar aquí la validación para COM_fecha_vencimiento si se desea.
			
			//COM_documento_origen (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.COM_documento_origen)
				.NotEmpty().WithMessage("El campo COM_documento_origen es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo COM_documento_origen no puede tener más de 25 caracteres.");
			//COM_tipo_documento (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.COM_tipo_documento)
				.NotEmpty().WithMessage("El campo COM_tipo_documento es obligatorio.")
				.Length(3).WithMessage("El campo COM_tipo_documento debe tener 3 caracteres.");
			//SOC_codigo (tipo: int)
			RuleFor(x => x.SOC_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_codigo");
			//COM_soc_nombre_razon (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.COM_soc_nombre_razon)
				.NotEmpty().WithMessage("El campo COM_soc_nombre_razon es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo COM_soc_nombre_razon no puede tener más de 150 caracteres.");
			//COM_subtotal (tipo: double)
			RuleFor(x => x.COM_subtotal)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_subtotal");
			//COM_porcentaje_percepcion (tipo: double)
			RuleFor(x => x.COM_porcentaje_percepcion)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_porcentaje_percepcion");
			//COM_monto_igv (tipo: double)
			RuleFor(x => x.COM_monto_igv)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_monto_igv");
			//COM_monto_isc (tipo: double)
			RuleFor(x => x.COM_monto_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_monto_isc");
			//COM_monto_percepcion (tipo: double)
			RuleFor(x => x.COM_monto_percepcion)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_monto_percepcion");
			//COM_monto_total (tipo: double)
			RuleFor(x => x.COM_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para COM_monto_total");
			//COM_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.COM_comentario??"")
				.Must(x => x.Length <= 250).WithMessage("El campo COM_comentario no puede tener más de 250 caracteres.");
			//COM_estado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.COM_estado)
				.NotEmpty().WithMessage("El campo COM_estado es obligatorio.")
				.Length(1).WithMessage("El campo COM_estado debe tener 1 caracteres.");
		}
	}
}
