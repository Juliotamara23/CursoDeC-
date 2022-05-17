using System;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(String[] args)
        {
            realizarTarea();

            var miVarible = new { Nombre = "Zaizor", Edad = 24 };

            Console.WriteLine(miVarible.Nombre + " " + miVarible.Edad);

            var miOtraVarible = new { Nombre = "Julia", Edad = 25 };

            miVarible = miOtraVarible;
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(239, 80);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los putos es: {distancia}");
            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}