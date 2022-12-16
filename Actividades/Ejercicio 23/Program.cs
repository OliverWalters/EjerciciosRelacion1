namespace Ejercicio_23
{
    class Program
    {
        static void Main()
        {

            try
            {
                Console.WriteLine("Introduzca un número entero para el numerador");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca un número entero para el denominador");
                int denominador = int.Parse(Console.ReadLine());

                int total = number1 / denominador;
                Console.WriteLine(total);
            }
            catch (Exception e)
            {
                Console.WriteLine("Se dió un error");
            }
        }
    }
}