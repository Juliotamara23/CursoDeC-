// See https://aka.ms/new-console-template for more information

List<Personas> gente = new List<Personas>();

Personas P1 = new Personas();
P1.Nombre = "Juan";
P1.Edad = 18;

Personas P2 = new Personas();
P2.Nombre = "Maria";
P2.Edad = 28;

Personas P3 = new Personas();
P3.Nombre = "Ana";
P3.Edad = 38;

gente.AddRange(new Personas[] { P1, P2, P3 });

Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

bool existe = gente.Exists(elPredicado);

if (existe)
{
    Console.WriteLine("Hay personas que se llaman Juan");
}
else Console.WriteLine("No hay personas que se llaman Juan");

static bool ExisteJuan(Personas persona)
{
    if (persona.Nombre == "Juan")
    {
        return true;
    }else return false;
}

class Personas
{
    private string nombre;

    private int edad;

    public int Edad { get => edad; set => edad = value; }
    public string Nombre { get => nombre; set => nombre = value; }
}