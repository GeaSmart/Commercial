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
	public partial class balPEDIDO:AbstractValidator<ePEDIDO>
	{
        private static balDETALLE_PEDIDO _balDETALLE_PEDIDO = new balDETALLE_PEDIDO();
        //private static dalDETALLE_PEDIDO _dalDETALLE_PEDIDO = new dalDETALLE_PEDIDO();

        public static bool insertarRegistroMaestroDetalle(ePEDIDO oePEDIDO, List<eDETALLE_PEDIDO> oeDETALLE_PEDIDO)
        {
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balPEDIDO.Validate(oePEDIDO);


            for (int i = 0; i < oeDETALLE_PEDIDO.Count; i++)
            {
                eDETALLE_PEDIDO o = new eDETALLE_PEDIDO();
                o = oeDETALLE_PEDIDO[i];
                ValidationResult result2 = _balDETALLE_PEDIDO.Validate(o);

                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera && result.IsValid)
            {
                if (_dalPEDIDO.obtenerRegistro(oePEDIDO).Rows.Count == 0)
                {
                    if (_dalPEDIDO.insertarRegistroMaestroDetalle(oePEDIDO, oeDETALLE_PEDIDO))
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

        public static bool actualizarRegistroMaestroDetalle(ePEDIDO oePEDIDO, List<eDETALLE_PEDIDO> oeDETALLE_PEDIDO)
        {
            bool bandera = true;
            bool flag = false;
            ValidationResult result = _balPEDIDO.Validate(oePEDIDO);


            for (int i = 0; i < oeDETALLE_PEDIDO.Count; i++)
            {
                eDETALLE_PEDIDO o = new eDETALLE_PEDIDO();
                o = oeDETALLE_PEDIDO[i];
                ValidationResult result2 = _balDETALLE_PEDIDO.Validate(o);

                if (!result2.IsValid)
                {
                    bandera = false;
                }
            }

            if (bandera && result.IsValid)
            {
                if (_dalPEDIDO.obtenerRegistro(oePEDIDO).Rows.Count > 0)
                {
                    if (_dalPEDIDO.actualizarRegistroMaestroDetalle(oePEDIDO, oeDETALLE_PEDIDO))
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

        public static bool anularRegistro(ePEDIDO oePEDIDO)
        {
            bool flag = false;
            if (_dalPEDIDO.obtenerRegistro(oePEDIDO).Rows.Count > 0)
            {
                if (_dalPEDIDO.anularRegistro(oePEDIDO))
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

        public static DataTable obtenerInformacionGeneracion(ePEDIDO oePEDIDO)
        {
            return _dalPEDIDO.obtenerInformacionGeneracion(oePEDIDO);
        }

        public static int generarDocumentosVenta(ePEDIDO oePEDIDO, string serie, int correlativoInicial)
        {
           return  _dalPEDIDO.generarDocumentosVenta(oePEDIDO, serie, correlativoInicial);
        }
    }
}
