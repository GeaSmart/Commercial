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
	public partial class balZONA:AbstractValidator<eZONA>
	{
        public static DataTable buscarRegistroP(string cadena, ePROGRAMACION oePROGRAMACION)
        {
            if (_dalZONA.buscarRegistroP(cadena, oePROGRAMACION).Rows.Count > 0)
            {
                return _dalZONA.buscarRegistroP(cadena, oePROGRAMACION);
            }
            else
                return null;
        }

        public static DataTable mostrarNoAsignadas(int RUT_codigo)
        {
            return _dalZONA.mostrarNoAsignadas(RUT_codigo);
        }
    }
}
