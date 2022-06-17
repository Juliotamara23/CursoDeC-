﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace CRUD_LINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings
                ["CRUD_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;

            dataContext = new DataClasses1DataContext(miConexion);

            //InsertaEmpresas();
            //InsertaEmpleado();
            //InsertaCargos();
            InsertaEmpleadoCargo();

        }

        public void InsertaEmpresas()
        {
            //dataContext.ExecuteCommand("delete from empresa");

            Empresa pildorasInformaticas = new Empresa();

            pildorasInformaticas.Nombre = "Pildoras Informaticas";

            dataContext.Empresa.InsertOnSubmit(pildorasInformaticas);

            Empresa empresaGoogle = new Empresa();

            empresaGoogle.Nombre = "Google";

            dataContext.Empresa.InsertOnSubmit(empresaGoogle);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empresa;
        }

        public void InsertaEmpleado()
        {
            Empresa pildorasInformaticas = dataContext.Empresa.First(em => em.Nombre.Equals("Pildoras Informaticas"));
            Empresa empresaGoogle = dataContext.Empresa.First(em => em.Nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado { Nombre = "Juan", Apellido = "Diaz", EmpresaId = pildorasInformaticas.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Anna", Apellido = "Martin", EmpresaId = empresaGoogle.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Maria", Apellido = "Lopez", EmpresaId = empresaGoogle.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Antonio", Apellido = "Fernandez", EmpresaId = pildorasInformaticas.Id });

            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;
        }

        public void InsertaCargos()
        {
            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Director/a" });
            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Administrativo/a" });

            dataContext.SubmitChanges();

            Principal.ItemsSource= dataContext.Cargo;
        }

        public void InsertaEmpleadoCargo()
        {
            Empleado Juan = dataContext.Empleado.First(em => em.Nombre.Equals("Juan"));
            Empleado Anna = dataContext.Empleado.First(em => em.Nombre.Equals("Anna"));

            Cargo cDirector = dataContext.Cargo.First(cg => cg.NombreCargo.Equals("Director/a"));
            Cargo cAdtvo = dataContext.Cargo.First(cg => cg.NombreCargo.Equals("Administrativo/a"));

            CargoEmpleado cargoJuan = new CargoEmpleado();

            cargoJuan.Empleado = Juan;

            cargoJuan.CargoId = cDirector.Id;

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.CargoEmpleado;
        }

    }
}
