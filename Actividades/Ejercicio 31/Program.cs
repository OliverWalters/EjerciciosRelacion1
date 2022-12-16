namespace Ejercicio_31
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[100];
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine($"Media: {total/numbers.Length}");
            Console.ReadLine();
        }
    }
}