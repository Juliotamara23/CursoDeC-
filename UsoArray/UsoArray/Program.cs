using System;

namespace UsoArray
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] arrayElementos = leerdatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arrayElementos) Console.WriteLine(i); ;
        }

        static int[] leerdatos()
        {
            Console.WriteLine("Cuantos elemetos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }

                return datos;
        }
    }

}
