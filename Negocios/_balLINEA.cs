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
	public partial class balLINEA:AbstractValidator<eLINEA>
	{
        public static DataTable mostrarPorCategoria(string CAT_codigo)
        {
            return _dalLINEA.mostrarPorCategoria(CAT_codigo);
        }
    }
}
