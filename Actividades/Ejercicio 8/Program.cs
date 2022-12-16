using System;

Console.WriteLine("Introduzca un número de dos cifras");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number % 10) * 10 + number / 10;
Console.WriteLine(result);



/* int num = Convert.ToInt32(Console.ReadLine());
int a, b;
a = num / 10;
b = (num % 10) * 10;
Console.WriteLine(a + b); */