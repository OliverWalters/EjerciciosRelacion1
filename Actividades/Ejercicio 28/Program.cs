using System.Globalization;

namespace Ejercicio_28
{
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Introduzca de que figura quiere calcular el área (circulo, cuadrado o triangulo):");
            string figura = (Console.ReadLine()).ToLower();
            switch (figura)
            {
                case "circulo":
                    Circulo();
                    break;

                case "cuadrado":
                    Cuadrado();
                    break;

                case "triangulo":
                    Triangulo();
                    break;
            }
        }

        static void Circulo()
        {
            Console.WriteLine("Cuanto mide su radio?");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine($"Su área es {Math.Pow(radio, 2)*Math.PI}");
        }

        static void Cuadrado()
        {
            Console.WriteLine("Cuanto mide su lado?");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine($"Su área es {lado* lado}");
        }

        static void Triangulo()
        {
            Console.WriteLine("Cuanto mide su base?");
            double @base = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto mide su altura?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Su área es {(@base * altura) / 2}");

        }
    }
}