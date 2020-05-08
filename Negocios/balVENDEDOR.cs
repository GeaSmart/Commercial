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
	public partial class balVENDEDOR:AbstractValidator<eVENDEDOR>
	{
		private static dalVENDEDOR _dalVENDEDOR = new dalVENDEDOR();
		private static balVENDEDOR _balVENDEDOR = new balVENDEDOR();

		public static bool insertarRegistro(eVENDEDOR oeVENDEDOR)
		{
			ValidationResult result = _balVENDEDOR.Validate(oeVENDEDOR);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVENDEDOR.obtenerRegistro(oeVENDEDOR).Rows.Count == 0)
				{
					if (_dalVENDEDOR.insertarRegistro(oeVENDEDOR))
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

		public static bool actualizarRegistro(eVENDEDOR oeVENDEDOR)
		{
			ValidationResult result = _balVENDEDOR.Validate(oeVENDEDOR);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalVENDEDOR.obtenerRegistro(oeVENDEDOR).Rows.Count > 0)
				{
					if (_dalVENDEDOR.actualizarRegistro(oeVENDEDOR))
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

		public static bool eliminarRegistro(eVENDEDOR oeVENDEDOR)
		{
			bool flag = false;
			
			if ( _dalVENDEDOR.obtenerRegistro(oeVENDEDOR).Rows.Count > 0)
			{
				if (_dalVENDEDOR.eliminarRegistro(oeVENDEDOR))
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

		public static DataTable obtenerRegistro(eVENDEDOR oeVENDEDOR) {
			if ( _dalVENDEDOR.obtenerRegistro(oeVENDEDOR).Rows.Count > 0)
			{
				return _dalVENDEDOR.obtenerRegistro(oeVENDEDOR);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalVENDEDOR.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalVENDEDOR.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalVENDEDOR.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalVENDEDOR.poblar().Rows.Count > 0)
			{
				if(_dalVENDEDOR.primerRegistro().Rows.Count > 0)
				{
					return _dalVENDEDOR.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalVENDEDOR.poblar().Rows.Count > 0)
			{
				if(_dalVENDEDOR.ultimoRegistro().Rows.Count > 0)
				{
					return _dalVENDEDOR.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eVENDEDOR oeVENDEDOR) {
			if(_dalVENDEDOR.poblar().Rows.Count > 0)
			{
				if(_dalVENDEDOR.anteriorRegistro(oeVENDEDOR).Rows.Count > 0)
				{
					return _dalVENDEDOR.anteriorRegistro(oeVENDEDOR);
				}
				else
				{
					return _dalVENDEDOR.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eVENDEDOR oeVENDEDOR) {
			if(_dalVENDEDOR.poblar().Rows.Count > 0)
			{
				if(_dalVENDEDOR.siguienteRegistro(oeVENDEDOR).Rows.Count > 0)
				{
					return _dalVENDEDOR.siguienteRegistro(oeVENDEDOR);
				}
				else
				{
					return _dalVENDEDOR.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balVENDEDOR()
		{
			CascadeMode = CascadeMode.Continue;
			
			//VEN_nombre_completo (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.VEN_nombre_completo)
				.NotEmpty().WithMessage("El campo VEN_nombre_completo es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo VEN_nombre_completo no puede tener más de 150 caracteres.");
			//VEN_dni (Tipo C#: string, SQL:char(8))
			RuleFor(x => x.VEN_dni)
				.NotEmpty().WithMessage("El campo VEN_dni es obligatorio.")
				.Length(8).WithMessage("El campo VEN_dni debe tener 8 caracteres.");
			//VEN_telefono (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.VEN_telefono??"")
				.Must(x => x.Length <= 50).WithMessage("El campo VEN_telefono no puede tener más de 50 caracteres.");
			//VEN_estado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.VEN_estado)
				.NotEmpty().WithMessage("El campo VEN_estado es obligatorio.")
				.Length(1).WithMessage("El campo VEN_estado debe tener 1 caracteres.");
			//VEN_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.VEN_comentario??"")
				.Must(x => x.Length <= 150).WithMessage("El campo VEN_comentario no puede tener más de 150 caracteres.");
			//VEN_imagen (tipo: byte[], Acepta NULL en la BD)

		}
	}
}
