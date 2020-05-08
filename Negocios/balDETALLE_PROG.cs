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
	public partial class balDETALLE_PROG:AbstractValidator<eDETALLE_PROG>
	{
		private static dalDETALLE_PROG _dalDETALLE_PROG = new dalDETALLE_PROG();
		private static balDETALLE_PROG _balDETALLE_PROG = new balDETALLE_PROG();

		public static bool insertarRegistro(eDETALLE_PROG oeDETALLE_PROG)
		{
			ValidationResult result = _balDETALLE_PROG.Validate(oeDETALLE_PROG);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_PROG.obtenerRegistro(oeDETALLE_PROG).Rows.Count == 0)
				{
					if (_dalDETALLE_PROG.insertarRegistro(oeDETALLE_PROG))
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

		public static bool actualizarRegistro(eDETALLE_PROG oeDETALLE_PROG)
		{
			ValidationResult result = _balDETALLE_PROG.Validate(oeDETALLE_PROG);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalDETALLE_PROG.obtenerRegistro(oeDETALLE_PROG).Rows.Count > 0)
				{
					if (_dalDETALLE_PROG.actualizarRegistro(oeDETALLE_PROG))
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

		public static bool eliminarRegistro(eDETALLE_PROG oeDETALLE_PROG)
		{
			bool flag = false;
			
			if ( _dalDETALLE_PROG.obtenerRegistro(oeDETALLE_PROG).Rows.Count > 0)
			{
				if (_dalDETALLE_PROG.eliminarRegistro(oeDETALLE_PROG))
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

		public static DataTable obtenerRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			if ( _dalDETALLE_PROG.obtenerRegistro(oeDETALLE_PROG).Rows.Count > 0)
			{
				return _dalDETALLE_PROG.obtenerRegistro(oeDETALLE_PROG);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalDETALLE_PROG.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalDETALLE_PROG.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalDETALLE_PROG.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalDETALLE_PROG.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PROG.primerRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_PROG.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalDETALLE_PROG.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PROG.ultimoRegistro().Rows.Count > 0)
				{
					return _dalDETALLE_PROG.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			if(_dalDETALLE_PROG.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PROG.anteriorRegistro(oeDETALLE_PROG).Rows.Count > 0)
				{
					return _dalDETALLE_PROG.anteriorRegistro(oeDETALLE_PROG);
				}
				else
				{
					return _dalDETALLE_PROG.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eDETALLE_PROG oeDETALLE_PROG) {
			if(_dalDETALLE_PROG.poblar().Rows.Count > 0)
			{
				if(_dalDETALLE_PROG.siguienteRegistro(oeDETALLE_PROG).Rows.Count > 0)
				{
					return _dalDETALLE_PROG.siguienteRegistro(oeDETALLE_PROG);
				}
				else
				{
					return _dalDETALLE_PROG.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balDETALLE_PROG()
		{
			CascadeMode = CascadeMode.Continue;
			
			//PRG_fecha (tipo: DateTime)
			//Agregar aquí la validación para PRG_fecha si se desea.
			
			//CHO_codigo (tipo: int)
			RuleFor(x => x.CHO_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para CHO_codigo");
			//DPR_numero_viaje (tipo: int)
			RuleFor(x => x.DPR_numero_viaje)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPR_numero_viaje");
			//DPR_zona_desde (tipo: int)
			RuleFor(x => x.DPR_zona_desde)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPR_zona_desde");
			//DPR_zona_hasta (tipo: int)
			RuleFor(x => x.DPR_zona_hasta)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPR_zona_hasta");
			//DPR_peso (tipo: double)
			RuleFor(x => x.DPR_peso)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPR_peso");
			//DPR_numero_documentos (tipo: int)
			RuleFor(x => x.DPR_numero_documentos)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPR_numero_documentos");
			//DPR_cantidad_producto (tipo: double)
			RuleFor(x => x.DPR_cantidad_producto)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para DPR_cantidad_producto");
			//VEH_placa (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.VEH_placa??"")
				.Must(x => x.Length <= 15).WithMessage("El campo VEH_placa no puede tener más de 15 caracteres.");
		}
	}
}
