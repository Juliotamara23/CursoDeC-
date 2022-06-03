// See https://aka.ms/new-console-template for more information

using Struct_y_Enum;
using static Struct_y_Enum.Enum;

//Empleado empleado1 = new Empleado(1200,250);

//empleado1.cambiaSalario(empleado1, 100);

//Console.WriteLine(empleado1);

Empleado Juan = new Empleado(Bonus.extra, 1900.50);
Console.WriteLine("El salario del empleado es: " + Juan.getSalario());