using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Escriba un número entero y le daré sus números divisibles por 2 y 3");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Números divisibles por 2 y 3");                              //preguntar como poner antes de del bucle pero solo salga una vez
for (int i = number; i >= 1; i--)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();