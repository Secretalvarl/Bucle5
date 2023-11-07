   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle5.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Interfaz para pedir mes
        /// 06112023-agb
        /// </summary>
        /// <returns></returns>
        public int pedirMes();

        /// <summary>
        /// Interfaz para pedir año
        /// 06112023-agb
        /// </summary>
        /// <returns></returns>
        public int pedirAño();

        /// <summary>
        /// interfaz para pedir S
        /// 06112023-agb
        /// </summary>
        /// <returns></returns>
        public string pedirS();
    }
}
