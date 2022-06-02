// See https://aka.ms/new-console-template for more information

Console.WriteLine("probando el avion");

Vehiculo.Avion miAvion = new Vehiculo.Avion();
miAvion.ArrancaMotor("tracatra");

miAvion.Despegar();
miAvion.Conducir();
miAvion.Aterrizar();
miAvion.PararMotor("ploff");

Console.WriteLine();

Console.WriteLine("Probando el coche");

Vehiculo.Coche miCoche = new Vehiculo.Coche();
miCoche.ArrancaMotor("grrrrum grummm");
miCoche.Conducir();
miCoche.Acelerar();
miCoche.Frenar();
miCoche.PararMotor("bluuuuff");

Console.WriteLine("Polimorfismo en accion!");

Vehiculo.Vehiculo miVehiculo = miCoche;
miVehiculo.Conducir();
miVehiculo = miAvion;
miVehiculo.Conducir();