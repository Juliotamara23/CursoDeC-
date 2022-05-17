using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce n° de mes");

            int NumeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NomrbreDelMes(NumeroMes));
            }
            catch (Exception e)
            {

                Console.WriteLine("Mensaje de la excepcion: " + e.Message);
            }

            Console.WriteLine("Aqui contunia todo el resto del programa");

        }

        public static string NomrbreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Optubre";
                case 10:
                    return "Septiembre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";

                default:

                    throw new ArgumentOutOfRangeException();

            }
        }
    }

}
