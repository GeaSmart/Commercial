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
	public partial class balBONIFICACION:AbstractValidator<eBONIFICACION>
	{
        public static DataTable mostrarBonificacionPorGrupo(eCANAL oeCANAL)
        {
            if (_dalBONIFICACION.mostrarBonificacionPorGrupo(oeCANAL).Rows.Count > 0)
            {
                return _dalBONIFICACION.mostrarBonificacionPorGrupo(oeCANAL);                
            }
            return null;
        }

        public static bool actualizarTabla(eBONIFICACION oeBONIFICACION)
        {
            return _dalBONIFICACION.actualizarTabla(oeBONIFICACION);
        }

        public static void eliminarTabla(eBONIFICACION oeBONIFICACION)
        {
            _dalBONIFICACION.eliminarTabla(oeBONIFICACION);
        }

        public static DataTable procesarReglas(eVENTA oeVENTA, eDETALLE_VENTA oeDETALLEVENTA)
        {
            if (_dalBONIFICACION.procesarReglas(oeVENTA, oeDETALLEVENTA).Rows.Count > 0)
            {
                return _dalBONIFICACION.procesarReglas(oeVENTA, oeDETALLEVENTA);
            }
            else                
            return null;
        }
    }
}
