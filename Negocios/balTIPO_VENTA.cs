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
	public partial class balTIPO_VENTA:AbstractValidator<eTIPO_VENTA>
	{
		private static dalTIPO_VENTA _dalTIPO_VENTA = new dalTIPO_VENTA();
		private static balTIPO_VENTA _balTIPO_VENTA = new balTIPO_VENTA();

		public static bool insertarRegistro(eTIPO_VENTA oeTIPO_VENTA)
		{
			ValidationResult result = _balTIPO_VENTA.Validate(oeTIPO_VENTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalTIPO_VENTA.obtenerRegistro(oeTIPO_VENTA).Rows.Count == 0)
				{
					if (_dalTIPO_VENTA.insertarRegistro(oeTIPO_VENTA))
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

		public static bool actualizarRegistro(eTIPO_VENTA oeTIPO_VENTA)
		{
			ValidationResult result = _balTIPO_VENTA.Validate(oeTIPO_VENTA);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalTIPO_VENTA.obtenerRegistro(oeTIPO_VENTA).Rows.Count > 0)
				{
					if (_dalTIPO_VENTA.actualizarRegistro(oeTIPO_VENTA))
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

		public static bool eliminarRegistro(eTIPO_VENTA oeTIPO_VENTA)
		{
			bool flag = false;
			
			if ( _dalTIPO_VENTA.obtenerRegistro(oeTIPO_VENTA).Rows.Count > 0)
			{
				if (_dalTIPO_VENTA.eliminarRegistro(oeTIPO_VENTA))
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

		public static DataTable obtenerRegistro(eTIPO_VENTA oeTIPO_VENTA) {
			if ( _dalTIPO_VENTA.obtenerRegistro(oeTIPO_VENTA).Rows.Count > 0)
			{
				return _dalTIPO_VENTA.obtenerRegistro(oeTIPO_VENTA);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalTIPO_VENTA.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalTIPO_VENTA.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalTIPO_VENTA.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalTIPO_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_VENTA.primerRegistro().Rows.Count > 0)
				{
					return _dalTIPO_VENTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalTIPO_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_VENTA.ultimoRegistro().Rows.Count > 0)
				{
					return _dalTIPO_VENTA.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eTIPO_VENTA oeTIPO_VENTA) {
			if(_dalTIPO_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_VENTA.anteriorRegistro(oeTIPO_VENTA).Rows.Count > 0)
				{
					return _dalTIPO_VENTA.anteriorRegistro(oeTIPO_VENTA);
				}
				else
				{
					return _dalTIPO_VENTA.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eTIPO_VENTA oeTIPO_VENTA) {
			if(_dalTIPO_VENTA.poblar().Rows.Count > 0)
			{
				if(_dalTIPO_VENTA.siguienteRegistro(oeTIPO_VENTA).Rows.Count > 0)
				{
					return _dalTIPO_VENTA.siguienteRegistro(oeTIPO_VENTA);
				}
				else
				{
					return _dalTIPO_VENTA.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balTIPO_VENTA()
		{
			CascadeMode = CascadeMode.Continue;
			
			//TVE_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TVE_codigo)
				.NotEmpty().WithMessage("El campo TVE_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TVE_codigo debe tener 3 caracteres.");
			//TVE_descripcion (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.TVE_descripcion)
				.NotEmpty().WithMessage("El campo TVE_descripcion es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo TVE_descripcion no puede tener más de 50 caracteres.");
		}
	}
}
