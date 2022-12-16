namespace Ejercicio_27
{
    class Program
    {
        static void Main()
        {
            int number1, number2, total;
            number1 = NumInput();
            number2 = NumInput();
            total = Suma(number1, number2);
            ImprimirResultado(number1, number2, total);
        }

        static int NumInput()
        {
            Console.WriteLine("Introduzca un número entero:");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int Suma(int number1, int number2)
        {
            int total = Fibonacci(number1) + Fibonacci(number2);
            return total;
        }

        static int Fibonacci(int x)
        {
            int fibonacci;
            if (x == 0)
            {
                fibonacci = 0;
            }
            else if (x == 1)
            {
                fibonacci = 1;
            }
            else
            {
                fibonacci = Fibonacci(x -1) + Fibonacci(x-2);
            }
            return fibonacci;
        }

        static void ImprimirResultado(int number1, int number2, int total)
        {
            Console.WriteLine($"La suma del fibonacci de {number1} y el fibonacci de {number2}, es {total}");
        }
    }
}