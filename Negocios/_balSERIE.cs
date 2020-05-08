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
	public partial class balSERIE:AbstractValidator<eSERIE>
	{
        public static DataTable CargarSeries(eTIPO_DOCUMENTO oeTIPO_DOCUMENTO)
        {
            return _dalSERIE.CargarSeries(oeTIPO_DOCUMENTO);
        }

        public static DataTable obtenerSeriesPorTipoDocumento(eSERIE oeSERIE, ePEDIDO oePEDIDO)
        {
            return _dalSERIE.obtenerSeriesPorTipoDocumento(oeSERIE, oePEDIDO);
        }
    }
}
