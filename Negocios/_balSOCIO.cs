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
	public partial class balSOCIO:AbstractValidator<eSOCIO>
	{
        public static DataTable buscarCliente(string cadena)
        {
            if (_dalSOCIO.buscarRegistro(cadena).Rows.Count > 0)
            {
                return _dalSOCIO.buscarCliente(cadena);
            }
            else
                return null;
        }

        public static DataTable buscarProveedor(string cadena)
        {
            if (_dalSOCIO.buscarRegistro(cadena).Rows.Count > 0)
            {
                return _dalSOCIO.buscarProveedor(cadena);
            }
            else
                return null;
        }
    }
}
