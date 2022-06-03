// See https://aka.ms/new-console-template for more information

List<int> numeros = new List<int>(); //Declarar una lista (Coleccion de tipo lista)

Console.WriteLine("\n introduce elementos en la coleccion (digita 0 para salir): ");

int elem = 1;

while (elem != 0)
{
    elem = Int32.Parse(Console.ReadLine());

    numeros.Add(elem);
}

numeros.RemoveAt(numeros.Count - 1);

Console.WriteLine("\n Elementos introducidos: ");

foreach (int elemento in numeros)
{
    Console.WriteLine(elemento);
}