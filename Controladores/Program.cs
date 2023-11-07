using Bucle5.Servicios;

namespace Bucle5
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string s;

            //Crear copias de los metodos
            //06112023-agb
            MenuInterfaz alpha = new MenuImplementacion();
            CasosInterfaz omega = new CasosImplementacion();

            do
            {
                //Llamadas y definicion de cada variable
                //06112023-agb
                int mes = alpha.pedirMes();
                int año = alpha.pedirAño();

                omega.pedirCaso(mes, año);

                s = alpha.pedirS();

            } while (s == "S");
        }

    }
}

