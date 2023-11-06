using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle5.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirMes()
        {
            int mes;
            Console.Write("Escribe un mes ");
            mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        public int pedirAño()
        {
            int año;
            Console.Write("Escribe un año ");
            año = Convert.ToInt32(Console.ReadLine());
            return año;

        }

        public string pedirS()
        {
            Console.WriteLine("Escribe una s si quiere seguir");
            string s = Console.ReadLine();
            return s;
        }



    }
}
