using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public abstract class Empleado
    {

        // Propiedad Nombre
        public string Nombre { get; set; }

        // Propiedad Años en la empresa
        public int Años { get; set; }

        public Company Company
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        // Constructor que recibe el nombre y los años
        public Empleado(string nombre, int años)
        {
            Nombre = nombre;
            Años = años;
        }

        // Método abstracto que se implementará en las clases derivadas
        public abstract string ObtenerNumeroEmpleado();

        // Campo que almacena el número de días de vacaciones
        protected int numeroDiasVacaciones;
        // Método virtual que se puede sobreescribir en las clases derivadas
        public virtual void CalcularVacaciones()
        {
            numeroDiasVacaciones = 22;
        }
    }
}
