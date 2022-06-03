// See https://aka.ms/new-console-template for more information

LinkedList<int> numeros = new LinkedList<int> ();

foreach (int numero in new int[] {10, 4, 5, 6, 8, 0})
{
    numeros.AddFirst(numero);
}

//numeros.Remove(6);

LinkedListNode<int> nodeImportante = new LinkedListNode<int>(15);
numeros.AddFirst(nodeImportante);

//foreach (int numero in numeros)
//{
//    Console.WriteLine(numero);
//}

for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
{
    int numero = nodo.Value;

    Console.WriteLine(numero);
}