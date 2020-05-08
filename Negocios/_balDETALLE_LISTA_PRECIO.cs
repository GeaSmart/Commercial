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
	public partial class balDETALLE_LISTA_PRECIO:AbstractValidator<eDETALLE_LISTA_PRECIO>
	{
        public static bool actualizarListaPrecios(eDETALLE_LISTA_PRECIO oeDETALLE_LISTA_PRECIO)
        {
            return _dalDETALLE_LISTA_PRECIO.actualizarListaPrecios(oeDETALLE_LISTA_PRECIO);
        }
    }
}
