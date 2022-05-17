using System;

namespace Practica_metodos{


    class Program
{
        static void Main(String[] args)
        {
            mensajeEnPantalla();

            Console.WriteLine("Mensaje ddesdde el main");
        }
        
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
        }
}

}