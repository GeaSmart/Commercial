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
	public partial class balSOCIO:AbstractValidator<eSOCIO>
	{
		private static dalSOCIO _dalSOCIO = new dalSOCIO();
		private static balSOCIO _balSOCIO = new balSOCIO();

		public static bool insertarRegistro(eSOCIO oeSOCIO)
		{
			ValidationResult result = _balSOCIO.Validate(oeSOCIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalSOCIO.obtenerRegistro(oeSOCIO).Rows.Count == 0)
				{
					if (_dalSOCIO.insertarRegistro(oeSOCIO))
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

		public static bool actualizarRegistro(eSOCIO oeSOCIO)
		{
			ValidationResult result = _balSOCIO.Validate(oeSOCIO);
			bool flag = false;
			if (result.IsValid)
			{
				if ( _dalSOCIO.obtenerRegistro(oeSOCIO).Rows.Count > 0)
				{
					if (_dalSOCIO.actualizarRegistro(oeSOCIO))
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

		public static bool eliminarRegistro(eSOCIO oeSOCIO)
		{
			bool flag = false;
			
			if ( _dalSOCIO.obtenerRegistro(oeSOCIO).Rows.Count > 0)
			{
				if (_dalSOCIO.eliminarRegistro(oeSOCIO))
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

		public static DataTable obtenerRegistro(eSOCIO oeSOCIO) {
			if ( _dalSOCIO.obtenerRegistro(oeSOCIO).Rows.Count > 0)
			{
				return _dalSOCIO.obtenerRegistro(oeSOCIO);
			}
			else
			return null;
		}

		public static DataTable poblar(){
			return _dalSOCIO.poblar();
		}

		public static DataTable buscarRegistro(string cadena) {
			if (_dalSOCIO.buscarRegistro(cadena).Rows.Count > 0)
			{
				return _dalSOCIO.buscarRegistro(cadena);
			}
			else
			return null;
		}

		public static DataTable primerRegistro() {
			if(_dalSOCIO.poblar().Rows.Count > 0)
			{
				if(_dalSOCIO.primerRegistro().Rows.Count > 0)
				{
					return _dalSOCIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable ultimoRegistro() {
			if(_dalSOCIO.poblar().Rows.Count > 0)
			{
				if(_dalSOCIO.ultimoRegistro().Rows.Count > 0)
				{
					return _dalSOCIO.ultimoRegistro();
				}
			}
			return null;
		}

		public static DataTable anteriorRegistro(eSOCIO oeSOCIO) {
			if(_dalSOCIO.poblar().Rows.Count > 0)
			{
				if(_dalSOCIO.anteriorRegistro(oeSOCIO).Rows.Count > 0)
				{
					return _dalSOCIO.anteriorRegistro(oeSOCIO);
				}
				else
				{
					return _dalSOCIO.primerRegistro();
				}
			}
			return null;
		}

		public static DataTable siguienteRegistro(eSOCIO oeSOCIO) {
			if(_dalSOCIO.poblar().Rows.Count > 0)
			{
				if(_dalSOCIO.siguienteRegistro(oeSOCIO).Rows.Count > 0)
				{
					return _dalSOCIO.siguienteRegistro(oeSOCIO);
				}
				else
				{
					return _dalSOCIO.ultimoRegistro();
				}
			}
			return null;
		}

		//El constructor de la clase se emplea para validación, importar FluentValidation.dll como referencia
		public balSOCIO()
		{
			CascadeMode = CascadeMode.Continue;
			
			//SOC_tipo_socio (Tipo C#: string, SQL:varchar(50))
			RuleFor(x => x.SOC_tipo_socio)
				.NotEmpty().WithMessage("El campo SOC_tipo_socio es obligatorio.")
				.Must(x => x.Length <= 50).WithMessage("El campo SOC_tipo_socio no puede tener más de 50 caracteres.");
			//SOC_nombre_razon_social (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_nombre_razon_social??"")
				.Must(x => x.Length <= 150).WithMessage("El campo SOC_nombre_razon_social no puede tener más de 150 caracteres.");
			//SOC_apellido_paterno (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_apellido_paterno??"")
				.Must(x => x.Length <= 50).WithMessage("El campo SOC_apellido_paterno no puede tener más de 50 caracteres.");
			//SOC_apellido_materno (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_apellido_materno??"")
				.Must(x => x.Length <= 50).WithMessage("El campo SOC_apellido_materno no puede tener más de 50 caracteres.");
			//SOC_nombres (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_nombres??"")
				.Must(x => x.Length <= 50).WithMessage("El campo SOC_nombres no puede tener más de 50 caracteres.");
			//SOC_numero_documento (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.SOC_numero_documento)
				.NotEmpty().WithMessage("El campo SOC_numero_documento es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo SOC_numero_documento no puede tener más de 25 caracteres.");
			//SOC_direccion (Tipo C#: string, SQL:varchar(250))
			RuleFor(x => x.SOC_direccion)
				.NotEmpty().WithMessage("El campo SOC_direccion es obligatorio.")
				.Must(x => x.Length <= 250).WithMessage("El campo SOC_direccion no puede tener más de 250 caracteres.");
			//SOC_referencia_direccion (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_referencia_direccion??"")
				.Must(x => x.Length <= 150).WithMessage("El campo SOC_referencia_direccion no puede tener más de 150 caracteres.");
			//SOC_telefono_fijo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_telefono_fijo??"")
				.Must(x => x.Length <= 15).WithMessage("El campo SOC_telefono_fijo no puede tener más de 15 caracteres.");
			//SOC_telefono_movil (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_telefono_movil??"")
				.Must(x => x.Length <= 15).WithMessage("El campo SOC_telefono_movil no puede tener más de 15 caracteres.");
			//SOC_email (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_email??"")
				.Must(x => x.Length <= 50).WithMessage("El campo SOC_email no puede tener más de 50 caracteres.");
			//SOC_web (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_web??"")
				.Must(x => x.Length <= 50).WithMessage("El campo SOC_web no puede tener más de 50 caracteres.");
			//SOC_is_agente_retencion (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.SOC_is_agente_retencion)
				.NotEmpty().WithMessage("El campo SOC_is_agente_retencion es obligatorio.")
				.Length(1).WithMessage("El campo SOC_is_agente_retencion debe tener 1 caracteres.");
			//SOC_is_agente_percepcion (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.SOC_is_agente_percepcion)
				.NotEmpty().WithMessage("El campo SOC_is_agente_percepcion es obligatorio.")
				.Length(1).WithMessage("El campo SOC_is_agente_percepcion debe tener 1 caracteres.");
			//SOC_porcentaje_percepcion (tipo: double, Acepta NULL en la BD)
			RuleFor(x => x.SOC_porcentaje_percepcion)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_porcentaje_percepcion");
			//SOC_is_validar_bonificacion (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.SOC_is_validar_bonificacion)
				.NotEmpty().WithMessage("El campo SOC_is_validar_bonificacion es obligatorio.")
				.Length(1).WithMessage("El campo SOC_is_validar_bonificacion debe tener 1 caracteres.");
			//SOC_is_bonificacion_personalizada (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.SOC_is_bonificacion_personalizada)
				.NotEmpty().WithMessage("El campo SOC_is_bonificacion_personalizada es obligatorio.")
				.Length(1).WithMessage("El campo SOC_is_bonificacion_personalizada debe tener 1 caracteres.");
			//SOC_is_descuento_personalizado (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.SOC_is_descuento_personalizado)
				.NotEmpty().WithMessage("El campo SOC_is_descuento_personalizado es obligatorio.")
				.Length(1).WithMessage("El campo SOC_is_descuento_personalizado debe tener 1 caracteres.");
			//SOC_is_key_account (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.SOC_is_key_account)
				.NotEmpty().WithMessage("El campo SOC_is_key_account es obligatorio.")
				.Length(1).WithMessage("El campo SOC_is_key_account debe tener 1 caracteres.");
			//SOC_dias_credito (tipo: int)
			RuleFor(x => x.SOC_dias_credito)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_dias_credito");
			//SOC_fecha_registro (tipo: DateTime)
			//Agregar aquí la validación para SOC_fecha_registro si se desea.
			
			//SOC_linea_credito (tipo: double)
			RuleFor(x => x.SOC_linea_credito)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_linea_credito");
			//SOC_tipo_persona (Tipo C#: string, SQL:varchar(25))
			RuleFor(x => x.SOC_tipo_persona)
				.NotEmpty().WithMessage("El campo SOC_tipo_persona es obligatorio.")
				.Must(x => x.Length <= 25).WithMessage("El campo SOC_tipo_persona no puede tener más de 25 caracteres.");
			//SOC_is_activo (Tipo C#: string, SQL:char(1))
			RuleFor(x => x.SOC_is_activo)
				.NotEmpty().WithMessage("El campo SOC_is_activo es obligatorio.")
				.Length(1).WithMessage("El campo SOC_is_activo debe tener 1 caracteres.");
			//SOC_comentario (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.SOC_comentario??"")
				.Must(x => x.Length <= 500).WithMessage("El campo SOC_comentario no puede tener más de 500 caracteres.");
			//SOC_tipo_documento_identidad (Tipo C#: string, SQL:varchar(35))
			RuleFor(x => x.SOC_tipo_documento_identidad)
				.NotEmpty().WithMessage("El campo SOC_tipo_documento_identidad es obligatorio.")
				.Must(x => x.Length <= 35).WithMessage("El campo SOC_tipo_documento_identidad no puede tener más de 35 caracteres.");
			//SOC_latitud (tipo: double, Acepta NULL en la BD)
			RuleFor(x => x.SOC_latitud)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_latitud");
			//SOC_longitud (tipo: double, Acepta NULL en la BD)
			RuleFor(x => x.SOC_longitud)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para SOC_longitud");
			//LPR_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.LPR_codigo)
				.NotEmpty().WithMessage("El campo LPR_codigo es obligatorio.")
				.Length(3).WithMessage("El campo LPR_codigo debe tener 3 caracteres.");
			//TNE_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.TNE_codigo)
				.NotEmpty().WithMessage("El campo TNE_codigo es obligatorio.")
				.Length(3).WithMessage("El campo TNE_codigo debe tener 3 caracteres.");
			//CAN_codigo (Tipo C#: string, SQL:char(3))
			RuleFor(x => x.CAN_codigo)
				.NotEmpty().WithMessage("El campo CAN_codigo es obligatorio.")
				.Length(3).WithMessage("El campo CAN_codigo debe tener 3 caracteres.");
			//UBI_id (Tipo C#: string, SQL:char(6))
			RuleFor(x => x.UBI_id)
				.NotEmpty().WithMessage("El campo UBI_id es obligatorio.")
				.Length(6).WithMessage("El campo UBI_id debe tener 6 caracteres.");
			//ZON_codigo (tipo: int)
			RuleFor(x => x.ZON_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para ZON_codigo");
			//VEN_codigo (tipo: int, Acepta NULL en la BD)
			RuleFor(x => x.VEN_codigo)
				.GreaterThanOrEqualTo(0).WithMessage("Ingrese un valor válido para VEN_codigo");
			//TDO_codigo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.TDO_codigo??"")
				.Must(x => x.Length <= 3).WithMessage("El campo TDO_codigo no puede tener más de 3 caracteres.");
			//CPA_codigo (tipo: string, Acepta NULL en la BD)
			RuleFor(x => x.CPA_codigo??"")
				.Must(x => x.Length <= 10).WithMessage("El campo CPA_codigo no puede tener más de 10 caracteres.");
		}
	}
}
