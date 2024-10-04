using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fechaInicio = new DateTime(2010,01,01);
            var fechaFin = new DateTime(2010,01,02);
            TimeSpan diferencia = fechaFin - fechaInicio;

            var anio = fechaInicio.Year.;

            string nombre = "Jose";
            var longitud = nombre.Length ;
            var num = 10;
            
            Console.WriteLine(longitud);
            
            //CREAMOS LISTA
            List<Employee> empleados = new List<Employee>();

            //CREAR INSTANCIA DE CLASE DE DISTINTAS MANERAS
            //1 MEDIANTE INSTANCIA DE CLASE
            Employee juan = new Employee();
            john.Nombre("John");
            john.FechaAlta(2021, 02, 02);

            //2 MEDIANTE BLOQUE
            Employee tony = new Employee
            {
                Nombre    = "Tony",
                FechaAlta = new DateTime(1998, 01, 01),
                Income    = 120000
            };
            tony.SetRating(Employee.Rating.excellent);
            //tony.FechaAlta = "01/01/2010";

            //3
            Employee john = new Employee("john",new DateTime(2021,02,02),3000);

            //LO AÑADO A LA LISTA
            empleados.Add(john);  



            empleados.Add(tony);

            Employee pepe = new 
                Employee("Pepe",new DateTime(2010,01,01),160000);
            pepe.SetRating(Employee.Rating.poor);
            

            empleados.Add(pepe);

            var nempleados = empleados.count;

            Console.WriteLine(nempleados);
            
            for(int i = 0; i < nempleados; i++)
            {

            }

                         //cada empleado de empleados     repite el bucle por cada empleado que haya
            foreach (Employee emple in empleados)
            {
                //empleado.CalculateRaise();
                Console.WriteLine("Nombre empleado: "+ emple.Nombre);
            }

        }

    }

    public class Employee
    {
        public enum Rating
        {
            poor,
            good,
            excellent

        }

        private Rating rating;

        public Employee()
        {
            Debugger.Break();
        }

        //CONTRUCTOR
        public Employee(string nombre, DateTime fechaAlta, int income)
        {
            Nombre = nombre;
            FechaAlta = fechaAlta;
            Income = income;
        }

        public double Income { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaAlta {get; set;}



        public void SetRating(Rating rating)
        {
            this.rating = rating;
        }

        public void CalculateRaise()
        {

            
            var años = YearsOfService();

            double baseRaise = Income * 0.05;
            double bonus = años * 1000;

            Income += baseRaise + bonus;

            switch (rating)
            {
                case Rating.poor:
                    Income -= años * 2000;
                    break;
                case Rating.good:
                    break;
                    case Rating.excellent:
                        Income += años * 500;
                        break;
            }

            Console.WriteLine($"{Nombre} lleva {años} y cobra {Income}");
        }

        private int YearsOfService()
        {

            return DateTime.Now.Year - FechaAlta.Year;

        }


    }
}
