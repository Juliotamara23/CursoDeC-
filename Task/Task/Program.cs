// See https://aka.ms/new-console-template for more information

//Task tarea = new Task(EjecutarTarea);
//tarea.Start();

//Task tarea = Task.Run(() => EjecutarTarea());
//Task tarea2 = tarea.ContinueWith(EjecutarOtraTarea);

//Task tarea2 = new Task(() =>
//{
//    for (int j = 0; j < 10; j++)
//    {
//        var miThread = Thread.CurrentThread.ManagedThreadId;

//        Thread.Sleep(1000);

//        Console.WriteLine("Tarea correspondiente al hilo: "+miThread+ " ejecutandose desde el main");
//    }
//});

//tarea2.Start();

RalizarTodasTareas();

Console.ReadLine();

static void RalizarTodasTareas()
{
    var tarea1 = Task.Run(() =>
    {
        EjecutarTarea();
    });

    tarea1.Wait();

    var tarea2 = Task.Run(() =>
    {
        EjecutarTarea2();
    });

    tarea2.Wait();

    var tarea3 = Task.Run(() =>
    {
        EjecutarTarea3();
    });

}

static void EjecutarTarea()
{
    for (int i = 0; i < 5; i++)
    {
        var miThread = Thread.CurrentThread.ManagedThreadId;

        Thread.Sleep(1000);

        Console.WriteLine("Esta vuelta de bucle corresponde a la tarea 1");
    }
}

static void EjecutarTarea2()
{
    for (int i = 0; i < 5; i++)
    {
        var miThread = Thread.CurrentThread.ManagedThreadId;

        Thread.Sleep(500);

        Console.WriteLine("Esta vuelta de bucle corresponde a la tarea 2");
    }
}

static void EjecutarTarea3()
{
    for (int i = 0; i < 5; i++)
    {
        var miThread = Thread.CurrentThread.ManagedThreadId;

        Thread.Sleep(500);

        Console.WriteLine("Esta vuelta de bucle corresponde a la tarea 3");
    }
}