 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle5.Servicios
{
    internal interface CasosInterfaz
    {
        /// <summary>
        /// Interfaz para pedir casos
        /// 06112023-agb
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="año"></param>
        public void pedirCaso(int mes, int año);
    }
}
