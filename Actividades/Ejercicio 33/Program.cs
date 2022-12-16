using System.Security.AccessControl;

namespace Ejercicio_33
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce numeros enteros separados por comas");
            string read = Console.ReadLine();
            string[] numbers = read.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                if (number % 2 == 0)
                {
                    Console.WriteLine($"El número {number} es par");
                }
            }
        }
    }
}