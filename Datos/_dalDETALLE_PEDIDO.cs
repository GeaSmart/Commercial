using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalDETALLE_PEDIDO
	{
        //    public bool insertarRegistroMaestroDetalle(ePEDIDO oePEDIDO, List<eDETALLE_PEDIDO> oeDETALLE_PEDIDO)
        //    {
        //        int rows = 0;
        //        using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
        //        {
        //            cnn.Open();
        //            SqlTransaction tran = cnn.BeginTransaction();
        //            SqlCommand cmd = cnn.CreateCommand();
        //            cmd.Transaction = tran;
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            try
        //            {
        //                cmd.CommandText = "pa_crud_PEDIDO_insertarRegistro";

        //                cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha)); //variable tipo:DateTime
        //                cmd.Parameters.Add(new SqlParameter("@PED_FECHA_ENTREGA", oePEDIDO.PED_fecha_entrega)); //variable tipo:DateTime
        //                cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oePEDIDO.VEN_codigo)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@PED_NOMBRE_VENDEDOR", oePEDIDO.PED_nombre_vendedor)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oePEDIDO.SOC_codigo)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@PED_SOC_NOMBRE_RAZON", oePEDIDO.PED_soc_nombre_razon)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@PED_SOC_DIRECCION", oePEDIDO.PED_soc_direccion)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@PED_SOC_ZONA", oePEDIDO.PED_soc_zona)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@PED_SUBTOTAL", oePEDIDO.PED_subtotal)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@PED_PORCENTAJE_IGV", oePEDIDO.PED_porcentaje_igv)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@PED_PORCENTAJE_PERCEPCION", oePEDIDO.PED_porcentaje_percepcion)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@PED_MONTO_IGV", oePEDIDO.PED_monto_igv)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@PED_MONTO_ISC", oePEDIDO.PED_monto_isc)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@PED_MONTO_PERCEPCION", oePEDIDO.PED_monto_percepcion)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@PED_MONTO_TOTAL", oePEDIDO.PED_monto_total)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@PED_COMENTARIO", (object)oePEDIDO.PED_comentario ?? DBNull.Value)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@PED_ESTADO", oePEDIDO.PED_estado)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oePEDIDO.CPA_codigo)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@PED_TDO_CODIGO", oePEDIDO.PED_tdo_codigo)); //variable tipo:string

        //                rows = cmd.ExecuteNonQuery();

        //                //INSERTAMOS EL DETALLE
        //                cmd.CommandText = "[pa_crud_DETALLE_VENTA_insertarRegistro]";

        //                for (int i = 0; i < oeDETALLE_PEDIDO.Count; i++)
        //                {
        //                    cmd.Parameters.Clear();
        //                    eDETALLE_PEDIDO o = new eDETALLE_PEDIDO();
        //                    o = oeDETALLE_PEDIDO[i];

        //                    cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", o.PED_numero)); //variable tipo:int
        //                    cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", o.DPE_is_bonificacion)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_PRO_DESCRIPCION", o.DPE_pro_descripcion)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_PRO_UME_MULTIPLO", o.DPE_pro_ume_multiplo)); //variable tipo:int
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD", o.DPE_cantidad)); //variable tipo:int
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD_SUBMULITPLO", (object)o.DPE_cantidad_submulitplo ?? DBNull.Value)); //variable tipo:int
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_PRECIO_UNITARIO", o.DPE_precio_unitario)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_SUBTOTAL", o.DPE_monto_subtotal)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_DESCUENTO", o.DPE_monto_descuento)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_DESCUENTO", o.DPE_porcentaje_descuento)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_IGV", o.DPE_monto_igv)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_ISC", o.DPE_monto_isc)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_ISC", o.DPE_porcentaje_isc)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_TOTAL_LINEA", o.DPE_monto_total_linea)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_MEMO", (object)o.DPE_memo ?? DBNull.Value)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DPE_NUMERO_FILA", o.DPE_numero_fila)); //variable tipo:int

        //                    cmd.ExecuteNonQuery();
        //                }

        //                tran.Commit();
        //                cnn.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                tran.Rollback();
        //            }
        //            return rows > 0;
        //        }
        //    }

        //    public bool actualizarRegistroMaestroDetalle(eVENTA oeVENTA, List<eDETALLE_VENTA> oeDETALLE_VENTA)
        //    {
        //        int rows = 0;
        //        using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
        //        {
        //            cnn.Open();
        //            SqlTransaction tran = cnn.BeginTransaction();
        //            SqlCommand cmd = cnn.CreateCommand();
        //            cmd.Transaction = tran;
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            try
        //            {
        //                cmd.CommandText = "pa_crud_VENTA_actualizarRegistro";


        //                cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", oeVENTA.VTA_serie_correlativo)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_FECHA_CONTABILIZACION", oeVENTA.VTA_fecha_contabilizacion)); //variable tipo:DateTime
        //                cmd.Parameters.Add(new SqlParameter("@VTA_FECHA_ENTREGA", oeVENTA.VTA_fecha_entrega)); //variable tipo:DateTime
        //                cmd.Parameters.Add(new SqlParameter("@TDO_CODIGO", oeVENTA.TDO_codigo)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@SER_SERIE", oeVENTA.SER_serie)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_CORRELATIVO", oeVENTA.VTA_correlativo)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", (object)oeVENTA.CHO_codigo ?? DBNull.Value)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@VTA_CHO_NOMBRE_COMPLETO", (object)oeVENTA.VTA_cho_nombre_completo ?? DBNull.Value)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", (object)oeVENTA.VEN_codigo ?? DBNull.Value)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@VTA_NOMBRE_VENDEDOR", (object)oeVENTA.VTA_nombre_vendedor ?? DBNull.Value)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_IS_COMISIONABLE", oeVENTA.VTA_is_comisionable)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_IS_OFICINA", oeVENTA.VTA_is_oficina)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@TVE_CODIGO", oeVENTA.TVE_codigo)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oeVENTA.SOC_codigo)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@VTA_SOC_NOMBRE_RAZON", oeVENTA.VTA_soc_nombre_razon)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_SOC_DIRECCION", oeVENTA.VTA_soc_direccion)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_SOC_ZONA", (object)oeVENTA.VTA_soc_zona ?? DBNull.Value)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@VTA_SUBTOTAL", oeVENTA.VTA_subtotal)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@VTA_PORCENTAJE_IGV", oeVENTA.VTA_porcentaje_igv)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@VTA_PORCENTAJE_PERCEPCION", oeVENTA.VTA_porcentaje_percepcion)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_IGV", oeVENTA.VTA_monto_igv)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_ISC", oeVENTA.VTA_monto_isc)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_PERCEPCION", oeVENTA.VTA_monto_percepcion)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_TOTAL", oeVENTA.VTA_monto_total)); //variable tipo:double
        //                cmd.Parameters.Add(new SqlParameter("@VTA_MONTO_TOTAL_TEXTO", oeVENTA.VTA_monto_total_texto)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_COMENTARIO", (object)oeVENTA.VTA_comentario ?? DBNull.Value)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@VTA_ESTADO", oeVENTA.VTA_estado)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oeVENTA.CPA_codigo)); //variable tipo:string
        //                cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", (object)oeVENTA.PED_numero ?? DBNull.Value)); //variable tipo:int
        //                cmd.Parameters.Add(new SqlParameter("@MDE_CODIGO", (object)oeVENTA.MDE_codigo ?? DBNull.Value)); //variable tipo:int

        //                rows = cmd.ExecuteNonQuery();

        //                //INSERTAMOS EL DETALLE
        //                cmd.CommandText = "[pa_crud_DETALLE_VENTA_actualizarRegistro]";

        //                for (int i = 0; i < oeDETALLE_VENTA.Count; i++)
        //                {
        //                    cmd.Parameters.Clear();
        //                    eDETALLE_VENTA o = new eDETALLE_VENTA();
        //                    o = oeDETALLE_VENTA[i];

        //                    cmd.Parameters.Add(new SqlParameter("@VTA_SERIE_CORRELATIVO", o.VTA_serie_correlativo)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_IS_BONIFICACION", o.DVE_is_bonificacion)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_PRO_DESCRIPCION", o.DVE_pro_descripcion)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_PRO_UME_MULTIPLO", o.DVE_pro_ume_multiplo)); //variable tipo:int
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_CANTIDAD", o.DVE_cantidad)); //variable tipo:int
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_CANTIDAD_SUBMULTIPLO", (object)o.DVE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_PRECIO_UNITARIO", o.DVE_precio_unitario)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_SUBTOTAL", o.DVE_monto_subtotal)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_DESCUENTO", o.DVE_monto_descuento)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_DESCUENTO", o.DVE_porcentaje_descuento)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_IGV", o.DVE_monto_igv)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_ISC", o.DVE_monto_isc)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_PORCENTAJE_ISC", o.DVE_porcentaje_isc)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_MONTO_TOTAL_LINEA", o.DVE_monto_total_linea)); //variable tipo:double
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_MEMO", (object)o.DVE_memo ?? DBNull.Value)); //variable tipo:string
        //                    cmd.Parameters.Add(new SqlParameter("@DVE_NUMERO_FILA", o.DVE_numero_fila)); //variable tipo:int

        //                    cmd.ExecuteNonQuery();
        //                }

        //                tran.Commit();
        //                cnn.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                tran.Rollback();
        //            }
        //            return rows > 0;
        //        }
        //    }
    }
}
