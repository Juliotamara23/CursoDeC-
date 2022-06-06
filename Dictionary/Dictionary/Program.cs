// See https://aka.ms/new-console-template for more information

Dictionary<string, int> edades = new Dictionary<string, int>();

// Rellenar el diccionario

edades.Add("Juan", 18);

edades.Add("Diandra", 35);

edades["Maria"] = 25;

edades["Antonio"] = 29;

foreach (KeyValuePair<string, int> persona in edades)
{
    Console.WriteLine("Nombre {0}, Edad: {1}", persona.Key, persona.Value);
}