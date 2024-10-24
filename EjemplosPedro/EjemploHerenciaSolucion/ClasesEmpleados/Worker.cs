using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public abstract class Worker : Empleado
    {
        public Worker(string nombre,int años) : base(nombre, años)
        {
           
        }

        public override void CalcularVacaciones()
        {
            base.CalcularVacaciones();
            numeroDiasVacaciones += 5;
        }

    }
}
