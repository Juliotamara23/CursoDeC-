using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    internal class Vehiculo
    {
        public void ArrancaMotor(string sonidoAlArrancar)
        {
            Console.WriteLine($"Arrancar el motor: {sonidoAlArrancar}");
        }

        public void PararMotor(string sonidoAlParar)
        {
            Console.WriteLine($"Parando el motor: {sonidoAlParar}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Este es el metodo generico para el metodo conducir");
        }

    }
}
