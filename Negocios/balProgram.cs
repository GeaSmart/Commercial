using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Negocios
{
    public class balProgram
    {
        private static dalProgram _dalProgram = new dalProgram();

        public static bool sincronizarDescuentosEspeciales()
        {
            return _dalProgram.sincronizarDescuentosEspeciales();            
        }

        public static bool sincronizarBonificacionesEspeciales()
        {
            return _dalProgram.sincronizarBonificacionesEspeciales();
        }
    }
}
