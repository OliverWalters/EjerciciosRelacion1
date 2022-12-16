using System.Diagnostics.Metrics;
using System.Xml.Schema;

namespace Ejercicio_25;
class Program
{
    static void Main()
    {
        int n, m, total;
        n = PedirNumero();
        m = PedirNumero();
        total = Resta(n, m);
        EscribirNumero(n, m, total);
    }
    static int PedirNumero()
    {
        Console.WriteLine("Introduzca un número");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int Resta(int n, int m)
    {
        int total = Factorial(n) - Factorial(m);
        return total;
    }

    static int Factorial(int x)
    {
        int resultado;
        if (x == 0) resultado = 1;
        else resultado = x * Factorial(x - 1);

        return resultado;
    }
    static void EscribirNumero(int n, int m, int total)
    {
        Console.WriteLine($"La resta factorial de {n} - {m} es {total}");
    }
}