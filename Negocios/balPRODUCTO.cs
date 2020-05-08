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
	public partial class balPRODUCTO:AbstractValidator<ePRODUCTO>
	{
		private static dalPRODUCTO _dalPRODUCTO = new dalPRODUCTO();
		private static balPRODUCTO _balPRODUCTO = new balPRODUCTO();

		public static bool insertarRegistro(ePRODUCTO oePRODUCTO)
		{
			ValidationResult result = _balPRODUCTO.Validate(oePRODUCTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPRODUCTO.obtenerRegistro(oePRODUCTO).Rows.Count == 0)
				{
					if (_dalPRODUCTO.insertarRegistro(oePRODUCTO))
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

		public static bool actualizarRegistro(ePRODUCTO oePRODUCTO)
		{
			ValidationResult result = _balPRODUCTO.Validate(oePRODUCTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalPRODUCTO.obtenerRegistro(oePRODUCTO).Rows.Count > 0)
				{
					if (_dalPRODUCTO.actualizarRegistro(oePRODUCTO))
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

		public static bool eliminarRegistro(ePRODUCTO oePRODUCTO)
		{
			bool flag = false;
			
			if ( _dalPRODUCTO.obtenerRegistro(oePRODUCTO).Rows.Count > 0)
			{
				if (_dalPRODUCTO.eliminarRegistro(oePRODUCTO))
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

		public static DataTable obtenerRegistro(ePRODUCTO oePRODUCTO) {
			if ( _dalPRODUCTO.obtenerRegistro(oePRODUCTO).Rows.Count > 0)
			{
				return _dalPRODUCTO.obtenerRegistro(oePRODUCTO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalPRODUCTO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalPRODUCTO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalPRODUCTO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalPRODUCTO.poblar().Rows.Count > 0)
			{
				if(_dalPRODUCTO.primerRegistro().Rows.Count > 0)
				{
					return _dalPRODUCTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalPRODUCTO.poblar().Rows.Count > 0)
			{
				if(_dalPRODUCTO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalPRODUCTO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(ePRODUCTO oePRODUCTO) {
			if(_dalPRODUCTO.poblar().Rows.Count > 0)
			{
				if(_dalPRODUCTO.anteriorRegistro(oePRODUCTO).Rows.Count > 0)
				{
					return _dalPRODUCTO.anteriorRegistro(oePRODUCTO);
				}
				else
				{
					return _dalPRODUCTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(ePRODUCTO oePRODUCTO) {
			if(_dalPRODUCTO.poblar().Rows.Count > 0)
			{
				if(_dalPRODUCTO.siguienteRegistro(oePRODUCTO).Rows.Count > 0)
				{
					return _dalPRODUCTO.siguienteRegistro(oePRODUCTO);
				}
				else
				{
					return _dalPRODUCTO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balPRODUCTO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PRO_codigo (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.PRO_codigo)
				.NotEmpty().WithMessage("El campo PRO_codigo es obligatorio.")
				.Length(6).WithMessage("El campo PRO_codigo debe tener 6 caracteres.");
			//PRO_descripcion (Tipo C#: string, SQL:varchar(100))
			RuleFor(x => x.PRO_descripcion)
				.NotEmpty().WithMessage("El campo PRO_descripcion es obligatorio.")
				.Must(x => x.Length <= 100).WithMessage("El campo PRO_descripcion no puede tener más de 100 caracteres.");
			//FOR_codigo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.FOR_codigo??"")
				.Must(x => x.Length <= 15).WithMessage("El campo FOR_codigo no puede tener más de 15 caracteres.");
			//PRO_is_igv (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.PRO_is_igv)
				.NotEmpty().WithMessage("El campo PRO_is_igv es obligatorio.")
				.Length(1).WithMessage("El campo PRO_is_igv debe tener 1 caracteres.");
			//PRO_porcentaje_isc (tipo: double)
			RuleFor(x => x.PRO_porcentaje_isc)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PRO_porcentaje_isc");
			//PRO_peso_kgr (tipo: double)
			RuleFor(x => x.PRO_peso_kgr)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para PRO_peso_kgr");
			//PRO_imagen (tipo: byte[], Acepta NULL en la BD)

			//PRO_is_activo (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.PRO_is_activo)
				.NotEmpty().WithMessage("El campo PRO_is_activo es obligatorio.")
				.Length(1).WithMessage("El campo PRO_is_activo debe tener 1 caracteres.");
			//PRO_is_pack (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.PRO_is_pack)
				.NotEmpty().WithMessage("El campo PRO_is_pack es obligatorio.")
				.Length(1).WithMessage("El campo PRO_is_pack debe tener 1 caracteres.");
			//PRO_codigo_pack (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.PRO_codigo_pack??"")
				.Must(x => x.Length <= 6).WithMessage("El campo PRO_codigo_pack no puede tener más de 6 caracteres.");
			//UME_codigo (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.UME_codigo)
				.NotEmpty().WithMessage("El campo UME_codigo es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo UME_codigo no puede tener más de 15 caracteres.");
			//LIN_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.LIN_codigo)
				.NotEmpty().WithMessage("El campo LIN_codigo es obligatorio.")
				.Length(3).WithMessage("El campo LIN_codigo debe tener 3 caracteres.");
			//MAR_codigo (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.MAR_codigo)
				.NotEmpty().WithMessage("El campo MAR_codigo es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo MAR_codigo no puede tener más de 15 caracteres.");
		}
	}
}
