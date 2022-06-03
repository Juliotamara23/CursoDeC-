// See https://aka.ms/new-console-template for more information

Empleado empleado1 = new Empleado(1200,250);

empleado1.cambiaSalario(empleado1, 100);

Console.WriteLine(empleado1);

public struct Empleado
{
    public double salarioBase, comision;

    public Empleado(int salarioBase, int comision)
    {
        this.salarioBase = salarioBase;
        this.comision = comision;
    }

    public override string ToString()
    {
        return string.Format("Salario y comision del empleado ({0},{1})",
            this.salarioBase, this.comision);
    }

    public void cambiaSalario(Empleado emp, double incremento)
    {
        emp.salarioBase = incremento+salarioBase;
        emp.comision = incremento+comision;
    }
}