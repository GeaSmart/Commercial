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
	public partial class balDETALLE_IMPUESTO:AbstractValidator<eDETALLE_IMPUESTO>
	{
        public static DataTable obtenerDetallePorImpuesto(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
        {
            return _dalDETALLE_IMPUESTO.obtenerDetallePorImpuesto(oeDETALLE_IMPUESTO);
        }

        public static bool actualizarFila(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
        {
            ValidationResult result = _balDETALLE_IMPUESTO.Validate(oeDETALLE_IMPUESTO);
            bool flag = false;
            if (result.IsValid)
            {
                if (_dalDETALLE_IMPUESTO.actualizarFila(oeDETALLE_IMPUESTO))
                {
                    flag = true;
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



        //public static bool actualizarFila(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
        //{
        //    return _dalDETALLE_IMPUESTO.actualizarFila(oeDETALLE_IMPUESTO);
        //}
        
        public static bool eliminarGrilla(eDETALLE_IMPUESTO oeDETALLE_IMPUESTO)
        {
            return _dalDETALLE_IMPUESTO.eliminarGrilla(oeDETALLE_IMPUESTO);
        }
    }
}
