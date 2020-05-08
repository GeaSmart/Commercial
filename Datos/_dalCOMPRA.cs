using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalCOMPRA
	{
        public bool insertarRegistroMaestroDetalle(eCOMPRA oeCOMPRA, List<eDETALLE_COMPRA> oeDETALLE_COMPRA)
        {
            int rows = 0;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                cnn.Open();
                SqlTransaction tran = cnn.BeginTransaction();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;

                //try
                //{
                    cmd.CommandText = "pa_crud_COMPRA_insertarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@COM_FECHA_DOCUMENTO_ORIGEN", oeCOMPRA.COM_fecha_documento_origen)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@COM_FECHA_VENCIMIENTO", oeCOMPRA.COM_fecha_vencimiento)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@COM_DOCUMENTO_ORIGEN", oeCOMPRA.COM_documento_origen)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@COM_TIPO_DOCUMENTO", oeCOMPRA.COM_tipo_documento)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeCOMPRA.SOC_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@COM_SOC_NOMBRE_RAZON", oeCOMPRA.COM_soc_nombre_razon)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@COM_SUBTOTAL", oeCOMPRA.COM_subtotal)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_PORCENTAJE_PERCEPCION", oeCOMPRA.COM_porcentaje_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_IGV", oeCOMPRA.COM_monto_igv)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_ISC", oeCOMPRA.COM_monto_isc)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_PERCEPCION", oeCOMPRA.COM_monto_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_TOTAL", oeCOMPRA.COM_monto_total)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_COMENTARIO", (object)oeCOMPRA.COM_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@COM_ESTADO", oeCOMPRA.COM_estado)); //variable tipo:string

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_op_crud_DETALLE_COMPRA_insertarRegistro]";

                    for (int i = 0; i < oeDETALLE_COMPRA.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_COMPRA o = new eDETALLE_COMPRA();
                        o = oeDETALLE_COMPRA[i];

                        //cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", o.COM_numero)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", o.DCO_is_bonificacion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_PRO_DESCRIPCION", o.DCO_pro_descripcion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_PRO_UME_MULTIPLO", o.DCO_pro_ume_multiplo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD", o.DCO_cantidad)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD_SUBMULTIPLO", (object)o.DCO_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_PRECIO_UNITARIO", o.DCO_precio_unitario)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_SUBTOTAL", o.DCO_monto_subtotal)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_DESCUENTO", o.DCO_monto_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_DESCUENTO", o.DCO_porcentaje_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_IGV", o.DCO_monto_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_ISC", o.DCO_monto_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_IGV", o.DCO_porcentaje_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_ISC", o.DCO_porcentaje_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_TOTAL_LINEA", o.DCO_monto_total_linea)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MEMO", (object)o.DCO_memo ?? DBNull.Value)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_NUMERO_FILA", o.DCO_numero_fila)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_PRODUCCION", o.DCO_fecha_produccion)); //variable tipo:DateTime
                        cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_VENCIMIENTO", o.DCO_fecha_vencimiento)); //variable tipo:DateTime


                        rows = cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    cnn.Close();
                //}
                //catch (Exception ex)
                //{
                //    tran.Rollback();
                //    return false;
                //}
                return rows > 0;
            }
        }

        public bool actualizarRegistroMaestroDetalle(eCOMPRA oeCOMPRA, List<eDETALLE_COMPRA> oeDETALLE_COMPRA)
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
                    cmd.CommandText = "pa_op_crud_COMPRA_actualizarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", oeCOMPRA.COM_numero)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@COM_FECHA_DOCUMENTO_ORIGEN", oeCOMPRA.COM_fecha_documento_origen)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@COM_FECHA_VENCIMIENTO", oeCOMPRA.COM_fecha_vencimiento)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@COM_DOCUMENTO_ORIGEN", oeCOMPRA.COM_documento_origen)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@COM_TIPO_DOCUMENTO", oeCOMPRA.COM_tipo_documento)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeCOMPRA.SOC_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@COM_SOC_NOMBRE_RAZON", oeCOMPRA.COM_soc_nombre_razon)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@COM_SUBTOTAL", oeCOMPRA.COM_subtotal)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_PORCENTAJE_PERCEPCION", oeCOMPRA.COM_porcentaje_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_IGV", oeCOMPRA.COM_monto_igv)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_ISC", oeCOMPRA.COM_monto_isc)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_PERCEPCION", oeCOMPRA.COM_monto_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_MONTO_TOTAL", oeCOMPRA.COM_monto_total)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@COM_COMENTARIO", (object)oeCOMPRA.COM_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@COM_ESTADO", oeCOMPRA.COM_estado)); //variable tipo:string

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_op_crud_DETALLE_COMPRA_actualizarRegistro]";

                    for (int i = 0; i < oeDETALLE_COMPRA.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_COMPRA o = new eDETALLE_COMPRA();
                        o = oeDETALLE_COMPRA[i];

                        cmd.Parameters.Add(new SqlParameter("@COM_NUMERO", o.COM_numero)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_IS_BONIFICACION", o.DCO_is_bonificacion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_PRO_DESCRIPCION", o.DCO_pro_descripcion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_PRO_UME_MULTIPLO", o.DCO_pro_ume_multiplo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD", o.DCO_cantidad)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_CANTIDAD_SUBMULTIPLO", (object)o.DCO_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_PRECIO_UNITARIO", o.DCO_precio_unitario)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_SUBTOTAL", o.DCO_monto_subtotal)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_DESCUENTO", o.DCO_monto_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_DESCUENTO", o.DCO_porcentaje_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_IGV", o.DCO_monto_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_ISC", o.DCO_monto_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_IGV", o.DCO_porcentaje_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_PORCENTAJE_ISC", o.DCO_porcentaje_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MONTO_TOTAL_LINEA", o.DCO_monto_total_linea)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DCO_MEMO", (object)o.DCO_memo ?? DBNull.Value)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DCO_NUMERO_FILA", o.DCO_numero_fila)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_PRODUCCION", o.DCO_fecha_produccion)); //variable tipo:DateTime
                        cmd.Parameters.Add(new SqlParameter("@DCO_FECHA_VENCIMIENTO", o.DCO_fecha_vencimiento)); //variable tipo:DateTime

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

        public bool anularRegistro(eCOMPRA oeCOMPRA)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_op_COMPRA_anularRegistro]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@COM_numero", oeCOMPRA.COM_numero));
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
