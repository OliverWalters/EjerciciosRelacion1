Console.WriteLine("Introduce un número entero y le daré todos los numeros primos hasta este");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
    bool isprimo = true;
    for (int j = 2; j <= i / 2 && isprimo; j++)
    {
        isprimo = i % j != 0;
    }
    if (isprimo)
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();

