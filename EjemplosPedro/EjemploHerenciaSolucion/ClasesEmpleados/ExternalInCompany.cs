using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleados
{
    public class ExternalInCompany : External
    {
        public string Department { get; set; }
        public ExternalInCompany(string nombre, int años, string company,string department) : base(nombre, años, company)
        {
            Department = department;
        }
    }
}