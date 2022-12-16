namespace Ejercicio_26
{
    class Program
    {
        static void Main()
        {
            int number, total;
            number = NumInput();
            total = Sumatorio(number);
            ImprimirNum(number, total);
        }

        static int NumInput()
        {
            Console.Write("Introduzca un número entero:");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int Sumatorio(int number)
        {
            int resultado = 0;
            for (int i = 1; i <= number; i++)
            {
                resultado += Factorial(i) + i;
            }
            return resultado;
        }

        static int Factorial(int x)
        {
            int resultado;
            if (x == 0) resultado = 1;
            else resultado = x * Factorial(x - 1);
            return resultado;
        }

        static void ImprimirNum(int number, int total)
        {
            Console.WriteLine($"El factorial del sumatorio de {number} más uno, es {total}");
        }
    }
}