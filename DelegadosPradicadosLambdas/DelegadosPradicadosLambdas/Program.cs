// See https://aka.ms/new-console-template for more information

// Creacion del objeto delegado apuntado a MensajeBienvenida
ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

// Utilizacion del delegado para llamar al metodo saludoBienvenida
ElDelegado("Hola acabo de llegar");

ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

ElDelegado("Hola ya me voy");

// Definicion del objeto delegado
delegate void ObjetoDelegado(string mjs);

class MensajeBienvenida
{
    public static void SaludoBienvenida(string mjs)
    {
        Console.WriteLine("Mensaje de bienvenida: {0}", mjs);
    }
}

class MensajeDespedida
{
    public static void SaludoDespedida(string mjs)
    {
        Console.WriteLine("Mensaje de despedida: {0}", mjs);
    }
}