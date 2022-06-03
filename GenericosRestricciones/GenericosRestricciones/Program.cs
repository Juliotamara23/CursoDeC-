// See https://aka.ms/new-console-template for more information

//AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);

//empleados.agregar(new Director(4500));
//empleados.agregar(new Director(5500));
//empleados.agregar(new Director(6500));

//AlmacenEmpleados<Secretaria> empleados = new AlmacenEmpleados<Secretaria>(3);

//empleados.agregar(new Secretaria(4500));
//empleados.agregar(new Secretaria(5500));
//empleados.agregar(new Secretaria(6500));

//AlmacenEmpleados<Electricista> empleados = new AlmacenEmpleados<Electricista>(3);

//empleados.agregar(new Electricista(4500));
//empleados.agregar(new Electricista(5500));
//empleados.agregar(new Electricista(6500));

//AlmacenEmpleados<Estudiante> empleados = new AlmacenEmpleados<Estudiante>(3);

//empleados.agregar(new Estudiante(4500));
//empleados.agregar(new Estudiante(5500));
//empleados.agregar(new Estudiante(6500));

class Estudiante
{
    public Estudiante(double edad)
    {
        this.edad = edad;
    }

    public double getEdad()
    {
        return edad;
    }

    private double edad;
}

class AlmacenEmpleados<T> where T : IParaEmpleados
{

    public AlmacenEmpleados(int z)
    {
        datosEmplados = new T[z];
    }

    public void agregar(T obj)
    {
        datosEmplados[i] = obj;

        i++;
    }

    public T getEmpleado(int i)
    {
        return datosEmplados[i];
    }

    private int i = 0;
    private T[] datosEmplados;
}

class Director : IParaEmpleados
{
    public Director(double salario)
    {
        this.salario = salario;
    }

    private double salario;

    public double getSalario()
    {
        return salario;
    }
}

class Secretaria : IParaEmpleados
{
    public Secretaria(double salario)
    {
        this.salario = salario;
    }

    private double salario;

    public double getSalario()
    {
        return salario;
    }
}


class Electricista : IParaEmpleados
{
    public Electricista(double salario)
    {
        this.salario = salario;
    }

    private double salario;

    public double getSalario()
    {
        return salario;
    }
}


interface IParaEmpleados
{
    double getSalario();
}