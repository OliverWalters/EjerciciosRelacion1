namespace Ejercicio_36
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce números enteros separados por comas");
            string[] input = (Console.ReadLine()).Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            int[] numbers = new int[input.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int copy = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        copy = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = copy;
                    }
                }
            }
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}