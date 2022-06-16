using System.Linq;

// See https://aka.ms/new-console-template for more information

ControlEmpresaEmpleados ce = new ControlEmpresaEmpleados();
ce.getCEO();

class ControlEmpresaEmpleados
{
    public ControlEmpresaEmpleados()
    {
        listaEmpleado = new List<Empleado>();
        listaEmpresas = new List<Empresa>();

        listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
        listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Pildoras Informaticas" });

        listaEmpleado.Add(new Empleado { Id = 1, Nombre = "Sergey Brin", Cargo = "CEO", EmpresaId = 1, Salario = 1500});
        listaEmpleado.Add(new Empleado { Id = 2, Nombre = "Juan Diaz", Cargo = "CEO", EmpresaId = 2, Salario = 1500 });
        listaEmpleado.Add(new Empleado { Id = 3, Nombre = "Larry Page", Cargo = "Co-CEO", EmpresaId = 1, Salario = 1400 });
        listaEmpleado.Add(new Empleado { Id = 4, Nombre = "Irina Shayk", Cargo = "Co-CEO", EmpresaId = 2, Salario = 1400 });
    }

    public void getCEO()
    {
        IEnumerable<Empleado> ceos = from Empleado in listaEmpleado where Empleado.Cargo == "CEO" select Empleado;

        foreach (Empleado empleado1 in ceos)
        {
            empleado1.getDatosEmpleado();
        }
    }

    public List<Empresa> listaEmpresas;
    public List<Empleado> listaEmpleado;
}

class Empresa
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public void getDatosEmpresa()
    {
        Console.WriteLine("Empresa  {0} con Id {1}", Nombre, Id);
    }
}

class Empleado
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Cargo { get; set; }

    public double Salario { get; set; }

    //Clase foranea

    public int EmpresaId { get; set; }

    public void getDatosEmpleado()
    {
        Console.WriteLine("Empresa  {0} con Id {1}, cargo {2} con salario {3} y " +
            "pertenece a la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
    }
}