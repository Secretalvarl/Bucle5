using Bucle5.Servicios;

namespace Bucle5
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string s;

            MenuInterfaz alpha = new MenuImplementacion();
            CasosInterfaz omega = new CasosImplementacion();

            do
            {
                int mes = alpha.pedirMes();
                int año = alpha.pedirAño();

                omega.pedirCaso(mes, año);

                s = alpha.pedirS();

            } while (s == "S");
        }

    }
}

