using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPEDIDO
	{
        public bool insertarRegistroMaestroDetalle(ePEDIDO oePEDIDO, List<eDETALLE_PEDIDO> oeDETALLE_PEDIDO)
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
                    cmd.CommandText = "pa_crud_PEDIDO_insertarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@PED_FECHA_ENTREGA", oePEDIDO.PED_fecha_entrega)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oePEDIDO.VEN_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_NOMBRE_VENDEDOR", oePEDIDO.PED_nombre_vendedor)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oePEDIDO.SOC_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_SOC_NOMBRE_RAZON", oePEDIDO.PED_soc_nombre_razon)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_SOC_DIRECCION", oePEDIDO.PED_soc_direccion)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_SOC_ZONA", oePEDIDO.PED_soc_zona)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_SUBTOTAL", oePEDIDO.PED_subtotal)); //variable tipo:double                    
                    cmd.Parameters.Add(new SqlParameter("@PED_PORCENTAJE_PERCEPCION", oePEDIDO.PED_porcentaje_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_IGV", oePEDIDO.PED_monto_igv)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_ISC", oePEDIDO.PED_monto_isc)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_PERCEPCION", oePEDIDO.PED_monto_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_TOTAL", oePEDIDO.PED_monto_total)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_COMENTARIO", (object)oePEDIDO.PED_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_ESTADO", oePEDIDO.PED_estado)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oePEDIDO.CPA_codigo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_TDO_CODIGO", oePEDIDO.PED_tdo_codigo)); //variable tipo:string

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_op_crud_DETALLE_PEDIDO_insertarRegistro]";

                    for (int i = 0; i < oeDETALLE_PEDIDO.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_PEDIDO o = new eDETALLE_PEDIDO();
                        o = oeDETALLE_PEDIDO[i];

                        cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", o.PED_numero)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", o.DPE_is_bonificacion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_PRO_DESCRIPCION", o.DPE_pro_descripcion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_PRO_UME_MULTIPLO", o.DPE_pro_ume_multiplo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD", o.DPE_cantidad)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD_SUBMULTIPLO", (object)o.DPE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPE_PRECIO_UNITARIO", o.DPE_precio_unitario)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_SUBTOTAL", o.DPE_monto_subtotal)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_DESCUENTO", o.DPE_monto_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_DESCUENTO", o.DPE_porcentaje_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_IGV", o.DPE_monto_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_ISC", o.DPE_monto_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_IGV", o.DPE_porcentaje_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_ISC", o.DPE_porcentaje_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_TOTAL_LINEA", o.DPE_monto_total_linea)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MEMO", (object)o.DPE_memo ?? DBNull.Value)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_NUMERO_FILA", o.DPE_numero_fila)); //variable tipo:int

                        rows = cmd.ExecuteNonQuery();
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

        public bool actualizarRegistroMaestroDetalle(ePEDIDO oePEDIDO, List<eDETALLE_PEDIDO> oeDETALLE_PEDIDO)
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
                    cmd.CommandText = "pa_op_crud_PEDIDO_actualizarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", oePEDIDO.PED_numero)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@PED_FECHA_ENTREGA", oePEDIDO.PED_fecha_entrega)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@VEN_CODIGO", oePEDIDO.VEN_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_NOMBRE_VENDEDOR", oePEDIDO.PED_nombre_vendedor)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@SOC_CODIGO", oePEDIDO.SOC_codigo)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_SOC_NOMBRE_RAZON", oePEDIDO.PED_soc_nombre_razon)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_SOC_DIRECCION", oePEDIDO.PED_soc_direccion)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_SOC_ZONA", oePEDIDO.PED_soc_zona)); //variable tipo:int
                    cmd.Parameters.Add(new SqlParameter("@PED_SUBTOTAL", oePEDIDO.PED_subtotal)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_PORCENTAJE_PERCEPCION", oePEDIDO.PED_porcentaje_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_IGV", oePEDIDO.PED_monto_igv)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_ISC", oePEDIDO.PED_monto_isc)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_PERCEPCION", oePEDIDO.PED_monto_percepcion)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_MONTO_TOTAL", oePEDIDO.PED_monto_total)); //variable tipo:double
                    cmd.Parameters.Add(new SqlParameter("@PED_COMENTARIO", (object)oePEDIDO.PED_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_ESTADO", oePEDIDO.PED_estado)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@CPA_CODIGO", oePEDIDO.CPA_codigo)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PED_TDO_CODIGO", oePEDIDO.PED_tdo_codigo)); //variable tipo:string

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_op_crud_DETALLE_PEDIDO_actualizarRegistro]";

                    for (int i = 0; i < oeDETALLE_PEDIDO.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_PEDIDO o = new eDETALLE_PEDIDO();
                        o = oeDETALLE_PEDIDO[i];

                        cmd.Parameters.Add(new SqlParameter("@PED_NUMERO", o.PED_numero)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@PRO_CODIGO", o.PRO_codigo)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_IS_BONIFICACION", o.DPE_is_bonificacion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_PRO_DESCRIPCION", o.DPE_pro_descripcion)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_PRO_UME_MULTIPLO", o.DPE_pro_ume_multiplo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD", o.DPE_cantidad)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPE_CANTIDAD_SUBMULTIPLO", (object)o.DPE_cantidad_submultiplo ?? DBNull.Value)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPE_PRECIO_UNITARIO", o.DPE_precio_unitario)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_SUBTOTAL", o.DPE_monto_subtotal)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_DESCUENTO", o.DPE_monto_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_DESCUENTO", o.DPE_porcentaje_descuento)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_IGV", o.DPE_monto_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_ISC", o.DPE_monto_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_IGV", o.DPE_porcentaje_igv)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_PORCENTAJE_ISC", o.DPE_porcentaje_isc)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MONTO_TOTAL_LINEA", o.DPE_monto_total_linea)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPE_MEMO", (object)o.DPE_memo ?? DBNull.Value)); //variable tipo:string
                        cmd.Parameters.Add(new SqlParameter("@DPE_NUMERO_FILA", o.DPE_numero_fila)); //variable tipo:int

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

        public bool anularRegistro(ePEDIDO oePEDIDO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_PEDIDO_anularRegistro";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();

                cmd.Parameters.Add(new SqlParameter("@PED_numero", oePEDIDO.PED_numero));
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable obtenerInformacionGeneracion(ePEDIDO oePEDIDO)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_bf_PEDIDO_DataOrigenGeneracion";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public int generarDocumentosVenta(ePEDIDO oePEDIDO, string serie, int correlativoInicial)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "pa_op_PEDIDO_migrarPedidos";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@PED_FECHA", oePEDIDO.PED_fecha));
                cmd.Parameters.Add(new SqlParameter("@FECHA_ENTREGA", oePEDIDO.PED_fecha));
                cmd.Parameters.Add(new SqlParameter("@PED_TDO_CODIGO", oePEDIDO.PED_tdo_codigo)); //variable tipo:DateTime
                cmd.Parameters.Add(new SqlParameter("@SER_SERIE", serie)); //variable tipo:DateTime
                cmd.Parameters.Add(new SqlParameter("@CorrelativoInicial", correlativoInicial)); //variable tipo:int

                SqlParameter par = new SqlParameter("@FilasResult", SqlDbType.Int);
                par.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par);
                
                cmd.ExecuteNonQuery();

                return Convert.ToInt32(cmd.Parameters["@FilasResult"].Value);
            }
        }
    }
}
