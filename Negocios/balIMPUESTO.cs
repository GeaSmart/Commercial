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
	public partial class balIMPUESTO:AbstractValidator<eIMPUESTO>
	{
		private static dalIMPUESTO _dalIMPUESTO = new dalIMPUESTO();
		private static balIMPUESTO _balIMPUESTO = new balIMPUESTO();

		public static bool insertarRegistro(eIMPUESTO oeIMPUESTO)
		{
			ValidationResult result = _balIMPUESTO.Validate(oeIMPUESTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalIMPUESTO.obtenerRegistro(oeIMPUESTO).Rows.Count == 0)
				{
					if (_dalIMPUESTO.insertarRegistro(oeIMPUESTO))
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

		public static bool actualizarRegistro(eIMPUESTO oeIMPUESTO)
		{
			ValidationResult result = _balIMPUESTO.Validate(oeIMPUESTO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalIMPUESTO.obtenerRegistro(oeIMPUESTO).Rows.Count > 0)
				{
					if (_dalIMPUESTO.actualizarRegistro(oeIMPUESTO))
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

		public static bool eliminarRegistro(eIMPUESTO oeIMPUESTO)
		{
			bool flag = false;
			
			if ( _dalIMPUESTO.obtenerRegistro(oeIMPUESTO).Rows.Count > 0)
			{
				if (_dalIMPUESTO.eliminarRegistro(oeIMPUESTO))
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

		public static DataTable obtenerRegistro(eIMPUESTO oeIMPUESTO) {
			if ( _dalIMPUESTO.obtenerRegistro(oeIMPUESTO).Rows.Count > 0)
			{
				return _dalIMPUESTO.obtenerRegistro(oeIMPUESTO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalIMPUESTO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalIMPUESTO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalIMPUESTO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalIMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalIMPUESTO.primerRegistro().Rows.Count > 0)
				{
					return _dalIMPUESTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalIMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalIMPUESTO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalIMPUESTO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eIMPUESTO oeIMPUESTO) {
			if(_dalIMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalIMPUESTO.anteriorRegistro(oeIMPUESTO).Rows.Count > 0)
				{
					return _dalIMPUESTO.anteriorRegistro(oeIMPUESTO);
				}
				else
				{
					return _dalIMPUESTO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eIMPUESTO oeIMPUESTO) {
			if(_dalIMPUESTO.poblar().Rows.Count > 0)
			{
				if(_dalIMPUESTO.siguienteRegistro(oeIMPUESTO).Rows.Count > 0)
				{
					return _dalIMPUESTO.siguienteRegistro(oeIMPUESTO);
				}
				else
				{
					return _dalIMPUESTO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balIMPUESTO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//IMP_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.IMP_codigo)
				.NotEmpty().WithMessage("El campo IMP_codigo es obligatorio.")
				.Length(3).WithMessage("El campo IMP_codigo debe tener 3 caracteres.");
			//IMP_nombre (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.IMP_nombre)
				.NotEmpty().WithMessage("El campo IMP_nombre es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo IMP_nombre no puede tener más de 50 caracteres.");
			//IMP_nombre_corto (Tipo C#: string, SQL:varchar(15))
			RuleFor(x => x.IMP_nombre_corto)
				.NotEmpty().WithMessage("El campo IMP_nombre_corto es obligatorio.")
				.Must(x => x.Length <= 15).WithMessage("El campo IMP_nombre_corto no puede tener más de 15 caracteres.");
		}
	}
}
