using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public class Administrative : Worker
    {
        public Administrative(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Administrative: {Nombre} ({Años} años)";
        }
    }
}
