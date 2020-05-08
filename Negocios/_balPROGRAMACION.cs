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
	public partial class balPROGRAMACION:AbstractValidator<ePROGRAMACION>
	{
        private static balPROGRAMACION obalPROGRAMACION = new balPROGRAMACION();

        public static bool insertarRegistroMaestroDetalle(ePROGRAMACION oePROGRAMACION, List<eDETALLE_PROG> oeDETALLE_PROGRAMACION)
        {
            bool flag = false;
            ValidationResult result = obalPROGRAMACION.Validate(oePROGRAMACION);
            if (result.IsValid)
            {
                if (_dalPROGRAMACION.insertarRegistroMaestroDetalle(oePROGRAMACION, oeDETALLE_PROGRAMACION))
                {
                    flag = true;
                }
                //else
                //{
                //    throw new CustomException("El registro no se pudo insertar.");
                //}
            }
            return flag;
        }

        public static bool actualizarRegistroMaestroDetalle(ePROGRAMACION oePROGRAMACION, List<eDETALLE_PROG> oeDETALLE_PROGRAMACION)
        {
            bool flag = false;
            ValidationResult result = obalPROGRAMACION.Validate(oePROGRAMACION);
            if (_dalPROGRAMACION.actualizarRegistroMaestroDetalle(oePROGRAMACION, oeDETALLE_PROGRAMACION))
            {                
                flag = true;
            }
            //else
            //{
            //    throw new CustomException("El registro no se pudo insertar.");
            //}
            return flag;
        }

        public DataTable obtenerInformacionDirigida(ePROGRAMACION oePROGRAMACION, eDETALLE_PROG oeDETALLE_PROGRAMACION)
        {
            return _dalPROGRAMACION.obtenerInformacionDirigida(oePROGRAMACION, oeDETALLE_PROGRAMACION);
        }

        public static bool eliminarRegistroMaestroDetalle(ePROGRAMACION oePROGRAMACION, List<eDETALLE_PROG> oeDETALLE_PROGRAMACION)
        {
            bool flag = false;
            if (_dalPROGRAMACION.eliminarRegistroMaestroDetalle(oePROGRAMACION, oeDETALLE_PROGRAMACION))
            {                
                flag = true;
            }
            //else
            //{
            //    throw new CustomException("El registro no se pudo insertar.");
            //}
            return flag;
        }
    }
}
