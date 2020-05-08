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
	public partial class balREGLA:AbstractValidator<eREGLA>
	{
		private static dalREGLA _dalREGLA = new dalREGLA();
		private static balREGLA _balREGLA = new balREGLA();

		public static bool insertarRegistro(eREGLA oeREGLA)
		{
			ValidationResult result = _balREGLA.Validate(oeREGLA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalREGLA.obtenerRegistro(oeREGLA).Rows.Count == 0)
				{
					if (_dalREGLA.insertarRegistro(oeREGLA))
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

		public static bool actualizarRegistro(eREGLA oeREGLA)
		{
			ValidationResult result = _balREGLA.Validate(oeREGLA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalREGLA.obtenerRegistro(oeREGLA).Rows.Count > 0)
				{
					if (_dalREGLA.actualizarRegistro(oeREGLA))
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

		public static bool eliminarRegistro(eREGLA oeREGLA)
		{
			bool flag = false;
			
			if ( _dalREGLA.obtenerRegistro(oeREGLA).Rows.Count > 0)
			{
				if (_dalREGLA.eliminarRegistro(oeREGLA))
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

		public static DataTable obtenerRegistro(eREGLA oeREGLA) {
			if ( _dalREGLA.obtenerRegistro(oeREGLA).Rows.Count > 0)
			{
				return _dalREGLA.obtenerRegistro(oeREGLA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalREGLA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalREGLA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalREGLA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalREGLA.poblar().Rows.Count > 0)
			{
				if(_dalREGLA.primerRegistro().Rows.Count > 0)
				{
					return _dalREGLA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalREGLA.poblar().Rows.Count > 0)
			{
				if(_dalREGLA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalREGLA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eREGLA oeREGLA) {
			if(_dalREGLA.poblar().Rows.Count > 0)
			{
				if(_dalREGLA.anteriorRegistro(oeREGLA).Rows.Count > 0)
				{
					return _dalREGLA.anteriorRegistro(oeREGLA);
				}
				else
				{
					return _dalREGLA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eREGLA oeREGLA) {
			if(_dalREGLA.poblar().Rows.Count > 0)
			{
				if(_dalREGLA.siguienteRegistro(oeREGLA).Rows.Count > 0)
				{
					return _dalREGLA.siguienteRegistro(oeREGLA);
				}
				else
				{
					return _dalREGLA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balREGLA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//REG_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.REG_nombre)
				.NotEmpty().WithMessage("El campo REG_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo REG_nombre no puede tener más de 50 caracteres.");
			//REG_descripcion (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.REG_descripcion??"")
				.Must(x => x.Length <= 150).WithMessage("El campo REG_descripcion no puede tener más de 150 caracteres.");
			//REG_tabla (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.REG_tabla??"")
				.Must(x => x.Length <= 50).WithMessage("El campo REG_tabla no puede tener más de 50 caracteres.");
		}
	}
}
