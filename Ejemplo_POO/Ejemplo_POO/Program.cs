using System;

namespace Ejemplo_POO
{
    class Program
    {
        static void Main(String[] args)
        {/*
            Circulo miCirculo = new Circulo(); //creacion de objeto de tipo Circulo. Varaible/objeto de tipo circulo.
            Console.WriteLine(miCirculo.CalculoArea(5));
         */

            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.cambiaValorEuro(1.05);
            Console.WriteLine(obj.convierte(50));
        }
    }
    /*
    class Circulo
    {
        const double pi = 3.1416; //Propiedad de la clase circulo. Campo de clase.
        public double CalculoArea(int radio) { return pi*radio*radio; }  //Metodo de clase.
    } */

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double convierte (double cantidad) { return euro*cantidad; }

        public void cambiaValorEuro(double nuevoValor) 
        {
            if (nuevoValor > 0)
            {
                euro = nuevoValor;
            }
            else
            {
                euro = 1.253;
            }
            
        }
    }
}