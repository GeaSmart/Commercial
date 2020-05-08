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
	public partial class balCAMBIO:AbstractValidator<eCAMBIO>
	{
		private static dalCAMBIO _dalCAMBIO = new dalCAMBIO();
		private static balCAMBIO _balCAMBIO = new balCAMBIO();

		public static bool insertarRegistro(eCAMBIO oeCAMBIO)
		{
			ValidationResult result = _balCAMBIO.Validate(oeCAMBIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCAMBIO.obtenerRegistro(oeCAMBIO).Rows.Count == 0)
				{
					if (_dalCAMBIO.insertarRegistro(oeCAMBIO))
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

		public static bool actualizarRegistro(eCAMBIO oeCAMBIO)
		{
			ValidationResult result = _balCAMBIO.Validate(oeCAMBIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCAMBIO.obtenerRegistro(oeCAMBIO).Rows.Count > 0)
				{
					if (_dalCAMBIO.actualizarRegistro(oeCAMBIO))
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

		public static bool eliminarRegistro(eCAMBIO oeCAMBIO)
		{
			bool flag = false;
			
			if ( _dalCAMBIO.obtenerRegistro(oeCAMBIO).Rows.Count > 0)
			{
				if (_dalCAMBIO.eliminarRegistro(oeCAMBIO))
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

		public static DataTable obtenerRegistro(eCAMBIO oeCAMBIO) {
			if ( _dalCAMBIO.obtenerRegistro(oeCAMBIO).Rows.Count > 0)
			{
				return _dalCAMBIO.obtenerRegistro(oeCAMBIO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalCAMBIO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalCAMBIO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalCAMBIO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalCAMBIO.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO.primerRegistro().Rows.Count > 0)
				{
					return _dalCAMBIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalCAMBIO.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalCAMBIO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eCAMBIO oeCAMBIO) {
			if(_dalCAMBIO.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO.anteriorRegistro(oeCAMBIO).Rows.Count > 0)
				{
					return _dalCAMBIO.anteriorRegistro(oeCAMBIO);
				}
				else
				{
					return _dalCAMBIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eCAMBIO oeCAMBIO) {
			if(_dalCAMBIO.poblar().Rows.Count > 0)
			{
				if(_dalCAMBIO.siguienteRegistro(oeCAMBIO).Rows.Count > 0)
				{
					return _dalCAMBIO.siguienteRegistro(oeCAMBIO);
				}
				else
				{
					return _dalCAMBIO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balCAMBIO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//CAM_numero (tipo: int)
			RuleFor(x => x.CAM_numero)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para CAM_numero");
			//SOC_codigo (tipo: int)
			RuleFor(x => x.SOC_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_codigo");
			//SOC_nombre_razon (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.SOC_nombre_razon)
				.NotEmpty().WithMessage("El campo SOC_nombre_razon es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo SOC_nombre_razon no puede tener más de 150 caracteres.");
			//MDE_codigo (tipo: int)
			RuleFor(x => x.MDE_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para MDE_codigo");
			//VEN_codigo (tipo: int)
			RuleFor(x => x.VEN_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VEN_codigo");
			//CAM_nombre_vendedor (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.CAM_nombre_vendedor)
				.NotEmpty().WithMessage("El campo CAM_nombre_vendedor es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo CAM_nombre_vendedor no puede tener más de 150 caracteres.");
			//CAM_monto_total (tipo: double)
			RuleFor(x => x.CAM_monto_total)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para CAM_monto_total");
		}
	}
}
