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
	public partial class balVEHICULO:AbstractValidator<eVEHICULO>
	{
		private static dalVEHICULO _dalVEHICULO = new dalVEHICULO();
		private static balVEHICULO _balVEHICULO = new balVEHICULO();

		public static bool insertarRegistro(eVEHICULO oeVEHICULO)
		{
			ValidationResult result = _balVEHICULO.Validate(oeVEHICULO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVEHICULO.obtenerRegistro(oeVEHICULO).Rows.Count == 0)
				{
					if (_dalVEHICULO.insertarRegistro(oeVEHICULO))
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

		public static bool actualizarRegistro(eVEHICULO oeVEHICULO)
		{
			ValidationResult result = _balVEHICULO.Validate(oeVEHICULO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVEHICULO.obtenerRegistro(oeVEHICULO).Rows.Count > 0)
				{
					if (_dalVEHICULO.actualizarRegistro(oeVEHICULO))
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

		public static bool eliminarRegistro(eVEHICULO oeVEHICULO)
		{
			bool flag = false;
			
			if ( _dalVEHICULO.obtenerRegistro(oeVEHICULO).Rows.Count > 0)
			{
				if (_dalVEHICULO.eliminarRegistro(oeVEHICULO))
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

		public static DataTable obtenerRegistro(eVEHICULO oeVEHICULO) {
			if ( _dalVEHICULO.obtenerRegistro(oeVEHICULO).Rows.Count > 0)
			{
				return _dalVEHICULO.obtenerRegistro(oeVEHICULO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalVEHICULO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalVEHICULO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalVEHICULO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalVEHICULO.poblar().Rows.Count > 0)
			{
				if(_dalVEHICULO.primerRegistro().Rows.Count > 0)
				{
					return _dalVEHICULO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalVEHICULO.poblar().Rows.Count > 0)
			{
				if(_dalVEHICULO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalVEHICULO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eVEHICULO oeVEHICULO) {
			if(_dalVEHICULO.poblar().Rows.Count > 0)
			{
				if(_dalVEHICULO.anteriorRegistro(oeVEHICULO).Rows.Count > 0)
				{
					return _dalVEHICULO.anteriorRegistro(oeVEHICULO);
				}
				else
				{
					return _dalVEHICULO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eVEHICULO oeVEHICULO) {
			if(_dalVEHICULO.poblar().Rows.Count > 0)
			{
				if(_dalVEHICULO.siguienteRegistro(oeVEHICULO).Rows.Count > 0)
				{
					return _dalVEHICULO.siguienteRegistro(oeVEHICULO);
				}
				else
				{
					return _dalVEHICULO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balVEHICULO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//VEH_placa (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.VEH_placa)
				.NotEmpty().WithMessage("El campo VEH_placa es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo VEH_placa no puede tener más de 15 caracteres.");
			//VEH_nombre (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.VEH_nombre??"")
				.Must(x => x.Length <= 50).WithMessage("El campo VEH_nombre no puede tener más de 50 caracteres.");
			//VEH_tonelaje (tipo: double)
			RuleFor(x => x.VEH_tonelaje)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VEH_tonelaje");
		}
	}
}
