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
	public partial class balSTOCK:AbstractValidator<eSTOCK>
	{
        public static DataTable obtenerInventario(string filtro)
        {
            return _dalSTOCK.obtenerInventario(filtro);            
        }
    }
}
