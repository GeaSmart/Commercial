using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Presentacion
{
    public class SharedData
    {
        private static SharedData oInstance;
        //private Cliente clientes;

        protected SharedData()
        {
        }

        public static SharedData Instance()
        {

            if (oInstance == null)
                oInstance = new SharedData();

            return oInstance;
        }

        public string USU_usuario { get; set; }
        public string USU_nombre_completo { get; set; }
        public string Perfil { get; set; }
        //public string[] Reglas { get; set; }
        public string Reglas { get; set; }

        public string getPermiso(string permiso)
        {
            string rpta = "";
            switch (permiso)
            {
                case "ALMACEN_VER": rpta = "1"; break;
                case "ALMACEN_CREAR": rpta = "2"; break;
                case "ALMACEN_MODIFICAR": rpta = "3"; break;
                case "ALMACEN_ELIMINAR": rpta = "4"; break;
                case "BONIFICACION_VER": rpta = "5"; break;
                case "BONIFICACION_MODIFICAR": rpta = "6"; break;
                case "CANAL_VER": rpta = "7"; break;
                case "CANAL_CREAR": rpta = "8"; break;
                case "CANAL_MODIFICAR": rpta = "9"; break;
                case "CANAL_ELIMINAR": rpta = "10"; break;
                case "CATEGORIA_VER": rpta = "11"; break;
                case "CATEGORIA_CREAR": rpta = "12"; break;
                case "CATEGORIA_MODIFICAR": rpta = "13"; break;
                case "CATEGORIA_ELIMINAR": rpta = "14"; break;
                case "CHOFER_VER": rpta = "15"; break;
                case "CHOFER_CREAR": rpta = "16"; break;
                case "CHOFER_MODIFICAR": rpta = "17"; break;
                case "CHOFER_ELIMINAR": rpta = "18"; break;
                case "CONDICION_PAGO_VER": rpta = "19"; break;
                case "CONDICION_PAGO_CREAR": rpta = "20"; break;
                case "CONDICION_PAGO_MODIFICAR": rpta = "21"; break;
                case "CONDICION_PAGO_ELIMINAR": rpta = "22"; break;
                case "DESCUENTO_VER": rpta = "23"; break;
                case "DESCUENTO_MODIFICAR": rpta = "24"; break;
                case "DESCUENTO_P_VER": rpta = "25"; break;
                case "DESCUENTO_P_MODIFICAR": rpta = "26"; break;
                case "DETALLE_LISTA_PRECIO_VER": rpta = "27"; break;
                case "DETALLE_LISTA_PRECIO_MODIFICAR": rpta = "28"; break;
                case "FORMATO_VER": rpta = "29"; break;
                case "FORMATO_CREAR": rpta = "30"; break;
                case "FORMATO_MODIFICAR": rpta = "31"; break;
                case "FORMATO_ELIMINAR": rpta = "32"; break;
                case "LINEA_VER": rpta = "33"; break;
                case "LINEA_CREAR": rpta = "34"; break;
                case "LINEA_MODIFICAR": rpta = "35"; break;
                case "LINEA_ELIMINAR": rpta = "36"; break;
                case "LISTA_PRECIO_VER": rpta = "37"; break;
                case "LISTA_PRECIO_CREAR": rpta = "38"; break;
                case "LISTA_PRECIO_MODIFICAR": rpta = "39"; break;
                case "LISTA_PRECIO_ELIMINAR": rpta = "40"; break;
                case "MARCA_VER": rpta = "41"; break;
                case "MARCA_CREAR": rpta = "42"; break;
                case "MARCA_MODIFICAR": rpta = "43"; break;
                case "MARCA_ELIMINAR": rpta = "44"; break;
                case "MOTIVO_DEVOLUCION_VER": rpta = "45"; break;
                case "MOTIVO_DEVOLUCION_CREAR": rpta = "46"; break;
                case "MOTIVO_DEVOLUCION_MODIFICAR": rpta = "47"; break;
                case "MOTIVO_DEVOLUCION_ELIMINAR": rpta = "48"; break;
                case "PEDIDO_GENERACION_VER": rpta = "49"; break;
                case "PEDIDO_IMPORTACION_VER": rpta = "50"; break;
                case "PEDIDO_VER": rpta = "51"; break;
                case "PEDIDO_CREAR": rpta = "120"; break;
                case "PEDIDO_MODIFICAR": rpta = "52"; break;
                case "PEDIDO_ANULAR": rpta = "53"; break;
                case "PEDIDO_GENERAR": rpta = "54"; break;
                case "PEDIDO_IMPORTAR": rpta = "55"; break;
                case "PERFIL_VER": rpta = "56"; break;
                case "PERFIL_CREAR": rpta = "57"; break;
                case "PERFIL_MODIFICAR": rpta = "58"; break;
                case "PERFIL_ELIMINAR": rpta = "59"; break;
                case "PERFIL_REGLA_VER": rpta = "60"; break;
                case "PERFIL_REGLA_MODIFICAR": rpta = "61"; break;
                case "PRODUCTO_VER": rpta = "62"; break;
                case "PRODUCTO_CREAR": rpta = "63"; break;
                case "PRODUCTO_MODIFICAR": rpta = "64"; break;
                case "PRODUCTO_ELIMINAR": rpta = "65"; break;
                case "PROGRAMACION_VER": rpta = "66"; break;
                case "PROGRAMACION_CREAR": rpta = "67"; break;
                case "PROGRAMACION_MODIFICAR": rpta = "68"; break;
                case "PROGRAMACION_ELIMINAR": rpta = "69"; break;
                case "RUTA_VER": rpta = "70"; break;
                case "RUTA_CREAR": rpta = "71"; break;
                case "RUTA_MODIFICAR": rpta = "72"; break;
                case "RUTA_ELIMINAR": rpta = "73"; break;
                case "SERIE_VER": rpta = "74"; break;
                case "SERIE_CREAR": rpta = "75"; break;
                case "SERIE_MODIFICAR": rpta = "76"; break;
                case "SERIE_ELIMINAR": rpta = "77"; break;
                case "SOCIO_VER": rpta = "78"; break;
                case "SOCIO_CREAR": rpta = "79"; break;
                case "SOCIO_MODIFICAR": rpta = "80"; break;
                case "SOCIO_ELIMINAR": rpta = "81"; break;
                case "TIPO_DOCUMENTO_VER": rpta = "82"; break;
                case "TIPO_DOCUMENTO_CREAR": rpta = "83"; break;
                case "TIPO_DOCUMENTO_MODIFICAR": rpta = "84"; break;
                case "TIPO_DOCUMENTO_ELIMINAR": rpta = "85"; break;
                case "TIPO_NEGOCIO_VER": rpta = "86"; break;
                case "TIPO_NEGOCIO_CREAR": rpta = "87"; break;
                case "TIPO_NEGOCIO_MODIFICAR": rpta = "88"; break;
                case "TIPO_NEGOCIO_ELIMINAR": rpta = "89"; break;
                case "TIPO_VENTA_VER": rpta = "90"; break;
                case "TIPO_VENTA_CREAR": rpta = "91"; break;
                case "TIPO_VENTA_MODIFICAR": rpta = "92"; break;
                case "TIPO_VENTA_ELIMINAR": rpta = "93"; break;
                case "UNIDAD_MEDIDA_VER": rpta = "94"; break;
                case "UNIDAD_MEDIDA_CREAR": rpta = "95"; break;
                case "UNIDAD_MEDIDA_MODIFICAR": rpta = "96"; break;
                case "UNIDAD_MEDIDA_ELIMINAR": rpta = "97"; break;
                case "USUARIO_VER": rpta = "98"; break;
                case "USUARIO_CREAR": rpta = "99"; break;
                case "USUARIO_MODIFICAR": rpta = "100"; break;
                case "USUARIO_ELIMINAR": rpta = "101"; break;
                case "VEHICULO_VER": rpta = "102"; break;
                case "VEHICULO_CREAR": rpta = "103"; break;
                case "VEHICULO_MODIFICAR": rpta = "104"; break;
                case "VEHICULO_ELIMINAR": rpta = "105"; break;
                case "VENDEDOR_VER": rpta = "106"; break;
                case "VENDEDOR_CREAR": rpta = "107"; break;
                case "VENDEDOR_MODIFICAR": rpta = "108"; break;
                case "VENDEDOR_ELIMINAR": rpta = "109"; break;
                case "VENTA_VER": rpta = "110"; break;
                case "VENTA_CREAR": rpta = "111"; break;
                case "VENTA_MODIFICAR": rpta = "112"; break;
                case "VENTA_ANULAR": rpta = "113"; break;
                case "VISITA_VER": rpta = "114"; break;
                case "VISITA_MODIFICAR": rpta = "115"; break;
                case "ZONA_VER": rpta = "116"; break;
                case "ZONA_CREAR": rpta = "117"; break;
                case "ZONA_MODIFICAR": rpta = "118"; break;
                case "ZONA_ELIMINAR": rpta = "119"; break;
                case "INFOSISTEMA":rpta = "121";break; //PERMISO PARA VER INFO DEL SISTEMA
                case "COMPRA_VER": rpta = "122"; break;
                case "COMPRA_CREAR": rpta = "123"; break;
                case "COMPRA_MODIFICAR": rpta = "124"; break;
                case "COMPRA_ANULAR": rpta = "125"; break;
                case "NOTA_CREDITO_VER": rpta = "126"; break;
                case "NOTA_CREDITO_CREAR": rpta = "127"; break;
                case "NOTA_CREDITO_MODIFICAR": rpta = "128"; break;
                case "NOTA_CREDITO_ANULAR": rpta = "129"; break;
                case "IMPUESTO_VER": rpta = "130"; break;
                case "IMPUESTO_CREAR": rpta = "131"; break;
                case "IMPUESTO_MODIFICAR": rpta = "132"; break;
                case "IMPUESTO_ELIMINAR": rpta = "133"; break;
            }

            return rpta;
        }

        //public eUSUARIO Clientes
        //{
        //    get
        //    {
        //        if (cliente = null)
        //            cliente = new Clientes();
        //        return clientes;
        //    }
        //}
    }
}
