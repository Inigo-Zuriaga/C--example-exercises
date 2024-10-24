using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleados
{
    public abstract class External : Empleado
    {
        public string Company { get; set; }
        public External(string nombre, int años, string company) : base(nombre, años)
        {
            Company = company;
        }
    }
}