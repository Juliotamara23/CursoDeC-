using System.Linq;

// See https://aka.ms/new-console-template for more information

int[] ValoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Numeros pares: ");

//list<int> numerosPares = new list<int>();

//foreach (int i in valoresnumericos)
//{
//    if (i % 2 == 0)
//    {
//        numerospares.add(i);
//    }
//}

//foreach (int i in numerosPares)
//{
//    console.writeline(i);
//}

IEnumerable<int> numerosPares = from numero in ValoresNumericos where numero%2 ==0 select numero;

foreach (int i in numerosPares)
{
    Console.WriteLine(i);
}