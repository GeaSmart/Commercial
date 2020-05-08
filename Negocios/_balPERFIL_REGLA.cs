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
    public partial class balPERFIL_REGLA : AbstractValidator<ePERFIL_REGLA>
    {
        public static DataTable mostrarReglas(ePERFIL oePERFIL, string filtro)
        {
            return _dalPERFIL_REGLA.mostrarReglas(oePERFIL, filtro);
        }

        public static bool actualizarRegla(ePERFIL_REGLA oePERFIL_REGLA)
        {
            return _dalPERFIL_REGLA.actualizarRegla(oePERFIL_REGLA);
        }
    }
}
