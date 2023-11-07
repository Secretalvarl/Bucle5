using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle5.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo para pedir por consola un mes
        /// 06112023-agb
        /// </summary>
        /// <returns></returns>
        public int pedirMes()
        {
            int mes;
            Console.Write("Escribe un mes ");
            mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        /// <summary>
        /// Metodo para pedir por consola un año
        /// 06112023-agb
        /// </summary>
        /// <returns></returns>
        public int pedirAño()
        {
            int año;
            Console.Write("Escribe un año ");
            año = Convert.ToInt32(Console.ReadLine());
            return año;

        }

        /// <summary>
        /// Metodo para pedir por consola una S para seguir
        /// 06112023-agb
        /// </summary>
        /// <returns></returns>
        public string pedirS()
        {
            Console.WriteLine("Escribe una s si quiere seguir");
            string s = Console.ReadLine();
            return s;
        }



    }
}
