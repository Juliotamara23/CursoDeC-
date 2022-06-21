// See https://aka.ms/new-console-template for more information

Thread t = new Thread(MetodoSaludo);
t.Start();

Thread t2 = new Thread(MetodoSaludo);
t2.Start();

Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
Thread.Sleep(500);
Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
Thread.Sleep(500);
Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
Thread.Sleep(500);
Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
Thread.Sleep(500);
Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");

static void MetodoSaludo()
{
    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
    Thread.Sleep(500);
    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
    Thread.Sleep(500);
    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
    Thread.Sleep(500);
    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
    Thread.Sleep(500);
    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
}
