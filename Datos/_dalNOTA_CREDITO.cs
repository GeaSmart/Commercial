using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalNOTA_CREDITO
	{
        public bool insertarRegistroMaestroDetalle(eNOTA_CREDITO oeNOTA_CREDITO, List<eDETALLE_NC> oeDETALLE_NC)
        {
            int rows = 0;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                cnn.Open();
                SqlTransaction tran = cnn.BeginTransaction();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cmd.CommandText = "pa_op_crud_NOTA_CREDITO_insertarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_FECHA_CONTABILIZACION", oeNOTA_CREDITO.NCR_fecha_contabilizacion)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeNOTA_CREDITO.TDO_codigo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SER_SERIE", oeNOTA_CREDITO.SER_serie)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_CORRELATIVO", oeNOTA_CREDITO.NCR_correlativo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeNOTA_CREDITO.VTA_serie_correlativo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeNOTA_CREDITO.SOC_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@NCR_SOC_NOMBRE_RAZON", oeNOTA_CREDITO.NCR_soc_nombre_razon)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_SUBTOTAL", oeNOTA_CREDITO.NCR_subtotal)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_IGV", oeNOTA_CREDITO.NCR_monto_igv)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_ISC", oeNOTA_CREDITO.NCR_monto_isc)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL", oeNOTA_CREDITO.NCR_monto_total)); //variable tipo:double
                    //cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL_TEXTO", oeNOTA_CREDITO.NCR_monto_total_texto)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_COMENTARIO", (object)oeNOTA_CREDITO.NCR_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_ESTADO", oeNOTA_CREDITO.NCR_estado)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", (object)oeNOTA_CREDITO.MDE_codigo ?? DBNull.Value)); //variable tipo:int

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_crud_DETALLE_NC_insertarRegistro]";

                    for (int i = 0; i < oeDETALLE_NC.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_NC o = new eDETALLE_NC();
                        o = oeDETALLE_NC[i];

                        cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", o.NCR_serie_correlativo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DNC_PRO_DESCRIPCION", o.DNC_pro_descripcion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DNC_PRO_UME_MULTIPLO", o.DNC_pro_ume_multiplo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD", o.DNC_cantidad)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD_SUBMULTIPLO", (object)o.DNC_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DNC_PRECIO_UNITARIO", o.DNC_precio_unitario)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_SUBTOTAL", o.DNC_monto_subtotal)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_DESCUENTO", o.DNC_monto_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_DESCUENTO", o.DNC_porcentaje_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_IGV", o.DNC_monto_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_ISC", o.DNC_monto_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_IGV", o.DNC_porcentaje_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_ISC", o.DNC_porcentaje_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_TOTAL_LINEA", o.DNC_monto_total_linea)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MEMO", (object)o.DNC_memo ?? DBNull.Value)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DNC_NUMERO_FILA", o.DNC_numero_fila)); //variable tipo:int


                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    cnn.Close();
            }
                catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            return rows > 0;
            }
        }

        public bool actualizarRegistroMaestroDetalle(eNOTA_CREDITO oeNOTA_CREDITO, List<eDETALLE_NC> oeDETALLE_NC)
        {
            int rows = 0;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                cnn.Open();
                SqlTransaction tran = cnn.BeginTransaction();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cmd.CommandText = "pa_op_crud_NOTA_CREDITO_actualizarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", oeNOTA_CREDITO.NCR_serie_correlativo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_FECHA_CONTABILIZACION", oeNOTA_CREDITO.NCR_fecha_contabilizacion)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeNOTA_CREDITO.TDO_codigo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SER_SERIE", oeNOTA_CREDITO.SER_serie)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_CORRELATIVO", oeNOTA_CREDITO.NCR_correlativo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeNOTA_CREDITO.VTA_serie_correlativo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeNOTA_CREDITO.SOC_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@NCR_SOC_NOMBRE_RAZON", oeNOTA_CREDITO.NCR_soc_nombre_razon)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_SUBTOTAL", oeNOTA_CREDITO.NCR_subtotal)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_IGV", oeNOTA_CREDITO.NCR_monto_igv)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_ISC", oeNOTA_CREDITO.NCR_monto_isc)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL", oeNOTA_CREDITO.NCR_monto_total)); //variable tipo:double
                    //cmd.Parameters.Add(new SqlParameter("@NCR_MONTO_TOTAL_TEXTO", oeNOTA_CREDITO.NCR_monto_total_texto)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_COMENTARIO", (object)oeNOTA_CREDITO.NCR_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@NCR_ESTADO", oeNOTA_CREDITO.NCR_estado)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", (object)oeNOTA_CREDITO.MDE_codigo ?? DBNull.Value)); //variable tipo:int

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_op_crud_DETALLE_NC_actualizarRegistro]";

                    for (int i = 0; i < oeDETALLE_NC.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_NC o = new eDETALLE_NC();
                        o = oeDETALLE_NC[i];

                        cmd.Parameters.Add(new SqlParameter("@NCR_SERIE_CORRELATIVO", o.NCR_serie_correlativo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DNC_PRO_DESCRIPCION", o.DNC_pro_descripcion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DNC_PRO_UME_MULTIPLO", o.DNC_pro_ume_multiplo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD", o.DNC_cantidad)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DNC_CANTIDAD_SUBMULTIPLO", (object)o.DNC_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DNC_PRECIO_UNITARIO", o.DNC_precio_unitario)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_SUBTOTAL", o.DNC_monto_subtotal)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_DESCUENTO", o.DNC_monto_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_DESCUENTO", o.DNC_porcentaje_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_IGV", o.DNC_monto_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_ISC", o.DNC_monto_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_IGV", o.DNC_porcentaje_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_PORCENTAJE_ISC", o.DNC_porcentaje_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MONTO_TOTAL_LINEA", o.DNC_monto_total_linea)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DNC_MEMO", (object)o.DNC_memo ?? DBNull.Value)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DNC_NUMERO_FILA", o.DNC_numero_fila)); //variable tipo:int


                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    cnn.Close();
            }
                catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            return rows > 0;
            }
        }

        public bool anularRegistro(eNOTA_CREDITO oeNOTA_CREDITO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_NOTA_CREDITO_anularRegistro]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@NCR_serie_correlativo", oeNOTA_CREDITO.NCR_serie_correlativo));
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
