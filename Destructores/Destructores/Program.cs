// See https://aka.ms/new-console-template for more information

ManejoArchivos miArchivo = new ManejoArchivos();
miArchivo.mensaje();

class ManejoArchivos{

    StreamReader? archivo = null;
    int contador = 0;
    string linea;

    public ManejoArchivos()
    {
        archivo = new StreamReader(@"C:\Users\spede\OneDrive\Escritorio\texto.txt");

        while ((linea = archivo.ReadLine()) !=null)
        {
            Console.WriteLine(linea);

            contador++;
        }
    }

    public void mensaje()
    {
        Console.WriteLine("Hay {0} lineas", contador);
    }

    ~ManejoArchivos(){ archivo.Close(); }
}