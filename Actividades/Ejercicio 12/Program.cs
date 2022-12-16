Console.WriteLine("Introduzca una palabra y le diré si es un palíndromo o no");
string palabra = Console.ReadLine();
char letra1 = Convert.ToChar(palabra[0]);
char letra2 = Convert.ToChar(palabra[1]);
char letra3 = Convert.ToChar(palabra[2]);
char letra4 = Convert.ToChar(palabra[3]);                           //preguntar como hacer si quiero poner una palabra de solo 3 digitos
int letras = palabra.Length - 1;

if (letras > 0)
{
    if (letras < 4)
    {
        if (letras <= 3)
        {
            if ((letra1 == palabra[palabra.Length - 1]) && (letra2 == palabra[palabra.Length - 2]))
            {
                Console.WriteLine("Sí, es un palíndromo");
            }
            else
            {
                Console.WriteLine("No, no es un palíndromo");
            }
        }
        if ((letra1 == palabra[palabra.Length - 1]) && (letra2 == palabra[palabra.Length - 2]) && (letra3 == palabra[palabra.Length - 3]))
        {
            Console.WriteLine("Sí, es un palíndromo");
        }

        else
        {
            Console.WriteLine("No, no es un palíndromo");
        }
    }
    if ((letra1 == palabra[palabra.Length - 1]) && (letra2 == palabra[palabra.Length - 2]) && (letra3 == palabra[palabra.Length - 3]) && (letra4 == palabra[palabra.Length - 4]))
    {
        Console.WriteLine("Sí, es un palíndromo");
    }
    else
    {
        Console.WriteLine("No, no es un palíndromo");
    }
}
Console.ReadLine();
