﻿// See https://aka.ms/new-console-template for more information

AlmacenaObjetos<String> archivos = new AlmacenaObjetos<String>(4);
archivos.agregar("Juan");
archivos.agregar("Elena");
archivos.agregar("Antonio");
archivos.agregar("Sandra");

//archivos.agregar(new Empleado(1500));
//archivos.agregar(new Empleado(2500));
//archivos.agregar(new Empleado(3500));
//archivos.agregar(new Empleado(4500));

//Empleado salarioEmpleado = (archivos.getElemento(2));
//Console.WriteLine(salarioEmpleado.getSalario());

String nombrePersona = (archivos.getElemento(2));
Console.WriteLine(nombrePersona);

class AlmacenaObjetos <T>
{
    public AlmacenaObjetos(int z)
    {
        datosElemento = new T[z];
    }

    public void agregar(T obj)
    {
        datosElemento[i] = obj;

        i++;
    }

    public T  getElemento(int i)
    {
        return datosElemento[i];
    }

    private T [] datosElemento;
    private int i = 0;
}

class Empleado
{
    public Empleado(double salario)
    {
        this.salario = salario;
    }

    public double getSalario()
    {
        return salario;
    }

    private double salario;
}