// See https://aka.ms/new-console-template for more information
using AvisosVarios;

AvisosTrafico av1 = new AvisosTrafico();

av1.mostrarAviso();

AvisosTrafico av2 = new AvisosTrafico("Jefactura providencial Madrir",
    "Sancion de velocidad: 300 $", "02-05-19");

Console.WriteLine(av2.getFecha());
av2.mostrarAviso();