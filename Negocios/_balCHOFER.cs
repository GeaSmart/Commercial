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
	public partial class balCHOFER:AbstractValidator<eCHOFER>
	{
        public static DataTable obtenerRegistroDetallado(eCHOFER oeCHOFER)
        {
            if (_dalCHOFER.obtenerRegistroDetallado(oeCHOFER).Rows.Count > 0)
            {
                return _dalCHOFER.obtenerRegistroDetallado(oeCHOFER);
            }
            else
            return null;
        }
    }
}
