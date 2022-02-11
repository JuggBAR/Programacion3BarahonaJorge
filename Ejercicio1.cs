using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrdenamientoBusquedaBarahonaJorge
{
    class Ejercicio1
    {
        public static void Ejec()
        {
            string nombre;
            byte edad;

            Console.WriteLine("De Cuantas Personas desea crear el arreglo");
            Persona[] arr = new Persona[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ingrese Nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Edad: ");
                edad = byte.Parse(Console.ReadLine());
                arr[i] = new Persona { Nombre = nombre, Edad = edad };
            }
            ImprimirArreglo(arr, "\n\nOriginal: ");
            Console.WriteLine($"\n\nPersona con menor edad : {BusquedaSequencialDeNombre(arr)}");
            ImprimirArreglo(OrdenarPorNombre(arr), "\n\nOrdenado Por Nombre: ");
            ImprimirArreglo(OrdenarPorEdad(arr), "\n\nOrdenado Por Edad: ");
        }
        public static Persona[] OrdenarPorNombre(Persona[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int v = 0; v < i; v++)
                {
                    if (arr[v].Nombre[0] > arr[v + 1].Nombre[0])
                    {
                        var ex = arr[v];
                        arr[v] = arr[v + 1];
                        arr[v + 1] = ex;
                    }
                    if (arr[v].Nombre[0] == arr[v + 1].Nombre[0])
                    {
                        if (arr[v].Nombre[1] > arr[v + 1].Nombre[1])
                        {
                            var ex = arr[v];
                            arr[v] = arr[v + 1];
                            arr[v + 1] = ex;
                        }
                    }
                }
            }
            return arr;
        }


        public static Persona[] OrdenarPorEdad(Persona[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int v = 0; v < i; v++)
                {
                    if (arr[v].Edad > arr[v + 1].Edad)
                    {
                        var ex = arr[v];
                        arr[v] = arr[v + 1];
                        arr[v + 1] = ex;
                    }
                }
            }
            return arr;
        }
        public static string BusquedaSequencialDeNombre(Persona[] arr)
        {
            byte menor = arr[0].Edad;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Edad < menor)
                {
                    menor = arr[i].Edad;
                    index = i;
                };
            }
            return arr[index].Nombre;
        }
        public static void ImprimirArreglo(Persona[] arr, string mes)
        {
            Console.WriteLine(mes);
            foreach (Persona p in arr)
            {
                Console.WriteLine($"Nombre: {p.Nombre}  Edad: {p.Edad}");
            }
        }
    }
}
