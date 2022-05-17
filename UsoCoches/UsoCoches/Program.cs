using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // Crear objeto/ instancia de tipo coche
                                        // Dar un estado inicial a nuesto coche
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtra(true, "cuero");
            Console.WriteLine(coche3.getExtra());
        }
    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";

        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }

        public string getInfoCoche() {
            return "Informacion del coche: \n " + "Ruedas: " + ruedas + ", Largo: "+ largo + ", Ancho: " + ancho; }

        public void setExtra(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;

            this.tapiceria = tapiceria;
        }

        public String getExtra()
        {
           return "Estras del coche: \n " + " Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;
    }
}
