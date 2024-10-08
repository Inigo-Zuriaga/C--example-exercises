using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosMini;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }
    public Libro(string titulo, string autor, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    
    public void MostrarDetalles()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Número de Páginas: {NumeroPaginas}");
    }

    public bool esLargo()
    {
        return NumeroPaginas > 300;
    }




}