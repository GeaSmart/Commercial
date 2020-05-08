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
	public partial class balPROGRAMACION:AbstractValidator<ePROGRAMACION>
	{
		private static dalPROGRAMACION _dalPROGRAMACION = new dalPROGRAMACION();
		private static balPROGRAMACION _balPROGRAMACION = new balPROGRAMACION();

		public static bool insertarRegistro(ePROGRAMACION oePROGRAMACION)
		{
			ValidationResult result = _balPROGRAMACION.Validate(oePROGRAMACION);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPROGRAMACION.obtenerRegistro(oePROGRAMACION).Rows.Count == 0)
				{
					if (_dalPROGRAMACION.insertarRegistro(oePROGRAMACION))
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

		public static bool actualizarRegistro(ePROGRAMACION oePROGRAMACION)
		{
			ValidationResult result = _balPROGRAMACION.Validate(oePROGRAMACION);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPROGRAMACION.obtenerRegistro(oePROGRAMACION).Rows.Count > 0)
				{
					if (_dalPROGRAMACION.actualizarRegistro(oePROGRAMACION))
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

		public static bool eliminarRegistro(ePROGRAMACION oePROGRAMACION)
		{
			bool flag = false;
			
			if ( _dalPROGRAMACION.obtenerRegistro(oePROGRAMACION).Rows.Count > 0)
			{
				if (_dalPROGRAMACION.eliminarRegistro(oePROGRAMACION))
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

		public static DataTable obtenerRegistro(ePROGRAMACION oePROGRAMACION) {
			if ( _dalPROGRAMACION.obtenerRegistro(oePROGRAMACION).Rows.Count > 0)
			{
				return _dalPROGRAMACION.obtenerRegistro(oePROGRAMACION);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPROGRAMACION.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPROGRAMACION.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPROGRAMACION.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPROGRAMACION.poblar().Rows.Count > 0)
			{
				if(_dalPROGRAMACION.primerRegistro().Rows.Count > 0)
				{
					return _dalPROGRAMACION.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPROGRAMACION.poblar().Rows.Count > 0)
			{
				if(_dalPROGRAMACION.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPROGRAMACION.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePROGRAMACION oePROGRAMACION) {
			if(_dalPROGRAMACION.poblar().Rows.Count > 0)
			{
				if(_dalPROGRAMACION.anteriorRegistro(oePROGRAMACION).Rows.Count > 0)
				{
					return _dalPROGRAMACION.anteriorRegistro(oePROGRAMACION);
				}
				else
				{
					return _dalPROGRAMACION.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePROGRAMACION oePROGRAMACION) {
			if(_dalPROGRAMACION.poblar().Rows.Count > 0)
			{
				if(_dalPROGRAMACION.siguienteRegistro(oePROGRAMACION).Rows.Count > 0)
				{
					return _dalPROGRAMACION.siguienteRegistro(oePROGRAMACION);
				}
				else
				{
					return _dalPROGRAMACION.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPROGRAMACION()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PRG_fecha (tipo: DateTime)
			//Agregar aquí la validación para PRG_fecha si se desea.
			
			//PRG_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.PRG_comentario??"")
				.Must(x => x.Length <= 150).WithMessage("El campo PRG_comentario no puede tener más de 150 caracteres.");
			//PRG_ultima_mod (tipo: DateTime)
			//Agregar aquí la validación para PRG_ultima_mod si se desea.
			
			//PRG_estado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.PRG_estado)
				.NotEmpty().WithMessage("El campo PRG_estado es obligatorio.")
				.Length(1).WithMessage("El campo PRG_estado debe tener 1 caracteres.");
		}
	}
}
