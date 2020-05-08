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
	public partial class balCOMPRA:AbstractValidator<eCOMPRA>
	{
        private static balDETALLE_COMPRA _balDETALLE_COMPRA = new balDETALLE_COMPRA();
        private static dalDETALLE_COMPRA _dalDETALLE_COMPRA = new dalDETALLE_COMPRA();

        public static bool insertarRegistroMaestroDetalle(eCOMPRA oeCOMPRA, List<eDETALLE_COMPRA> oeDETALLE_COMPRA)
        {
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balCOMPRA.Validate(oeCOMPRA);
            
            for (int i = 0; i < oeDETALLE_COMPRA.Count; i++)
            {
                eDETALLE_COMPRA o = new eDETALLE_COMPRA();
                o = oeDETALLE_COMPRA[i];
                ValidationResult result2 = _balDETALLE_COMPRA.Validate(o);

                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera && result.IsValid)
            {
                if (_dalCOMPRA.obtenerRegistro(oeCOMPRA).Rows.Count == 0)
                {
                    if (_dalCOMPRA.insertarRegistroMaestroDetalle(oeCOMPRA, oeDETALLE_COMPRA))
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

        public static bool actualizarRegistroMaestroDetalle(eCOMPRA oeCOMPRA, List<eDETALLE_COMPRA> oeDETALLE_COMPRA)
        {
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balCOMPRA.Validate(oeCOMPRA);


            for (int i = 0; i < oeDETALLE_COMPRA.Count; i++)
            {
                eDETALLE_COMPRA o = new eDETALLE_COMPRA();
                o = oeDETALLE_COMPRA[i];
                ValidationResult result2 = _balDETALLE_COMPRA.Validate(o);

                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera && result.IsValid)
            {
                if (_dalCOMPRA.obtenerRegistro(oeCOMPRA).Rows.Count > 0)
                {
                    if (_dalCOMPRA.actualizarRegistroMaestroDetalle(oeCOMPRA, oeDETALLE_COMPRA))
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

        public static bool anularRegistro(eCOMPRA oeCOMPRA)
        {
            bool flag = false;
            if (_dalCOMPRA.obtenerRegistro(oeCOMPRA).Rows.Count > 0)
            {
                if (_dalCOMPRA.anularRegistro(oeCOMPRA))
                {
                    flag = true;
                }
            }
            else
            {
                throw new CustomException("El registro que desea anular no existe.");
            }
            return flag;
        }
    }
}
