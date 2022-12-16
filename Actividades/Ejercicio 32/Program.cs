namespace Ejercicio_32
{
    class Program
    {
        //const int SIZE = 10;
        static void Main()
        {
            //int[] numbers = CrearArray();
            int[] numbers = new int[10];
            CrearArray(numbers);
            Mostrar(numbers);
        }

        static void CrearArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Mostrar(int[] numbers)
        {
            for (int i = 1; i < numbers.Length +1; i++)
            {
                Console.WriteLine($"{i} => {numbers[i-1]}");
            }
        }


            /*static int[] CrearArray()
            {
                int[] numbers = new int[SIZE];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                return numbers;
            }*/
        }
}