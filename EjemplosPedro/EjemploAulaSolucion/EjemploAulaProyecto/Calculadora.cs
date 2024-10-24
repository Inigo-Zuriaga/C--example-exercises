

namespace EjemploAulaProyecto;

public class Calculadora
{
    //         Firma del metodo
    //         ================
    //      1                2
    //     ===      ==========================
    //     void
    public int Suma(int sumando1, int sumando2)
    {
        return sumando1 + sumando2;

    }
    public int Resta(int minuendo, int sustraendo)
    {
        return minuendo - sustraendo;

    }

    public int Multiplicacion(int numero1, int numero2)
    {
        return numero1 * numero2;

    }

    public double Division(int dividendo, int divisor)
    {
        return dividendo / divisor;

    }

    public void Imprimir(string valor)
    {
        Console.WriteLine(valor);
    }
}
