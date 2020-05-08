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
	public partial class balDESCUENTO_P:AbstractValidator<eDESCUENTO_P>
	{
		private static dalDESCUENTO_P _dalDESCUENTO_P = new dalDESCUENTO_P();
		private static balDESCUENTO_P _balDESCUENTO_P = new balDESCUENTO_P();

		public static bool insertarRegistro(eDESCUENTO_P oeDESCUENTO_P)
		{
			ValidationResult result = _balDESCUENTO_P.Validate(oeDESCUENTO_P);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDESCUENTO_P.obtenerRegistro(oeDESCUENTO_P).Rows.Count == 0)
				{
					if (_dalDESCUENTO_P.insertarRegistro(oeDESCUENTO_P))
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

		public static bool actualizarRegistro(eDESCUENTO_P oeDESCUENTO_P)
		{
			ValidationResult result = _balDESCUENTO_P.Validate(oeDESCUENTO_P);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDESCUENTO_P.obtenerRegistro(oeDESCUENTO_P).Rows.Count > 0)
				{
					if (_dalDESCUENTO_P.actualizarRegistro(oeDESCUENTO_P))
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

		public static bool eliminarRegistro(eDESCUENTO_P oeDESCUENTO_P)
		{
			bool flag = false;
			
			if ( _dalDESCUENTO_P.obtenerRegistro(oeDESCUENTO_P).Rows.Count > 0)
			{
				if (_dalDESCUENTO_P.eliminarRegistro(oeDESCUENTO_P))
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

		public static DataTable obtenerRegistro(eDESCUENTO_P oeDESCUENTO_P) {
			if ( _dalDESCUENTO_P.obtenerRegistro(oeDESCUENTO_P).Rows.Count > 0)
			{
				return _dalDESCUENTO_P.obtenerRegistro(oeDESCUENTO_P);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDESCUENTO_P.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDESCUENTO_P.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDESCUENTO_P.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDESCUENTO_P.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO_P.primerRegistro().Rows.Count > 0)
				{
					return _dalDESCUENTO_P.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDESCUENTO_P.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO_P.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDESCUENTO_P.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDESCUENTO_P oeDESCUENTO_P) {
			if(_dalDESCUENTO_P.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO_P.anteriorRegistro(oeDESCUENTO_P).Rows.Count > 0)
				{
					return _dalDESCUENTO_P.anteriorRegistro(oeDESCUENTO_P);
				}
				else
				{
					return _dalDESCUENTO_P.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDESCUENTO_P oeDESCUENTO_P) {
			if(_dalDESCUENTO_P.poblar().Rows.Count > 0)
			{
				if(_dalDESCUENTO_P.siguienteRegistro(oeDESCUENTO_P).Rows.Count > 0)
				{
					return _dalDESCUENTO_P.siguienteRegistro(oeDESCUENTO_P);
				}
				else
				{
					return _dalDESCUENTO_P.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDESCUENTO_P()
		{
			CascadeMode = CascadeMode.Continue;
			
			//SOC_codigo (tipo: int)
			RuleFor(x => x.SOC_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_codigo");
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//DSC_porcentaje (tipo: double)
			RuleFor(x => x.DSC_porcentaje)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DSC_porcentaje");
		}
	}
}
