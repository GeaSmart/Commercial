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
	public partial class balSERIE:AbstractValidator<eSERIE>
	{
		private static dalSERIE _dalSERIE = new dalSERIE();
		private static balSERIE _balSERIE = new balSERIE();

		public static bool insertarRegistro(eSERIE oeSERIE)
		{
			ValidationResult result = _balSERIE.Validate(oeSERIE);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalSERIE.obtenerRegistro(oeSERIE).Rows.Count == 0)
				{
					if (_dalSERIE.insertarRegistro(oeSERIE))
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

		public static bool actualizarRegistro(eSERIE oeSERIE)
		{
			ValidationResult result = _balSERIE.Validate(oeSERIE);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalSERIE.obtenerRegistro(oeSERIE).Rows.Count > 0)
				{
					if (_dalSERIE.actualizarRegistro(oeSERIE))
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

		public static bool eliminarRegistro(eSERIE oeSERIE)
		{
			bool flag = false;
			
			if ( _dalSERIE.obtenerRegistro(oeSERIE).Rows.Count > 0)
			{
				if (_dalSERIE.eliminarRegistro(oeSERIE))
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

		public static DataTable obtenerRegistro(eSERIE oeSERIE) {
			if ( _dalSERIE.obtenerRegistro(oeSERIE).Rows.Count > 0)
			{
				return _dalSERIE.obtenerRegistro(oeSERIE);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalSERIE.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalSERIE.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalSERIE.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalSERIE.poblar().Rows.Count > 0)
			{
				if(_dalSERIE.primerRegistro().Rows.Count > 0)
				{
					return _dalSERIE.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalSERIE.poblar().Rows.Count > 0)
			{
				if(_dalSERIE.ultimoRegistro().Rows.Count > 0)
				{
					return _dalSERIE.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eSERIE oeSERIE) {
			if(_dalSERIE.poblar().Rows.Count > 0)
			{
				if(_dalSERIE.anteriorRegistro(oeSERIE).Rows.Count > 0)
				{
					return _dalSERIE.anteriorRegistro(oeSERIE);
				}
				else
				{
					return _dalSERIE.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eSERIE oeSERIE) {
			if(_dalSERIE.poblar().Rows.Count > 0)
			{
				if(_dalSERIE.siguienteRegistro(oeSERIE).Rows.Count > 0)
				{
					return _dalSERIE.siguienteRegistro(oeSERIE);
				}
				else
				{
					return _dalSERIE.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balSERIE()
		{
			CascadeMode = CascadeMode.Continue;
			
			//SER_serie (Tipo C#: string, SQL:varchar(7))
			RuleFor(x => x.SER_serie)
				.NotEmpty().WithMessage("El campo SER_serie es obligatorio.")
				.Must(x => x.Length <= 7).WithMessage("El campo SER_serie no puede tener más de 7 caracteres.");
			//TDO_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TDO_codigo)
				.NotEmpty().WithMessage("El campo TDO_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TDO_codigo debe tener 3 caracteres.");
			//SER_correlativo_actual (tipo: int)
			RuleFor(x => x.SER_correlativo_actual)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SER_correlativo_actual");
			//SER_correlativo_desde (tipo: int)
			RuleFor(x => x.SER_correlativo_desde)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SER_correlativo_desde");
			//SER_correlativo_hasta (tipo: int)
			RuleFor(x => x.SER_correlativo_hasta)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SER_correlativo_hasta");
		}
	}
}
