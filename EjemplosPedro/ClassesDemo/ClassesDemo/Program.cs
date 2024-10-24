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

            var año = fechaInicio.Year;
            var mes = fechaInicio.Month;
            var dia = fechaFin.Day;

            string nombre = "Jose".ToUpper();
            var longitudNombre = nombre.Length;
            string numero = 10.ToString().ToLower();


            // Lista  De Tipo Employee
               List<Employee> empleados = new List<Employee>();


            // 1-Crear instancia de clase e inicializar propiedades 
            // mediante instancia de clase
            Employee John = new Employee();
            John.Nombre = "John";
            John.FechaAlta = new DateTime(2021, 1, 10);
            empleados.Add(John);

            // 2- Crear instancia de clase e inicializar variables 
            // mediante bloque
            Employee tony = new Employee()
            {
                Nombre    = "Tony",
                FechaAlta = new DateTime(1998, 01, 01),
                Income    = 120000
            };
            tony.SetRating(Employee.Rating.excellent);
            //tony.FechaAlta = "01/01/2010";
            empleados.Add(tony);

            // 3 - Crear instancia de clase mediante Constructor 
            // Inicializamos algunas propiedades o campos
            // mediante los parametros del constructor
            Employee pepe = new 
                Employee("Pepe",new DateTime(2010,01,01),160000);
            pepe.SetRating(Employee.Rating.poor);
            

            empleados.Add(pepe);


            Employee pedro = new Employee("Pedro", new DateTime(2021, 1, 1), 25000);
            empleados.Add(pedro);

            Employee rosa = new Employee("Rosa", new DateTime(2023, 5, 3),25000);
            empleados.Add(rosa);





            Console.WriteLine(empleados.Count);

            
            var numeroEmpleados = empleados.Count;


            foreach (Employee emp in empleados)
            {
                Console.WriteLine("Nombre empleado: "+emp.Nombre);
            }





            //foreach (Employee empleado in empleados)
            //{
            //    empleado.CalculateRaise();
            //}

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

        // Constructor Nº1 - Sin parametros
        // Se llama igual que la clase
        // No devuelve nada
        public Employee()
        {
            // Debugger.Break();
        }

        // Constructor Nº 2 - Con tres parametros: Nombre, fecha , salario
        // Se llama igual que la clase 
        // No devuelve nada
        public Employee(string nombre, DateTime fechaAlta, int salario)
        {
            Nombre = nombre;
            FechaAlta = fechaAlta;
            Income = salario;
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
