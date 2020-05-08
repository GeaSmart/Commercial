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
	public partial class balLISTA_PRECIO:AbstractValidator<eLISTA_PRECIO>
	{
        public static DataTable mostrarListaPrecios(eLISTA_PRECIO oeLISTA_PRECIO, string filtro)
        {
            return _dalLISTA_PRECIO.mostrarListaPrecios(oeLISTA_PRECIO, filtro);
        }
    }
}