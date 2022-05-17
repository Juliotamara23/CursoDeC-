using System;

namespace Switch
{

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Elige medio de transporte (coche, tren, avion)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media: 100km/h");
                    break;
                
                case "tren":
                    Console.WriteLine("Velocidad media: 250 km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media: 800 km/h");
                    break;

                    default: Console.WriteLine("Transporte no contemplado");
                    break;
            }
        }
    }
}