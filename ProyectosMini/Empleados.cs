using System;

namespace ProyectosMini
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Departamento { get; set; }

        public Empleado(string nombre, string departamento)
        {
            Nombre = nombre;
            Departamento = departamento;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Departamento: {Departamento}");
        }
    }


}
