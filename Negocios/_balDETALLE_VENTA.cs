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
	public partial class balDETALLE_VENTA:AbstractValidator<eDETALLE_VENTA>
	{
        private static dalVENTA _dalVENTA = new dalVENTA();
        private static balVENTA _balVENTA = new balVENTA();

        public static bool insertarRegistroMaestroDetalle(eVENTA oeVENTA, List<eDETALLE_VENTA> oeDETALLE_VENTA)
        {
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balVENTA.Validate(oeVENTA);
            

            for (int i = 0; i < oeDETALLE_VENTA.Count; i++)
            {
                eDETALLE_VENTA o = new eDETALLE_VENTA();
                o = oeDETALLE_VENTA[i];
                ValidationResult result2 = _balDETALLE_VENTA.Validate(o);
                
                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera && result.IsValid)
            {
                if (_dalVENTA.obtenerRegistro(oeVENTA).Rows.Count == 0)
                {
                    if (_dalDETALLE_VENTA.insertarRegistroMaestroDetalle(oeVENTA, oeDETALLE_VENTA))
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

        public static bool actualizarRegistroMaestroDetalle(eVENTA oeVENTA, List<eDETALLE_VENTA> oeDETALLE_VENTA)
        {
            //return _dalDETALLE_VENTA.actualizarRegistroMaestroDetalle(oeVENTA, oeDETALLE_VENTA);
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balVENTA.Validate(oeVENTA);
            for (int i = 0; i < oeDETALLE_VENTA.Count; i++)
            {
                eDETALLE_VENTA o = new eDETALLE_VENTA();
                o = oeDETALLE_VENTA[i];
                ValidationResult result2 = _balDETALLE_VENTA.Validate(o);
                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera = true && result.IsValid)
            {
                if (_dalVENTA.obtenerRegistro(oeVENTA).Rows.Count > 0)
                {
                    if (_dalDETALLE_VENTA.actualizarRegistroMaestroDetalle(oeVENTA, oeDETALLE_VENTA))
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
    }
}
