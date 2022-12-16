using System;
using System.Globalization;

class Hola
{
    static void Main()
    {
        Console.WriteLine("Cual es tu nombre?");
        string nombre = Console.ReadLine();
        Console.WriteLine($"\"Hola, {nombre}\"");

        Console.WriteLine("Le voy a hacer una suma, introduzca el primer número");
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        double num1, num2, total;
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo número");
        num2 = double.Parse(Console.ReadLine());
        total = num1 + num2;
        Console.WriteLine($"La suma es {total}");
    }
}