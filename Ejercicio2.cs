using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrdenamientoBusquedaBarahonaJorge
{
    class Ejercicio2
    {
        public static void Ejec()
        {
            Random r = new Random();
            int[] arr = new int[10];
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = r.Next(10);
            }
            
            Console.WriteLine("Arreglo Original: "+ string.Join(", ",arr));
            
            for(int i=0;i<arr.Length-1; i++)
            {
                for(int v=i; v < arr.Length - 1; v++)
                {
                    if (arr[i]>arr[v+1])
                    {
                        var ex = arr[i];
                        arr[i] = arr[v + 1];
                        arr[v + 1] = ex;
                    }
                }
                Console.WriteLine($"Resultante Pasada {i + 1}: {string.Join(", ", arr)}");
            }
        }
    }
}
