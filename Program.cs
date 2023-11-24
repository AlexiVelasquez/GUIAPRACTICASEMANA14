using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIAPRACTICASEMANA14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantalla.PantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantalla.VacunacionCovid();
                        break;
                    case 2:
                        opcion = Pantalla.DatosEncuestaCovid();
                        break;
                    case 3:
                        opcion = Pantalla.Resultados();
                        break;
                    case 4:
                        opcion = Pantalla.Buscador();
                        break;  
                    case 0:
                    default:
                        opcion = Pantalla.PantallaPrincipal();
                        break;
                }
            } while (opcion != 5);
            Console.ReadLine();
        }
    }
}
