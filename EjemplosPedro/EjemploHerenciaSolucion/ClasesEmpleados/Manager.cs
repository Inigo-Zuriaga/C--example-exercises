using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public abstract class Manager : Empleado
    {
        public Manager(string nombre, int años) : base(nombre, años)
        {
        }
    }
}
