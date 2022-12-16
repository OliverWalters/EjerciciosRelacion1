using System.Globalization;
using System;
class Hola
{
    static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Introduce los grados Fahrenheit");
        double fahrenheit = Convert.ToInt32(Console.ReadLine()), celsius;
        celsius = (fahrenheit - 32) / 9 * 5;
        Console.WriteLine($"Hace {celsius} grados Celsius");
    }
}