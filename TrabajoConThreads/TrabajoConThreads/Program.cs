// See https://aka.ms/new-console-template for more information

//Thread t = new Thread(MetodoSaludo);
//t.Start();
//t.Join();

//Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
//Thread.Sleep(500);
//Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
//Thread.Sleep(500);
//Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
//Thread.Sleep(500);
//Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");
//Thread.Sleep(500);
//Console.WriteLine("Hola alumnos desde thread (0 hilo) 1");

//Thread t2 = new Thread(MetodoSaludo);
//t2.Start();
//t2.Join();

//static void MetodoSaludo()
//{
//    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
//    Thread.Sleep(500);
//    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
//    Thread.Sleep(500);
//    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
//    Thread.Sleep(500);
//    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
//    Thread.Sleep(500);
//    Console.WriteLine("Hola alumnos desde thread (0 hilo) 2");
//}

//CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);

//Thread[] hilosPersonas = new Thread[15];

//for (int i = 0; i < 15; i++)
//{
//    Thread t = new Thread(CuentaFamilia.VamosRetirarEfectivo);

//    t.Name = i.ToString();

//    hilosPersonas[i] = t;
//}

//for (int i = 0; i < 15; i++)
//{
//    hilosPersonas[i].Start();

//    hilosPersonas[i].Join(); //Sincronizar el hilo
//}

//class CuentaBancaria
//{

//    private Object bloquearSaldoPositivo = new Object();

//    double Saldo {set; get;}

//    public CuentaBancaria(double Saldo)
//    {
//        this.Saldo = Saldo;
//    }

//    public double RetirarEfectivo(double cantidad)
//    {
//        //lock(bloquearSaldoPositivo)  //Bloquear el hilo
//        //{
//            if ((Saldo - cantidad) < 0)
//            {
//                Console.WriteLine($"Lo siento queda {Saldo} en la cuenta. Hilo:{Thread.CurrentThread.Name}");
//                return 0;
//            }

//            if (Saldo >= cantidad)
//            {
//                Console.WriteLine("Retirado {0} y queda {1} en la cuenta {2}", cantidad, (Saldo - cantidad), Thread.CurrentThread.Name);
//                Saldo -= cantidad;
//            }

//            return Saldo; 
//        //}
//    }

//    public void VamosRetirarEfectivo()
//    {

//        Console.WriteLine("Esta sacando dinero el hilo: {0}", Thread.CurrentThread.Name);

//        for (int i = 0; i < 4; i++)
//        {
//            RetirarEfectivo(500); 
//        }
//    }
//}

//var tareaTerminada = new TaskCompletionSource<bool>();

//var hilo1 = new Thread(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine("Hilo 1");
//        Thread.Sleep(1000);
//    }

//    tareaTerminada.TrySetResult(true);
//});

//var hilo2 = new Thread(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine("Hilo 2");
//        Thread.Sleep(1000);
//    }
//});

//var hilo3 = new Thread(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine("Hilo 3");
//        Thread.Sleep(1000);
//    }
//});

//hilo1.Start();

//var resultado = tareaTerminada.Task.Result;

//hilo2.Start();

//hilo3.Start();

for (int i = 0; i < 100; i++)
{
    //Thread t = new Thread(EjecutarTarea);

    //t.Start();

    ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
} 

Console.ReadLine();

static void EjecutarTarea(Object o)
{
    int nTarea = (int)o;

    Console.WriteLine($"Thread n°: {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea n° "+nTarea);
    Thread.Sleep(1000);

    Console.WriteLine($"Thread n°: {Thread.CurrentThread.ManagedThreadId} ha Terminado la tarea n° "+nTarea);
}