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
	public partial class balPAGO:AbstractValidator<ePAGO>
	{
        public static DataTable mostrarListadoPagos(DateTime desde, DateTime hasta, eVENTA oeVENTA, DataTable series, DataTable condicionesPago, string isSoloAbiertos)
        {
            if (_dalPAGO.mostrarListadoPagos(desde,hasta,oeVENTA,series,condicionesPago, isSoloAbiertos).Rows.Count > 0)
            {
                return _dalPAGO.mostrarListadoPagos(desde, hasta, oeVENTA, series, condicionesPago, isSoloAbiertos);
            }            
            return null;
        }

        public static bool pagarDocumento(ePAGO oePAGO)
        {
            return _dalPAGO.pagarDocumento(oePAGO);
        }
    }
}
