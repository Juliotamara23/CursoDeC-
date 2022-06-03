// See https://aka.ms/new-console-template for more information

Queue <int> numeros = new Queue<int> ();

//Agregando elementos a la cola

foreach (int numero in new int[5] {2, 4, 5, 8, 10})
{
    numeros.Enqueue(numero);
}

//Recorriendo la cola

Console.WriteLine("Recorriendo el Queue: ");

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine();
//Eliminando elementos de la cola

Console.WriteLine("Eliminando los elementos: ");
numeros.Dequeue();

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}