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
	public partial class balUSUARIO:AbstractValidator<eUSUARIO>
	{
        //ADICIONALES bal usuario
        public static DataTable login(eUSUARIO oeUSUARIO)
        {
            return _dalUSUARIO.login(oeUSUARIO);
        }

        public static bool TieneRegla(string reglasVerificar, string reglasAsignadas)
        {
            string[] array = reglasAsignadas.Split(',');

            //string[] arreglo = reglasVerificar.Split(',');
            foreach (var s in array)
            {
                if (s != "" && reglasVerificar == s)
                {
                    return true;
                }
            }
            return false;
        }

        public static DataTable refrescarReglas(string USU_usuario)
        {
            return _dalUSUARIO.refrescarReglas(USU_usuario);
        }
    }
}
