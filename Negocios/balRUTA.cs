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
	public partial class balRUTA:AbstractValidator<eRUTA>
	{
		private static dalRUTA _dalRUTA = new dalRUTA();
		private static balRUTA _balRUTA = new balRUTA();

		public static bool insertarRegistro(eRUTA oeRUTA)
		{
			ValidationResult result = _balRUTA.Validate(oeRUTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalRUTA.obtenerRegistro(oeRUTA).Rows.Count == 0)
				{
					if (_dalRUTA.insertarRegistro(oeRUTA))
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

		public static bool actualizarRegistro(eRUTA oeRUTA)
		{
			ValidationResult result = _balRUTA.Validate(oeRUTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalRUTA.obtenerRegistro(oeRUTA).Rows.Count > 0)
				{
					if (_dalRUTA.actualizarRegistro(oeRUTA))
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

		public static bool eliminarRegistro(eRUTA oeRUTA)
		{
			bool flag = false;
			
			if ( _dalRUTA.obtenerRegistro(oeRUTA).Rows.Count > 0)
			{
				if (_dalRUTA.eliminarRegistro(oeRUTA))
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

		public static DataTable obtenerRegistro(eRUTA oeRUTA) {
			if ( _dalRUTA.obtenerRegistro(oeRUTA).Rows.Count > 0)
			{
				return _dalRUTA.obtenerRegistro(oeRUTA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalRUTA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalRUTA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalRUTA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalRUTA.poblar().Rows.Count > 0)
			{
				if(_dalRUTA.primerRegistro().Rows.Count > 0)
				{
					return _dalRUTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalRUTA.poblar().Rows.Count > 0)
			{
				if(_dalRUTA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalRUTA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eRUTA oeRUTA) {
			if(_dalRUTA.poblar().Rows.Count > 0)
			{
				if(_dalRUTA.anteriorRegistro(oeRUTA).Rows.Count > 0)
				{
					return _dalRUTA.anteriorRegistro(oeRUTA);
				}
				else
				{
					return _dalRUTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eRUTA oeRUTA) {
			if(_dalRUTA.poblar().Rows.Count > 0)
			{
				if(_dalRUTA.siguienteRegistro(oeRUTA).Rows.Count > 0)
				{
					return _dalRUTA.siguienteRegistro(oeRUTA);
				}
				else
				{
					return _dalRUTA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balRUTA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//RUT_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.RUT_nombre)
				.NotEmpty().WithMessage("El campo RUT_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo RUT_nombre no puede tener más de 50 caracteres.");
		}
	}
}
