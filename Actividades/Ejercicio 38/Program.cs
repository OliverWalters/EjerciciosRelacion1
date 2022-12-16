namespace Ejercicio_38
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Los numeros impares de los 10 aleatorios son:");
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i+=2)
            {
                    Console.WriteLine(numbers[i] = random.Next());
            }
        }
    }
}