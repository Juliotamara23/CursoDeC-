// See https://aka.ms/new-console-template for more information

Task tarea = new Task(EjecutarTarea);
tarea.Start();

Task tarea2 = new Task(() =>
{
    for (int j = 0; j < 100; j++)
    {
        var miThread = Thread.CurrentThread.ManagedThreadId;

        Thread.Sleep(1000);

        Console.WriteLine("Tarea correspondiente al hilo: "+miThread+ " ejecutandose desde el main");
    }
});

tarea2.Start();

Console.ReadLine();

static void EjecutarTarea()
{
    for (int i = 0; i < 100; i++)
    {
        var miThread = Thread.CurrentThread.ManagedThreadId;

        Thread.Sleep(1000);

        Console.WriteLine("Esta vuelta de bucle corresponde al Thread: "+miThread);
    }
}