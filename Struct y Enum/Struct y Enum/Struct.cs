using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_y_Enum
{
    internal class Struct
    {
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
                emp.salarioBase = incremento + salarioBase;
                emp.comision = incremento + comision;
            }
        }
    }
}
