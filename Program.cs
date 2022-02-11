using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrdenamientoBusquedaBarahonaJorge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            bool le = false;
            while (input != "0")
            {
                Console.WriteLine("Escoja Ejercicio a ejecutar (Ingrese numero de ejercicio): \n1) Ejercicio 1\n2) Ejercicio 2\n0) Salir");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1": {
                            Ejercicio1.Ejec();
                            break;
                        }
                    case "2":
                        {
                            Ejercicio2.Ejec();
                            break;
                        }
                    case "0":
                        {
                            le = true;
                            break;
                        }             
                    default:
                        {
                            Console.WriteLine("Seleccion invalida");
                            break;
                        }
                }
                if (le) break;
                Console.ReadKey();
            }
            
        }
    }
}
