// See https://aka.ms/new-console-template for more information

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo Babieca = new Caballo("Babieca");
            Humano Juan = new Humano("Juan");
            Gorila Copito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;
            almacenAnimales[1] = Juan;
            almacenAnimales[2] = Copito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            //Juan.getNombre();
            //Babieca.getNombre();
            //Copito.getNombre();

        }
    }

    class Mamiferos
    {

        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan solas por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }

    class Caballo : Mamiferos
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {

        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Soy capaz");
        }
    }

    class Gorila : Mamiferos
    {

        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar de forma instintiva");
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}