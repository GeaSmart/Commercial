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
    public partial class balNOTA_CREDITO : AbstractValidator<eNOTA_CREDITO>
    {
        private static balDETALLE_NC _balDETALLE_NC = new balDETALLE_NC();
        private static dalDETALLE_NC _dalDETALLE_NC = new dalDETALLE_NC();

        public static bool insertarRegistroMaestroDetalle(eNOTA_CREDITO oeNOTA_CREDITO, List<eDETALLE_NC> oeDETALLE_NC)
        {
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balNOTA_CREDITO.Validate(oeNOTA_CREDITO);

            for (int i = 0; i < oeDETALLE_NC.Count; i++)
            {
                eDETALLE_NC o = new eDETALLE_NC();
                o = oeDETALLE_NC[i];
                ValidationResult result2 = _balDETALLE_NC.Validate(o);

                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera && result.IsValid)
            {
                if (_dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO).Rows.Count == 0)
                {
                    if (_dalNOTA_CREDITO.insertarRegistroMaestroDetalle(oeNOTA_CREDITO, oeDETALLE_NC))
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

        public static bool actualizarRegistroMaestroDetalle(eNOTA_CREDITO oeNOTA_CREDITO, List<eDETALLE_NC> oeDETALLE_NC)
        {
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balNOTA_CREDITO.Validate(oeNOTA_CREDITO);


            for (int i = 0; i < oeDETALLE_NC.Count; i++)
            {
                eDETALLE_NC o = new eDETALLE_NC();
                o = oeDETALLE_NC[i];
                ValidationResult result2 = _balDETALLE_NC.Validate(o);

                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera && result.IsValid)
            {
                if (_dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO).Rows.Count > 0)
                {
                    if (_dalNOTA_CREDITO.actualizarRegistroMaestroDetalle(oeNOTA_CREDITO, oeDETALLE_NC))
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

        public static bool anularRegistro(eNOTA_CREDITO oeNOTA_CREDITO)
        {
            bool flag = false;
            if (_dalNOTA_CREDITO.obtenerRegistro(oeNOTA_CREDITO).Rows.Count > 0)
            {
                if (_dalNOTA_CREDITO.anularRegistro(oeNOTA_CREDITO))
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
