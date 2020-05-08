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
	public partial class balVENTA:AbstractValidator<eVENTA>
	{
        public static DataTable siguienteCorrelativo(eVENTA oeVENTA)
        {
            return _dalVENTA.obtenerSiguienteCorrelativo(oeVENTA);
        }

        public static DataTable siguienteCorrelativo(eNOTA_CREDITO oeNOTA_CREDITO)
        {
            return _dalVENTA.obtenerSiguienteCorrelativo(oeNOTA_CREDITO);
        }

        public static bool anularRegistro(eVENTA oeVENTA)
        {
            bool flag = false;
            if (_dalVENTA.obtenerRegistro(oeVENTA).Rows.Count > 0)
            {
                if (_dalVENTA.anularRegistro(oeVENTA))
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

        public static DataTable obtenerCantidadDocumentosDia(eVENTA oeVENTA)
        {
            return _dalVENTA.obtenerCantidadDocumentosDia(oeVENTA);
        }
    }
}
