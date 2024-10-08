﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(5, 101);
            // a) Mostrar los años de servicio del empleado mediante concatenacion

            Console.WriteLine("emp years of service: " + emp.YearsOfService);

            // b) Mostrar los años de servicio del empleado
            //    mediante formateado de cadenas (String.Format)
            Console.WriteLine("emp years of service: {0}", emp.YearsOfService);

            // c) Mostrar los años de servicio del empleado
            //    mediante interpolación de cadenas
            Console.WriteLine($"emp years of service: {emp.YearsOfService} ");
            Console.WriteLine($"emp office: {emp.Office}");

            Employee emp2 = new Employee();
            emp2.YearsOfService = 15;
            emp2.Office = 201;
            Console.WriteLine($"emp2 years of service: {emp2.YearsOfService}");
            Console.WriteLine($"emp2 office: {emp2.Office}");

            Employee emp3 = new Employee()
            {
                YearsOfService = 20,
                Office = 301
            };
            Console.WriteLine($"emp3 years of service: {emp3.YearsOfService}");
            Console.WriteLine($"emp3 office: {emp3.Office}");


            Employee emp4 = new Employee("intern");




        }
    }

}
