using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
	public partial class dalPROGRAMACION
	{
        public bool insertarRegistroMaestroDetalle(ePROGRAMACION oePROGRAMACION, List<eDETALLE_PROG> oeDETALLE_PROGRAMACION)
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
                    cmd.CommandText = "pa_crud_PROGRAMACION_insertarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", oePROGRAMACION.PRG_fecha)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@PRG_COMENTARIO", (object)oePROGRAMACION.PRG_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PRG_ULTIMA_MOD", oePROGRAMACION.PRG_ultima_mod)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@PRG_ESTADO", oePROGRAMACION.PRG_estado)); //variable tipo:string

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_crud_DETALLE_PROG_insertarRegistro]";

                    for (int i = 0; i < oeDETALLE_PROGRAMACION.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_PROG o = new eDETALLE_PROG();
                        o = oeDETALLE_PROGRAMACION[i];

                        cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", o.PRG_fecha)); //variable tipo:DateTime
                        cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", o.CHO_codigo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", o.DPR_numero_viaje)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_DESDE", o.DPR_zona_desde)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_HASTA", o.DPR_zona_hasta)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_PESO", o.DPR_peso)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_PEDIDOS", o.DPR_numero_documentos)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_CANTIDAD_PRODUCTO", o.DPR_cantidad_producto)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@VEH_PLACA", o.VEH_placa)); //variable tipo:string

                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                }
                return rows > 0;
            }
        }

        public bool actualizarRegistroMaestroDetalle(ePROGRAMACION oePROGRAMACION, List<eDETALLE_PROG> oeDETALLE_PROGRAMACION)
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
                    cmd.CommandText = "pa_crud_PROGRAMACION_actualizarRegistro";

                    cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", oePROGRAMACION.PRG_fecha)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@PRG_COMENTARIO", (object)oePROGRAMACION.PRG_comentario ?? DBNull.Value)); //variable tipo:string
                    cmd.Parameters.Add(new SqlParameter("@PRG_ULTIMA_MOD", oePROGRAMACION.PRG_ultima_mod)); //variable tipo:DateTime
                    cmd.Parameters.Add(new SqlParameter("@PRG_ESTADO", oePROGRAMACION.PRG_estado)); //variable tipo:string

                    rows = cmd.ExecuteNonQuery();

                    //INSERTAMOS EL DETALLE
                    cmd.CommandText = "[pa_crud_DETALLE_PROG_actualizarRegistro]";

                    for (int i = 0; i < oeDETALLE_PROGRAMACION.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_PROG o = new eDETALLE_PROG();
                        o = oeDETALLE_PROGRAMACION[i];

                        cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", o.PRG_fecha)); //variable tipo:DateTime
                        cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", o.CHO_codigo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", o.DPR_numero_viaje)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_DESDE", o.DPR_zona_desde)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_ZONA_HASTA", o.DPR_zona_hasta)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_PESO", o.DPR_peso)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_PEDIDOS", o.DPR_numero_documentos)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_CANTIDAD_PRODUCTO", o.DPR_cantidad_producto)); //variable tipo:double
                        cmd.Parameters.Add(new SqlParameter("@VEH_PLACA", o.VEH_placa)); //variable tipo:string

                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                }
                return rows > 0;
            }
        }

        public DataTable obtenerInformacionDirigida(ePROGRAMACION oePROGRAMACION, eDETALLE_PROG oeDETALLE_PROGRAMACION)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaPrincipal"].ToString()))
            {
                string sp = "[pa_bf_PROGRAMACION_informacionDirigida]";
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.SelectCommand.Parameters.Add(new SqlParameter("@PRG_fecha", oePROGRAMACION.PRG_fecha));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@DPR_zona_desde", oeDETALLE_PROGRAMACION.DPR_zona_desde));
                dad.SelectCommand.Parameters.Add(new SqlParameter("@DPR_zona_hasta", oeDETALLE_PROGRAMACION.DPR_zona_hasta));

                DataTable dt = new DataTable();
                dad.Fill(dt);

                return dt;
            }
        }

        public bool eliminarRegistroMaestroDetalle(ePROGRAMACION oePROGRAMACION, List<eDETALLE_PROG> oeDETALLE_PROGRAMACION)
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
                    //ELIMINAMOS EL DETALLE
                    cmd.CommandText = "[pa_crud_DETALLE_PROG_eliminarRegistro]";

                    for (int i = 0; i < oeDETALLE_PROGRAMACION.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        eDETALLE_PROG o = new eDETALLE_PROG();
                        o = oeDETALLE_PROGRAMACION[i];

                        cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", o.PRG_fecha)); //variable tipo:DateTime
                        cmd.Parameters.Add(new SqlParameter("@CHO_CODIGO", o.CHO_codigo)); //variable tipo:int
                        cmd.Parameters.Add(new SqlParameter("@DPR_NUMERO_VIAJE", o.DPR_numero_viaje)); //variable tipo:int

                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "pa_crud_PROGRAMACION_eliminarRegistro";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@PRG_FECHA", oePROGRAMACION.PRG_fecha)); //variable tipo:DateTime

                    rows = cmd.ExecuteNonQuery();

                    tran.Commit();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                }
                return rows > 0;
            }
        }
    }
}
