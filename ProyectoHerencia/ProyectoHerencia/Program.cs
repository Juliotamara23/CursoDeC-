// See https://aka.ms/new-console-template for more information

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Caballo Babieca = new Caballo("Babieca");
            //ISaltoConPatas IBabieca = Babieca;
            //Humano Juan = new Humano("Juan");
            //Gorila Copito = new Gorila("Copito");

            //Mamiferos[] almacenAnimales = new Mamiferos[3];

            //almacenAnimales[0] = Babieca;
            //almacenAnimales[1] = Juan;
            //almacenAnimales[2] = Copito;

            //for (int i = 0; i < 3; i++)
            //{
            //    almacenAnimales[i].pensar();
            //}

            ////Juan.getNombre();
            ////Babieca.getNombre();
            ////Copito.getNombre();

            //Ballena miWally = new Ballena("Wally");

            //miWally.nada();

            //Console.WriteLine("Numero de patas de Babieca usadas para el salto: "
            //    + IBabieca.numeroPatas());

            lagartija Juancho = new lagartija("Juancho");
            Juancho.getNombre();

            Humano Juan = new Humano("Juan");
            Juan.getNombre();

        }
    }

    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();

        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {
        int numeroPatas();
    }

    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
    }

    class lagartija : Animales
    {

        public lagartija(String nombre)
        {
            nombreReptil = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }

        private String nombreReptil;
    }

    class Mamiferos:Animales
    {

        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan solas por si solas");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamifero es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void nada()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");

            //respirar();
        }

        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }

        public string tipoDeporte()
        {
            return "Hipica";
        }

        public Boolean esOlimpico()
        {
            return true;
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

    class Gorila : Mamiferos, IMamiferosTerrestres
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

        public int numeroPatas()
        {
            return 2;
        }
    }

}