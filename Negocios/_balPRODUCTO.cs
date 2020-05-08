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
	public partial class balPRODUCTO:AbstractValidator<ePRODUCTO>
	{
        public static DataTable obtenerRegistroComplejo(ePRODUCTO oePRODUCTO, eSOCIO oeSOCIO)
        {
            return _dalPRODUCTO.obtenerRegistroComplejo(oePRODUCTO, oeSOCIO);
        }

        public static DataTable obtenerRegistroComplejoBonificacion(eCANAL oeCANAL)
        {
            return _dalPRODUCTO.obtenerRegistroComplejoBonificacion(oeCANAL);
        }

        public static DataTable buscarRegistroBonificacion(string cadena, eCANAL oeCANAL)
        {
            if (_dalPRODUCTO.buscarRegistroBonificacion(oeCANAL, cadena).Rows.Count > 0)
            {
                return _dalPRODUCTO.buscarRegistroBonificacion(oeCANAL, cadena);
            }
            else
            return null;
        }

        public static DataTable poblarParaDescuentos()
        {
            return _dalPRODUCTO.poblarParaDescuentos();
        }

        public static DataTable poblarPacks()
        {
            return _dalPRODUCTO.poblarPacks();
        }
    }
}
