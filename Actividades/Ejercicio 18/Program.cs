
using System;

Console.WriteLine("De cuantos numeros necesita hacer la media?");
int notas;
if (int.TryParse(Console.ReadLine(), out notas)) { }
else
{
    Console.WriteLine("No me jodas");
}
int notasmedia = notas;
double total = 0;                                                        //preguntar como hacer para que alfinal del bucle se reinicie el número

for (; notas > 0; notas--)
{
    Console.WriteLine("Introduce nota");
    double tocuadrado;
    if (double.TryParse(Console.ReadLine(), out tocuadrado)) { }
    else
    {
        Console.WriteLine("Introduce un numero");
    }
    total += tocuadrado * tocuadrado;
}
double end = total / notasmedia;
Console.WriteLine($"Tu nota media es {Math.Sqrt(end)}");
Console.ReadLine();