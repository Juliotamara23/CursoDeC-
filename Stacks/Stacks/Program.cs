// See https://aka.ms/new-console-template for more information

Stack <int> numeros = new Stack<int>();

//Agregando elementos a la Stack

foreach (int numero in new int[5] { 2, 4, 5, 8, 10 })
{
    numeros.Push(numero);
}

//Recorriendo la cola

Console.WriteLine("Recorriendo el Stack: ");

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine();
//Eliminando elementos de la cola

Console.WriteLine("Eliminando los elementos del stack: ");
numeros.Pop();

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
