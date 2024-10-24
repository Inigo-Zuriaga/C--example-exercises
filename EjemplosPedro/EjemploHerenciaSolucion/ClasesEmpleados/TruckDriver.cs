using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleados
{
    public class TruckDriver : Worker
    {
        public TruckDriver(string nombre, int años) 
                : base(nombre, años) 
        {

        }

        public override string ToString()
        {
            return $"TruckDriver: {Nombre} ({Años} Años )   ";
        }

        public override string ObtenerNumeroEmpleado()
        {
            return "Driver-" + Id.ToString();
        }

    }
}