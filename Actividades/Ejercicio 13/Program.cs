Console.WriteLine("Introduce un número entero");
int numero = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
bool match = false;

for (int i = 0; i < 5; i++)                             // si quisiesemos para el bucle se pondria && "!match" depues de "i < 5"
{
    int num1 = random.Next(1, numero + 1);
    Console.WriteLine(numero);

    if (numero == num1 && !match)                       // !match      no falso --> verdadero     y al pasar por match = true pasaria a ser no verdadero que seria falso y no volveria a ejecutarse
    {
        Console.WriteLine("Coincide");
        match = true;
    }
}
Console.ReadLine();




/*Console.WriteLine("Introduzca un número");
int numero = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int num1 = random.Next(numero + 1);

if (numero == num1) { Console.WriteLine($"{num1} Tu número coincide"); }
else
{
    Console.WriteLine(num1);
    int num2 = random.Next(numero + 1);
    if (numero == num2) { Console.WriteLine($"{num2} Tu número coincide"); }
    else
    {
        Console.WriteLine(num2);
        int num3 = random.Next(numero + 1);
        if (numero == num3) { Console.WriteLine($"{num3} Tu número coincide"); }
        else
        {
            Console.WriteLine(num3);
            int num4 = random.Next(numero + 1);
            if (numero == num4) { Console.WriteLine($"{num4} Tu número coincide"); }
            else
            {
                Console.WriteLine(num4);
                int num5 = random.Next(numero + 1);
                if (numero == num5) { Console.WriteLine($"{num5} Tu número coincide"); }
                else { Console.WriteLine(num5); }
            }
        }
    }
}
Console.ReadLine();*/