namespace Ejercicio_35
{
    class Program
    {
        static string LETTERS = "TRWAGMYFPDXBNJZSQVHLCKE";
        static void Main()
        {
            Console.WriteLine("Introduce tu DNI sin la letra");
            int dni = int.Parse(Console.ReadLine());
            char letra = LETTERS[dni % LETTERS.Length];
            Console.WriteLine($"Tu DNI es {LETTERS}{letra}");
        }
    }
}