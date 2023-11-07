using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle5.Servicios
{

    internal class CasosImplementacion : CasosInterfaz
    {
        /// <summary>
        /// Metodo para dar los dias del mes pedido
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="año"></param>
        public void pedirCaso(int mes, int año)
        {
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    Console.WriteLine("El mes seleccionado tiene 31 dias");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:

                    Console.WriteLine("El mes seleccionado tiene 30 dias");
                    break;

                case 2:

                    if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                    {
                        Console.WriteLine("En este año febrero tiene 29 dias");
                    }
                    else
                    {
                        Console.WriteLine("En este año febrero tiene 28 dias");
                    }
                    break;
            }
        }
    }
}









