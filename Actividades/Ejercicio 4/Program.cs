using System;
class Hola
{
    static void Main()
    {
        Console.WriteLine("Introduce un número entero");
        int number = int.Parse(Console.ReadLine()), units;
        units = number % 10;
        Console.WriteLine(units);
    }
}

//decenas :10 y luego %10