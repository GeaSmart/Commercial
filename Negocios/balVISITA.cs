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
	public partial class balVISITA:AbstractValidator<eVISITA>
	{
		private static dalVISITA _dalVISITA = new dalVISITA();
		private static balVISITA _balVISITA = new balVISITA();

		public static bool insertarRegistro(eVISITA oeVISITA)
		{
			ValidationResult result = _balVISITA.Validate(oeVISITA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVISITA.obtenerRegistro(oeVISITA).Rows.Count == 0)
				{
					if (_dalVISITA.insertarRegistro(oeVISITA))
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

		public static bool actualizarRegistro(eVISITA oeVISITA)
		{
			ValidationResult result = _balVISITA.Validate(oeVISITA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVISITA.obtenerRegistro(oeVISITA).Rows.Count > 0)
				{
					if (_dalVISITA.actualizarRegistro(oeVISITA))
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

		public static bool eliminarRegistro(eVISITA oeVISITA)
		{
			bool flag = false;
			
			if ( _dalVISITA.obtenerRegistro(oeVISITA).Rows.Count > 0)
			{
				if (_dalVISITA.eliminarRegistro(oeVISITA))
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

		public static DataTable obtenerRegistro(eVISITA oeVISITA) {
			if ( _dalVISITA.obtenerRegistro(oeVISITA).Rows.Count > 0)
			{
				return _dalVISITA.obtenerRegistro(oeVISITA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalVISITA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalVISITA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalVISITA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalVISITA.poblar().Rows.Count > 0)
			{
				if(_dalVISITA.primerRegistro().Rows.Count > 0)
				{
					return _dalVISITA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalVISITA.poblar().Rows.Count > 0)
			{
				if(_dalVISITA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalVISITA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eVISITA oeVISITA) {
			if(_dalVISITA.poblar().Rows.Count > 0)
			{
				if(_dalVISITA.anteriorRegistro(oeVISITA).Rows.Count > 0)
				{
					return _dalVISITA.anteriorRegistro(oeVISITA);
				}
				else
				{
					return _dalVISITA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eVISITA oeVISITA) {
			if(_dalVISITA.poblar().Rows.Count > 0)
			{
				if(_dalVISITA.siguienteRegistro(oeVISITA).Rows.Count > 0)
				{
					return _dalVISITA.siguienteRegistro(oeVISITA);
				}
				else
				{
					return _dalVISITA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balVISITA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//ZON_codigo (tipo: int)
			RuleFor(x => x.ZON_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para ZON_codigo");
			//VEN_codigo (tipo: int)
			RuleFor(x => x.VEN_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VEN_codigo");
			//VIS_dia_semana (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.VIS_dia_semana)
				.NotEmpty().WithMessage("El campo VIS_dia_semana es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo VIS_dia_semana no puede tener más de 15 caracteres.");
			//VIS_cantidad_clientes_activos (tipo: int)
			RuleFor(x => x.VIS_cantidad_clientes_activos)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VIS_cantidad_clientes_activos");
			//VIS_estado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.VIS_estado)
				.NotEmpty().WithMessage("El campo VIS_estado es obligatorio.")
				.Length(1).WithMessage("El campo VIS_estado debe tener 1 caracteres.");
		}
	}
}
