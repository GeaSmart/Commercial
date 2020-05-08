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
	public partial class balMARCA:AbstractValidator<eMARCA>
	{
		private static dalMARCA _dalMARCA = new dalMARCA();
		private static balMARCA _balMARCA = new balMARCA();

		public static bool insertarRegistro(eMARCA oeMARCA)
		{
			ValidationResult result = _balMARCA.Validate(oeMARCA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalMARCA.obtenerRegistro(oeMARCA).Rows.Count == 0)
				{
					if (_dalMARCA.insertarRegistro(oeMARCA))
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

		public static bool actualizarRegistro(eMARCA oeMARCA)
		{
			ValidationResult result = _balMARCA.Validate(oeMARCA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalMARCA.obtenerRegistro(oeMARCA).Rows.Count > 0)
				{
					if (_dalMARCA.actualizarRegistro(oeMARCA))
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

		public static bool eliminarRegistro(eMARCA oeMARCA)
		{
			bool flag = false;
			
			if ( _dalMARCA.obtenerRegistro(oeMARCA).Rows.Count > 0)
			{
				if (_dalMARCA.eliminarRegistro(oeMARCA))
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

		public static DataTable obtenerRegistro(eMARCA oeMARCA) {
			if ( _dalMARCA.obtenerRegistro(oeMARCA).Rows.Count > 0)
			{
				return _dalMARCA.obtenerRegistro(oeMARCA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalMARCA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalMARCA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalMARCA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalMARCA.poblar().Rows.Count > 0)
			{
				if(_dalMARCA.primerRegistro().Rows.Count > 0)
				{
					return _dalMARCA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalMARCA.poblar().Rows.Count > 0)
			{
				if(_dalMARCA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalMARCA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eMARCA oeMARCA) {
			if(_dalMARCA.poblar().Rows.Count > 0)
			{
				if(_dalMARCA.anteriorRegistro(oeMARCA).Rows.Count > 0)
				{
					return _dalMARCA.anteriorRegistro(oeMARCA);
				}
				else
				{
					return _dalMARCA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eMARCA oeMARCA) {
			if(_dalMARCA.poblar().Rows.Count > 0)
			{
				if(_dalMARCA.siguienteRegistro(oeMARCA).Rows.Count > 0)
				{
					return _dalMARCA.siguienteRegistro(oeMARCA);
				}
				else
				{
					return _dalMARCA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balMARCA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//MAR_codigo (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.MAR_codigo)
				.NotEmpty().WithMessage("El campo MAR_codigo es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo MAR_codigo no puede tener más de 15 caracteres.");
			//MAR_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.MAR_nombre)
				.NotEmpty().WithMessage("El campo MAR_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo MAR_nombre no puede tener más de 50 caracteres.");
		}
	}
}
