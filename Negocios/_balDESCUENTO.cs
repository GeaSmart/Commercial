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
	public partial class balDESCUENTO:AbstractValidator<eDESCUENTO>
	{
        //ADICIONALES BAL DESCUENTO
        public DataTable mostrarDescuentosPorProducto(eDESCUENTO oeDESCUENTO)
        {
            if (_dalDESCUENTO.mostrarDescuentosPorProducto(oeDESCUENTO).Rows.Count > 0)
            {
                return _dalDESCUENTO.mostrarDescuentosPorProducto(oeDESCUENTO);
            }
            else
            return null;
        }

        public static bool actualizarDescuento(eDESCUENTO oeDESCUENTO)
        {
            return _dalDESCUENTO.actualizarDescuento(oeDESCUENTO);
        }
    }
}
