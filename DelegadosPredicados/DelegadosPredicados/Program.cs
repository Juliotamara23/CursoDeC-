// See https://aka.ms/new-console-template for more information

Personas P1 = new Personas();
P1.Nombre = "Juan";
P1.Edad = 18;

Personas P2 = new Personas();
P2.Nombre = "Maria";
P2.Edad = 28;

ComparaPersonas compareEdad = (persona1, persona2) => persona1 == persona2;

Console.WriteLine(compareEdad(P1.Edad, P2.Edad));

public delegate bool ComparaPersonas(int edad1, int edad2);

class Personas
{
    private string nombre;

    private int edad;

    public int Edad { get => edad; set => edad = value; }
    public string Nombre { get => nombre; set => nombre = value; }
}