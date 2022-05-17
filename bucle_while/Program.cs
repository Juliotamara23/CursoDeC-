using System;

namespace bucle_while;

    class Program{

    public static void Main(string[] args) 
    {
        //Console.WriteLine("Deseas entrar en el bucle while?");

        //string respuesta = Console.ReadLine();

        //while (respuesta != "no")
        //{
        //    Console.WriteLine("Estas ejecutando el buble while");2

        //    Console.WriteLine("introduce tu nombre");

        //    string nombre = Console.ReadLine();

        //    Console.WriteLine($"salgras del buble while {nombre} cuando respondas no");

        //    Console.WriteLine("deseas repetir de nuevo?");

        //    respuesta = Console.ReadLine();
        //}
        //Console.WriteLine("has salido del buble");

        int z = 10;

        do
        {
            Console.WriteLine("Impresion" + z);
            z++;
        } while (z < 15); 
    }
}
