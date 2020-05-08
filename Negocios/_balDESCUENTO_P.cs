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
	public partial class balDESCUENTO_P:AbstractValidator<eDESCUENTO_P>
	{
        //ADICIONALES BAL DESCUENTO P
        public DataTable mostrarDescuentosPPorProducto(eDESCUENTO_P oeDESCUENTOP)
        {
            if (_dalDESCUENTO_P.mostrarDescuentosPPorProducto(oeDESCUENTOP).Rows.Count > 0)
            {
                return _dalDESCUENTO_P.mostrarDescuentosPPorProducto(oeDESCUENTOP);
            }
            else
            return null;
        }

        public bool actualizarDescuentoP(eDESCUENTO_P oeDESCUENTOP)
        {
            return _dalDESCUENTO_P.actualizarDescuentoP(oeDESCUENTOP);
        }
    }
}
