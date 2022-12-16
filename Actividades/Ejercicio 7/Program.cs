Console.WriteLine("Introduce la medida del primer lado del triángulo");
int lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce la medida del segundo lado del triángulo");
int lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce la medida del tercer lado del triángulo");
int lado3 = Convert.ToInt32(Console.ReadLine());
if ((lado1 == lado2) && (lado1 == lado3))
{
    Console.WriteLine("Es un triángulo equilátero");
}
else if ((lado1 == lado3) || (lado1 == lado2) || (lado2 == lado3))
{
    Console.WriteLine("Es un triángulo isosceles");
}
else
{
    Console.WriteLine("Es un triángulo escaleno");
}