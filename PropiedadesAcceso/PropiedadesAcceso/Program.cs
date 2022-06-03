// See https://aka.ms/new-console-template for more information

Empleado Juan = new Empleado("juan");

Juan.SALARIO = 1200;
Console.WriteLine("El salario del empleado es: "+ Juan.SALARIO);


class Empleado
{

    public Empleado(string nombre)
    {
        this.nombre = nombre;
    }

    //public void setSalario(double salario)
    //{
    //    if (salario < 0)
    //    {
    //        Console.WriteLine("el salario no puede ser negativo. Se asignara 0 como salario");
    //        this.salario = 0;
    //    }
    //    else
    //    {
    //        this.salario = salario;
    //    }
    //}

    //public double getSalario()
    //{
    //    return salario;
    //}

    private double evaluaSalario(double salario)
    {
        if (salario < 0) return 0;

        else return salario;
    }

    // CREACION DE PROPIEDAD

    //public double SALARIO
    //{
    //    get { return this.salario; }
    //    set { this.salario = evaluaSalario(value); }
    //}

    public double SALARIO
    {
        get => this.salario; set => this.salario = value;
    }

    private double salario;
    private string nombre;
}