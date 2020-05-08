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
	public partial class balZONA:AbstractValidator<eZONA>
	{
		private static dalZONA _dalZONA = new dalZONA();
		private static balZONA _balZONA = new balZONA();

		public static bool insertarRegistro(eZONA oeZONA)
		{
			ValidationResult result = _balZONA.Validate(oeZONA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalZONA.obtenerRegistro(oeZONA).Rows.Count == 0)
				{
					if (_dalZONA.insertarRegistro(oeZONA))
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

		public static bool actualizarRegistro(eZONA oeZONA)
		{
			ValidationResult result = _balZONA.Validate(oeZONA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalZONA.obtenerRegistro(oeZONA).Rows.Count > 0)
				{
					if (_dalZONA.actualizarRegistro(oeZONA))
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

		public static bool eliminarRegistro(eZONA oeZONA)
		{
			bool flag = false;
			
			if ( _dalZONA.obtenerRegistro(oeZONA).Rows.Count > 0)
			{
				if (_dalZONA.eliminarRegistro(oeZONA))
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

		public static DataTable obtenerRegistro(eZONA oeZONA) {
			if ( _dalZONA.obtenerRegistro(oeZONA).Rows.Count > 0)
			{
				return _dalZONA.obtenerRegistro(oeZONA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalZONA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalZONA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalZONA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalZONA.poblar().Rows.Count > 0)
			{
				if(_dalZONA.primerRegistro().Rows.Count > 0)
				{
					return _dalZONA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalZONA.poblar().Rows.Count > 0)
			{
				if(_dalZONA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalZONA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eZONA oeZONA) {
			if(_dalZONA.poblar().Rows.Count > 0)
			{
				if(_dalZONA.anteriorRegistro(oeZONA).Rows.Count > 0)
				{
					return _dalZONA.anteriorRegistro(oeZONA);
				}
				else
				{
					return _dalZONA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eZONA oeZONA) {
			if(_dalZONA.poblar().Rows.Count > 0)
			{
				if(_dalZONA.siguienteRegistro(oeZONA).Rows.Count > 0)
				{
					return _dalZONA.siguienteRegistro(oeZONA);
				}
				else
				{
					return _dalZONA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balZONA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//ZON_codigo (tipo: int)
			RuleFor(x => x.ZON_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para ZON_codigo");
			//ZON_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.ZON_nombre)
				.NotEmpty().WithMessage("El campo ZON_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo ZON_nombre no puede tener más de 50 caracteres.");
			//ZON_descripcion (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.ZON_descripcion??"")
				.Must(x => x.Length <= 150).WithMessage("El campo ZON_descripcion no puede tener más de 150 caracteres.");
			//RUT_codigo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.RUT_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para RUT_codigo");
		}
	}
}
