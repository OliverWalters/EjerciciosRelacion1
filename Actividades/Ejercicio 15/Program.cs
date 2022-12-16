using System;

Console.WriteLine("De cuantos numeros necesita hacer la media?");
int notas = int.Parse(Console.ReadLine());
int notasmedia = notas;
double total = 0;                                                        //preguntar como hacer para que alfinal del bucle se reinicie el número

for(;notas > 0; notas--)
{
    Console.WriteLine("Introduce nota");
    total += double.Parse(Console.ReadLine());
}
Console.WriteLine($"Tu nota media es {total / notasmedia}");
Console.ReadLine();