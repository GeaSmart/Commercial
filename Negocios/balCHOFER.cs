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
	public partial class balCHOFER:AbstractValidator<eCHOFER>
	{
		private static dalCHOFER _dalCHOFER = new dalCHOFER();
		private static balCHOFER _balCHOFER = new balCHOFER();

		public static bool insertarRegistro(eCHOFER oeCHOFER)
		{
			ValidationResult result = _balCHOFER.Validate(oeCHOFER);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCHOFER.obtenerRegistro(oeCHOFER).Rows.Count == 0)
				{
					if (_dalCHOFER.insertarRegistro(oeCHOFER))
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

		public static bool actualizarRegistro(eCHOFER oeCHOFER)
		{
			ValidationResult result = _balCHOFER.Validate(oeCHOFER);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalCHOFER.obtenerRegistro(oeCHOFER).Rows.Count > 0)
				{
					if (_dalCHOFER.actualizarRegistro(oeCHOFER))
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

		public static bool eliminarRegistro(eCHOFER oeCHOFER)
		{
			bool flag = false;
			
			if ( _dalCHOFER.obtenerRegistro(oeCHOFER).Rows.Count > 0)
			{
				if (_dalCHOFER.eliminarRegistro(oeCHOFER))
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

		public static DataTable obtenerRegistro(eCHOFER oeCHOFER) {
			if ( _dalCHOFER.obtenerRegistro(oeCHOFER).Rows.Count > 0)
			{
				return _dalCHOFER.obtenerRegistro(oeCHOFER);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalCHOFER.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalCHOFER.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalCHOFER.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalCHOFER.poblar().Rows.Count > 0)
			{
				if(_dalCHOFER.primerRegistro().Rows.Count > 0)
				{
					return _dalCHOFER.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalCHOFER.poblar().Rows.Count > 0)
			{
				if(_dalCHOFER.ultimoRegistro().Rows.Count > 0)
				{
					return _dalCHOFER.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eCHOFER oeCHOFER) {
			if(_dalCHOFER.poblar().Rows.Count > 0)
			{
				if(_dalCHOFER.anteriorRegistro(oeCHOFER).Rows.Count > 0)
				{
					return _dalCHOFER.anteriorRegistro(oeCHOFER);
				}
				else
				{
					return _dalCHOFER.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eCHOFER oeCHOFER) {
			if(_dalCHOFER.poblar().Rows.Count > 0)
			{
				if(_dalCHOFER.siguienteRegistro(oeCHOFER).Rows.Count > 0)
				{
					return _dalCHOFER.siguienteRegistro(oeCHOFER);
				}
				else
				{
					return _dalCHOFER.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balCHOFER()
		{
			CascadeMode = CascadeMode.Continue;
			
			//CHO_nombre_completo (Tipo C#: string, SQL:varchar(150))
			RuleFor(x => x.CHO_nombre_completo)
				.NotEmpty().WithMessage("El campo CHO_nombre_completo es obligatorio.")
				.Must(x => x.Length <= 150).WithMessage("El campo CHO_nombre_completo no puede tener más de 150 caracteres.");
			//CHO_dni (Tipo C#: string, SQL:char(8))
			RuleFor(x => x.CHO_dni)
				.NotEmpty().WithMessage("El campo CHO_dni es obligatorio.")
				.Length(8).WithMessage("El campo CHO_dni debe tener 8 caracteres.");
			//VEH_placa (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.VEH_placa)
				.NotEmpty().WithMessage("El campo VEH_placa es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo VEH_placa no puede tener más de 15 caracteres.");
			//CHO_licencia_conducir (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.CHO_licencia_conducir)
				.NotEmpty().WithMessage("El campo CHO_licencia_conducir es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo CHO_licencia_conducir no puede tener más de 50 caracteres.");
		}
	}
}
