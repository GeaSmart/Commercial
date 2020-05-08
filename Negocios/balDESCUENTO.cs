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
	public partial class balDESCUENTO:AbstractValidator<eDESCUENTO>
	{
		private static dalDESCUENTO _dalDESCUENTO = new dalDESCUENTO();
		private static balDESCUENTO _balDESCUENTO = new balDESCUENTO();

		public static bool insertarRegistro(eDESCUENTO oeDESCUENTO)
		{
			ValidationResult result = _balDESCUENTO.Validate(oeDESCUENTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDESCUENTO.obtenerRegistro(oeDESCUENTO).Rows.Count == 0)
				{
					if (_dalDESCUENTO.insertarRegistro(oeDESCUENTO))
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

		public static bool actualizarRegistro(eDESCUENTO oeDESCUENTO)
		{
			ValidationResult result = _balDESCUENTO.Validate(oeDESCUENTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDESCUENTO.obtenerRegistro(oeDESCUENTO).Rows.Count > 0)
				{
					if (_dalDESCUENTO.actualizarRegistro(oeDESCUENTO))
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

		public static bool eliminarRegistro(eDESCUENTO oeDESCUENTO)
		{
			bool flag = false;
			
			if ( _dalDESCUENTO.obtenerRegistro(oeDESCUENTO).Rows.Count > 0)
			{
				if (_dalDESCUENTO.eliminarRegistro(oeDESCUENTO))
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

		public static DataTable obtenerRegistro(eDESCUENTO oeDESCUENTO) {
			if ( _dalDESCUENTO.obtenerRegistro(oeDESCUENTO).Rows.Count > 0)
			{
				return _dalDESCUENTO.obtenerRegistro(oeDESCUENTO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDESCUENTO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDESCUENTO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDESCUENTO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDESCUENTO.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO.primerRegistro().Rows.Count > 0)
				{
					return _dalDESCUENTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDESCUENTO.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDESCUENTO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDESCUENTO oeDESCUENTO) {
			if(_dalDESCUENTO.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO.anteriorRegistro(oeDESCUENTO).Rows.Count > 0)
				{
					return _dalDESCUENTO.anteriorRegistro(oeDESCUENTO);
				}
				else
				{
					return _dalDESCUENTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDESCUENTO oeDESCUENTO) {
			if(_dalDESCUENTO.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO.siguienteRegistro(oeDESCUENTO).Rows.Count > 0)
				{
					return _dalDESCUENTO.siguienteRegistro(oeDESCUENTO);
				}
				else
				{
					return _dalDESCUENTO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDESCUENTO()
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
			//DSC_is_especial (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.DSC_is_especial)
				.NotEmpty().WithMessage("El campo DSC_is_especial es obligatorio.")
				.Length(1).WithMessage("El campo DSC_is_especial debe tener 1 caracteres.");
			//DSC_porcentaje (tipo: double)
			RuleFor(x => x.DSC_porcentaje)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DSC_porcentaje");
			//DSC_esp_porcentaje (tipo: double, Acepta NULL en la BD)
			RuleFor(x => x.DSC_esp_porcentaje)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DSC_esp_porcentaje");
			//DSC_fecha_vencimiento (tipo: DateTime, Acepta NULL en la BD)

		}
	}
}
