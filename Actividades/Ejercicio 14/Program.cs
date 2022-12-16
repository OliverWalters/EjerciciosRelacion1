Console.WriteLine("Introduzca el número para generar la semilla");
int semilla = int.Parse(Console.ReadLine());
Console.WriteLine("Introduzca el número para la cantidad de caracteres");
int caracteres = int.Parse(Console.ReadLine());

Random random = new Random(semilla);

for (; caracteres >= 1; caracteres--)
{
    int numsemilla = random.Next(256);
    Console.WriteLine((char)numsemilla);
}

Console.ReadLine();
