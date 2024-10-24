using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleados
{
    public class Subcontractor : External
    {
        public string Project { get; set; }

        public Subcontractor(string nombre, int años, string company, string project) 
            : base(nombre, años, company)
        {
            Project = project;
        }
        public override string ObtenerNumeroEmpleado()
        {
            return "Subc-" + Id.ToString();
        }
    }
}